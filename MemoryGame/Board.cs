public class Board
{
    private Card[,] cells;
    private int rows;
    private int cols;
    private int totalMatches;

    public Board(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        this.cells = new Card[rows, cols];
        this.RandomPlaceCards();
        this.totalMatches = 0;
    }

    public bool IsGameOver
    {
        get{return this.totalMatches == this.rows * this.cols;}
    }

    public void RandomPlaceCards()
    {
        Random rand = new Random();
        string[] cardsToCreate = {
            "Fi,R",
            "Ra,C",
            "Ca,G",
            "Sh,B",
            "Do,B",
            "Ke,Y",
            "S,R",
            "Co,B"
        };

        foreach(string generateCard in cardsToCreate)
        {
            string[] token = generateCard.Split(",");
            

            int placed = 0;
            while(placed < 2)
            {
                int row = rand.Next(rows);
                int col = rand.Next(cols);
                

                if(this.cells[row,col] == null){
                    Card card = new Card(token[0], token[1]);
                    this.cells[row, col] = card;
                    placed++;
                }
            }
        }
    }

    public Card Flip(int row, int col)
    {
        Card card = this.cells[row,col];
        card.Reveal(true);
        return card;
    }

    public bool IsMatch(Card card1, Card card2)
    {
        if(card1.Equals(card2))
        {
            return true;
            this.totalMatches+=2;
        }
            
        card1.Reveal(false);
        card2.Reveal(false);


        return false;
    }

    public void ShowBoard()
    {
        for(int row = 0; row < rows; row++)
        {
            for(int col = 0; col < cols; col++)
            {
                Console.Write($"{this.cells[row, col]}| ");
            }
            //space for the next row
            Console.WriteLine();
        }
    }



}