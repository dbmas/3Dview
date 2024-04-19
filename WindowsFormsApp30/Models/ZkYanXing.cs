using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 钻孔岩性
    /// </summary>
    public class ZkYanXing
    {
        public long Id { get; set; }

        /// <summary>
        /// 钻孔编号
        /// </summary>
        public string ZkNo { get; set; }
        /// <summary>
        /// 地层代码界
        /// </summary>
        public string DcDmj { get; set; }
        /// <summary>
        /// 地层代码统
        /// </summary>
        public string DcDmt { get; set; }
        /// <summary>
        /// 地层代码段
        /// </summary>
        public string DcDmd { get; set; }
        /// <summary>
        /// 岩层层号
        /// </summary>
        public string YcCh { get; set; }
        /// <summary>
        /// 地层代码系
        /// </summary>
        public string DcDmx { get; set; }
        /// <summary>
        /// 地层代码组
        /// </summary>
        public string DcDmz { get; set; }
        /// <summary>
        /// 岩层累计假厚度
        /// </summary>
        public float YcLjJhd { get; set; }
        /// <summary>
        /// 岩层假厚度
        /// </summary>
        public float YcJhd { get; set; }
        /// <summary>
        /// 岩石名称
        /// </summary>
        public string YsMc { get; set; }
        /// <summary>
        /// 岩层真厚度
        /// </summary>
        public string YcZhd { get; set; }
        /// <summary>
        /// 岩层累计真厚度
        /// </summary>
        public string YcLjZhd { get; set; }
        /// <summary>
        /// 岩性描述
        /// </summary>
        public string YxMs { get; set; }
        /// <summary>
        /// 岩层倾角
        /// </summary>
        public float YcQj { get; set; }
        /// <summary>
        /// 采取率
        /// </summary>
        public float Cql { get; set; }
        /// <summary>
        /// 采长
        /// </summary>
        public float Cc { get; set; }
        /// <summary>
        /// 标志层名称
        /// </summary>
        public string BzcMc { get; set; }
    }
}
