using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("StudentInfo")]
    [PrimaryKey("Sfzh", AutoIncrement = false)]
    /// <summary>
    /// 考生信息表
    /// </summary>
    public class StudentInfo
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Sfzh { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Csrq { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public string Nation { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Xb { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string ZZMM { get; set; }
        /// <summary>
        /// 健康状态
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// 考生类别
        /// </summary>
        public string KSLB { get; set; }
        /// <summary>
        /// 所在县区代码
        /// </summary>
        public string AreaCode { get; set; }
        /// <summary>
        /// 毕业学校
        /// </summary>
        public string Byyx { get; set; }
        /// <summary>
        /// 毕业类别
        /// </summary>
        public string BYLB { get; set; }
        /// <summary>
        /// 爱好
        /// </summary>
        public string LikeSpecial { get; set; }
        /// <summary>
        /// 收件人
        /// </summary>
        public string AcceptPeople { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 固定电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// E_Mail
        /// </summary>
        public string EMail { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string Yzbm { get; set; }
        /// <summary>
        /// 通知书邮寄地址
        /// </summary>
        public string Txdz { get; set; }
        /// <summary>
        /// /照片地址
        /// </summary>
        public string PicPath { get; set; }

    }
}
