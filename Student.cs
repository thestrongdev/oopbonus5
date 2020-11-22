﻿using System;
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

            return String.Compare(this.LastName, s.LastName);
        }
    }
}
