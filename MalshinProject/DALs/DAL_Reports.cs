using MySql.Data.MySqlClient;
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
            string name = Console.ReadLine();
            Console.WriteLine("Enter your ID");
            string ReporterID = Console.ReadLine();
            if(DALPeople.CheckCode(ReporterID) == -1)
            {
                DALPeople.AddPerson();
            }
            Console.WriteLine("Enter the target's ID.");
            string TargetID = Console.ReadLine();
            if (DALPeople.CheckCode(ReporterID) == -1)
            {
                DALPeople.AddPerson();
            }
            Console.WriteLine("Enter your message.");
            string message = Console.ReadLine();
            Reports report = new Reports(ReporterID,message,TargetID);

            string sql = $"INSERT INTO reports(ReporterId,TargetId,ReportText) VALUES({ReporterID},{TargetID},{message})";
            DBConnection.Execute(sql, null);

        }

        public static bool IsGoodCandidateByCode(string code)
        {
            int count = 0;
            bool isGoodCandidate = false;
            string sql = $"SELECT COUNT (*) from reports WHERE ReporterId = {code}";
            MySqlConnection conn = DBConnection.Connect();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count >= 10)
            {
                return true;
            }
            return false;
        }

        public static bool IsGoodCandidateByName(string name)
        {

            int count = 0;
            bool isGoodCandidate = false;
            string sql = $"SELECT COUNT (*) from reports WHERE FullName = {name}";
            MySqlConnection conn = DBConnection.Connect();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count >= 10)
            {
                return true;
            }
            return false;
        }




        




    }
}
