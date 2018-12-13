using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Entity
{
    [TableName("CheckTeacher")]
    [PrimaryKey("UserName", AutoIncrement = false)]
    public class CheckTeacher
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TeacherName { get; set; }
        public int Sex { get; set; }
        public string Mobilie { get; set; }
        public DateTime AddTime { get; set; }
        public string AddUser { get; set; }
        public int IsLock { get; set; }
        public string Note { get; set; }
        public int Role { get; set; }

    }
}
