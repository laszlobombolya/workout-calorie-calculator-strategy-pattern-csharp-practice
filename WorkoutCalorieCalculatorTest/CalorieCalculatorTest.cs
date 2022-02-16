using NUnit.Framework;
using WorkoutCalorieCalculator.Workouts;

namespace WorkoutCalorieCalculatorTest
{
    public class Tests
    {
        [Test]
        public void CalculateMorningYoga_validResponse()
        {
            double expected = 100;
            WorkoutType type = WorkoutType.MorningYoga;
            WorkoutCalculator calculator = new WorkoutCalculator();

            double result = calculator.CalculateCalorie(type);

            Assert.AreEqual(expected, result);

        }

        [Test]
        public void CalculateHIIT_validResponse()
        {
            double expected = 159;
            WorkoutType type = WorkoutType.HIIT;
            WorkoutCalculator calculator = new WorkoutCalculator();

            double result = calculator.CalculateCalorie(type);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateRunning_validResponse()
        {
            double expected = 154;
            WorkoutType type = WorkoutType.Running;
            WorkoutCalculator calculator = new WorkoutCalculator();

            double result = calculator.CalculateCalorie(type);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateStrengthening_validResponse()
        {
            double expected = 121;
            WorkoutType type = WorkoutType.Strengthening;
            WorkoutCalculator calculator = new WorkoutCalculator();

            double result = calculator.CalculateCalorie(type);

            Assert.AreEqual(expected, result);
        }
    }
}