using System;
using System.Collections.Generic;
using System.Linq;
using dot_social.Database;
using dot_social.Entities;
using dot_social.Models;

namespace dot_social.Services {
  public interface IUserService {
    User Authenticate(UserAuthenticationDto authDto);
    User Create(UserRegistrationDto registrationDto);
    void Update(UserUpdateDto userDto);
  }

  public class UserService : IUserService {
    private DataContext _context;

    public UserService(DataContext context) {
      _context = context;
    }

    public User Authenticate(UserAuthenticationDto auth) {
      if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        return null;

      var user = _context.Users.SingleOrDefault(x => x.Username == username);

      // check if username exists
      if (user == null)
        return null;

      // check if password is correct
      if (!dot_social.Utils.ComparePasswords(password, user.PasswordHash, user.PasswordSalt))
        return null;

      // authentication successful
      return user;
    }

    public User Create(UserRegistrationDto registrationDto) {
    }

    public void Update(UserUpdateDto userDto) {
    }
  }
}
