using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 钻孔基础信息
    /// </summary>
    public class ZkBase
    {
        public long Id { get; set; }
        /// <summary>
        /// 钻孔编号
        /// </summary>
        public string ZkNo { get; set; }

        /// <summary>
        /// 钻孔倾角
        /// </summary>
        public float ZkQj { get; set; }

        /// <summary>
        /// x坐标
        /// </summary>
        public float XZb { get; set; }

        /// <summary>
        /// y坐标
        /// </summary>
        public float YZb { get; set; }

        /// <summary>
        /// z坐标
        /// </summary>
        public float ZZb { get; set; }

        /// <summary>
        /// 钻孔深度
        /// </summary>
        public float ZkSd { get; set; }

        /// <summary>
        /// 终孔深度
        /// </summary>
        public float EndSd { get; set; }

        /// <summary>
        /// 终孔层位
        /// </summary>
        public string EndCw { get; set; }

        /// <summary>
        /// 最终斜度
        /// </summary>
        public float EndXd { get; set; }

        /// <summary>
        /// 开工日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 竣工日期
        /// </summary>
        public float EndQ { get; set; }

        /// <summary>
        /// 施工单位
        /// </summary>
        public string SgDw { get; set; }

        /// <summary>
        /// 施工地点
        /// </summary>
        public string SgDd { get; set; }

        /// <summary>
        /// 穿过层位
        /// </summary>
        public string CgCw { get; set; }

        /// <summary>
        /// 穿过煤层
        /// </summary>
        public string CgMc { get; set; }

        /// <summary>
        /// 测井深度
        /// </summary>
        public float CjSd { get; set; }

        /// <summary>
        /// 测井期
        /// </summary>
        public float CjQ { get; set; }

    }
}
