using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Jedi 
            { 
                Name = "Skywallker", 
                FirstName = "Luke", 
                Saber = new Saber(Color.Blue),
            };

            var dv = new Lord 
            { 
                Saber = new Saber(Color.Red),
            };

            var e = new Emperor();

            j.Saber.Severing(dv);

            e.Lightning(j, dv);

            var a = dv.To(firstName: "Anakin", name: "Skywalker");

            a.Kill(e);

            TE();
        }

        private static void TE()
        {
            Console.ReadLine();
        }
    }
}
