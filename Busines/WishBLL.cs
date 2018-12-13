using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines
{
    public class WishBLL : IDisposable
    {
        DaoWish Dao = new DaoWish();
        public int Update(Wish wish)
        {
            return Dao.Update(wish);
        }

        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }

        public int Delete(Wish wish)
        {
            return Dao.Delete(wish);
        }

        public int Insert(Wish wish)
        {
            return (int)Dao.Insert(wish);
        }
        public bool isNew(Wish wish)
        {
            return Dao.IsNew(wish);

        }
        public void Save(Wish wish)
        {
            Dao.Save(wish);

        }
        public Wish getEntity(string sfzh)
        {
            return Dao.GetEntity(sfzh);
        }
    }
}

