using WorkoutCalorieCalculator.Workouts;

namespace WorkoutCalorieCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkoutCalculator workout = new WorkoutCalculator();
            WorkoutType workoutType = WorkoutType.MorningYoga;
            var calories = workout.CalculateCalorie(workoutType);

        }
    }
}
