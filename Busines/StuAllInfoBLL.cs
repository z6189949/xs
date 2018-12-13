using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;
namespace Busines
{
    public class StuAllInfoBLL : IDisposable
    {
        #region Private
        private DaoStuAllInfo _dao;
        private DaoStuAllInfo Dao
        {
            get
            {
                if (_dao == null)
                {
                    _dao = new DaoStuAllInfo();
                }
                return _dao;
            }
        }

        #endregion

        public int Update(StuAllInfo stuAllInfo)
        {
            return Dao.Update(stuAllInfo);
        }

        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }

        public int Delete(StuAllInfo stuAllInfo)
        {
            return Dao.Delete(stuAllInfo);
        }

        public int Insert(StuAllInfo stuAllInfo)
        {
            return (int)Dao.Insert(stuAllInfo);
        }
        public bool isNew(StuAllInfo stuAllInfo)
        {
            return Dao.IsNew(stuAllInfo);

        }
        public void Save(StuAllInfo stuAllInfo)
        {
            Dao.Save(stuAllInfo);

        }
        public StuAllInfo getEntity(string sfzh)
        {
            return Dao.GetEntity(sfzh);
        }
        public List<StuAllInfo> getStuAllInfo()
        {
            return Dao.getStuAllInfo();
        }
    }
}
