using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("BYLB")]
    public class BYLB
    {
        public string BylbDm { get; set; }
        public string BylbMc { get; set; }

    }
}
