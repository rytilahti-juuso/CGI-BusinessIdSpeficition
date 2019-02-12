﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace BusinessIdSpecification
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessIdSpecification business = new BusinessIdSpecification();
            string businessId = "0357502-98";
            string businessId2 = "a0357502-9";
            business.IsSatisfiedBy(businessId);
            Console.WriteLine("BREAK");
            business.IsSatisfiedBy(businessId2);
            //Console.WriteLine(business.IsSatisfiedBy("0357502-9"));
            //Console.WriteLine(business.IsSatisfiedBy("0357502-9"));
            foreach (var item in business.ReasonsForDissatisfaction)
            {
                Console.WriteLine(item);
            }
            // Display and wait
            Console.ReadLine();
        }
    }
}
