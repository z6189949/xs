using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 考生需要参加的考试项目表
    /// </summary>
    public class StudentsTypePointType
    {
        public int Id { get; set; }
        /// <summary>
        /// 考生类别
        /// </summary>
        public int StudentType { get; set; }
        /// <summary>
        /// 考试类别
        /// </summary>
        public int PointType { get; set; }

    }
}
