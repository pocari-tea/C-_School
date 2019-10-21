using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice09
{
    class Computer
    {
        string name;
        bool powerOn;
        
        public void Boot()
        {
            Console.WriteLine("부팅합니다.");
            powerOn = true;
        }

        public void ShutDown()
        {
            Console.WriteLine("전원을 종료합니다.");
            powerOn = false;
        }

        public void Reset()
        {
            Console.WriteLine("재부팅 합니다.");
        }
    }

    class Notebook : Computer
    {
        static int touchpadSize;

        public Notebook(int s)
        {
            touchpadSize = s;
        }

        public void useTouchpad()
        {
            Console.WriteLine($"터치패드를 사용함. 사이즈: {touchpadSize}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer com1 = new Computer();
            com1.Boot();
            com1.Reset();
            com1.ShutDown();

            Notebook note1 = new Notebook(5);
            note1.useTouchpad();
        }
    }
}
