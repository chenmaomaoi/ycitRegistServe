using System.Data.Entity;
using SQLite.CodeFirst;
using RegistServe.DB.Domain;

namespace RegistServe.DB
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext() : base("DataBase") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //如果不存在数据库，则创建
            Database.SetInitializer(new SqliteCreateDatabaseIfNotExists<BaseDBContext>(modelBuilder));
        }

        //在此处添加实体
        public DbSet<RegistLog> RegistLogs { get; set; }

        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
