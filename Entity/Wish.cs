using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("Wish")]
    [PrimaryKey("Sfzh", AutoIncrement = true)]
    /// <summary>
    /// 考生志愿表
    /// </summary>
    public class Wish
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Sfzh { get; set; }
        /// <summary>
        /// 第一志愿
        /// </summary>
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
