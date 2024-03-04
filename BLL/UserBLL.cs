using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;


namespace BLL
{
    public class UserBLL
    {
        DB db = new DB();
        UserDAL udal = new UserDAL();

        public string Encode(string text)
        {
            byte[] encData_byte = new byte[text.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(text);
            string enCodeData = Convert.ToBase64String(encData_byte);
            return enCodeData;
        }
        public string Decode(string text)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decoder = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(text);
            int charCount = utf8Decoder.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decoder.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }


        public string Create(User u, UserGroup ug)
        {
            u.Password = Encode(u.Password);
            return udal.Create(u, ug);
        }
        public DataTable Search(string s)
        {
            return udal.Search(s);
        }
        public void ReadActive(int id, bool a)
        {
            udal.ReadActive(id, a);
        }
        public bool IsRegisterd()
        {
            return udal.IsRegisterd();
        }
        public User Read(int id)
        {
            return udal.Read(id);
        }
        public List<string> ReadUserName()
        {
            return udal.ReadUserName();
        }
        public User ReadU(string s)
        {
            return udal.ReadU(s);
        }

        public DataTable Read()
        {
            return udal.Read();
        }

        public string Update(User u, int id)
        {
          //  u.Password = Encode(u.Password);
            return udal.Update(u, id);
        }

        public string Delete(int id)
        {
            return udal.Delete(id);
        }

        public User Login(string s, string p)
        {
            return udal.Login(s, Encode(p));
        }

        public bool Access(User u, string s, int a)
        {
            return udal.Access(u, s, a);
        }
        public User Readid(int id)
        {
            return udal.Readid(id);
        }
        public void Changeuser(string s, string p)
        {
           udal.Changeuser(s, Encode(p));
        }
        public string ReadPassword1(string username)
        {
            return udal.ReadPassword1((username));

        }

        public void remember(string s)
        {
            udal.remember(s);
        }

        public List<User> ReadPatiants()
        {
            return udal.ReadPatiants();
        }
    }
}
