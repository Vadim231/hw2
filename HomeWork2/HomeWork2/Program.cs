using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new Hw2Context())
            {
                context.Gruppas.ToList();
            }
        }
    }
}
