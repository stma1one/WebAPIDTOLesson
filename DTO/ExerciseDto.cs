using System.Text.Json;

namespace CalculatorWebAPI.DTO
{
    public class ExerciseDto
    {
        public int FirstVal { get; set; }
        public int SecondVal { get; set; }
        public char Op { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class ExerciseResultDto
    {
        public ExerciseDto Exercise { get; set; }
        public bool Success { get; set; }
        public int Result { get; set; }
    }
}
