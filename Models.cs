using System;

namespace dot_social.Models {
  public class UserDto {
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string Summary { get; set; }
  }

  public class UserCollectionDto {
  }

  public class UserProfileDto {
  }

  public class TagDto {
  }

  public class TagCollectionDto {
  }

  public class PostDto {
  }

  public class PostCollectionDto {
  }
 }
