using System;

namespace dot_social.Utils {
  public class Utils {
    /// <summary>
    /// Generate random data for hashing passwords.
    /// </summary>
    public static string GenerateSalt() {
      return "";
    }

    /// <summary>
    /// Encrypt (hash) password with provided salt.
    /// <example>
    /// string hashed = Utils.HashPassword("mypassword", "123456");
    /// </example>
    /// </summary>
    public static string HashPassword(string password, string salt) {
      return "";
    }

    /// <summary>
    /// Compare plain text password with hash using salt.
    /// <example>
    /// User user = UserService.GetById(1);
    /// bool auth = Utils.ComparePasswords(user.password, user.salt, "mypassword");
    /// </example>
    /// </summary>
    public static bool ComparePasswords(hash, salt, password) {
      return HashPassword(password, salt).Equals(hash);
    }

    /// <summary>
    /// Encrypt post content in the database.
    /// </summary>
    public static string EncryptContent(string content) {
      return "";
    }

    /// <summary>
    /// Decrypt post content from the database.
    /// </summary>
    public static string DecryptContent(string content) {
      return "";
    }
  }
}
