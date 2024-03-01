Printer<int> printer = new Printer<int>(10);

Console.WriteLine(printer.Add(3));
Console.WriteLine(printer.Add(4));
Console.WriteLine($"Total jobs:{printer.TotalJobs}");

Console.WriteLine("");
Console.WriteLine(printer.Cancel(4));
Console.WriteLine($"Total jobs:{printer.TotalJobs}");

Printer<string> printer1 = new Printer<string>(10);
for(int i = 0; i < 5; i++)
{
    string element = i.ToString();
    Console.WriteLine($"Adding {element} to the printer");
    printer1.Add(element);
}

Console.WriteLine();
for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"printing the document {printer1.Print()}");
}



// Printer<bool> printer2 = new Printer<bool>(3);
// printer2.Add(true);
// printer2.Add(false);
// printer2.Add(true);





