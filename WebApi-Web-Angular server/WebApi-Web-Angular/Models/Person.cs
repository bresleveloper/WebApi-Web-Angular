using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApi_Web_Angular.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }




        public static Person[] GetAllPersons()
        {
            exampleDB db = new exampleDB();
            DataTable t = db.GetPersons();

            List<Person> l = new List<Person>();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                DataRow r = t.Rows[i];

                l.Add(new Person()
                {
                    FirstName = r[0].ToString(),
                    LastName = r[1].ToString(),
                    Age = Convert.ToInt32(r[2].ToString())
                });
            }
            return l.ToArray();
        }
    }
}