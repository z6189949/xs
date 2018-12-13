using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StuAllInfo
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

        public string FrsZY { get; set; }
        /// <summary>
        /// 第二志愿
        /// </summary>
        public string SecZY { get; set; }
        /// <summary>
        /// 是否服从专业调剂
        /// </summary>
        public int IsAdjust { get; set; }
        /// <summary>
        /// 是否参加体育、文艺特长生加试
        /// </summary>
        public int IsAddTest { get; set; }
        /// <summary>
        /// 参加特长考试项目
        /// </summary>
        public int Test { get; set; }
        /// <summary>
        /// 艺术类统考分数
        /// </summary>
        public decimal ArtTest { get; set; }
        /// <summary>
        /// 体育类证书
        /// </summary>
        public string RewardPath { get; set; }
    }
}
