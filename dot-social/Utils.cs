using System;
using System.Linq;

namespace dot_social {
  public class Utils {
    /// <summary>
    /// Generate random data for hashing passwords.
    /// </summary>
    public static string GenerateSalt()
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      Random random = new Random();
      return new string(Enumerable.Range(1, 8)
          .Select(_ => chars[random.Next(chars.Length)]).ToArray());
    }

    /// <summary>
    /// Encrypt (hash) password with provided salt.
    /// <example>
    /// string hashed = Utils.HashPassword("mypassword", "123456");
    /// </example>
    /// </summary>
    public static string HashPassword(string password, string salt) {
      string _password = dot_social.Crypto.MD5Hash(password);
      string _salt = dot_social.Crypto.MD5Hash(salt);
      return dot_social.Crypto.Sha256Hash(_password + _salt);
    }

    /// <summary>
    /// Compare plain text password with hash using salt.
    /// <example>
    /// User user = UserService.GetById(1);
    /// bool auth = Utils.ComparePasswords(user.password, user.salt, "mypassword");
    /// </example>
    /// </summary>
    public static bool ComparePasswords(string hash, string salt, string password) {
      return HashPassword(password, salt).Equals(hash);
    }
  }
}
