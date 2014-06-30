using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class LightSaber
    {
        private System.Drawing.Color color;

        public LightSaber(System.Drawing.Color color)
        {
            this.color = color;
        }

        public Jedi JediOwner { get; set; }

        public void SeveringHandOf(Jedi jedi)
        {
            Console.WriteLine("{0} severing hand of {1}", this.JediOwner.FullName, jedi.FullName);
        }
    }
}
