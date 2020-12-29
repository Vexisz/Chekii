using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chekii
{
    public class Functions
    {
        public static void Threader(ThreadStart module)
        {
            for(int i =0; i<Vars.threads; i++)
            {
                new Thread(module).Start();
            }
        }

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
        public static string ParseLeft(string src, string left)
        {
            return src.Split(new string[]
            {
                left
            }, StringSplitOptions.None)[1];
        }

        

        
    }
}
