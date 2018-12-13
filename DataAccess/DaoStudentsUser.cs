using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using PetaPoco;

namespace DataAccess
{
    public class DaoStudentsUser : Base.DaoBase<StudentsUser>
    {
        public bool isHaveBySfzh(String sfzh)
        {
            if (base.FirstOrDefault("select * from StudentsUser where Sfzh=@0", sfzh) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // <summary>
        /// 通过考生的身份证号返回考生id
        /// </summary>
        /// <param name="sfzh">身份证号</param>
        /// <returns>id</returns>
        public StudentsUser getStudBySfzh(string sfzh)
        {
            return base.FirstOrDefault("select * from StudentsUser where Sfzh=@0", sfzh);
        }
        // <summary>
        /// 通过登录名返回考生信息
        /// </summary>
        /// <param name="SignUpNum">登录名</param>
        /// <returns></returns>
        public StudentsUser getStudentsUserBySignUpNum(string SignUpNum)
        {
            return base.FirstOrDefault("select * from StudentsUser where SignUpNum=@0", SignUpNum);
        }
        public  StudentsUser getStudentsSignUpNumBySfzh(string Sfzh)
        {
            return base.FirstOrDefault("select * from StudentsUser where  Sfzh=@0", Sfzh);
        }
        /// <summary>
        /// 考生身份证号码返回id
        /// </summary>
        /// <param name="sfzh">身份证号</param>
        /// <returns>ID</returns>
        public StudentsUser getStuIdbySfzh(String sfzh)
        {
            return base.FirstOrDefault("selecet * from StudentsUser where  Sfzh={0}", sfzh);
        }
        /// <summary>
        /// 返回制定页的考生信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public Page<StudentsUser> getStuUserPage(int pageIndex,int pageSize) {
            return base.Page(pageIndex, pageSize,"select Id,Sfzh,StuName,Zkzh,Mobile from StudentsUser");
        }
        public List<StudentsUser> getStudentUser() {
            return base.GetList("select * from StudentsUser");
        }
    }
}
