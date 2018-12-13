using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("Affiche")]
    [PrimaryKey("Id", AutoIncrement = true)]
    /// <summary>
    /// 公告
    /// </summary>
    public class AfficheBll
    {
        /// <summary>
        /// 公告id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int InfoType { get; set; }
        /// <summary>
        /// 公告标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 公告内容
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 添加用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 是否配置
        /// </summary>
        public int IsTop { get; set; }
        /// <summary>
        /// 是否红胸
        /// </summary>
        public int IsRed { get; set; }
        /// <summary>
        /// 单机次数
        /// </summary>
        public int Clicks { get; set; }

    }
}
