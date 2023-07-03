﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GitMergeTest
{
<<<<<<< HEAD
    // {    2023. 07. 03. Modified class position / Alpha
=======
    // im user3
    public class Program
    {
        static void Main(string[] args)
        {
            // {    2023. 07. 03. Add user Input / User
            string userInput = string.Empty;
            Console.WriteLine("this program convert Cm to Inch");
            Console.WriteLine("Input Cm value : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(10);
            // }    2023. 07. 03. Add user Input / User
            ruler.Run();
        }
    }
    // im user3

>>>>>>> origin/main
    public class Ruler
    {
        private const float ONE_INCH = 2.54F;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

    }
    // }   2023. 07. 03. Modified class position / Alpha

    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

}
