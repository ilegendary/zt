using System;
using Xunit;
using ZT.Business;
using ZT.DTO;
using System.Threading.Tasks;

namespace ZT.UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void   GetInfoTestAsync()
        {
            GroundLockTerminalBLL terminalBLL = new GroundLockTerminalBLL();
            GroundLockTerminalInfo terminalInfo =  terminalBLL.GetTerminalStatus("ZZCWS0000002");
            Assert.Equal(1, terminalInfo.OnLine);
        }


    }
}
