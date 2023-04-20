using System;
using System.Windows.Forms;
using System.Threading;

namespace CustomChess
{
    public partial class MainForm : Form, UI
    {
        
        TimeSpan whiteClock = new TimeSpan(0);
        TimeSpan blackClock = new TimeSpan(0);

        public MainForm()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CreateBoard();

            picTurn.SizeMode = PictureBoxSizeMode.StretchImage;
            picTurn.Image = graphics.TurnIndicator[Player.WHITE];

            
            Computer.DEPTH = 3;

            SetStatus(false, "Choose New Game or Manual Board.");

            // setup menu
            setPieceToolStripMenuItem.Enabled = false;
            manualBoardToolStripMenuItem.Checked = false;
            endCurrentGameToolStripMenuItem.Enabled = false;
        }

        private void windowClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void Shutdown(object sender, EventArgs e)
        {
            Stop();
            this.Close();
        }

        private void endGame(object sender, EventArgs e)
        {
            Stop();
        }

        private void NewGame(object sender, EventArgs e)
        {
            ToolStripMenuItem button = (ToolStripMenuItem)sender;
            if (button.Text.StartsWith("New Game"))
            {
                NewGame NewGameDlg = new NewGame();
                NewGameDlg.ShowDialog();
                if (NewGameDlg.bStartGame)
                {
                    if (NewGameDlg.PlayersHvC.Checked)
                        NewGame(1);
                    else if (NewGameDlg.PlayersCvC.Checked)
                        NewGame(0);
                    else
                        NewGame(2);
                }

            }
            
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundEffect sound = new SoundEffect("../../Library/");
            sound.ClickSound();
            Save GameObj = new Save();
            ToolStripMenuItem button = (ToolStripMenuItem)sender;
            if (button.Text.StartsWith("Save"))
            {
                GameObj.SaveGame();

            }
        }


        private void Difficulty(object sender, EventArgs e)
        {
            ToolStripMenuItem button = (ToolStripMenuItem)sender;
            bool was = Computer.RUNNING;
            Computer.STOP = true;

            if (button.Text.StartsWith("New Game"))
            {
                NewGame NewGameDlg = new NewGame();
                NewGameDlg.ShowDialog();
                

               
                if (NewGameDlg.bStartGame)
                {
                    if (NewGameDlg.PlayerLevel1.Checked)
                    {
                        Computer.DEPTH = 1;
                    }
                    else if (NewGameDlg.PlayerLevel2.Checked)
                    {
                        Computer.DEPTH = 3;
                    }
                    else
                    {
                        Computer.DEPTH = 5;
                    }
                }
            }
            
            LogMove("Computer Level " + Computer.DEPTH + "\n");

            if (was)
            {
                LogMove("Computer changed move\n");
                new Thread(chess.ComputerMove).Start();
            }
        }

        private void manualBoardToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Checked) // turning on manual setup
            {

                manual = false;
                doneToolStripMenuItem.Enabled = false;
                initialboard = false;
                Stop();

                manual = ((ToolStripMenuItem)sender).Checked;
                endCurrentGameToolStripMenuItem.Enabled = true;
                White_King.Enabled = true;
                Black_King.Enabled = true;

                SetStatus(false, "Choose game mode to start placing pieces.");
            }
            else if (!initialboard)
            {
                Stop();
            }
        }

        private void SetManualPiece(object sender, EventArgs e)
        {
            String labelName = ((ToolStripMenuItem)sender).Name;

            player = (labelName.StartsWith("White")) ? Player.WHITE : Player.BLACK;

            if (labelName.EndsWith("Pawn"))
            {
                piece = Piece.PAWN;
            }
            else if (labelName.EndsWith("Knight"))
            {
                piece = Piece.KNIGHT;
            }
            else if (labelName.EndsWith("Bishop"))
            {
                piece = Piece.BISHOP;
            }
            else if (labelName.EndsWith("Rook"))
            {
                piece = Piece.ROOK;
            }
            else if (labelName.EndsWith("Queen"))
            {
                piece = Piece.QUEEN;
            }
            else if (labelName.EndsWith("King"))
            {
                piece = Piece.KING;
            }
        }
        private void WhiteClock(object sender, EventArgs e)
        {
            whiteClock = whiteClock.Add(new TimeSpan(0, 0, 0, 0, tmrWhite.Interval));
            lblWhiteTime.Text = string.Format("{0:d2}:{1:d2}:{2:d2}.{3:d1}", whiteClock.Hours, whiteClock.Minutes, whiteClock.Seconds, whiteClock.Milliseconds / 100);
        }

        private void BlackClock(object sender, EventArgs e)
        {
            blackClock = blackClock.Add(new TimeSpan(0, 0, 0, 0, tmrBlack.Interval));
            lblBlackTime.Text = string.Format("{0:d2}:{1:d2}:{2:d2}.{3:d1}", blackClock.Hours, blackClock.Minutes, blackClock.Seconds, blackClock.Milliseconds / 100);
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundEffect sound = new SoundEffect("../../Library/");
            sound.ClickSound();
            manual = false;
            initialboard = true;

            manualBoardToolStripMenuItem.Checked = false;
            setPieceToolStripMenuItem.Enabled = false;
            doneToolStripMenuItem.Enabled = false;

            SetStatus(false, "White's Turn");
            tmrWhite.Start();
            check = chess.detectCheckmate();

            if (computer && !check)
            {
                new Thread(chess.ComputerMove).Start();
            }
        }

        private void showMoveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMoveLogToolStripMenuItem.Checked = !showMoveLogToolStripMenuItem.Checked;

            if (showMoveLogToolStripMenuItem.Checked)
            {
                txtLog.Visible = true;
            }
            else
            {
                txtLog.Visible = false;
            }
        }

  
    }
}
