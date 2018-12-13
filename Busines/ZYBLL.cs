using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;

namespace Busines
{
    public class ZYBLL : IDisposable
    {
        DaoZY Dao = new DaoZY();
        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }
        public List<ZY> getListZy()
        {
            return Dao.getListZy();
        }
        public String getZymcByZydm(string zydm) {
            return Dao.getZymcByZydm(zydm);
        }
    }
}
