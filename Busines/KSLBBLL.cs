using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;

namespace Busines
{
    public class KSLBBLL : IDisposable
    {
        DaoKSLB Dao = new DaoKSLB();
        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }
        public List<KSLB> getListKslb()
        {
            return Dao.getListKslb();
        }
    }
}
