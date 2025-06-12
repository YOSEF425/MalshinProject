using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinProject
{
    public static class DALPeople
    {
        
        public static void AddPerson(People person) 
        {
            string sql = $"INSERT INTO people(fullName,SecretCode,CreaedAt)" +
                $"VALUES({person.FullName},{person.SecretCode},{person.CreatedAt}";

            DBConnection.Execute(sql);

        }


        public static int CheckCode(string code)   
        {
            string sql = $"SELECT COUNT(*) FROM People WHERE SecretCode = {code}";
            MySqlConnection conn =
                new MySqlConnection("server=localhost;port=3306;user=root;password=yosef1999!;database=malshinon");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }


        public static int CheckName(string name)
        {
            string sql = $"SELECT COUNT (*) FROM people WHERE FullName = {name}";
            MySqlConnection conn =
            new MySqlConnection("server=localhost;port=3306;user=root;password=yosef1999!;database=malshinon");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        public static string GetNameByCode()
        {
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();

            string sql = $"SELECT SecretCode FROM people WHERE FullName = {name}";
            MySqlConnection conn =
            new MySqlConnection("server=localhost;port=3306;user=root;password=yosef1999!;database=malshinon");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);


        }




    }
}
