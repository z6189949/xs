using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
namespace Entity
{
    [TableName("SeatAndCertificate")]
    [PrimaryKey("Id", AutoIncrement = true)]
    /// <summary>
    /// 考场座位表
    /// </summary>
    public class SeatAndCertificate
    {
        /// <summary>
        /// 考场座位id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 考试类型1面试2笔试
        /// </summary>
        public int PointId { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Sfzh { get; set; }
        /// <summary>
        /// 考场号
        /// </summary>
        public string RoomNum { get; set; }
        /// <summary>
        /// 座位号
        /// </summary>
        public string SeatNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Title { get; set; }

    }
}
