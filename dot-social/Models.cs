using System;
using System.Collections.Generic;

namespace dot_social.Models {
  public class LocationDto {
    public string name { get; set; }
    public double latitude { get; set; }
    public double longitutde { get; set; }
  }

  public class UserDto {
    public string href { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public sring fullName { get; set; }
    public DateTime birthday { get; set; }
    public LocationDto location { get; set; }
    public DateTime joined { get; set; }
    public bool deleted { get; set; }
  }

  public class UserProfileDto {
    public string href { get; set; }
  }

  public class UserPublicDto {
    public string href { get; set; }
    public string username { get; set; }
    public string email { get; set; }
    public string fullName { get; set; }
    public Location location { get; set; }
  }

  public class UserPublicCollectionDto {
    public List<UserPublicDto> users { get; set; }
    public int count { get; set; }
  }

  public class TagDto {
    public string href { get; set; }
    public string name { get; set; }
    public int referenced { get; set; }
    public DateTime lastUsed { get; set; }
    public DateTime created { get; set; }
  }

  public class TagCollectionDto {
    public List<TagDto> tags { get; set; }
    public int count { get; set; }
  }

  public class PostDto {
    public string href { get; set; }
    public string content { get; set; }
    public DateTime created { get; set; }
    public DateTime editted { get; set; }
  }

  public class PostCollectionDto {
    public List<PostDto> posts { get; set; }
  }
 }
