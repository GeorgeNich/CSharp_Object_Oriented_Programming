using System;
using System.Collections.Generic;
using System.Text;

namespace Practicaltask5._1
{
    class Duck : Bird
    {
        public double size { get; set; }
        public String kind { get; set; }

        public override string ToString()
        {
            return "A duck names " + base.name + " is a " + size + " inch " + kind; 
        }
    }


}
