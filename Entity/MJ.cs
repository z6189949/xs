using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("MJ")]
    public class MJ
    {
        public int Id { get; set; }
        public int MJType { get; set; }
        public string MJKey { get; set; }
        public string MJValue { get; set; }
        public string MJBZ { get; set; }

    }
}
