using System;
using System.ComponentModel.DataAnnotations;

namespace dot_social.Database {
  public class Location {
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
  }
  public class User {
    [Key]
    public int id { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string fullName { get; set; }
    [DataType(DataType.Date)]
    public DateTime birthday { get; set; }
    [ForeignKey("locationId")]
    public Location location { get; set; }
    [DataType(DataType.Date)]
    public DateTime joined { get; set; }
    public bool deleted { get; set; }
  }

  public class Relationship {
    [ForeignKey("userId")]
    public User user { get; set; }
    [ForeignKey("partnerId")]
    public User partner { get; set; }
    public string type { get; set; }
    [DataType(DataType.Date)]
    public DateTime conception { get; set; }
  }

  public class Profile {
    public int
    [ForeignKey("userId")]
    public User user;

  }

  public class Tag {

  }

  public class Post {

  }
}
