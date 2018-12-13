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
    public class EnrollSave
    {
        public string Sfzh { get; set; }
        public string StuName { get; set; }
        public string Certificate { get; set; }
        public string WHK { get; set; }
        public string ZHCS { get; set; }
        public string GZXYSP { get; set; }
        public string TCCJ { get; set; }
        public decimal hj { get; set; }
        public string FrsZY { get; set; }
        public string SecZY { get; set; }
        public int Test { get; set; }
        public int IsAdjust { get; set; }
        public int IsRecruit { get; set; }
        public string RecruitZY { get; set; }
        public string bz { get; set; }

    }
}
