using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinProject
{
    internal class Alerts
    {
        DateTime CreatedAt;
        int Id;
        string Reason;
        string TargetId;



        public Alerts(string reason,string targetId)
        {
            this.Reason = reason;
            this.TargetId = targetId;
        }
    }
}
