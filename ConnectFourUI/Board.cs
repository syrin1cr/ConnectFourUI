/// <summary>
/// Author: Cody Syring
/// Filename: Board.cs
/// Part of Project: ConnectFourUI
///
/// File Purpose:
/// Create the game board itself.
/// Its goals is to create a 2D array to keep track of what spaces
/// the Players have tokens on. 
/// 
/// Drop new tokens into the game field.
/// 
/// Convert our array to a form we can push to the UI.
/// </summary>
namespace ConnectFourUI
{
    public class GameBoard
    {
        // VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES
        // VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES
        // VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES
        private CellState[,] cells; //Control for our game board
        private Button[,] UIcells;  //Array of buttons on our UI

        // METHODS/FUNCTIONS -- METHODS/FUNCTIONS -- METHODS/FUNCTIONS
        // METHODS/FUNCTIONS -- METHODS/FUNCTIONS -- METHODS/FUNCTIONS
        // METHODS/FUNCTIONS -- METHODS/FUNCTIONS -- METHODS/FUNCTIONS
        /// <summary>
        /// Builds our game board and sets the default values.
        /// </summary>
        /// <param name="UIcells"></param>  //Array of buttons from our UI
        public GameBoard(Button[,] UIcells)
        {
            this.cells = new CellState[6, 7];
            InitializeGrid();
            this.UIcells = UIcells;
        }
        /// <summary>
        /// This method will set up an new board with no chips. 
        /// </summary>
        private void InitializeGrid()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    cells[row, col] = CellState.Empty;
                }
            }
        }
        /// <summary>
        /// This method will get a col to look at and return true if
        /// the top bucket is full and false if its empty.
        /// </summary>
        /// <param name="col"></param>  //Col to look at.
        /// <returns>True if full False if not.</returns>
        public Boolean checkIfFull(int col)
        {
            if (cells[0, col] != CellState.Empty)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// This method will get a Col and a CellState and drop the 
        /// a tokon down the col sent in.
        /// 
        /// Will return false if the col is already full.
        /// true if action is complete.
        /// </summary>
        /// <param name="col"></param>      //Col to drop into
        /// <param name="state"></param>    //Player to fill spot with.
        /// <returns></returns>
        public Boolean DropStateToBottom(int col, CellState state)
        {
            if (checkIfFull(col))
            {
                return false;
            }

            for (int row = 5; row >= 0; row--)
            {
                if (cells[row, col] == CellState.Empty)
                {
                    cells[row, col] = state;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// This method will check all win types to see if the player sent in has won.
        /// Types:
        /// Row
        /// Columb
        /// Diagnal 
        /// </summary>
        /// <param name="state"></param>    //What player we are looking for
        /// <returns>Returns player name if win set was found, Empty if none.</returns> 
        public CellState checkWin(CellState state)
        {
            Boolean winner = false;

            winner = checkRow(state);
            if (winner == true)
            {
                return state;
            }

            winner = checkColumb(state);
            if (winner == true)
            {
                return state;
            }

            winner = checkDiagnal(state);
            if (winner == true)
            {
                return state;
            }

            return CellState.Empty;
        }
        /// <summary>
        /// This method will look for wins in the rows of the board.
        /// </summary>
        /// <param name="state"></param>    // what player we are looking for.
        /// <returns> True if win con found, false if not.</returns>
        public Boolean checkRow(CellState state)
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col <= 3; col++)
                {
                    if (cells[row, col] == state &&
                        cells[row, col + 1] == state &&
                        cells[row, col + 2] == state &&
                        cells[row, col + 3] == state)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// This method will look for wins in the Columb of the board.
        /// </summary>
        /// <param name="state"></param>    // what player we are looking for.
        /// <returns> True if win con found, false if not.</returns>
        public Boolean checkColumb(CellState state)
        {
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row <= 2; row++)
                {
                    if (cells[row, col] == state &&
                        cells[row + 1, col] == state &&
                        cells[row + 2, col] == state &&
                        cells[row + 3, col] == state)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// This method will look for wins in the Diagnal of the board.
        /// </summary>
        /// <param name="state"></param>    // what player we are looking for.
        /// <returns> True if win con found, false if not.</returns>
        public Boolean checkDiagnal(CellState state)
        {
            //Need to look left and right Diagnal
            for (int row = 0; row <= 2; row++)
            {
                for (int col = 0; col <= 3; col++)
                {
                    if (cells[row, col] == state &&
                        cells[row + 1, col + 1] == state &&
                        cells[row + 2, col + 2] == state &&
                        cells[row + 3, col + 3] == state)
                    {
                        return true;
                    }
                }
            }

            for (int row = 3; row < 6; row++)
            {
                for (int col = 0; col <= 3; col++)
                {
                    if (cells[row, col] == state &&
                        cells[row - 1, col + 1] == state &&
                        cells[row - 2, col + 2] == state &&
                        cells[row - 3, col + 3] == state)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// This will take the cells arrfay and push it into the UI.
        /// </summary>
        public void pushToUI()
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (cells[row, col] == CellState.Player1)
                    {
                        UIcells[row, col].BackColor = Color.Red;
                    }
                    else if (cells[row, col] == CellState.Player2)
                    {
                        UIcells[row, col].BackColor = Color.Blue;
                    }
                    else
                    {
                        UIcells[row, col].BackColor = Color.Gray;
                    }
                }
            }
        }
        /// <summary>
        /// This method will bring the board back to an empty state. 
        /// Clean board.
        /// </summary>
        public void resetBoard()
        {
            InitializeGrid();
        }
    }
}
