using System;
using System.Collections.Generic;
using System.Text;

namespace ZT.DTO
{
    public class GroundLockTerminalInfo
    {
        /// <summary>
        /// 设备编号
        /// </summary>
        public string SN { get; set; }
        /// <summary>
        /// 硬件版本
        /// </summary>
        public string HwVer { get; set; }
        /// <summary>
        ///软件版本
        /// </summary>
        public string SwVer { get; set; }
        /// <summary>
        /// 是否在线
        /// </summary>
        public int OnLine { get; set; }
        /// <summary>
        /// 电量
        /// </summary>
        public string Battery { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string Lng { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string Lat { get; set; }
    }
}
