﻿using System;
using System.Data.SqlClient;
using log4net;

namespace ADO4Join
{
    class OneToMany
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(OneToOne));
        static SqlConnection con = null;
        static void Connection()
        {
            try
            {

                string str = @"Data Source=DESKTOP-4EEFVUL\SQLEXPRESS;Initial Catalog=PersonOtoM;Integrated Security=True";
                con = new SqlConnection(str);
            }
            catch (Exception ex)
            {
                log.Error("Somthing wrong : " + ex);
            }
        }
        static void InnerJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P INNER JOIN MAIL_ACCOUNT M ON P.ID = M.PERSON_ID;", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................INNER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                log.Error("ERROR :" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void LeftOuterJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P LEFT OUTER JOIN MAIL_ACCOUNT M ON P.ID = M.PERSON_ID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................LEFT OUTER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                log.Error("Error : " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void RightOuterJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P RIGHT OUTER JOIN MAIL_ACCOUNT M ON P.ID = M.PERSON_ID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................RIGHT OUTER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                log.Error("Error : " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void FullOuterJoin()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON P FULL OUTER JOIN MAIL_ACCOUNT M ON P.ID = M.PERSON_ID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine(".......................FULL OUTER JOIN.......................");
                Console.WriteLine();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("===========================================================================================");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("===========================================================================================");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                log.Error("Error : " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            Connection();
            InnerJoin();
            LeftOuterJoin();
            RightOuterJoin();
            FullOuterJoin();
            Console.ReadKey();
        }
    }
}