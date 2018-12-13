using DataAccess;
using Entity;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines
{
     public class StudentInfoBLL : IDisposable
    {
        DaoStudentInfo Dao = new DaoStudentInfo();
        public int Update(StudentInfo studentInfo)
        {
            return Dao.Update(studentInfo);
        }

        public void Dispose()
        {

            if (Dao != null)
            {
                Dao.Dispose();
            }
        }

        public int Delete(StudentInfo studentInfo)
        {
            return Dao.Delete(studentInfo);
        }

        public int Insert(StudentInfo studentInfo)
        {
            return (int)Dao.Insert(studentInfo);
        }
        public bool isNew(StudentInfo info)
        {
            return Dao.IsNew(info);

        }
        public void Save(StudentInfo info)
        {
            Dao.Save(info);
        }
        public StudentInfo getEntity(string sfzh) {
            return Dao.GetEntity(sfzh);
        }

    /// <summary>
    /// 通过sql语句返回制定数量的分页数据
    /// </summary>
    /// <param name="pageIndex">返回第几页的数据</param>
    /// <param name="pageSize">分页长度</param>
    /// <returns></returns>
    public Page<StudentInfo> getStuInfoPage(int pageIndex, int pageSize) {
            return Dao.getStuInfoPage(pageIndex, pageSize);
    }
       
    }
}
