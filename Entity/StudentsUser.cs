using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using System.ComponentModel;

namespace Entity
{
    [TableName("StudentsUser")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class StudentsUser
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [DisplayName("Id")]
        public int Id { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Sfzh { get; set; }
        /// <summary>
        /// 注册顺序号
        /// </summary>
        public string SignUpNum { get; set; }
        /// <summary>
        /// 口令
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 准考证号
        /// </summary>
        public string Zkzh { get; set; }
        /// <summary>
        /// 考生姓名
        /// </summary>
        public string StuName { get; set; }
        /// <summary>
        /// 登陆次数
        /// </summary>
        public int LoginCount { get; set; }
        /// <summary>
        /// 是否标准
        /// </summary>
        public int IsCriterion { get; set; }
        /// <summary>
        /// 标准课程
        /// </summary>
        public string CriterionCouse { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegDate { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime LastLoginDate { get; set; }
        /// <summary>
        /// 审核结果 0/1通过/2信息不完整/3考生号未填写
        /// </summary>
        public int IsCheck { get; set; }
        /// <summary>
        /// 审核老师
        /// </summary>
        public string CheckTeacher { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime CheckTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Bz { get; set; }
        /// <summary>
        /// 是否计划
        /// </summary>
        public int IsPlan { get; set; }
        /// <summary>
        /// 考生类别
        /// </summary>
        public int StuType { get; set; }
        /// <summary>
        /// 准考证号
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// 状态0/1
        /// </summary>
        public int State { get; set; }

        public String Mobile { get; set; }
        public String E_mail { get; set; }
    }
   
}
