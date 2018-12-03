using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxWebApp.Models
{
    public class PersonList
    {
        private static List<Person> pList = new List<Person>();

        public void addPerson(Person p)
        {
            pList.Add(p);
        }

        public void removePerson(Person p)
        {
            pList.Remove(p);
        }


    }
}
