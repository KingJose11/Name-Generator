using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Consonant : Phonetic
    {

        public Consonant(String chars = "bcdfghjklmnpqrstvwxyz")
        {
            this.SetValue(chars);
        }

    }
}
