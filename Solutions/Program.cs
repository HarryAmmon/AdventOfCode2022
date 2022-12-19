using Solutions;

var solution = new Day4();

var fileContent = File.ReadAllLines("./inputs/day4.txt");

Console.WriteLine(solution.Part1(fileContent));
Console.WriteLine(solution.Part2(fileContent));