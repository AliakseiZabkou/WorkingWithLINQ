﻿using System;
using System.Linq;
using static System.Console;

namespace LinqWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqWithArrayOfStrings();
        }

        static void LinqWithArrayOfStrings()
        {
            var names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };
            var query = names.Where(name => name.Length > 4)
                .OrderBy(name => name.Length).ThenBy(name => name);  
            foreach(string item in query)
            {
                WriteLine(item);
            }
        }

    }
}
