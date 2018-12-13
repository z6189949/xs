using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
using PetaPoco;

namespace Busines
{
    public class StudentsUserBLL : IDisposable
    {
        DaoStudentsUser Dao = new DaoStudentsUser();

        public int Insert(StudentsUser user)
        {
            return (int)Dao.Insert(user);
        }
        public int Update(StudentsUser studentsuser)
        {
            return Dao.Update(studentsuser);
        }
        public int Delete(StudentsUser studentsuser)
        {
            return Dao.Delete(studentsuser);
        }
        public bool isHaveBySfzh(String sfzh)
        {
            return Dao.isHaveBySfzh(sfzh);
        }
        public void Dispose()
        {
            Dao.Dispose();
        }
        public StudentsUser getStubySfzh(string sfzh)
        {
            return Dao.getStudBySfzh(sfzh);
        }
        public StudentsUser getStudentUserBySighUpNum(String SignUpNum)
        {
            return Dao.getStudentsUserBySignUpNum(SignUpNum);
        }
        public StudentsUser getStudentsSignUpNumBySfzh(String Sfzh)
        {
            return Dao.getStudentsSignUpNumBySfzh(Sfzh);
        }
        public StudentsUser getStuIdbySfzh(string sfzh)
        {
            return Dao.getStuIdbySfzh(sfzh);
        }
        public StudentsUser getStudentsUser(int id)
        {
            return Dao.GetEntity(id);
        }
        public Page<StudentsUser> getStuUserPage(int pageIndex, int pageSize)
        {
            return Dao.getStuUserPage(pageIndex, pageSize);
        }
        public List<StudentsUser> getStudentUser()
        {
            return Dao.getStudentUser();
        }
        public StudentsUser GetEntity(int id)
        {
            return Dao.GetEntity(id);
        }
    }
}
