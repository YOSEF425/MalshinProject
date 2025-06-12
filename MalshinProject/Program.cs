using MalshinProject.DALs;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;

namespace MalshinProject
{
    public class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("1. submit Report");
            Console.WriteLine("2. Import from csv");
            Console.WriteLine("3. Show secret code by name");
            Console.WriteLine("4. Analysis Dashboard");
            Console.WriteLine("5. Exit");
        }

        public static void Main(string[] args)
        {
            ShowMenu();
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please identify yourself. Options: 1. By name   2. By secretCode");
                        int ident_choice = Convert.ToInt32(Console.ReadLine());
                        if (ident_choice == 1)
                        {
                            Console.WriteLine("Enter your name.");

                            DAL_Reports.AddReport();
                        }
                        else
                        {
                            DAL_Reports.AddReport();

                        }
                        break;

                    case 2:
                        break;


                    case 3:
                        DALPeople.GetNameByCode();
                        break;


                    case 4:
                        Console.WriteLine("Enter Target Id");
                        string TargetId = Console.ReadLine();
                        DAL_Alerts.IsDangerous(TargetId);
                        break;
                    case 5:
                        break;

                }
            }
            Console.WriteLine("Thanks for visiting!");



                            
            

        }
    }

}
