using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("TeacherOperLogs")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class TeacherOperLogs
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Oper { get; set; }
        public string IP { get; set; }
        public string Reason { get; set; }
        public DateTime OperTime { get; set; }

    }
}
