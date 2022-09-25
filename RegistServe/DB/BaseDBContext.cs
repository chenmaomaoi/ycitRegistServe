using System.Data.Entity;
using SQLite.CodeFirst;
using RegistServe.DB.Domain;

namespace RegistServe.DB
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext() : base("UserData") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //如果不存在数据库，则创建
            Database.SetInitializer(new SqliteCreateDatabaseIfNotExists<BaseDBContext>(modelBuilder));
        }

        //在此处添加实体
        public virtual DbSet<RegistLog> RegistLogs { get; set; }

        public virtual DbSet<UserInfo> UserInfos { get; set; }
    }
}
