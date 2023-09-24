using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeExcercise
{
	internal class BoardTicTacToe
	{
		private char[,] _board = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

		public BoardTicTacToe()
		{
			
		}

		public void Setfield()
		{
			Console.WriteLine("   |   |   ");
			Console.WriteLine(" {0} | {1} | {2} ", _board[0, 0], _board[0, 1], _board[0, 2]);
			Console.WriteLine("___|___|___");
			Console.WriteLine("   |   |   ");
			Console.WriteLine(" {0} | {1} | {2} ", _board[1, 0], _board[1, 1], _board[1, 2]);
			Console.WriteLine("___|___|___");
			Console.WriteLine("   |   |   ");
			Console.WriteLine(" {0} | {1} | {2} ", _board[2, 0], _board[2, 1], _board[2, 2]);
			Console.WriteLine("   |   |   ");


		}

			public void WriteSymbol(int selectedCell2, char playerSymbol)
		{
			switch (selectedCell2) 
			{
				case 1:
					{ 
						_board[0,0] = playerSymbol; 
						break; 
					}
				case 2:
					{
						_board[0, 1] = playerSymbol;
						break;
					}
				case 3:
					{
						_board[0, 2] = playerSymbol;
						break;
					}
				case 4:
					{
						_board[1, 0] = playerSymbol;
						break;
					}
				case 5:
					{
						_board[1, 1] = playerSymbol;
						break;
					}
				case 6:
					{
						_board[1, 2] = playerSymbol;
						break;
					}
				case 7:
					{
						_board[2, 0] = playerSymbol;
						break;
					}
				case 8:
					{
						_board[2, 1] = playerSymbol;
						break;
					}
				case 9:
					{
						_board[2, 2] = playerSymbol;
						break;
					}
			}
				Setfield();
			}

		public bool BoardChecker()
		{
			// here we perform horizontal and vertical checks
			for (int i = 0; i < 3; i++)
			{
				if (_board[i, 0] == _board[i, 1] && _board[i, 1] == _board[i, 2])
					return true;
				if (_board[0, i] == _board[1, i] && _board[1, i] == _board[2, i])
					return true;
			}
			// here diagonal checks 
			if (_board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2])
				return true;
			if (_board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0])
				return true;

			return false;
		}

	}


	
}
