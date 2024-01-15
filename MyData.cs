using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class MyData
    {

        public static List<Room> rooms = new List<Room>
        {
            new Room (101, "High", "HCM", 100, "Luxury", "Before Mid-night", "Available"),
            new Room (102, "Basic", "HaNoi", 50, "Basic", "None", "Rented"),
            new Room (103, "Normal", "Other", 20, "None", "None", "Available"),
            new Room (104, "High", "HaNoi", 100, "Luxury", "Before Mid-night", "Available"),
            new Room (105, "Basic", "Other", 50, "Basic", "None", "Available"),
            new Room (106, "Normal", "HCM", 20, "None", "None", "Rented"),
            new Room (107, "High", "Other", 100, "Luxury", "Before Mid-night", "Available"),
            new Room (108, "Basic", "HCM", 50, "Basic", "None", "Rented"),
            new Room (109, "Normal", "HaNoi", 20, "None", "None", "Available"),
            new Room (110, "High", "HaNoi", 100, "Luxury", "Before Mid-night", "Available"),
            new Room (111, "Basic", "Other", 50, "Basic", "None", "Available"),
            new Room (112, "Normal", "HCM", 20, "None", "None", "Available"),
            new Room (113, "High", "HCM", 100, "Luxury", "Before Mid-night", "Available"),
            new Room (114, "Basic", "HaNoi", 50, "Basic", "None", "Rented"),
            new Room (115, "Normal", "Other", 20, "None", "None", "Available"),
            new Room (116, "High", "Other", 100, "Luxury", "Before Mid-night", "Available"),
            new Room (117, "Basic", "HCM", 50, "Basic", "None", "Available"),
            new Room (118, "Normal", "HaNoi", 20, "None", "None", "Rented"),
            new Room (119, "High", "HaNoi", 100, "Luxury", "Before Mid-night", "Available"),
            new Room (120, "Basic", "Other", 50, "Basic", "None", "Available"),
        };

        public static List<Landlord> landlords = new List<Landlord>
        {
            new Landlord (rooms[0], "Nguyen Van A", 25, "123456789", "Engineer"),
            new Landlord (rooms[1], "Tran Thi B", 30, "987654321", "Teacher"),
            new Landlord (rooms[2], "Le Van C", 22, "555555555", "Doctor"),
            new Landlord (rooms[3], "Pham Thi D", 28, "111111111", "Programmer"),
            new Landlord (rooms[4], "Vu Van E", 35, "999999999", "Artist"),
            new Landlord (rooms[5], "Nguyen Thi F", 40, "777777777", "Chef"),
            new Landlord (rooms[6], "Tran Van G", 26, "333333333", "Writer"),
            new Landlord (rooms[7], "Le Thi H", 32, "444444444", "Accountant"),
            new Landlord (rooms[8], "Pham Van I", 38, "666666666", "Marketing Specialist"),
            new Landlord (rooms[9], "Vu Thi K", 29, "222222222", "Sales Representative"),
            new Landlord (rooms[10], "Nguyen Van L", 31, "888888888", "Engineer"),
            new Landlord (rooms[11], "Tran Thi M", 33, "555555555", "Teacher"),
            new Landlord (rooms[12], "Pham Van N", 27, "444444444", "Doctor"),
            new Landlord (rooms[13], "Vu Thi P", 36, "111111111", "Programmer"),
            new Landlord (rooms[14], "Nguyen Van Q", 39, "999999999", "Artist"),
            new Landlord (rooms[15], "Tran Thi R", 24, "777777777", "Chef"),
            new Landlord (rooms[16], "Le Van S", 37, "666666666", "Writer"),
            new Landlord (rooms[17], "Pham Thi T", 34, "333333333", "Accountant"),
            new Landlord (rooms[18], "Vu Van U", 23, "888888888", "Marketing Specialist"),
            new Landlord (rooms[19], "Nguyen Thi V", 26, "222222222", "Sales Representative"),
        };

        public static List<DateTime> rentDate = new List<DateTime>
        {
            //yyyy - mm - dd
            new DateTime(2022, 1, 15),  // 15/01/2023
            new DateTime(2021, 2, 28),  // 28/01/2023
            new DateTime(2023, 4, 10),  // 10/11/2023
            new DateTime(2020, 6, 5),   // 05/06/2023
            new DateTime(2022, 8, 20),  // 20/06/2023
            new DateTime(2021, 10, 3),  // 03/10/2023
            new DateTime(2023, 12, 04)  // 04/12/2023
        };

        public static List<Tenant> tenants = new List<Tenant>
        {
            new Tenant(rooms[1], rentDate[0], "Ngo Van N", 19, "0258147369", "Student"),
            new Tenant(rooms[5], rentDate[1], "Nguyen Thi Q", 22, "0159753684", "Teacher"),
            new Tenant(rooms[7], rentDate[2], "Thi Tran A", 35, "0153246897", "Worker"),
            new Tenant(rooms[8], rentDate[3], "Thai Thi B", 40, "51983654891", "Chef"),
            new Tenant(rooms[13], rentDate[4], "Ho Vam B", 25, "02315648921", "Sales"),
            new Tenant(rooms[14], rentDate[5], "Ngo Thi L", 20, "0789654321", "Student"),
            new Tenant(rooms[17], rentDate[6], "Huu Van H", 46, "01650165454", "Doctor"),
        };

        public static List<BrokerageCompany> brokerageCompany = new List<BrokerageCompany>
        {
            new BrokerageCompany ("Alpha Investments", 1234567890123456, "HCM"),
            new BrokerageCompany ("Beta Securities", 4567890123456789, "HaNoi"),
            new BrokerageCompany ("Gamma Capital", 7890123456789012, "DaNang"),
            new BrokerageCompany ("Delta Financial", 1011121314151617, "Other"),
            new BrokerageCompany ("Epsilon Holdings", 2021222324252627, "HCM"),
            new BrokerageCompany ("Zeta Advisors", 3031323334353637, "HaNoi"),
            new BrokerageCompany ("Eta Brokers", 4041424344454647, "DaNang"),
            new BrokerageCompany ("Theta Investments", 5051525354555657, "Other"),
            new BrokerageCompany ("Iota Securities", 6061626364656667, "HCM"),
            new BrokerageCompany ("Kappa Capital", 7071727374757677, "HaNoi"),
            new BrokerageCompany ("Lambda Financial", 8081828384858687, "DaNang"),
            new BrokerageCompany ("Mu Holdings", 9091929394959697, "Other"),
            new BrokerageCompany ("Nu Advisors", 1112131415161718, "HCM"),
            new BrokerageCompany ("Xi Brokers", 2223242526272829, "HaNoi"),
            new BrokerageCompany ("Omicron Investments", 3334353637383940, "DaNang"),
            new BrokerageCompany ("Pi Securities", 4445464748495051, "Other"),
            new BrokerageCompany ("Raho Capital", 5556575859606162, "HCM"),
            new BrokerageCompany ("Siga Financial", 6667686970717273, "HaNoi"),
            new BrokerageCompany ("Tau Holdings", 7778798081828384, "DaNang"),
            new BrokerageCompany ("Upsilon Advisors", 8889909192939495, "Other"),
        };

        public static List<Broker> brokers = new List<Broker>
        {
            new Broker (brokerageCompany[0], rooms[0], "Nguyen Hong B", 25, "1234567890", "Engineer"),
            new Broker (brokerageCompany[1], rooms[1], "Tran Quoc A", 30, "4567890123", "Teacher"),
            new Broker (brokerageCompany[2], rooms[2], "Pham Thi C", 22, "7890123456", "Doctor"),
            new Broker (brokerageCompany[3], rooms[3], "Le Van D", 35, "1011121314", "Manager"),
            new Broker (brokerageCompany[4], rooms[4], "Vo Thanh E", 28, "2021222324", "Software Developer"),
            new Broker (brokerageCompany[5], rooms[5], "Hoang Khanh F", 40, "3031323334", "Accountant"),
            new Broker (brokerageCompany[6], rooms[6], "Nguyen Lan G", 32, "4041424344", "Designer"),
            new Broker (brokerageCompany[7], rooms[7], "Tran Minh H", 27, "5051525354", "Nurse"),
            new Broker (brokerageCompany[8], rooms[8], "Pham Nam I", 38, "6061626364", "Sales Representative"),
            new Broker (brokerageCompany[9], rooms[9], "Le Quan J", 45, "7071727374", "Marketing Specialist"),
            new Broker (brokerageCompany[10], rooms[10], "Vo Thanh K", 33, "8081828384", "Lawyer"),
            new Broker (brokerageCompany[11], rooms[11], "Le Hieu", 29, "9091929394", "Consultant"),
            new Broker (brokerageCompany[12], rooms[12], "Hoang H", 42, "1112131415", "Chef"),
            new Broker (brokerageCompany[13], rooms[13], "Nguyen F", 26, "2223242526", "Financial Analyst"),
            new Broker (brokerageCompany[14], rooms[14], "Pham H", 36, "3334353637", "HR Manager"),
            new Broker (brokerageCompany[15], rooms[15], "Tran E", 31, "4445464748", "Electrician"),
            new Broker (brokerageCompany[16], rooms[16], "Vo A", 37, "5556575859", "Architect"),
            new Broker (brokerageCompany[17], rooms[17], "Le Dat", 41, "6667686970", "Data Scientist"),
            new Broker (brokerageCompany[18], rooms[18], "Nguyen J", 34, "7778798081", "Journalist"),
            new Broker (brokerageCompany[19], rooms[19], "Tran L", 39, "8889909192", "Librarian"),
        };

        public static List<DateTime> contractTerm = new List<DateTime>
        {
            rentDate[0].AddYears(1),
            rentDate[1].AddYears(1),
            rentDate[2].AddYears(1),
            rentDate[3].AddYears(1),
            rentDate[4].AddYears(1),
            rentDate[5].AddYears(1),
            rentDate[6].AddYears(1),
        };

        public static List<Contract> contract = new List<Contract>
        {
            new Contract (rooms[1], landlords[1], tenants[0], contractTerm[0]),
            new Contract (rooms[5], landlords[5], tenants[1], contractTerm[1]),
            new Contract (rooms[7], landlords[7], tenants[2], contractTerm[2]),
            new Contract (rooms[8], landlords[8], tenants[3], contractTerm[3]),
            new Contract (rooms[13], landlords[13], tenants[4], contractTerm[4]),
            new Contract (rooms[14], landlords[14], tenants[5], contractTerm[5]),
        };
    }
}
