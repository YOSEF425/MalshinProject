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
        int TargetId;



        public Alerts(string reason,int targetId)
        {
            this.Reason = reason;
            this.TargetId = targetId;
        }
    }
}
