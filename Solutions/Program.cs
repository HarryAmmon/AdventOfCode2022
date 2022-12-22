using Solutions;

var solution = new Day7();

var fileContent = File.ReadAllLines("./inputs/day7.txt");

Console.WriteLine(solution.Part1(fileContent));
Console.WriteLine(solution.Part2(fileContent));