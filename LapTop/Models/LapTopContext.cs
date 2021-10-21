using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace LapTop.Models
{
    public class LapTopContext
    {
        readonly IConfiguration configuration;
        public string ConnectionString { get; set; }

        public LapTopContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Customer> GetCustomer()
        {
            List<Customer> list = new List<Customer>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from KhachHang";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Customer()
                        {
                            MaKH = reader["makh"].ToString(),
                            TenDN = reader["tendangnhap"].ToString(),
                            TenKH = reader["tenKH"].ToString(),
                            SoDT = reader["soDT"].ToString(),
                            Email = reader["email"].ToString(),
                            GTinh = reader["gioiTinh"].ToString(),
                        }) ;
                        
                    }
                }
            }
            return list;
        }

        public List<Customer> SearchCustomer(string search)
        {
            List<Customer> list = new List<Customer>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from KhachHang where makh like '%"+ search + "%' or tenkh like '%" + search + "%' or sodt like '%" + search + "%' or email like '%" + search + "%' or gioitinh like '%" + search + "%' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Customer()
                        {
                            MaKH = reader["makh"].ToString(),
                            TenDN = reader["tendangnhap"].ToString(),
                            TenKH = reader["tenKH"].ToString(),
                            SoDT = reader["soDT"].ToString(),
                            Email = reader["email"].ToString(),
                            GTinh = reader["gioiTinh"].ToString(),
                        });
                    }
                }
            }
            return list;
        }

        public Customer GetDataCustomer(string makh)
        {

            Customer kh = new Customer();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from KhachHang where makh ='" + makh + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kh.MaKH = reader["makh"].ToString();
                        kh.TenDN = reader["tendangnhap"].ToString();
                        kh.TenKH = reader["tenKH"].ToString();
                        kh.SoDT = reader["soDT"].ToString();
                        kh.Email = reader["email"].ToString();
                        kh.GTinh = reader["gioiTinh"].ToString();
                    };

                }
            }
            return kh;
        }

        public int CreateCustomer(Customer kh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into khachhang value(?makh, ?tendangnhap, ?tenkh, ?sodt, ?email, ?gioitinh) ON DUPLICATE KEY UPDATE MaKH = ?makh";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("makh", kh.MaKH.ToString());
                cmd.Parameters.AddWithValue("tendangnhap", kh.TenDN.ToString());
                cmd.Parameters.AddWithValue("tenkh", kh.TenKH.ToString());
                cmd.Parameters.AddWithValue("sodt", kh.SoDT.ToString());
                cmd.Parameters.AddWithValue("email", kh.Email.ToString());
                cmd.Parameters.AddWithValue("gioitinh", kh.GTinh.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int UpdateCustomer(Customer kh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "update khachhang set tenkh=@Tenkh, sodt =@Sodt, email=@Email, gioitinh =@Gioitinh where makh ='"+kh.MaKH+"' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("makh", kh.MaKH.ToString());
                cmd.Parameters.AddWithValue("tendangnhap", kh.TenDN.ToString());
                cmd.Parameters.AddWithValue("tenkh", kh.TenKH.ToString());
                cmd.Parameters.AddWithValue("sodt", kh.SoDT.ToString());
                cmd.Parameters.AddWithValue("email", kh.Email.ToString());
                cmd.Parameters.AddWithValue("gioitinh", kh.GTinh.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int DeleteCustomer(string makh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from khachhang where makh ='" + makh + "' ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }


    }
}
