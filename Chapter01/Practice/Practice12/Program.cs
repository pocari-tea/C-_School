using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    class NameCard
    {
        private int age;
        private string name;

        public int Age { get; set; }
        public string Name { get; set; }
    }

    class MainApp
    {
        public static void Main()
        {
            NameCard MyCard = new NameCard();

            MyCard.Age = 19;
            MyCard.Name = "훈";

            Console.WriteLine($"나이: {MyCard.Age}");
            Console.WriteLine($"이름: {MyCard.Name}");
        }
    }
}
