using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class Broker : Person
    {
        public BrokerageCompany brokerageCompany;
        public Room brokerageRoom;

        public Broker()
        {

        }

        public Broker (BrokerageCompany brokerageCompany,Room brokerageRoom, string name, int age, string phoneNumber, string job) : base(name, age, phoneNumber, job)
        {
            this.brokerageCompany = brokerageCompany;
            this.brokerageRoom = brokerageRoom;
        }

        //in thong tin nguoi moi gioi
        public static void DisplayBrokerInfo(string name, int age, string phoneNumber, string job)
        {
            Console.WriteLine("┌─────────────────────Room's Broker information─────────────────────────────┐");
            Console.WriteLine("┌──────────────┬──────────┬───────────────────────┬─────────────────────────┐");
            Console.WriteLine("│   Name       │ Age      │      PhoneNumer       |     Job                 │");
            Console.WriteLine("├──────────────┼──────────┼───────────────────────┼─────────────────────────┤");
            Console.WriteLine($"│{name,-13} │ {age,-8} │ {phoneNumber,-21} │ {job,-23} │");
            Console.WriteLine("└──────────────┴──────────┴───────────────────────┴─────────────────────────┘");
        }

        //in thong tin nguoi moi gioi khi tim kiem thong tin theo phong
        public static void DisplayBrokerOnRoom(int roomId)
        {
            bool roomFound = false;
            foreach (Broker brokers in MyData.brokers)
            {
                if (roomId == brokers.brokerageRoom.roomId)
                {
                    roomFound = true;
                }
            }

            if (roomFound == true)
            {
                foreach (Broker brokers in MyData.brokers)
                {
                    if (roomId == brokers.brokerageRoom.roomId)
                    {
                        DisplayBrokerInfo(brokers.name, brokers.age, brokers.phoneNumber, brokers.job);
                        BrokerageCompany.DisplayBrokerageCompanyInfo(brokers.brokerageCompany.name, brokers.brokerageCompany.taxCode, brokers.brokerageCompany.address);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Does not exist Broker with entered room's ID: {roomId} !");
            }
        }
    }
}
