using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("Enroll")]
    [PrimaryKey("Sfzh", AutoIncrement = false)]
    public class Enroll
    {
        public string Sfzh { get; set; }
        public int Zhiyuan { get; set; }
        public string ZYDM { get; set; }
        public int State { get; set; }
        public DateTime EnrollTime { get; set; }
        public int EnrollType { get; set; }
        public string hj { get; set; }

    }
}
