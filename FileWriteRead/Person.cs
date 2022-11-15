using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriteRead
{
    public class Person
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string sex { get; set; }
        public int BirthYear   { get; set; }    


        public Person(
            string LastName ,
            string FirstName,
            string sex,
            int BirthYear  )
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.BirthYear = BirthYear;
            this.sex = sex; 
        }



    }
}
