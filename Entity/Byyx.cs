using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("Byyx")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Byyx
    {
        public int id { get; set; }
        public string _Byyx { get; set; }

    }
}
