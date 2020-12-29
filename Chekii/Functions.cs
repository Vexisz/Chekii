using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chekii
{
    public class Functions
    {
        private static string result;
        #region Starts Threads
        public static void Threader(ThreadStart module)
        {
            for(int i =0; i<Vars.threads; i++)
            {
                new Thread(module).Start();
            }
        }
#endregion
        #region Parse
        public static string Parse(string src,string left,string right)
        {
            return src.Split(new string[]
            {
                left
            }, StringSplitOptions.None)[1].Split(new string[]
            {
                right
            }, StringSplitOptions.None)[0];
        }
        #endregion
        #region ParseLeft
        public static string ParseLeft(string src, string left)
        {
            return src.Split(new string[]
            {
                left
            }, StringSplitOptions.None)[1];
        }
        #endregion 
        #region Decode in Base64
        public static string Base64Decode(string encrypted_text)
        {
            byte[] data = Convert.FromBase64String(encrypted_text);
            string decoded_text = Encoding.UTF8.GetString(data);
            return decoded_text;
        }
        #endregion
        #region Encode in Base64
        public static string Base64Encode(string normal_text)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(normal_text);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        #endregion
        #region Random String
        public static string RandomString(int length, string type)
        {
            var rnd = new Random();
            var abc = "abcdefghijklmnopqrstuvwxyz";
            var ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "123456789";
            var mix = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789";
            //Only numbers
            if (type == "?m")
            {
                var rndstr = new string(Enumerable.Repeat(numbers, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
                result = rndstr;
            }
            //Only lower letters
            else if(type == "?l")
            {
                var rndstr = new string(Enumerable.Repeat(abc, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
                result = rndstr;
            }
            //Only Upper letters
            else if(type == "?v")
            {
                var rndstr = new string(Enumerable.Repeat(ABC, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
                result = rndstr;
            }
            //Mix
            else if(type == "?r")
            {
                var rndstr = new string(Enumerable.Repeat(mix, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
                result = rndstr;
            }
            return result;
        }
        #endregion
        //Picks a random value from list (not ready)
        //public static string RandomPick()
        //{

        //}


    }
}
