using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel3
{
    internal class Person
    {
        public string name;
        public int age;
        public string phoneNumber;
        public string job;

        public Person()
        {

        }

        public Person(string name, int age, string phoneNumber, string job)
        {
            this.name = name;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.job = job;
        }
    }
}
