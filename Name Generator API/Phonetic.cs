using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Phonetic
    {

        private static Random rng;
        private Random Rng
        {
            get
            {
                if (rng == null)
                {
                    rng = new Random();
                }
                return rng;
            }
        }

        public char Value { get; private set; }

        protected void SetValue(String chars)
        {
            var index = Rng.Next(0, chars.Length);
            Value = chars[index];
        }

    }
}
