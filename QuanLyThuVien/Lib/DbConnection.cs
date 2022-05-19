using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System;
using System.Diagnostics;

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

                    // Debug
                    Debug.WriteLine(cmd.CommandText);

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

                    // Debug
                    Debug.WriteLine(cmd.CommandText);

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

                // Debug
                Debug.WriteLine(cmd.CommandText);

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

        public static DataTable ExecuteAdapter(string commandText, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SA"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlDataAdapter da = new SqlDataAdapter(commandText, conn))
            {
                da.SelectCommand.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                }
                catch
                {
                    throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static DataTable ExecuteAdapter(string connectionStringName, string commandText, params SqlParameter[] parameters)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlDataAdapter da = new SqlDataAdapter(commandText, conn))
            {
                da.SelectCommand.Parameters.AddRange(parameters);

                try
                {
                    conn.Open();
                }
                catch
                {
                    throw new Exception("Không thể kết nối tới cơ sở dữ liệu!");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
