using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("IPLogs")]
    public class IPLogs
    {
        public int Id { get; set; }
        public string IP { get; set; }
        public DateTime AddTime { get; set; }

    }
}
