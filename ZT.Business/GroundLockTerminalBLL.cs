using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ZT.DTO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZT.Business
{
    public class GroundLockTerminalBLL
    {
        public const string apiDomain = "http://47.104.31.86:1234";

        public int GetTotalCount()
        {
            return 0;
        }

        /// <summary>
        /// 获取设备信息
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        public GroundLockTerminalInfo GetTerminalInfo(string sn)
        {
            string requestUrl = apiDomain + "/device/info/" + sn;
            var client = new HttpClient();

            var res = client.GetAsync(requestUrl);
            var resp = res.Result;

            Task<string> temp = resp.Content.ReadAsStringAsync();
            temp.Wait();
            var jObject = JObject.Parse(temp.Result);
            return JsonConvert.DeserializeObject<GroundLockTerminalInfo>(jObject["data"].ToString());
        }

        public bool DownLock(string sn)
        {
            string requestUrl = apiDomain + "/" + sn + "/cmd" + "/" + ZTEnum.CommandType.DownLock;
            var client = new HttpClient();

            //发送请求
            client.GetAsync(requestUrl);
            return true;
        }

        public bool UpLock(string sn)
        {
            string requestUrl = apiDomain + "/" + sn + "/cmd" + "/" + ZTEnum.CommandType.UpLock;
            var client = new HttpClient();

            //发送请求
            client.GetAsync(requestUrl);
            return true;
        }
    }
}
