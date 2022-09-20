using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTA_CONSTRUCTOR
{
    internal class RESTA
    {
        //campos, propiedades, como es 
        private float n1, n2;
        //constructor
        public RESTA(float n1, float n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public float restar()
        {
            return (n1 - n2);
        }
    }
}
