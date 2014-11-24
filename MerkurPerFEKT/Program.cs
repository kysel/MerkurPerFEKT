using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkurPerFEKT
{
    class Program
    {
        static void Main(string[] args)
        {
            SOS Motor = new SOS("COM123", 9400);
            Motor[0] = 1;
        }
    }
}
