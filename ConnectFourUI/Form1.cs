/// <summary>
/// Author: Cody Syring
/// Filename: Form1.cs
/// Part of Project: ConnectFourUI
///
/// File Purpose:
/// This Form is the UI handles of the program. Its main purpose is
/// to interact with the user.
/// 
/// It will create a new game board
/// Turn control 
/// Taking of turns.
/// Resetting the board for new games
/// </summary>
namespace ConnectFourUI
{
    /// <summary>
    /// This enum is used for user control during:
    /// Turns
    /// Placing new tokens
    /// Checking for win con
    /// ect..
    /// </summary>
    public enum CellState
    {
        Empty,
        Player1,
        Player2
    }
    public partial class Form1 : Form
    {
        // VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES
        // VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES
        // VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES -- VARIABLES
        private Button? draggedButton;   //Current user being dragged
        CellState currentTurn;          //User who is taking their turn
        GameBoard gameBoard;            //The instance of the game board.
        public Form1()
        {
            InitializeComponent();

            Button[,] controlButtonArray =
            {
                { btn00, btn10, btn20, btn30, btn40, btn50, btn60 },
                { btn01, btn11, btn21, btn31, btn41, btn51, btn61 },
                { btn02, btn12, btn22, btn32, btn42, btn52, btn62 },
                { btn03, btn13, btn23, btn33, btn43, btn53, btn63 },
                { btn04, btn14, btn24, btn34, btn44, btn54, btn64 },
                { btn05, btn15, btn25, btn35, btn45, btn55, btn65 }
            };

            gameBoard = new GameBoard(controlButtonArray);

            currentTurn = CellState.Player1;
            setToP1Turn();

            gameBoard.pushToUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// This method will set the board and the flags so Player 1 can 
        /// take their turn
        /// </summary>
        private void setToP1Turn()
        {
            btnP1.Enabled = true;
            btnP2.Enabled = false;
            currentTurn = CellState.Player1;
            lblDisplay.Text = $"Current Turn: {currentTurn.ToString()}";
        }
        /// <summary>
        /// This method will set the board and the flags so Player 2 can 
        /// take their turn
        /// </summary>
        private void setToP2Turn()
        {
            btnP2.Enabled = true;
            btnP1.Enabled = false;
            currentTurn = CellState.Player2;
            lblDisplay.Text = $"Current Turn: {currentTurn.ToString()}";
        }
        /// <summary>
        /// This method will lock the board after a winner has been chosen.
        /// </summary>
        private void lockBoardForWinner()
        {
            btnP1.Enabled = false;
            btnP2.Enabled = false;
            currentTurn = CellState.Empty;
        }
        /// <summary>
        /// This method will take the turn for the player.
        /// It will check if their is a winner after every turn.
        /// It will Display the winner if their is one.
        /// </summary>
        /// <param name="col"></param>  //What col we are looking at
        private void takeTurn(int col)
        {
            if (gameBoard.DropStateToBottom(col, currentTurn))
            {
                gameBoard.pushToUI();
                CellState chckWinner = gameBoard.checkWin(currentTurn);

                if (chckWinner == CellState.Empty)
                {
                    if (currentTurn == CellState.Player1)
                    {
                        setToP2Turn();
                    }
                    else if (currentTurn == CellState.Player2)
                    {
                        setToP1Turn();
                    }
                    else
                    {
                        //Something went really really wrong..
                    }
                }
                else
                {
                    lockBoardForWinner();
                    lblDisplay.Text = $"Congratulations {chckWinner} you win!";
                }
            }
            else
            {
                MessageBox.Show($"Invalid move, {currentTurn.ToString()} turn continuous.");
            }
        }
        /// <summary>
        /// This method will reset to a clean board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            gameBoard.resetBoard();
            gameBoard.pushToUI();
            setToP1Turn();
        }

        // DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS
        // DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS
        // DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS -- DRAGCONTROLS

        /// <summary>
        /// This is the control for draging the btns, it will store
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDrag_MouseDown(object? sender, MouseEventArgs e)
        {
            // Start drag operation on MouseDown
            if (e.Button == MouseButtons.Left && draggedButton == null)
            {
                draggedButton = (Button)sender;
                draggedButton.DoDragDrop(sender, DragDropEffects.Move);
            }
        }
        /// <summary>
        /// This method will change the cursor if hovered over btnControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl6_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// This method will fire when a button is placed onto btnControl6
        /// It will fire takeTurn sending col 6.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl6_DragDrop(object sender, DragEventArgs e)
        {
            takeTurn(6);
            draggedButton = null;
        }
        /// <summary>
        /// This method will change the cursor if hovered over btnControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl5_DragEnter(object? sender, DragEventArgs e)
        {
            // Check if the data being dragged is of type Button
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// This method will fire when a button is placed onto btnControl6
        /// It will fire takeTurn sending col 5.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl5_DragDrop(object sender, DragEventArgs e)
        {
            takeTurn(5);
            draggedButton = null;
        }
        /// <summary>
        /// This method will change the cursor if hovered over btnControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl4_DragEnter(object? sender, DragEventArgs e)
        {
            // Check if the data being dragged is of type Button
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// This method will fire when a button is placed onto btnControl6
        /// It will fire takeTurn sending col 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl4_DragDrop(object sender, DragEventArgs e)
        {
            takeTurn(4);
            draggedButton = null;
        }
        /// <summary>
        /// This method will change the cursor if hovered over btnControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl3_DragEnter(object? sender, DragEventArgs e)
        {
            // Check if the data being dragged is of type Button
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// This method will fire when a button is placed onto btnControl6
        /// It will fire takeTurn sending col 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl3_DragDrop(object sender, DragEventArgs e)
        {
            takeTurn(3);
            draggedButton = null;
        }
        /// <summary>
        /// This method will change the cursor if hovered over btnControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl2_DragEnter(object? sender, DragEventArgs e)
        {
            // Check if the data being dragged is of type Button
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// This method will fire when a button is placed onto btnControl6
        /// It will fire takeTurn sending col 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl2_DragDrop(object sender, DragEventArgs e)
        {
            takeTurn(2);
            draggedButton = null;
        }
        /// <summary>
        /// This method will change the cursor if hovered over btnControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl1_DragEnter(object? sender, DragEventArgs e)
        {
            // Check if the data being dragged is of type Button
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// This method will fire when a button is placed onto btnControl6
        /// It will fire takeTurn sending col 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl1_DragDrop(object sender, DragEventArgs e)
        {
            takeTurn(1);
            draggedButton = null;
        }
        /// <summary>
        /// This method will change the cursor if hovered over btnControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl0_DragEnter(object? sender, DragEventArgs e)
        {
            // Check if the data being dragged is of type Button
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// This method will fire when a button is placed onto btnControl6
        /// It will fire takeTurn sending col 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControl0_DragDrop(object sender, DragEventArgs e)
        {
            takeTurn(0);
            draggedButton = null;
        }
        /// <summary>
        /// This method will reset the drag event if it gets stuck.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            draggedButton = null;
        }
    }
}
