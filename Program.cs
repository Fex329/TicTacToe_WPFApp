using System.Threading.Channels;

namespace TicTacToeExcercise
{
	internal class Program
	{

		Console.WriteLine("Do you want to play TicTacToe?");


		static BoardTicTacToe playBoard = new BoardTicTacToe();
		static char player1Symbol = 'X';
		static char player2Symbol = 'O';
		static int turnsLeft = 9;
		static bool hasWon = false;
		static int[] numbersUsed = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		static void Main(string[] args)
		{
			playBoard.Setfield();
			do
			{
				GetAndProcessInput("Player 1", player1Symbol);
				if (playBoard.BoardChecker())
				{
					Console.WriteLine("Player 1 has won!");
					Console.Read();
					break;
				}
				turnsLeft--;
				if (turnsLeft == 0)
				{
					Console.WriteLine("This looks like a draw!");
					Console.Read();
					break;
				}

				GetAndProcessInput("Player 2", player2Symbol);
				if (playBoard.BoardChecker())
				{
					Console.WriteLine("Player 2 has won!");
					Console.Read();
					break;
				}
				turnsLeft--;



			} while (turnsLeft > 0 && hasWon == false);



		}

		public static void GetAndProcessInput(string playerName, char playerSymbol)
		{
			//this method gets the input of a player and add the symbol on the corresponding cell

			bool validEntry = false;
			do
			{
				Console.WriteLine("Please {0}, select a free cell and enter the corresponding number", playerName);

				string playerInput = Console.ReadLine();
				int selectedCell;
				

				if (int.TryParse(playerInput, out selectedCell))
				{
					if (selectedCell > 0 && selectedCell < 10)
					{
						if (!numbersUsed.Contains(selectedCell))

						{
							Console.WriteLine("Cell already occupied");
						}
						else
						{
							playBoard.WriteSymbol(selectedCell, playerSymbol);
							numbersUsed[selectedCell - 1] = 0;
							validEntry = true;
						}

					}

					else
					{
						Console.WriteLine("Number out of range, select a number between 1 and 9");
					}
				}
				else if (playerInput == "")
				{
					Console.WriteLine("Empty input, try again!");
				}

				else
				{
					Console.WriteLine("Only numbers between 1 and 9 Please!");
				}


			} while (!validEntry);

		}





		/*public static bool BoardChecker(string[,] board)
		{
			// here we perform horizontal and vertical checks
			for (int i = 0; i < 3; i++)
			{
				if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
					return true;
				if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
					return true;
			}
			// here diagonal checks 
			if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
				return true;
			if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
				return true;
			return false;
		}*/
	}
}
