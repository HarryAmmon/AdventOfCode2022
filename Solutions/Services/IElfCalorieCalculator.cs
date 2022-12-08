namespace Solutions.Services
{
    public interface IElfCalorieCalculator
    {
        int MaximumCaloriesCarried(string[] calorieList);

        int CaloriesCarriedByTopThreeElfs(string[] calorieList);
    }
}