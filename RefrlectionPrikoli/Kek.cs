using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrlectionPrikoli
{
    public class Kek
    {
        public int MyProperty { get; set; }
        public string? Lole { get; set; }
        public Lol LOL { get; set; }
    }

    public struct Lol
    {
        public int MyProperty { get; set; }
        public Kek KEK { get; set; }
        public bool IsMeme { get; set; }
    }
}
