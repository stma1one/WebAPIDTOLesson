using System.Text.Json;

namespace CalculatorWebAPI.Models
{
    public class Exercise
    {
        public int FirstVal { get; set; }
        public int SecondVal { get; set; }
        public char Op { get; set; }

        public ExerciseResult Solve()
        {
            ExerciseResult res = new ExerciseResult();
            res.Exercise = this;

            switch (this.Op)
            {
                case '+':
                    res.Success = true;
                    res.Result = this.FirstVal + this.SecondVal;
                    break;
                case '-':
                    res.Success = true;
                    res.Result = this.FirstVal - this.SecondVal;
                    break;
                case '*':
                    res.Success = true;
                    res.Result = this.FirstVal * this.SecondVal;
                    break;
                case '/':
                    res.Success = this.SecondVal != 0;
                    if (res.Success)
                        res.Result = this.FirstVal / this.SecondVal;
                    break;
                default:
                    res.Success = false;
                    break;
            }


            return res;


        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }

    public class ExerciseResult
    {
        public Exercise Exercise { get; set; }
        public bool Success { get; set; }
        public int Result { get; set; }
    }
}
