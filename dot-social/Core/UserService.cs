using System;
using System.Collections.Generic;
using System.Linq;
using dot_social.Database;
using dot_social.Entities;
using dot_social.Models;

namespace dot_social.Services {
  public interface IUserService {
    User Authenticate(string username, string password);
    User GetById(int id);
    User Create()
  }

  public class UserService : IUserService {
    private DataContext _context;

    public UserService(DataContext context) {
      _context = context;
    }

    public User Authenticate() {
      if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        return null;

      var user = _context.Users.SingleOrDefault(x => x.Username == username);

      // check if username exists
      if (user == null)
        return null;

      // check if password is correct
      if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        return null;

      // authentication successful
      return user;
    }
  }
}
