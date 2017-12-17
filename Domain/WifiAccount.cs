using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WifiAccount : Account
    {
        public virtual string Ssid { get; set; }

        public override string ToString()
        {
            return "Id : " + this.Id + "\nName : " + this.Name + "\nLogin : " + this.Login + "\nPassword : " + this.Password + "\nDate :" + Update + "\nUser ID : " + UserId + "\nSSID : "+Ssid;
        }
    }
}
