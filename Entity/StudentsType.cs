using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("StudentsType")]
    [PrimaryKey("Id", AutoIncrement = true)]
    /// <summary>
    /// 考生类型
    /// </summary>
    public class StudentsType
    {
        public int Id { get; set; }
        /// <summary>
        /// 考生类型
        /// </summary>
        public string StuType { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Bz { get; set; }
    }
}
