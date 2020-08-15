using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesTutorial
{
    class CurrencyConversion
    {
        private float balance;
     
        //holds USD balance after conversion
        public float USDbalance
        {
            get
            {
                return balance * 0.72f;
            }
        }

        //holds AUD balance
        public float AUDbalance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        //assigns value to balance and prints amounts
        static void Start()
        {
            CurrencyConversion money = new CurrencyConversion();
            money.AUDbalance = 100;

            Console.WriteLine("AUD is : " + money.AUDbalance);
            Console.WriteLine("USD is : " + money.USDbalance);
            Console.ReadKey();
           
        }
    }
}
