using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlWasmCrud.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string Heroname { get; set; } = string.Empty;
        public comic? Comic { get; set; }
        public int ComicId { get; set; }
    }
}
