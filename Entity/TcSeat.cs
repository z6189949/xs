using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("TcSeat")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class TcSeat
    {
        public int ID { get; set; }
        public string Sfzh { get; set; }
        public int tcId { get; set; }
        public int seatNum { get; set; }
        public string tcPoint { get; set; }
        public string userName { get; set; }
        public string teacherName { get; set; }
        public int isLock { get; set; }

    }
}
