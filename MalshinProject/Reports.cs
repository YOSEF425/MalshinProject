using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinProject
{
    internal class Reports
    {
        private int Id   { get; set; }
        private int ReporterId  { get; set; }
        private string ReporterText { get; set; }
        private DateTime SubmittedAt { get; set; }
        private int TargetId   { get; set; }


        public Reports(int ReporterId, string ReporterText, int TargetId)
        {
            this.ReporterId = ReporterId;
            this.ReporterText = ReporterText;
            this.TargetId = TargetId;
        }


    }
}
