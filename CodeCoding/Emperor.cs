using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class Emperor : Jedi, IDarkSideForce
    {
        public Emperor()
        {
            this.FirstName = "Sith";
            this.LastName = "Emperor";
        }

        public void UseForceLightningTo(params Jedi[] jedi)
        {
            Console.WriteLine("Sith emperor use force lightning on {0}", string.Join(" and ", jedi.Select(j => j.FullName)));
        }
    }
}
