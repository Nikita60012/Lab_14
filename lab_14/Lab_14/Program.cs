using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip_v4 = "tytyty193.166.235.189uytiyui";
            string ip_v4_2 = "193.006.235.189";
            string ip_v6 = "2001:DB0::0:123A";
            string ip_v6_2 = "tyutiuyiuy2001:0DB0:0000:123A:0000:0000:0000:0030uyiuyuyuy";

            IpCheck($"Hello world fdljgdlj {ip_v4} Hello C# lkclk");
            IpCheck($"Hello world fdljgdlj {ip_v4_2} Hello C# lkclk");
            IpCheck($"Hello world fdljgdlj {ip_v6} Hello C# lkclk");
            IpCheck($"Hello world fdljgdlj {ip_v6_2} Hello C# lkclk");
        }
        public static void IpCheck(string str)
        {

            Match ip_v4 = Regex.Match(str, @"(((25[0-5]|(2[0-4]\d))|(1\d{2})|([^0]\d{1,2}))\.){3}(((25[0-5]|(2[0-4]\d))|(1\d{2})|(\d{1,2})))");
            Match ip_v6 = Regex.Match(str, @"(([0-9a-f]{1,4}:){7}([0-9a-f]{1,4})|([0-9a-f]{1,4}:){1,5}(:[0-9a-f]{1,4}){1,5}|([0-9a-f]{1,4}:){1,5}:(?!:))", RegexOptions.IgnoreCase);
            
            //(?!(::([0-9a-f]{1,4}:){1,5}([0-9a-f]{1,4}){1,5}))

            if (ip_v6.Success)
            {
                Console.WriteLine($"найден ip v6: {ip_v6.Value}");
            }
            else if (ip_v4.Success)
            {
                Console.WriteLine($"найден ip v4: {ip_v4.Value}");
            }

            else
            {
                Console.WriteLine("Ip отсутствует");
            }
        }
    }
}
