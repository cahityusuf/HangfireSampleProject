
namespace HangfireSampleProject.Services
{
    public class EmailService : IEmailService
    {
        public async Task Send()
        {
            Console.WriteLine("Zamanlış Görev Çalıştı");
        }
    }
}
