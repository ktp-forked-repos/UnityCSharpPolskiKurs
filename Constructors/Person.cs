using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstname;
        string lastname;
        string address;
        int age;
        string gender;

        public Person()
        {
            id = 1;
            firstname = "Kamil";
            lastname = "Nurkowski";
            address = "Utheimsveien";
            age = 14;
        }

        public Person(int id, string firstname, string lastname, string address, int age, string gender)
        {

        }

    }
}
