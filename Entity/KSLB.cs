using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("KSLB")]
    public class KSLB
    {
        public string KslbDm { get; set; }
        public string KslbMc { get; set; }

    }
}
