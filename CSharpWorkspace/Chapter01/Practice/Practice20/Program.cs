using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice20
{
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;

        public void BuySomething(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }
    class Program
    {
        static void prize(int n)
        {
            Console.WriteLine($"축하합니다! {n}번째 고객 이벤트에 담청되셨습니다.");
        }

        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate (prize);

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomething(customerNo);
        }
    }
}
