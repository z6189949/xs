using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("PointType")]
    [PrimaryKey("Id", AutoIncrement = true)]
    /// <summary>
    /// 成绩类型
    /// </summary>
    public class PointType
    {
        public int Id { get; set; }
        /// <summary>
        /// 成绩类型（中文）
        /// </summary>
        public string PointTypeC { get; set; }
        /// <summary>
        /// 成绩类型(英文)
        /// </summary>
        public string PointTypeE { get; set; }
        /// <summary>
        /// 上级类型ID
        /// </summary>
        public int FatherID { get; set; }
        /// <summary>
        /// 次序ID
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// 总分数
        /// </summary>
        public decimal Percent { get; set; }
        /// <summary>
        /// 考试时间
        /// </summary>
        public string TestTime { get; set; }
        /// <summary>
        /// 考试地点
        /// </summary>
        public string TestPlace { get; set; }
        /// <summary>
        /// 属性
        /// </summary>
        public int Attribute { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Bz { get; set; }

    }
}
