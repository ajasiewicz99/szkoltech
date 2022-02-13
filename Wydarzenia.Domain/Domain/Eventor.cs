using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wydarzenia.Domain
{
    public class Eventor
    {
        public virtual int Id { get; set; }
        public virtual string Wydarzenie { get; set; }
        public virtual Miasto Miasto { get; set; }
        public virtual string Organizator { get; set; }
        public virtual Typy Typy { get; set; }
    }
}
