namespace Solutions.Services
{
    public class ElfCalorieCalculator : IElfCalorieCalculator
    {
        public int CaloriesCarriedByTopThreeElfs(string[] calorieList)
        {
            var currentElfsCalories = 0;
            var topThreeElfs = new int[3];
            for (int i = 0; i < calorieList.Length; i++)
            {
                var parseResult = int.TryParse(calorieList[i], out var calories);
                if (parseResult)
                {
                    currentElfsCalories += calories;
                }

                if (!parseResult || i == calorieList.Length - 1)
                {
                    if (currentElfsCalories > topThreeElfs[0])
                    {
                        topThreeElfs[2] = topThreeElfs[1];
                        topThreeElfs[1] = topThreeElfs[0];
                        topThreeElfs[0] = currentElfsCalories;
                    }
                    else if (currentElfsCalories > topThreeElfs[1])
                    {
                        topThreeElfs[2] = topThreeElfs[1];
                        topThreeElfs[1] = currentElfsCalories;
                    }
                    else if (currentElfsCalories > topThreeElfs[2])
                    {
                        topThreeElfs[2] = currentElfsCalories;
                    }
                    currentElfsCalories = 0;
                }
            }
            return topThreeElfs[0] + topThreeElfs[1] + topThreeElfs[2];
        }

        public int MaximumCaloriesCarried(string[] calorieList)
        {
            var maxCalories = 0;
            var currentElfsCalories = 0;
            for (int i = 0; i < calorieList.Length; i++)
            {
                var parseResult = int.TryParse(calorieList[i], out var calories);
                if (parseResult)
                {
                    currentElfsCalories += calories;
                }

                if (!parseResult || i == calorieList.Length - 1)
                {
                    if (currentElfsCalories > maxCalories)
                    {
                        maxCalories = currentElfsCalories;
                    }
                    currentElfsCalories = 0;
                }
            }

            return maxCalories;
        }
    }
}