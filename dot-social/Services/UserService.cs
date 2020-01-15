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

    /// <summary>
    /// </summary>
    public bool Authenticate(UserAuthenticationDto auth) {
      if (string.IsNullOrEmpty(auth.username) || (string.IsNullOrEmpty(auth.username) || string.IsNullOrEmpty(auth.email))) {
        return false;
      }
      User user = context.Users
        .Single(x => string.IsNullOrEmpty(u.username) ? u.username == auth.username : u.email == auth.email);
      return dot_social.Utils.ComparePasswords(password, user.PasswordHash, user.PasswordSalt);
    }

    /// <summary>
    /// </summary>
    public User GetById(int userId) {
      return context.Users.Single(u => u.id == userId);
    }

    /// <summary>
    /// </summary>
    public User Create(UserRegistrationDto registrationDto) {
      try {
         context.Users
          .Single(u => u.username == registrationDto.username || u.email == registrationDto.email);
      }
      catch () {
        string salt = Utils.GenerateSalt();
        string password = Utils.HashPassword(registrationDto.password, salt);
        User user = new User{
          username = registrationDto.username,
          email = registrationDto.email,
          fullName = registrationDto.fullName,
          birthday = registrationDto.birthday,
          password = password,
          salt = salt,
          joined = DateTime.now,
          locationId = registrationDto.locationId
        };
        context.Add<User>(suser);
        context.SaveChanges();
      } finally {

      }
    }

    /// <summary>
    /// </summary>
    public void Update(int userId, UserUpdateDto userDto) {
      User user = GetById(userId);
      user.email = userDto.email;
      user.fullName = userDto.fullName;
      if (userDto.password) {
        user.password = Utils.HashPassword(userDto.password, user.salt);
      }
      user.birthday = userDto.birthday;
      user.locationId = userDto.locationId;
    }

    /// <summary>
    /// </summary>
    public void Delete(int userId) {
      User user = GetById(userId);
      user.deleted = DateTime.now;
      context.Users.Update(user);
      context.SaveChanges();
    }
  }
}
