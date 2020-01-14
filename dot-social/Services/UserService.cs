using System;
using System.Collections.Generic;
using System.Linq;
using dot_social.Database;
using dot_social.Entities;
using dot_social.Models;

namespace dot_social.Services {
  public interface IUserService {
    bool Authenticate(UserAuthenticationDto authDto);
    User Create(UserRegistrationDto registrationDto);
    User GetById(int userId);
    void Update(int userId, UserUpdateDto userDto);
    void Delete(int userId);
  }

  public class UserService : IUserService {
    private DataContext context;

    public UserService(DataContext context) {
      this.context = context;
    }

    public bool Authenticate(UserAuthenticationDto auth) {
      if (string.IsNullOrEmpty(auth.username) || (string.IsNullOrEmpty(auth.username) || string.IsNullOrEmpty(auth.email))) {
        return false;
      }

      User user = context.Users
        .Single(x => string.IsNullOrEmpty(u.username) ? u.username == auth.username : u.email == auth.email);

      return dot_social.Utils.ComparePasswords(password, user.PasswordHash, user.PasswordSalt);
    }

    public User GetById(int userId) {
      return context.Users.Single(u => u.id == userId);
    }

    public User Create(UserRegistrationDto registrationDto) {
      var user = context.Users
        .SingleOrDefault(x => string.IsNullOrEmpty(u.username) ? u.username == auth.username : u.email == auth.email);
      if (user != null) {
        // error out for existing user
      }
      var author = new Author{ FirstName = "William", LastName = "Shakespeare" };
      context.Add<Author>(author);
      context.SaveChanges();
      // TODO: (User Create) left here, figure out location logic
    }

    public void Update(int userId, UserUpdateDto userDto) {
      User user = GetById(userId);

      user.email = userDto.email;
      user.fullName = userDto.fullName;
      if (userDto.password) {
        user.password = Utils.HashPassword(userDto.password, user.salt);
      }
      user.birthday = userDto.birthday;
      // TODO: (User Update) left here, figure out location logic
    }

    public void Delete(int userId) {
      User user = GetById(userId);
      user.deleted = DateTime.now;
      context.Users.Update(user);
      context.SaveChanges();
    }
  }
}
