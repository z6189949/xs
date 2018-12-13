using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("TestRoom")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class TestRoom
    {
        public int ID { get; set; }
        public string RoomName { get; set; }
        public string RoomAdd { get; set; }
        public int RoomStateCount { get; set; }
        public int TestRoomName { get; set; }
        public int TestType { get; set; }
        public int IsUse { get; set; }
        public int StudentCount { get; set; }

    }
}
