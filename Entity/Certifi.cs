using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("Certifi")]
    [PrimaryKey("Id", AutoIncrement = true)]
    /// <summary>
    /// 用户总情况说明
    /// </summary>
    public class Certifi
    {
        /// <summary>
        /// 用户总情况id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        public int Attribute { get; set; }

    }
}
