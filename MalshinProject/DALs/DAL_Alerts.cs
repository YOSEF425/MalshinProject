﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinProject.DALs
{
    internal class DAL_Alerts
    {
        public static bool IsDangerous(string TargetId)
        {
            int count = 0;
            string sql = $"SELECT COUNT(*) FROM your_table_name WHERE reporterId = {TargetId}";
            MySqlConnection conn =
            new MySqlConnection("server=localhost;port=3306;user=root;password=yosef1999!;database=malshinon");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if(count >= 20)
            {
                Alerts alerts = new Alerts("ssdds",TargetId);
                return true;
            }
            else
            {
                return false;
            }
        }

        








        

    }
}
