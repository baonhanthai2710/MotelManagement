using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class Landlord : Person
    {
        public Room roomOwn;

        public Landlord()
        {

        }

        public Landlord (Room roomOwn, string name, int age, string phoneNumber, string job): base (name, age, phoneNumber, job)
        {
            this.roomOwn = roomOwn;
        }

        // in thong tin chu nha tro
        public static void DisplayLandlordInfo(string name, int age, string phoneNumber, string job)
        {
            Console.WriteLine("┌─────────────────────Room's landlord information───────────────────────────┐");
            Console.WriteLine("┌──────────────┬──────────┬───────────────────────┬─────────────────────────┐");
            Console.WriteLine("│   Name       │ Age      │      PhoneNumer       |     Job                 │");
            Console.WriteLine("├──────────────┼──────────┼───────────────────────┼─────────────────────────┤");
            Console.WriteLine($"│{name,-13} │ {age,-8} │ {phoneNumber,-21} │ {job,-23} │");
            Console.WriteLine("└──────────────┴──────────┴───────────────────────┴─────────────────────────┘");
        }

        // in thong tin chu nha tro khi tim theo ma phong
        public static void DisplayLandlordOnRoom(int roomId)
        {
            bool roomFound = false;
            foreach (Landlord landlord in MyData.landlords)
            {
                if (roomId == landlord.roomOwn.roomId)
                {
                    roomFound = true;
                }
            }

            if (roomFound == true)
            {
                foreach (Landlord landlord in MyData.landlords)
                {
                    if (roomId == landlord.roomOwn.roomId)
                    {
                        DisplayLandlordInfo(landlord.name, landlord.age, landlord.phoneNumber, landlord.job);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Does not exist landlord with entered room's ID: {roomId} !");
            }
        }


    }
}
