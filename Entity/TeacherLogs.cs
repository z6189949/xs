using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("TeacherLogs")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class TeacherLogs
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ErrorPwd { get; set; }
        public string IP { get; set; }
        public string Reason { get; set; }
        public DateTime Logintime { get; set; }
        public string Cause { get; set; }

    }
}
