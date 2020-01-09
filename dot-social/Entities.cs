using System;
using System.ComponentModel.DataAnnotations;

namespace dot_social.Entities {
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
    public string relation { get; set; }
    public bool romantic { get; set; }
    [DataType(DataType.Date)]
    public DateTime conception { get; set; }
  }

  public class Profile {
    [Key]
    public int id { get; set; }
    [ForeignKey("userId")]
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
    [ForeignKey("userId")]
    public User user { get; set; }
    [ForeignKey("postId")]
    public Post post { get; set; }
    [DataType(DataType.Date)]
    public DateTime created { get; set; }
  }
}
