using System.Linq;
using System.Security.Cryptography;

namespace Xiazaibao.Remote.Utils
{
    public class StringUtils
    {
        public static string GetMd5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            return targetData.Aggregate<byte, string>(null, (current, t) => current + t.ToString("x"));
        }
    }
}