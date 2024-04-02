using CalculatorWebAPI.DTO;
using System.Text.Json;

namespace JsonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExerciseDto exercise = new ExerciseDto()
            {
                FirstVal = 1,
                SecondVal = 2,
                Op = '+'
            };

            string json = JsonSerializer.Serialize(exercise);
            Console.WriteLine(json);

            ExerciseDto deserialesed = JsonSerializer.Deserialize<ExerciseDto>(json);

            Console.WriteLine($"first={deserialesed.FirstVal}\nsecond={deserialesed.SecondVal}\nop={deserialesed.Op}");
        }
    }
}