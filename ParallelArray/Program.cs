// To create a parallel array, for example, string for describting a value, and a double for a value related
string[] people = new string[5];
double[] weight = new double[5];

people[0] = "Rahul";
weight[0] = 110;

Console.WriteLine($"{people[0]} weights {weight[0]}lbs");

people[1] = "Shadirah";
weight[1] = 115;

Console.WriteLine($"{people[1]} weights {weight[1]}lbs");

Console.Write("Enter Name: ");
string name = Console.ReadLine();

Console.Write("Enter Weight: ");
double personWeight = double.Parse(Console.ReadLine());

people[2] = name;
weight[2] = personWeight;

Console.WriteLine($"{people[2]} weights {weight[2]}lbs");