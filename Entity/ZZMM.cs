using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("ZZMM")]
    public class ZZMM
    {
        public string ZzmmDm { get; set; }
        public string ZzmmMc { get; set; }

    }
}
