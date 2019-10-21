using System;
using static System.Console;
namespace Practice2
{
    class MainApp
    {
        public static void Main()
        {
            var nameCard = new { Name = "박상현", Age = "17" };
            WriteLine("이름 : {0}, 나이 : {1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = "3", Imaginary = "-12" };
            WriteLine("Real : {0}, Imaginary : {1}", complex.Real, complex.Imaginary);
        }
    }
}