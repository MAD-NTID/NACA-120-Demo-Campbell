// string[] menus = {
//                     "Drive home",
//                     "Visit Friend",
//                     "Sleep in the car"

//                  };


// int[,] scores = {
//                     {1,2,3,4,5},
//                     {5,2,9,10,11}

//                 };


string[] menus = {
    "Set up 2D array size",
    "Add Grades",
    "Show All grades"
};

int[,] grades = null;
int rows = 0;
int cols = 0;
int row = 0;

while(true)
{
    for(int i = 0; i < menus.Length; i++){
        Console.WriteLine($"{i+1}. {menus[i]}");
    }
    Console.Write("Selection:");
    string selection = Console.ReadLine();
    switch(selection)
    {
        case "1":
            Console.Write("Rows:");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Cols:");
            cols = int.Parse(Console.ReadLine());

            grades = new int[rows,cols];
            Console.WriteLine("New grade matrix setup");
        break;

        case "2":
            Console.Write($"Enter {cols} grades. separate using comma:");
            string[] gradesStr = Console.ReadLine().Split(",");
            for(int col = 0; col < cols; col++)
                grades[row,col] = int.Parse(gradesStr[col]);
            row++;
        break;

        case "3":
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"{grades[i,j]} ");
                }
                Console.WriteLine();
            }
        break;

            

    }
}
