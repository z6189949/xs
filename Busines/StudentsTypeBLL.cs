using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace Busines
{
    public class StudentsTypeBLL
    {
        /// <summary>
        /// 返回所有考生类型的列表
        /// </summary>
        /// <returns></returns>
        public List<StudentsType> getStuTypeList()
        {

            List<StudentsType> retunList = new List<StudentsType>();
            using (DaoStudentsType Dao = new DaoStudentsType())
            {
                retunList = Dao.getStuTypeList();
            }
            return retunList;
        }
    }
}
