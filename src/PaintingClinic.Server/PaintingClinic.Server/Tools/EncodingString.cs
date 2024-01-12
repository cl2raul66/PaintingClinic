using System.Security.Cryptography;
using System.Text;

namespace EasyAuth.Server.Tools;

public interface IEncodingString
{
    string ToSHA256Hash(string input);
}

public class EncodingString : IEncodingString
{
    public string ToSHA256Hash(string input)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));

        StringBuilder builder = new();
        for (int i = 0; i < bytes.Length; i++)
        {
            builder.Append(bytes[i].ToString("x2"));
        }
        return builder.ToString();
    }
}
