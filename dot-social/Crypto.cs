using System;
using System.Security.Cryptography;

namespace dot_social.Crypto {
  /// <summary>
  /// </summary>
  public static string MD5Hash(string input) {
    MD5 md5Hash = MD5.Create();
    byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
    StringBuilder sBuilder = new StringBuilder();
    for (int i = 0; i < data.Length; i++)
    {
      sBuilder.Append(data[i].ToString("x2"));
    }
    return sBuilder.ToString();
  }

  /// <summary>
  /// </summary>
  public static string Sha256Hash(string input) {
    StringBuilder Sb = new StringBuilder();
    using (SHA256 hash = SHA256Managed.Create()) {
      Encoding enc = Encoding.UTF8;
      Byte[] result = hash.ComputeHash(enc.GetBytes(input));
      foreach (Byte b in result) {
        Sb.Append(b.ToString("x2"));
      }
    }
    return Sb.ToString();
  }
}
