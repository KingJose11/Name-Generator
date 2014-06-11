using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Number : Phonetic
    {
        public Number(String chars = "1234567890")
        {
            this.SetValue(chars);
        }
    }
}
