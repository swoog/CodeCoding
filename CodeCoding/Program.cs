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
            var luke = new Jedi 
            { 
                LastName = "Skywallker", 
                FirstName = "Luke", 
                LightSaber = new LightSaber(Color.Blue),
            };

            var darkVador = new Lord 
            { 
                LightSaber = new LightSaber(Color.Red),
            };

            var emperorSith = new Emperor();

            luke.LightSaber.SeveringHandOf(darkVador);

            emperorSith.UseForceLightningTo(luke, darkVador);

            var anakin = darkVador.To(firstName: "Anakin", lastName: "Skywalker");

            anakin.Kill(emperorSith);

            TheEnd();
        }

        private static void TheEnd()
        {
            Console.ReadLine();
        }
    }
}
