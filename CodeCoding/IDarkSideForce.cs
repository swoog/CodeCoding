using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCoding
{
    public interface IDarkSideForce : IForce
    {
        void UseForceLightningTo(params Jedi [] jedi);
    }
}
