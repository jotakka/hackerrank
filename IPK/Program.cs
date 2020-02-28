using HackerRank.IPK.WarmUp.Exercises;
using Microsoft.Extensions.DependencyInjection;


namespace HackerRank.IPK
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IExercise, RepeatedString>()
                .BuildServiceProvider();
            var exercise = serviceProvider.GetRequiredService<IExercise>();

            exercise.Run();

        }
    }
}