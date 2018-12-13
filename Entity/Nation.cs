using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("Nation")]
    public class Nation
    {
        public string NationCode { get; set; }
        public string NationName { get; set; }

    }
}
