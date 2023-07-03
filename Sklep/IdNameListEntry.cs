using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class IdNameListEntry
    {
        public int? id { get; private set; }
        public string name { get; private set; }

        public IdNameListEntry(int? id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
