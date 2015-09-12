namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MineSweeper
    {
        static void Main()
        {
            const int AllMines = 35;

            string command = string.Empty;
            char[,] board = CreateGameBoard();
            char[,] mines = PlaceBombs();
            List<Ranking> topPlayers = new List<Ranking>(6);
            int openedmines = 0;
            int row = 0;
            int col = 0;
            bool gameOver = false;
            bool newGame = true;
            bool winGame = false;

            do
            {
                if (newGame)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintBoard(board);
                    newGame = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Rankings(topPlayers);
                        break;
                    case "restart":
                        board = CreateGameBoard();
                        mines = PlaceBombs();
                        PrintBoard(board);
                        gameOver = false;
                        newGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                MakeTurn(board, mines, row, col);
                                openedmines++;
                            }

                            if (AllMines == openedmines)
                            {
                                winGame = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (gameOver)
                {
                    PrintBoard(mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", openedmines);
                    string name = Console.ReadLine();
                    Ranking t = new Ranking(name, openedmines);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < t.Points)
                            {
                                topPlayers.Insert(i, t);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Ranking r1, Ranking r2) => r2.Name.CompareTo(r1.Name));
                    topPlayers.Sort((Ranking r1, Ranking r2) => r2.Points.CompareTo(r1.Points));
                    Rankings(topPlayers);

                    board = CreateGameBoard();
                    mines = PlaceBombs();
                    openedmines = 0;
                    gameOver = false;
                    newGame = true;
                }

                if (winGame)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintBoard(mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Ranking player = new Ranking(name, openedmines);
                    topPlayers.Add(player);
                    Rankings(topPlayers);
                    board = CreateGameBoard();
                    mines = PlaceBombs();
                    openedmines = 0;
                    winGame = false;
                    newGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Rankings(List<Ranking> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void MakeTurn(char[,] board, char[,] mines, int row, int col)
        {
            char digit = DigitInCell(mines, row, col);
            mines[row, col] = digit;
            board[row, col] = digit;
        }

        private static void PrintBoard(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardCols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardCols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            int boardRows = 5;
            int boardCols = 10;
            char[,] board = new char[boardRows, boardCols];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardCols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> minePoints = new List<int>();
            while (minePoints.Count < 15)
            {
                Random random = new Random();
                int minePoint = random.Next(50);
                if (!minePoints.Contains(minePoint))
                {
                    minePoints.Add(minePoint);
                }
            }

            foreach (int mine in minePoints)
            {
                int col = mine / boardCols;
                int row = mine % boardCols;
                if (row == 0 && mine != 0)
                {
                    col--;
                    row = boardCols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void FillBoard(char[,] board)
        {
            int cols = board.GetLength(0);
            int rows = board.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char digit = DigitInCell(board, i, j);
                        board[i, j] = digit;
                    }
                }
            }
        }

        private static char DigitInCell(char[,] board, int row, int col)
        {
            int minesNear = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    minesNear++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, col] == '*')
                {
                    minesNear++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    minesNear++;
                }
            }

            if (col + 1 < cols)
            {
                if (board[row, col + 1] == '*')
                {
                    minesNear++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    minesNear++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    minesNear++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    minesNear++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    minesNear++;
                }
            }

            return char.Parse(minesNear.ToString());
        }

        public class Ranking
        {
            string name;
            int points;

            public Ranking() {}

            public Ranking(string name, int point)
            {
                this.name = name;
                this.points = point;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }
        }
    }
}
