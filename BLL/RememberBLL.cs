using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
   public class RememberBLL
    {
        RememberDAL rdal = new RememberDAL();

        private string Encode(string Pass)
        {
            byte[] endata = new byte[Pass.Length];
            endata = System.Text.Encoding.UTF8.GetBytes(Pass);
            string encodedata = Convert.ToBase64String(endata);
            return encodedata;
        }

        private string Decode(string EncodedPass)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8decoder = encoder.GetDecoder();
            byte[] todecoder_byte = Convert.FromBase64String("EncodedPass");
            int charcount = utf8decoder.GetCharCount(todecoder_byte, 0, todecoder_byte.Length);
            char[] decode_char = new char[charcount];
            utf8decoder.GetChars(todecoder_byte, 0, todecoder_byte.Length, decode_char, 0);
            string result = new string(decode_char);
            return result;
        }

        public void Create(Remember r)
        {
            r.passwords = r.passwords;
            rdal.Create(r);
        }

        public List<string> Readusername()
        {
           return rdal.Readusername().ToList();
        }
        public List<string> ReadPassword()
        {
            return rdal.ReadPassword().ToList();
        }
        public string ReadPassword1(string username)
        {
            string s = rdal.ReadPassword1(username);
            return s;
           

        }

        public void Changeuser(string s, string p)
        {
           rdal.Changeuser(s,p);
        }
    }
}
