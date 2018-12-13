using Entity;
using DataAccess.Base;
using System.Collections.Generic;

namespace DataAccess
{
    public class DaoKSLB : DaoBase<KSLB>
    {
        public List<KSLB> getListKslb()
        {
            return base.GetList("select * from KSLB");
        }
    }
}
