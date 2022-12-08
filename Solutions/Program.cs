using Solutions;

var solution = new Day1();

var fileContent = File.ReadAllLines("./Solutions/inputs/day1.txt");

Console.WriteLine(solution.Part1(fileContent));
Console.WriteLine(solution.Part2(fileContent));