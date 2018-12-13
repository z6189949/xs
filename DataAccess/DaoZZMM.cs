using Entity;
using DataAccess.Base;
using System.Collections.Generic;

namespace DataAccess
{
    public class DaoZZMM : DaoBase<ZZMM>
    {
        public List<ZZMM> getZZMMList()
        {
            return base.GetList("select * from ZZMM");
        }
        public ZZMM getZZMMByZzmmDm(string dm)
        {
            return base.FirstOrDefault("select * from ZZMM where ZzmmDm=@0", dm);
        }
    }
}
