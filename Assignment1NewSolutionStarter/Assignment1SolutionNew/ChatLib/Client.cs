using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public class Client
    {
        public static object IPADDRESS { get; set; }

        public object NetworkingBase()
        {
            return true;
        }

        public object GetComponentType()
        {
            return "hi";
        }

        public object Getmethod()
        {
            return "StartTcpClient";

        }

        public void StartTcpClient()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }
    }

  
}
