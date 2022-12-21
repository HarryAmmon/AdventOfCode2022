using Solutions;

var solution = new Day6();

var fileContent = File.ReadAllLines("./inputs/day6.txt");

Console.WriteLine(solution.Part1(fileContent));
Console.WriteLine(solution.Part2(fileContent));