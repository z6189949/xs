using System.Text;
using Entity;
using DataAccess.Base;
using System.Collections.Generic;

namespace DataAccess
{
    public class DaoStudentsType : DaoBase<StudentsType>
    {
        /// <summary>
        /// 返回所有考生类型的列表
        /// </summary>
        /// <returns></returns>
        public List<StudentsType> getStuTypeList()
        {
            
            return base.GetList("select * from StudentsType");
        }
    }
}
