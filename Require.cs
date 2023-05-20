using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursaBD
{
    public partial class Require
    {
        public long RequireID { get; set; }

        public long ParrentsId { get;set; }

        public long ChildId { get; set; }

        public int Season { get; set; }  
    }
}
