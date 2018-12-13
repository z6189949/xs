using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;

namespace Busines
{
    public class BYLBBLL : IDisposable
    {
        DaoBYLB Dao = new DaoBYLB();

        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }
        public List<BYLB> getListBylb()
        {
            return Dao.getListBylb();
        }
    }
}
