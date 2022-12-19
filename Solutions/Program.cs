using Solutions;

var solution = new Day3();

var fileContent = File.ReadAllLines("./inputs/day3.txt");

Console.WriteLine(solution.Part1(fileContent));
Console.WriteLine(solution.Part2(fileContent));