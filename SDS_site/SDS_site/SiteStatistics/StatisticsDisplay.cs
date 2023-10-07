namespace SDS_site.SiteStatistics
{
    //Класс для работы с базой данной UserData и получение информации (IP)
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public class StatisticsDisplay
    {
        public StatisticsDisplay(string IPAddress, string PageName)
        {
            bool isNewUser = SearchIPUser(IPAddress);

            UserSelection(isNewUser, IPAddress, PageName);
        }

        private bool SearchIPUser(string IPAddress)
        {
            using (var dbContext = new AppDbContextStatistics())
            {
                return !dbContext.userData.Any(user => user.IPAddress == IPAddress);
            }
        }

        private void UserSelection(bool isNewUser, string IPAddress, string PageName)
        {
            if (isNewUser) AddNewUserToDb(IPAddress, PageName);
            else WriteMessageOldUser(IPAddress, PageName);
        }

        private void AddNewUserToDb(string IPAddress, string PageName)
        {
            using (var dbContext = new AppDbContextStatistics())
            {
                int lastId = dbContext.userData.OrderByDescending(u => u.Id).Select(u => u.Id).FirstOrDefault();

                var user = new UserData
                {
                    IPAddress = IPAddress
                };

                dbContext.userData.Add(user);
                dbContext.SaveChanges();
            }

            WriteMessageNewUser(IPAddress, PageName);
        }

        private void WriteMessageNewUser(string IPAddress, string PageName) => Console.WriteLine($"Новый пользователь с IP: {IPAddress}, зашел на страницу {PageName}. Новый пользователь добавлен в базу данных.");
        private void WriteMessageOldUser(string IPAddress, string PageName) => Console.WriteLine($"Пользователь с IP: {IPAddress}, зашел на страницу {PageName}.");
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
}
