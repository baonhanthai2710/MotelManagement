using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class Room
    {
        public int roomId;
        public string roomType;
        public string address;
        public int price;
        public string furniture;
        public string specifiedTime;
        public string status;
        public double electricity;
        public double water;

        public static List<Room> foundRoom = new List<Room>();

        public Room()
        {

        }

        public Room(int roomId, string roomType,string address, int price, string furniture, string specifiedTime, string status)
        {
            this.roomId = roomId;
            this.roomType = roomType;
            this.address = address;
            this.price = price;
            this.furniture = furniture;
            this.specifiedTime = specifiedTime;
            this.status = status;

            if (roomType == "High")
            {
                electricity = 0.6;
                water = 0.5;
            }
            else if (roomType == "Normal") 
            {
                electricity = 0.5;
                water = 0.4;
            }
            else if (roomType=="Basic")
            {
                electricity = 0.5;
                water = 0.4;
            }    
        }
   
        //in thong tin phong
        public static void DisplayRoomInfo(int roomId, string roomType, string address, int price, string furniture, string specifiedTime, string status)
        {
            Console.WriteLine("┌──────────────┬────────────┬──────────┬──────────────────┬─────────────────┬────────────────────┬───────────────┐");
            Console.WriteLine("│ Room's ID    │ Room Type  │ Address  │      Price       │  Furniture      │ Specified Time     │ Status        |");
            Console.WriteLine("├──────────────┼────────────┼──────────┼──────────────────┼─────────────────┼────────────────────┼───────────────┤");
            Console.WriteLine($"│ {roomId,-13}│ {roomType,-11}│ {address,-9}│ {price,-17}│ {furniture,-16}│ {specifiedTime,-18} │ {status,-14}│");
            Console.WriteLine("└──────────────┴────────────┴──────────┴──────────────────┴─────────────────┴────────────────────┴───────────────┘");
        }

        //in tat ca cac phong
        public static void DisplayAllRoom()
        {
            Console.WriteLine("┌──────────────┬────────────┬──────────┬──All Room────────┬─────────────────┬────────────────────┬───────────────┐");
            Console.WriteLine("│ Room's ID    │ Room Type  │ Address  │      Price       │  Furniture      │ Specified Time     │ Status        |");
            Console.WriteLine("├──────────────┼────────────┼──────────┼──────────────────┼─────────────────┼────────────────────┼───────────────┤");

            foreach (var room in MyData.rooms)
            {
                Console.WriteLine($"│ {room.roomId,-13}│ {room.roomType,-11}│ {room.address,-9}│ {room.price,-17}│ {room.furniture,-16}│ {room.specifiedTime,-18} │ {room.status,-14}│");
            }
            Console.WriteLine("└──────────────┴────────────┴──────────┴──────────────────┴─────────────────┴────────────────────┴───────────────┘");
            Console.WriteLine();
        }

        //tim phong theo nguoi nhap
        public static void FindRoom()
        {
            Console.WriteLine("Enter Room details you need to find: ");

            Console.Write("Room Type(High/Basic/Normal): ");
            string roomType = Console.ReadLine();

            Console.Write("Address(HCM/HaNoi/Other): ");
            string address = Console.ReadLine();

            Console.Write("Price($100/$50/$20): ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Furniture(Luxury/Basic/None): ");
            string furniture = Console.ReadLine();

            Console.Write("Specified Time(Before mid-night/None): ");
            string specifiedTime = Console.ReadLine();

            foreach (Room room in MyData.rooms)
            {
                if (roomType.ToLower() == room.roomType.ToLower() && address.ToLower() == room.address.ToLower() && price == room.price && furniture.ToLower() == room.furniture.ToLower() && specifiedTime.ToLower() == room.specifiedTime.ToLower() && room.status == "Available")  
                {
                    foundRoom.Add(room);
                }
            }
        }

        //in phong tim thay theo yeu cau cua nguoi nhap
        public static void DisplayFoundRoom()
        {
            if(foundRoom.Count()>0)
            {
                Console.WriteLine("Rooms founded: " + foundRoom.Count());

                Console.WriteLine("┌──────────────┬────────────┬──────────┬──Found Room──────┬─────────────────┬────────────────────┬───────────────┐");
                Console.WriteLine("│ Room's ID    │ Room Type  │ Address  │      Price       │  Furniture      │ Specified Time     │ Status        |");
                Console.WriteLine("├──────────────┼────────────┼──────────┼──────────────────┼─────────────────┼────────────────────┼───────────────┤");

                foreach (var room in foundRoom)
                {
                    Console.WriteLine($"│ {room.roomId,-13}│ {room.roomType,-11}│ {room.address,-9}│ {room.price,-17}│ {room.furniture,-16}│ {room.specifiedTime,-18} │ {room.status,-14}│");
                }
                Console.WriteLine("└──────────────┴────────────┴──────────┴──────────────────┴─────────────────┴────────────────────┴───────────────┘");
                Console.WriteLine();
                foundRoom.Clear();
            }
            else
            {
                Console.WriteLine("ROOM NOT FOUND!");
            }
        }

        //in cac phong da thue
        public static void DisplayRentedRoom()
        {
            int countRented = 0;
            foreach (var room in MyData.rooms)
            {
                if (room.status == "Rented")
                {
                    countRented++;
                }
            }

            if (countRented > 0)
            {
                Console.WriteLine("┌──────────────┬────────────┬──────────┬──Rented Room─────┬─────────────────┬────────────────────┬───────────────┐");
                Console.WriteLine("│ Room's ID    │ Room Type  │ Address  │      Price       │  Furniture      │ Specified Time     │ Status        |");
                Console.WriteLine("├──────────────┼────────────┼──────────┼──────────────────┼─────────────────┼────────────────────┼───────────────┤");

                foreach (var room in MyData.rooms)
                {
                    if (room.status == "Rented")
                    {
                        Console.WriteLine($"│ {room.roomId,-13}│ {room.roomType,-11}│ {room.address,-9}│ {room.price,-17}│ {room.furniture,-16}│ {room.specifiedTime,-18} │ {room.status,-14}│");
                    }
                }
                Console.WriteLine("└──────────────┴────────────┴──────────┴──────────────────┴─────────────────┴────────────────────┴───────────────┘");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There's no rented room");
            }
        }

        //xem cac phong con trong
        public static void DisplayAvaiableRoom()
        {
            int countAvaiable = 0;
            foreach (var room in MyData.rooms)
            {
                if (room.status == "Available")
                {
                    countAvaiable++;
                }
            }

            if (countAvaiable > 0)
            {
                Console.WriteLine("┌──────────────┬────────────┬──────────┬──Avaiable Room───┬─────────────────┬────────────────────┬───────────────┐");
                Console.WriteLine("│ Room's ID    │ Room Type  │ Address  │      Price       │  Furniture      │ Specified Time     │ Status        |");
                Console.WriteLine("├──────────────┼────────────┼──────────┼──────────────────┼─────────────────┼────────────────────┼───────────────┤");

                foreach (var room in MyData.rooms)
                {
                    if (room.status == "Available")
                    {
                        Console.WriteLine($"│ {room.roomId,-13}│ {room.roomType,-11}│ {room.address,-9}│ {room.price,-17}│ {room.furniture,-16}│ {room.specifiedTime,-18} │ {room.status,-14}│");
                    }
                }
                Console.WriteLine("└──────────────┴────────────┴──────────┴──────────────────┴─────────────────┴────────────────────┴───────────────┘");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There's no available room");
            }
        }

        // in thong tin phong theo id nhap vao
        public static void DisplayRoomById(int roomId)
        {
            bool roomFound = false;
            foreach(Room room in MyData.rooms)
            {
                if (roomId == room.roomId)
                {
                    roomFound = true;
                }
            }

            if (roomFound == true)
            {
                foreach (Room room in MyData.rooms)
                {
                    if (roomId == room.roomId)
                    {
                        DisplayRoomInfo(room.roomId, room.roomType, room.address, room.price, room.furniture, room.specifiedTime, room.status);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Does not exist room with ID: {roomId} !");
            }
        }

        //in thong tin phong, chu phong, nguoi thue (neu co) va hop dong cua phong theo so phong nhap
        public static void SearchRoomById()
        {
            Console.Write("Enter Room's ID (From 101 to 120): ");
            int roomId = int.Parse(Console.ReadLine());

            DisplayRoomById(roomId);

            Contract contract= new Contract();
            contract.DisplayContractOnRoom(roomId);

            Landlord.DisplayLandlordOnRoom(roomId);

            Tenant.DisplayTenantOnRoom(roomId);

            Broker.DisplayBrokerOnRoom(roomId);
        }

        //in hoa don tien nha bao gom tien dien,nuoc, tien nha va tong tien
        public static void CalculateMonthlyRent()
        {
            double electricityTotal = 0;
            double waterTotal = 0;
            double totalrent = 0;

            Console.Write("Enter Room's ID you need to calculate rent money (From 101 to 120/ONLY RENTED ROOM): ");
            int roomId = int.Parse(Console.ReadLine());

            bool roomFound = false;
            foreach (Room room in MyData.rooms)
            {
                if ((roomId == room.roomId) && (room.status == "Rented"))
                {
                    roomFound = true;
                }
            }

            if (roomFound == true)
            {
                Console.Write("Enter the electricity number Used this month: ");
                double electricityUse = Double.Parse(Console.ReadLine());

                Console.Write("Enter the water number used this month: ");
                double waterUse = Double.Parse(Console.ReadLine());

                foreach (Room room in MyData.rooms)
                {
                    if ((roomId == room.roomId) && (room.status == "Rented"))
                    {
                        electricityTotal = room.electricity * electricityUse;
                        waterTotal = room.water * waterUse;
                        totalrent = room.price + electricityTotal + waterTotal;
                        Console.WriteLine("┌────────────────┬────────────┬────────────┬──────────────────┐");
                        Console.WriteLine("│ Electric Bill  │ Water Bill │ Room price │  Total Rent Bill │");
                        Console.WriteLine("├────────────────┼────────────┼────────────┼──────────────────┤");
                        Console.WriteLine($"│ {electricityTotal,-15}│ {waterTotal,-11}│ {room.price,-11}│ {totalrent,-16} │");
                        Console.WriteLine("└────────────────┴────────────┴────────────┴──────────────────┘");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Does not exist room with ID: {roomId} or this room is avaiable !");
            }
        }

    }
}