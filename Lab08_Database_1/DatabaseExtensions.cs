using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Database_1
{
    partial class Film
    {
        public override string ToString()
        {
            return $"{this.Category.Name} - {this.Title} ({this.Duration}min.)";
        }
    }
}
