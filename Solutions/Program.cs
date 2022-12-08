using Solutions;

var solution = new Day2();

var fileContent = File.ReadAllLines("./inputs/day2.txt");

Console.WriteLine(solution.Part1(fileContent));
Console.WriteLine(solution.Part2(fileContent));