using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic l = new Logic("Shirt","M");
            l.Add();
            l.Display();
        }
    }
}
