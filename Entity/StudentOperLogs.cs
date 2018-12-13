using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("StudentOperLogs")]
    [PrimaryKey("Id", AutoIncrement = true)]
    /// <summary>
    /// 学生操作日志
    /// </summary>
    public class StudentOperLogs
    {
        public int Id { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Sfzh { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public string Oper { get; set; }
        /// <summary>
        /// ip
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 登录状态
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }

    }
}
