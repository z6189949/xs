using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Entity
{
    [TableName("Affiche")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class msmInfoCord
    {      
        public int ID { get; set; }
        public string guid { get; set; }
        public string msminfo { get; set; }

    }
}
