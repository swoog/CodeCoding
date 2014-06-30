using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public class Lord : Jedi, IDarkSideForce
    {
        public Lord()
        {
            this.FirstName = "Dark";
            this.LastName = "Vador";
        }

        public void UseForceLightningTo(params Jedi[] jedi)
        {
            Console.WriteLine("Dark Vador use force lightning on {0}", string.Join(" and ", jedi.Select(j => j.FullName)));
        }

        public Jedi To(string lastName, string firstName)
        {
            Console.WriteLine("{0} {1} reemerges", firstName, lastName);

            return new Jedi { LastName = lastName, FirstName = firstName };
        }

    }
}
