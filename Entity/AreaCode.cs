using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("AreaCode")]
    [PrimaryKey("AreaCode", AutoIncrement = false)]
    public class AreaCode_
    {
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public int IsBd { get; set; }

    }
}
