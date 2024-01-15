using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class Contract
    {
        public string deposit;
        public Room room;
        public Landlord landlord;
        public Tenant tenant;
        public DateTime contractTerm;
        public string furniture; // boi thuong noi that
        public string idemnification; //tien boi thuong 

        public Contract()
        {

        }

        public Contract(Room room, Landlord landlord, Tenant tenant, DateTime contractTerm)
        {
            this.room = room;
            this.landlord = landlord;
            this.tenant = tenant;
            this.contractTerm = contractTerm;

            if (room.roomType == "High")
            {
                deposit = "$120";
                furniture = "$100 each broken";
                idemnification = "$500";
            }
            else if (room.roomType == "Basic")
            {
                deposit = "$100";
                furniture = "$80 each broken";
                idemnification = "$400";
            }
            else if (room.roomType == "Normal")
            {
                deposit = "$80";
                furniture = "$50 each broken";
                idemnification = "$300";
            }
        }

        //in thong tin hop dong
        public void DisplayContractInfo(string deposit, int roomId, string landlordName, string tenantName, string furniture, string idemnification, DateTime contractTerm)
        {
            Console.WriteLine("┌────────────────────────────────Contract information──────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("┌──────────────┬────────────┬────────────────┬──────────────────┬─────────────────┬──────────────┬─────────────────────┐");
            Console.WriteLine("│ Deposit      │ Room ID    │ Landlord name  │   Tenant name    │  Furniture      │Idemnification│  ContractTerm       │");
            Console.WriteLine("├──────────────┼────────────┼────────────────┼──────────────────┼─────────────────┼──────────────┼─────────────────────┘");
            Console.WriteLine($"│ {deposit,-13}│ {roomId,-11}│ {landlordName,-14} │ {tenantName,-17}│ {furniture,-16}│ {idemnification,-13}│{contractTerm,-14}│");
            Console.WriteLine("└──────────────┴────────────┴────────────────┴──────────────────┴─────────────────┴──────────────┴─────────────────────┘");
        }

        //in thong tin hop dong theo ma phong
        public void DisplayContractOnRoom(int roomId)
        {
            bool roomFound = false;
            foreach (Contract contract in MyData.contract)
            {
                if (roomId == contract.room.roomId)
                {
                    roomFound = true;
                }
            }

            if (roomFound == true)
            {
                foreach (Contract contract in MyData.contract)
                {
                    if (roomId == contract.room.roomId)
                    {
                        DisplayContractInfo(contract.deposit, contract.room.roomId, contract.landlord.name, contract.tenant.name, contract.furniture, contract.idemnification, contract.contractTerm);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Does not exist contract of room with ID: {roomId} !");
            }
        }

        //dien hop dong khi thue phong
        public static void FillContract()
        {
            DateTime rentDate = DateTime.Today;

            Console.Write("Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("PhoneNumber: ");
            string phoneNumber= Console.ReadLine();

            Console.Write("Job: ");
            string job = Console.ReadLine();

            Console.Write("Room rent ID: ");
            int roomRent = Convert.ToInt32(Console.ReadLine());

            bool roomFound = false;
            foreach (Contract a in MyData.contract)
            {
                if (roomRent == a.room.roomId) 
                {
                    roomFound = true;
                }
            }

            if (roomFound == true)
            {
                foreach (Contract a in MyData.contract)
                {
                    if (roomRent == a.room.roomId)
                    {
                        Console.WriteLine("┌────────────────────────────────Contract information──────────────────────────────────────────────────────────────────┐");
                        Console.WriteLine("┌──────────────┬────────────┬────────────────┬──────────────────┬─────────────────┬──────────────┬─────────────────────┐");
                        Console.WriteLine("│ Deposit      │ Room ID    │ Landlord name  │   Tenant name    │  Furniture      │Idemnification│  ContractTerm       │");
                        Console.WriteLine("├──────────────┼────────────┼────────────────┼──────────────────┼─────────────────┼──────────────┼─────────────────────┘");
                        Console.WriteLine($"│ {a.deposit,-13}│ {roomRent,-11}│ {a.landlord.name,-14} │ {name,-17}│ {a.furniture,-16}│ {a.idemnification,-13}│{rentDate,-14}│");
                        Console.WriteLine("└──────────────┴────────────┴────────────────┴──────────────────┴─────────────────┴──────────────┴─────────────────────┘");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Does not exist contract of room with ID: {roomRent} !");
            }

            Tenant.DisplayTenantInfo(name, age, phoneNumber, job, roomRent, rentDate);
        }

        //den hop dong khi tra phong truoc thoi han
        public void CompensateContract()
        {
            Console.Write("Enter Room id you need to check out (only enter): ");
            int roomId = int.Parse(Console.ReadLine());

            int countRented = 0;
            foreach (var room in MyData.rooms)
            {
                if (roomId == room.roomId && room.status == "Rented") 
                {
                    countRented++;
                }
            }

            if (countRented > 0)
            {
                foreach(Contract contract in MyData.contract)
                { 
                    if (DateTime.Now.Year - contract.contractTerm.Year <= 1)
                    {
                        Console.WriteLine("╔══════════════════════════════════════════╗");
                        Console.WriteLine($"║ You lost your deposit: {contract.deposit,-17} ║");
                        Console.WriteLine("╚══════════════════════════════════════════╝");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("╔════════════════════════════════════╗");
                        Console.WriteLine("║  Check out completed successfully  ║");
                        Console.WriteLine("╚════════════════════════════════════╝");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"There's no rented room with {roomId}");
            }
        }
    }
}
