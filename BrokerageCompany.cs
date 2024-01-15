using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class BrokerageCompany
    {
        public string name;
        public long taxCode;
        public string address;

        public BrokerageCompany()
        {

        }

        public BrokerageCompany(string name, long taxCode, string address)
        {
            this.name = name;
            this.taxCode = taxCode;
            this.address = address;
        }

        //in thong tin cong ty moi gioi
        public static void DisplayBrokerageCompanyInfo(string name, long taxCode, string address)
        {
            Console.WriteLine("┌───────────────Brokerage Company's information──────────────┐");
            Console.WriteLine("┌──────────────────┬────────────────────┬────────────────────┐");
            Console.WriteLine("│   Name           │ TaxCode            │      Address       |");
            Console.WriteLine("├──────────────────┼────────────────────┼────────────────────┤");
            Console.WriteLine($"│{name,-17} │ {taxCode,-18} │ {address,-18} |");
            Console.WriteLine("└──────────────────┴────────────────────┴────────────────────┘");
        }

    }
}
