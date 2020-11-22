using System;
using System.Collections.Generic;
using System.Text;

namespace OopBonus5
{
    class Student : IComparable
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;

            if(this.LastName == s.LastName)
            {
                return this.FirstName.CompareTo(s.FirstName);
            }

            return String.Compare(this.LastName, s.LastName);
        }
    }
}
