using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class Tenant : Person
    {
        public Room roomRent;
        public DateTime rentDate; 

        public Tenant()
        {

        }

        public Tenant (Room roomRent, DateTime rentDate, string name, int age, string phoneNumber, string job) : base(name, age, phoneNumber, job)
        {
            this.roomRent = roomRent;
            this.rentDate = rentDate;
        }

        // in thong tin nguoi thue phong
        public static void DisplayTenantInfo(string name, int age, string phoneNumber, string job, int roomRent, DateTime rentDate)
        {
            Console.WriteLine("┌─────────────────────Room's tenant information─────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("┌──────────────┬──────────┬───────────────────────┬─────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│   Name       │ Age      │      PhoneNumer       |     Job                 │ room rent │     Rent Date         │");
            Console.WriteLine("├──────────────┼──────────┼───────────────────────┼─────────────────────────┼───────────┼───────────────────────┤");
            Console.WriteLine($"│{name,-13} │ {age,-8} │ {phoneNumber,-21} │ {job,-23} │ {roomRent,-9} | {rentDate,-20} │");
            Console.WriteLine("└──────────────┴──────────┴───────────────────────┴─────────────────────────┴───────────┴───────────────────────┘");
        }

        //in thong tin nguoi thue khi phong da co nguoi thue
        public static void DisplayTenantOnRoom(int roomId)
        {
            bool roomFound = false;
            foreach (Tenant tenant in MyData.tenants)
            {
                if (( roomId == tenant.roomRent.roomId ) && (tenant.roomRent.status=="Rented"))
                {
                    roomFound = true;
                }
            }

            if(roomFound == true)
            {
                foreach(Tenant tenant in MyData.tenants)
                {
                    if (roomId == tenant.roomRent.roomId) 
                    {
                        DisplayTenantInfo(tenant.name, tenant.age, tenant.phoneNumber, tenant.job, tenant.roomRent.roomId, tenant.rentDate);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Does not have tenant information of room : {roomId}!");
            }
        }
    }
}
