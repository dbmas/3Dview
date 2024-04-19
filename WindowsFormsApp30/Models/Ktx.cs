using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 勘探线数据
    /// </summary>
    public class Ktx
    {
        public long Id { get; set; }
        /// <summary>
        /// 勘探线编号
        /// </summary>
        public string KtxNo { get; set; }

        /// <summary>
        /// 钻孔编号
        /// </summary>
        public string ZkNo { get; set; }

        /// <summary>
        /// 钻孔在该勘探线中的编号
        /// </summary>
        public string ZkKtxNo{get;set;}

    }
}
