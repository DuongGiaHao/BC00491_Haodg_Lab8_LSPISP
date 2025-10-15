using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSP
{
    public class PayPalPayment: IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal. ");// Simulate PayPal payment processing logic here
        }
    }
    
   
}
