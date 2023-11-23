﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{ 
        public class TicTacToe
        {
            public static bool Checker(string[,] board)
            {
                // here we perform horizontal and vertical checks
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && !string.IsNullOrEmpty(board[i, 0]) && !string.IsNullOrEmpty(board[i, 1]) && !string.IsNullOrEmpty(board[i, 2]))
                        return true;
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && !string.IsNullOrEmpty(board[0, 1]) && !string.IsNullOrEmpty(board[1, i]) && !string.IsNullOrEmpty(board[2, i]))
                        return true;
                }
                // here diagonal checks 
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && !string.IsNullOrEmpty(board[0, 0]) && !string.IsNullOrEmpty(board[1, 1]) && !string.IsNullOrEmpty(board[2, 2]))
                    return true;
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && !string.IsNullOrEmpty(board[0, 2]) && !string.IsNullOrEmpty(board[1, 1]) && !string.IsNullOrEmpty(board[2, 0]))
                    return true;
                return false;
            }
        }
    
}

