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
        
        public static void AddPerson() 
        {
            Console.WriteLine("Enter name.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter ID Code.");
            int IdCode = Convert.ToInt32(Console.ReadLine());
            People p = new People(name,IdCode);
            string sql = $"INSERT INTO people(fullName,Id) VALUES({p.FullName},{p.Id})";
               

            DBConnection.Execute(sql);

        }


        public static int CheckCode(int id)   
        {
            string sql = $"SELECT COUNT(*) FROM People WHERE Id = {id}";
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

        public static void GetCodeByName()
        {
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();

            string sql = $"SELECT Id FROM people WHERE FullName = {name}";
            MySqlConnection conn = DBConnection.Connect();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Console.WriteLine(rdr["SecretCode"]);
            }
            else
            {
                Console.WriteLine("Name not found.");
            }

        }



        




    }
}
