using System;
using System.Security.Cryptography;
using System.Text;

namespace dot_social {
  public class Crypto {
    /// <summary>
    /// </summary>
    public static string MD5Hash(string input) {
      StringBuilder sBuilder = new StringBuilder();
      using (MD5 md5Hash = MD5.Create()) {
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        for (int i = 0; i < data.Length; i++) {
          sBuilder.Append(data[i].ToString("x2"));
        }
      }
      return sBuilder.ToString();
    }

    /// <summary>
    /// </summary>
    public static string Sha256Hash(string input) {
      StringBuilder sBuilder = new StringBuilder();
      using (SHA256 hash = SHA256Managed.Create()) {
        Encoding enc = Encoding.UTF8;
        Byte[] result = hash.ComputeHash(enc.GetBytes(input));
        foreach (Byte b in result) {
          sBuilder.Append(b.ToString("x2"));
        }
      }
      return sBuilder.ToString();
    }
  }
}
