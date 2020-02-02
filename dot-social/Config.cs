using System;

namespace dot_social.Config {
  public class AppConfig {
    public string appHost { get; set; }
    public string appPort { get; set; }
    public string dbHost { get; set; }
    public string dbPort { get; set; }
    public bool devMode { get; set; }
    public string jwtKey { get; set; }
  }

  public class AppLoginSettings {
    public int maxFailedLogins { get; set; }
    public int maxSessionTime { get; set; }
  }

  public class AppUserSettings {
    public int avatarSize { get; set; }
    public int usernameMinChar { get; set; }
    public int usernameMaxChar { get; set; }
    public int nameMinChar { get; set; }
    public int nameMaxChar { get; set; }
  }

  public class AppPostSettings {
    public int contentMinChar { get; set; }
    public int contentMaxChar { get; set; }
    public int tagMinChar { get; set; }
    public int tagMaxChar { get; set; }
  }

  public class AppSettings {
    public AppLoginSettings loginSettings { get; set; }
    public AppUserSettings userSettings { get; set; }
    public AppPostSettings appSettings { get; set; }
  }
}
