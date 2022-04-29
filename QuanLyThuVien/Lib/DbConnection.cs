using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System;

namespace QuanLyThuVien.Lib
{
    public class DbConnection
    {
        public static int ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                    }
                    
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ExecuteNonQuery(string connectionStringName, string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static Object ExecuteScalar( string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                    }

                    return cmd.ExecuteScalar();
                }
            }
        }

        public static Object ExecuteScalar(string connectionStringName, string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                    }

                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                }

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }

        public static SqlDataReader ExecuteReader(string connectionStringName, string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                }

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }
    }
}
