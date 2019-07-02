using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string middleName;

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Person(string firstName, string lastName,string middleName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
        }
    public string FirstName
        {
            get
            {
                return firstName;
            }
            set {  this.firstName = value; }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set { this.lastName = value; }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set { this.middleName = value; }
        }



    }
    }

