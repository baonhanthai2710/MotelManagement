using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class Menu
    {
        //in menu
        public static void DisplayMainMenu()
        {
            while (true) 
            {
                SelectTable();

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Room.FindRoom();
                        Room.DisplayFoundRoom();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DisplayMenuRoomById();
                        FillContract();
                        break;

                    case "2":
                        Console.Clear();
                        Room.DisplayAvaiableRoom();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DisplayMenuRoomById();
                        FillContract();
                        break;

                    case "3":
                        Console.Clear();
                        Room.DisplayAllRoom();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        DisplayMenuRoomById();
                        FillContract();
                        break;

                    case "4":
                        Console.Clear();
                        Room.DisplayRentedRoom();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        CalculateMonthlyRent();
                        break;

                    case "5":
                        Console.Clear();
                        Contract a = new Contract();
                        a.CompensateContract();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //bang chon
        public static void SelectTable()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║               Motel System             ║");
            Console.WriteLine("╠════════════════════════════════════════╣");
            Console.WriteLine("║ 1. Find Room                           ║");
            Console.WriteLine("║ 2. View Avaiable Room                  ║");
            Console.WriteLine("║ 3. View All Room                       ║");
            Console.WriteLine("║ 4. Calculate monthly rent              ║");
            Console.WriteLine("║ 5. Check out Rental room               ║");
            Console.WriteLine("║ 6. Exit                                ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
        }

        //menu xem thong tin phong theo id nhap vao
        public static void DisplayMenuRoomById()
        {
            bool returnToMainMenu = false;

            do
            {
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║               SELECT TABLE             ║");
                Console.WriteLine("╠════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Room's Detail by ID                 ║");
                Console.WriteLine("║ 2. Exit/Next Option                    ║");
                Console.WriteLine("╚════════════════════════════════════════╝");

                Console.Write("Enter your choice (1-2): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Room.SearchRoomById();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        returnToMainMenu = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 2.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } while (!returnToMainMenu);
        }

        //menu tinh tien hang thang theo cac phong da thue
        public static void CalculateMonthlyRent()
        {
            bool returnToMainMenu = false;

            do
            {
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║               SELECT TABLE             ║");
                Console.WriteLine("╠════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Calculate Monthly Rent              ║");
                Console.WriteLine("║ 2. Exit                                ║");
                Console.WriteLine("╚════════════════════════════════════════╝");

                Console.Write("Enter your choice (1-2): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Room.CalculateMonthlyRent();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        returnToMainMenu = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 2.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } while (!returnToMainMenu);
        }

        //menu dien thong tin hop dong
        public static void FillContract()
        {
            bool returnToPrevious = false;

            do
            {
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║               SELECT TABLE             ║");
                Console.WriteLine("╠════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Fill Contract                       ║");
                Console.WriteLine("║ 2. Exit/Next Option                    ║");
                Console.WriteLine("╚════════════════════════════════════════╝");

                Console.Write("Enter your choice (1-2): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Contract.FillContract();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        returnToPrevious = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 2.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } while (!returnToPrevious);
        }
    }
}
