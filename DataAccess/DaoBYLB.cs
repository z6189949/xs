using Entity;
using DataAccess.Base;
using System.Collections.Generic;

namespace DataAccess
{ public class DaoBYLB : DaoBase<BYLB>
    {
        public List<BYLB> getListBylb() {
            return base.GetList("select * from BYLB");
        }
    }
}
