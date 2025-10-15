using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSP
{
    internal class CreditCardPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"paid {amount} using Credit Card. ");// Simulate credit card payment processing logic here
        }
    }
}
