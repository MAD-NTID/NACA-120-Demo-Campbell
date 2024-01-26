string[] names = new string[10];

names[0] = "Panda";
names[1] = "Freddy Kruger";
names[2] = "Spy";

Console.WriteLine(names[0]);

for(int i = 0; i < names.Length; i++){
    Console.WriteLine(names[i]);
}

foreach(string name in names)
{
    Console.WriteLine(name);
}
//for name in names: -- python
