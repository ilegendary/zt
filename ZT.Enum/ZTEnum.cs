
using System;

namespace ZT
{
    public class ZTEnum
    {
        /// <summary>
        /// 车锁状态
        /// </summary>
        public enum GroudLockStatus
        {
            /// <summary>
            /// 未激活状态
            /// </summary>
            InActived=-1,
            /// <summary>
            /// 0  车锁上锁，无预定状态  （此时摇臂处于升起状态，且无车进入）
            /// </summary>
            LockUp_NoBooking=0,
            /// <summary>
            /// 1  车锁上锁，已预定状态  （此时摇臂处于升起状态，且无车进入）
            /// </summary>
            LockUp_Booking,
            /// <summary>
            /// 2  车位锁开锁，待停车状态（此时摇臂处于下降状态，且无车进入）
            /// </summary>
            LockDown_Wating,
            /// <summary>
            /// 3  车位锁开锁，已停车状态（此时摇臂处于下降状态，车已进入）
            /// </summary>
            LockDown_Parking,
            /// <summary>
            /// 4  车位锁开锁，车离开状态（此时摇臂处于下降状态，车已离开）
            /// </summary>
            LockDown_Left,
            /// <summary>
            /// 5  车位锁上锁失败，且摇臂处于下降状态（此时摇臂处于下降状态）
            /// </summary>
            LockUpFailed_Down,
            /// <summary>
            /// 6  车位锁上锁失败，且摇臂处于中间状态（此时摇臂处于异常状态）
            /// </summary>
            LockUpFailed_Intermediate,
            /// <summary>
            /// 7  车位锁开锁失败，且摇臂处于升起状态（此时摇臂处于升起状态）
            /// </summary>
            LockDownFailed_Up,
            /// <summary>
            /// 8  车位锁开锁失败，且摇臂处于中间状态（此时摇臂处于异常状态）
            /// </summary>
            LockDwonFailed_Intermediate,
            /// <summary>
            /// 9  车锁非法侵占状态 （摇臂处于升起状态时，被外力推倒后无法恢复到升起状态，      而是处于下降或异常状态）
            /// </summary>
            Abnormal

        }

        /// <summary>
        /// 已经操作指令
        /// </summary>
        public enum CommandType
        {
            /// <summary>
            /// 关锁
            /// </summary>
            UpLock = 0,
            /// <summary>
            /// 开锁
            /// </summary>
            DownLock,
            /// <summary>
            /// 找锁
            /// </summary>
            FindLock,
            /// <summary>
            /// 预定
            /// </summary>
            Book,
            /// <summary>
            /// 取消预定
            /// </summary>
            CancelBook,
            /// <summary>
            /// 获取电量
            /// </summary>
            GetPower
        }
    }
}
