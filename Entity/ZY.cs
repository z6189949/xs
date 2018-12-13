using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("ZY")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class ZY
    {
        public int Id { get; set; }
        public string KLDM { get; set; }
        public string KLMC { get; set; }
        public string ZYDM { get; set; }
        public string ZYMC { get; set; }
        public string XLCC { get; set; }
        public string WYYZ { get; set; }
        public int XZ { get; set; }
        public string XFBZ { get; set; }
        public int PTJHS { get; set; }
        public int WYJHS { get; set; }
        public int TYJHS { get; set; }
        public int JHS { get; set; }
        public int Sex { get; set; }
        public string StuTypes { get; set; }
        public string Notes { get; set; }

    }
}
