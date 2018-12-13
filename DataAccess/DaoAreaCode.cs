using Entity;
using DataAccess.Base;
using System.Collections.Generic;

namespace DataAccess
{
    public class DaoAreaCode : DaoBase<AreaCode_>
    {
        public List<AreaCode_> getShiAreaCode()
        {
            return base.GetList("select * from AreaCode where len(AreaCode)=4");
        }
        public List<AreaCode_> getXianAreaCodeByShiAreaCode(string shicode)
        {
            return base.GetList("select * from AreaCode where len(AreaCode)=6 and SUBSTRING(AreaCode,1,4)=@0", shicode);
        }
        public AreaCode_ getAreaName(string AreaName)
        {
            return base.FirstOrDefault("select AreaName from AreaCode where AreaCode=@0 ", AreaName);
        }
    }
}
