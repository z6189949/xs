using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;


namespace Busines
{
    public class AfficheBLL : IDisposable
    {
        DaoAreaCode Dao = new DaoAreaCode();
        public int Update(AreaCode_ affiche)
        {
            return Dao.Update(affiche);
        }
        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }

        public int Delete(AreaCode_ affiche)
        {
            return Dao.Delete(affiche);
        }
        public List<AreaCode_> getShiAreaCode()
        {
            return Dao.getShiAreaCode();
        }
        public List<AreaCode_> getXianAreaCodeByShiAreaCode(string shicode)
        {
            return Dao.getXianAreaCodeByShiAreaCode(shicode);
        }
    }
}
