using Entity;
using DataAccess.Base;
using System.Collections.Generic;

namespace DataAccess
{
    public class DaoNation : DaoBase<Nation>
    {   
        /// <summary>
        /// 返回民族列表
        /// </summary>
        /// <returns></returns>
        public List<Nation> getListNation()
        {
            return base.GetList("select * from Nation");
        }
        public Nation getNationName(string NationCode)
        {
            return base.FirstOrDefault("select NationName from Nation where NationCode=@0", NationCode);
        }
    }
    
}
