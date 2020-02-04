using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace dot_social.DatabaseConfig {
  public class DbConfig : DbConfiguration {
    public DbConfig() {
      SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
      SetDefaultConnectionFactory(new LocalDbConnectionFactory("mssqllocaldb"));
    }
  }
}
