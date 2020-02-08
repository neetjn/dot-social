using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dot_social.Entities {
  public class Location {
    [Key]
    public int id { get; set; }
    public string name { get; set; }
  }

  public class User {
    [Key]
    public int id { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string fullName { get; set; }
    public string password { get; set; }
    public string salt { get; set; }
    [DataType(DataType.Date)]
    public DateTime birthday { get; set; }
    [ForeignKey("location")]
    public int locationId { get; set; }
    public Location location { get; set; }
    [DataType(DataType.Date)]
    public DateTime joined { get; set; }
    public DateTime deleted { get; set; }
  }

  public class Relationship {
    [ForeignKey("user")]
    public int userId { get; set; }
    public User user { get; set; }
    [ForeignKey("partner")]
    public int partnerId { get; set; }
    public User partner { get; set; }
    public string relation { get; set; }
    public bool romantic { get; set; }
    [DataType(DataType.Date)]
    public DateTime conception { get; set; }
  }

  public class Profile {
    [Key]
    public int id { get; set; }
    [ForeignKey("user")]
    public int userId { get; set; }
    public User user { get; set; }
  }

  public class Tag {
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public int referenced { get; set; }
    [DataType(DataType.Date)]
    public DateTime lastUsed { get; set; }
    [DataType(DataType.Date)]
    public DateTime created { get; set; }
  }

  public class Post {
    [Key]
    public int id { get; set; }
    [ForeignKey("author")]
    public int authorId { get; set; }
    public User author { get; set; }
    public string content { get; set; }
    [DataType(DataType.Date)]
    public DateTime created { get; set; }
    [DataType(DataType.Date)]
    public DateTime editted { get; set; }
  }

  // placeholder - possible rel map for tag -> <- post
  /*public class TagFragment {
  }*/

  public class Like {
    [Key]
    public int id { get; set; }
    [ForeignKey("user")]
    public int userId { get; set; }
    public User user { get; set; }
    [ForeignKey("post")]
    public int postId { get; set; }
    public Post post { get; set; }
    [DataType(DataType.Date)]
    public DateTime created { get; set; }
  }
}
