using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("Points")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Points
    {
        public int Id { get; set; }
        public string Sfzh { get; set; }
        public int PointType { get; set; }
        public string Point { get; set; }
        public int RoomNum { get; set; }
        public int seatNum { get; set; }
        public string teacherName { get; set; }
        public string userName { get; set; }
        public int isLock { get; set; }

    }
}
