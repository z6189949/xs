using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Busines
{
    public class NationBLL : IDisposable
    {
        DaoNation Dao = new DaoNation();
        public int Update(Nation nation)
        {
            return Dao.Update(nation);
        }

        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }

        public int Delete(Nation nation)
        {
            return Dao.Delete(nation);
        }
        public List<Nation> getListNation() {
            return Dao.getListNation();
        }
        public Nation getNationName(string NationCode)
        {
            return Dao.getNationName(NationCode);
        }
    }
}
