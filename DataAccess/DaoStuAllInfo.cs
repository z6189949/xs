using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using DataAccess.Base;
using Entity;

namespace DataAccess
{
    public class DaoStuAllInfo : DaoBase<StuAllInfo>
    {
        public List<StuAllInfo> getStuAllInfo() {
            return base.GetList("select * from StudentsUser a join StudentInfo b on a.Sfzh = b.Sfzh join Wish c on a.Sfzh=c.Sfzh");
        }
    }
}
