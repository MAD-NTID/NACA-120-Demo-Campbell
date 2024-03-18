// Card card1 = new Card("Fish", "Red");
// Card card2 = new Card("Fish", "Red");

// Console.WriteLine(card1);

// Console.WriteLine(card2);

// Console.WriteLine(card1.Equals(card2));

Board board = new Board(4,4);

while(!board.IsGameOver)
{
    Console.WriteLine("Current board");
    board.ShowBoard();

    Console.WriteLine("Enter the card in the format row,col");
    Console.Write("Card1:");
    string[] target1 = Console.ReadLine().Split(",");

    Console.Write("Card2:");
    string[] target2 = Console.ReadLine().Split(",");

    int row1 = int.Parse(target1[0]);
    int col1 = int.Parse(target1[1]);

    int row2 = int.Parse(target2[0]);
    int col2 = int.Parse(target2[1]);

    Card card1 = board.Flip(row1, col1);
    Card card2 = board.Flip(row2, col2);
    board.ShowBoard();

    if(!board.IsMatch(card1, card2)) {
        Console.WriteLine("Incorrect!!!");
    } else {
        Console.WriteLine("Yaaaaay!!!");
    }

}


StreamWriter writer = new StreamWriter("myfile.txt");