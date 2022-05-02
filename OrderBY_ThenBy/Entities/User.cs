using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBY_ThenBy.Entities
{
    class User
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string str = "";
            str += $"{Name} | {Mail} | {Age}"+"\n";

            return str;
        }


    }
}
