using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSP
{
    public class EmailNotifier: INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}
