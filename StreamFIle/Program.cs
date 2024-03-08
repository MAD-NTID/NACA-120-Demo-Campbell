//Normal txt file
//setup the filename
// string filename = "myfile.txt";

// //setup the stream for writing to file
// StreamWriter writer = new StreamWriter(filename, true);

// writer.WriteLine("Meeeeehhhhhhhhh");
// writer.WriteLine(10);
// writer.Write(20+3);
//terminate the stream
//writer.Close();

//CSV FILE

// string filename = "sales.csv";
// StreamWriter writer = new StreamWriter(filename);
// Console.WriteLine($"The file {filename} was successfully created");

// //setup the header
// writer.WriteLine("item number,description,unit price,quantity");
// //the data must be in the same order as the csv
// writer.WriteLine("123-B,Gray Coat,$25.98,200");
// writer.WriteLine("123-A,Black Coat,$50.98,500");
// writer.WriteLine("151-B,White Coat,$2.98,2000");

// //close the stream when done
// writer.Close();
// Console.WriteLine($"The data was stored to the {filename}");


//Read in a file
// string filename = "myfile.txt";



// if(File.Exists(filename)){

//     //setup stream
//     StreamReader reader = new StreamReader(filename);
//     //read the line by line as long as we have not get to the end of the stream
//     while(!reader.EndOfStream)
//     {
//         //get the data from the ReadLine()
//         string line = reader.ReadLine();
//         //show on console
//         Console.WriteLine(line);
//     }

//     //close the stream
//     reader.Close();

//     //let the user know the file has been read in
//     Console.WriteLine("File reading done");
// } else {
//     Console.WriteLine($"{filename} not found!! or yet, my friend, it doesnt exist!!!!");
// }


//reading from csv
// string filename = "sales.csv";



// if(File.Exists(filename)){

//     //setup stream
//     StreamReader reader = new StreamReader(filename);
//     bool skipHeader = true;
//     //read the line by line as long as we have not get to the end of the stream
//     while(!reader.EndOfStream)
//     {
//         //get the data from the ReadLine()
//         string line = reader.ReadLine();
        
//         //we do not want to include the header
//         if(skipHeader)
//         {
//             skipHeader = false;
//             continue;
//         }
        
//         //grab each values by spliting
//         string[] token  = line.Split(",");

//         string itemNumber = token[0];
//         string description = token[1];
//         double price = double.Parse(token[2].Substring(1));
//         int quantity = int.Parse(token[3]);
//         //show on console
//         Console.WriteLine($"{itemNumber} {description} {price} {quantity}");
//     }

//     //close the stream
//     reader.Close();

//     //let the user know the file has been read in
//     Console.WriteLine("File reading done");
// } else {
//     Console.WriteLine($"{filename} not found!! or yet, my friend, it doesnt exist!!!!");
// }


//loading data from CSV into array
string filename = "sales.csv";
Sale[] sales = new Sale[10];
int index = 0;


if(File.Exists(filename)){

    //setup stream
    StreamReader reader = new StreamReader(filename);
    bool skipHeader = true;
    //read the line by line as long as we have not get to the end of the stream
    while(!reader.EndOfStream)
    {
        //get the data from the ReadLine()
        string line = reader.ReadLine();
        
        //we do not want to include the header
        if(skipHeader)
        {
            skipHeader = false;
            continue;
        }
        
        //grab each values by spliting
        string[] token  = line.Split(",");

        string itemNumber = token[0];
        string description = token[1];
        double price = double.Parse(token[2].Substring(1));
        int quantity = int.Parse(token[3]);

        sales[index] = new Sale(itemNumber,description,quantity, price);
        index++;
    }

    //close the stream
    reader.Close();

    //let the user know the file has been read in
    Console.WriteLine("File reading done");
} else {
    Console.WriteLine($"{filename} not found!! or yet, my friend, it doesnt exist!!!!");
}

//showing records
foreach(Sale sale in sales)
{
    if(sale is not null)
        Console.WriteLine(sale);
}


