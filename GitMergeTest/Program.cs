using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GitMergeTest
{
<<<<<<< HEAD
    // {    2023. 07. 03. Modified class position / User
=======
    // im user3
    public class Program
    {
        static void Main(string[] args)
        {
            // {    2023. 07. 03. Add user Input / User3
            string userInput = string.Empty;
            Console.WriteLine("this program convert Cm to Inch");
            Console.WriteLine("Input Cm value : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(10);
            // }    2023. 07. 03. Add user Input / User3
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

            // {    2023. 07. 03    Add private _SetInch function / User2
            private set { this._SetInch(value); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

        private void _SetInch(float inchValue) {  Centimeter = (int)(inchValue / ONE_INCH); }
        // }    2023. 07. 03    Add private _SetInch function / User2
    }
    // }   2023. 07. 03. Modified class position / User

    public class Program
    {
        static void Main(string[] args)
        {
            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

}
