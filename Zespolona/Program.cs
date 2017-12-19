using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zespolona
{
    class Program
    {
        static void Main(string[] args)
        {
            Zespolona<float> z1 = new Zespolona<float>(1.0f, 1.0f);
            Zespolona<float> z2 = new Zespolona<float>(2.0f, 2.0f);

            Zespolona<float> z3 = z1 + z2;

            Zespolona<float> z4 = new Zespolona<float>(0, 0);

            z4.przepisz(z3);
           
            Console.WriteLine(z3.Re);
            Console.ReadKey();
        }
    }
}
