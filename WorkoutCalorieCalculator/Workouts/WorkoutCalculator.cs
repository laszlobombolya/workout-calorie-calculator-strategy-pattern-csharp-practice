namespace WorkoutCalorieCalculator.Workouts
{
    public class WorkoutCalculator
    {
        public double CalculateCalorie(WorkoutType type)
        {
            double calories = 0D;
            switch (type)
            {
                case WorkoutType.MorningYoga:
                    calories += 90 * 0.2 + 100 * 0.7 + 120 * 0.1;
                    break;
                case WorkoutType.HIIT:
                    calories += 120 * 0.2 + 170 * 0.7 + 160 * 0.1;
                    break;
                case WorkoutType.Running:
                    calories += 120 * 0.3 + 170 * 0.6 + 160 * 0.1;
                    break;
                case WorkoutType.Strengthening:
                    calories += 100 * 0.3 + 130 * 0.5 + 130 * 0.2;
                    break;
            }
            return calories;
        }
    }
}