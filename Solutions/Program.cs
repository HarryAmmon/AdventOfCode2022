using Solutions;

var solution = new Day5();

var fileContent = File.ReadAllLines("./inputs/day5.txt");

Console.WriteLine(solution.Part1(fileContent));
Console.WriteLine(solution.Part2(fileContent));