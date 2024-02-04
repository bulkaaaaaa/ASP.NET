namespace MyWebApplication
{
    public class Program
    {
        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 101);
        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            
            Company company = new Company();

            company.Id = 1;
            company.Name = "NexGenCode";
            company.Description = "Your partner in software development";
            company.Location = "Mykolaiv, Ukraine";
            company.YearFounded = 2022;

            app.MapGet("/", () =>
            {
                int randomNumber = GenerateRandomNumber();

                return $"A random number: {randomNumber}";

                /*
                return $"Id: {company.Id}\n" + 
                    $"The company name: {company.Name}\n" + 
                    $"Description: {company.Description}\n" + 
                    $"Location: {company.Location}\n" + 
                    $"Year of foundation: {company.YearFounded}";
                */
            });

            app.Run();
        }
    }
}