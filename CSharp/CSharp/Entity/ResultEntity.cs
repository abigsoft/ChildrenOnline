using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Entity
{
    public class ResultEntity
    {
        private int status = 0;
        public void setStatus(int value)
        {
            this.status = value;
        }

        public int getStatus()
        {
            return this.status;
        }
        private string msg = "系统错误";
        public void setMsg(string value)
        {
            this.msg = value;
        }

        public string getMsg()
        {
            return this.msg;
        }
        private JToken data = null;
        public void setData(JToken value)
        {
            this.data = value;
        }

        public JToken getData()
        {
            return this.data;
        }
    }
}
