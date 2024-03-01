Printer printer = new Printer(10);

Console.WriteLine(printer.Add(3));
Console.WriteLine(printer.Add(4));
Console.WriteLine($"Total jobs:{printer.TotalJobs}");

Console.WriteLine("");
Console.WriteLine(printer.Cancel(4));
Console.WriteLine($"Total jobs:{printer.TotalJobs}");



