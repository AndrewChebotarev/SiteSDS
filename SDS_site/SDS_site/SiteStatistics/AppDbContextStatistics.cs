//-------------------------------------------------------------------------------------------------------------------------------------------------

namespace SDS_site.SiteStatistics
{
    //Работа с базой данный о пользователях
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public class AppDbContextStatistics : DbContext
    {
        public DbSet<UserData> userData { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=217.28.223.127,17160;User Id=user_c2e33;Password=J%d52C&c!9nR4;Database=db_401df;TrustServerCertificate=true;");
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
}
