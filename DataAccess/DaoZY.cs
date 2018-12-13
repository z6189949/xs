using Entity;
using DataAccess.Base;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class DaoZY : DaoBase<ZY>
    {
        public List<ZY> getListZy()
        {
            return base.GetList("select Id,ZYDM,'('+KLMC+')'+ZYMC as ZYMC from ZY");
        }

        public String getZymcByZydm(string zydm)
        {
            ZY selectZy = new ZY();
            selectZy = base.FirstOrDefault("select *  from ZY where ZYDM=@0",zydm);
            return selectZy.ZYMC;
        }
    }
}
