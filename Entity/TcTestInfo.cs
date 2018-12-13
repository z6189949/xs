using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("TcTestInfo")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class TcTestInfo
    {
        public int ID { get; set; }
        public int tcID { get; set; }
        public string TcName { get; set; }
        public string TcTestDateTime { get; set; }
        public string TcTestAdd { get; set; }

    }
}
