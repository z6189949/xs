using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess.Base;
using PetaPoco;
namespace DataAccess
{
    public class DaoStudentInfo : DaoBase<StudentInfo>
    {
        public bool isNew(StudentInfo info)
        {
            return base.IsNew(info);

        }
        /// <summary>
        /// 通过sql语句返回制定数量的分页数据
        /// </summary>
        /// <param name="pageIndex">返回第几页的数据</param>
        /// <param name="pageSize">分页长度</param>
        /// <returns></returns>
        public Page<StudentInfo> getStuInfoPage(int pageIndex,int pageSize)
        {
           return  base.Page(pageIndex, pageSize,"select * from StudentInfo");
        }
    }
}
