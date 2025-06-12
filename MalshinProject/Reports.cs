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
        private string ReporterId  { get; set; }
        private string ReporterText { get; set; }
        private DateTime SubmittedAt { get; set; }
        private string TargetId   { get; set; }


        public Reports(string ReporterId, string ReporterText, string TargetId)
        {
            this.ReporterId = ReporterId;
            this.ReporterText = ReporterText;
            this.TargetId = TargetId;
        }


    }
}
