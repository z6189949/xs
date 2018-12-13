using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("StudentLogs")]
    [PrimaryKey("Id", AutoIncrement = true)]
    /// <summary>
    /// 考生登录日志
    /// </summary>
    public class StudentLogs
    {
        public int Id { get; set; }
        /// <summary>
        /// 记录号
        /// </summary>
        public string SignUpNum { get; set; }
        /// <summary>
        /// 口令
        /// </summary>
        public string ErrorPwd { get; set; }
        /// <summary>
        /// ip
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 登录状态
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime Logintime { get; set; }
        /// <summary>
        /// 登陆方式
        /// </summary>
        public string Cause { get; set; }

    }
}
