using Ambulatorio.Repository;
namespace Ambulatorio.Services
{
    public class StartUp
    {

        public static void Starter()
        {
            SeedingService seedingService = new SeedingService();
            seedingService.Seeding();
        }



    }
}