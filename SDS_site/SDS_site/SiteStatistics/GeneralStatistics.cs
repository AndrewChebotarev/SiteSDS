//-------------------------------------------------------------------------------------------------------------------------------------------------

namespace SDS_site.SiteStatistics
{
    //Класс для получение статистики: всего уникальных пользователей, которые заходили на сайт
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public class GeneralStatistics : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingTokken)
        {
            while (!stoppingTokken.IsCancellationRequested)
            {
                var usersCount = GetUsersCount();
                Console.WriteLine($"Всего пользователей было на сайте: {usersCount}");
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingTokken);
            }
        }

        private int GetUsersCount()
        {
            using (var dbContext = new AppDbContextStatistics())
            {
                return dbContext.userData.Count();
            }
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
}
