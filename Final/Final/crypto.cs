using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SecureDatabase
{
    internal class crypto
    {
        SqlConnection cnn;
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        public uint generateCustomerID(string email)
        {
            byte[] salt = Encoding.ASCII.GetBytes(email);
            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(email, salt, 5000, HashAlgorithmName.SHA512);
            byte[] IDByte = obj.GetBytes(4);
            uint ID = BitConverter.ToUInt32(IDByte, 0);
            return ID;
        }
    }
}
