using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines
{
    public class AreaCodeBLL : IDisposable
    {
        DaoAreaCode Dao = new DaoAreaCode();
        public void Dispose()
        {
            if (Dao != null) { Dao.Dispose(); }

        }
        public int Insert(AreaCode_ areaCode)
        {
            return (int)Dao.Insert(areaCode);
        }
        public int Update(AreaCode_ areaCode)
        {
            return Dao.Update(areaCode);
        }
        public int Delete(AreaCode_ areaCode)
        {
            return Dao.Delete(areaCode);
        }
        public List<AreaCode_> getShiAreaCode()
        {
            return Dao.getShiAreaCode();
        }
        public List<AreaCode_> getXianAreaCodeByShiAreaCode(string shiCode)
        {
            return Dao.getXianAreaCodeByShiAreaCode(shiCode);
        }
        public AreaCode_ getAreaName(string AreaName)
        {
            return Dao.getAreaName(AreaName);
        }
        
    }
}
