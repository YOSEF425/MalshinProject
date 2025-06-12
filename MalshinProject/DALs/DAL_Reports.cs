using SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinProject.DALs
{
    internal class DAL_Reports
    {

        public static void AddReport()
        {
            Console.WriteLine("Enter your ID");
            string ReporterID = Console.ReadLine();
            Console.WriteLine("Enter the target's ID.");
            string TargetID = Console.ReadLine();
            Console.WriteLine("Enter your message.");
            string message = Console.ReadLine();


            string sql = $"INSERT INTO reports(ReporterId,TargetId,ReportText) VALUES({ReporterID},{TargetID},{message})";
            DBConnection.Execute(sql, null);

        }

        public static int ReporterCount(Report report)
        {
            int count = 0;
            string sql = $"SELECT COUNT (*) FROM reports WHERE ReporterId = {report.ReporterId};"
            MySqlConnection conn = new MySqlConnection
            ("server=localhost;port=3306;user=root;password=yosef1999!;database=malshinon");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;

        }




    }
}
