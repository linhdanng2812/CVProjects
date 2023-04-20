using System;
using System.Windows.Forms;
using System.Threading;

namespace CustomChess
{
    public partial class MainForm : Form, UI
    {

        bool computer = false;
        bool check = false;
        bool manual = false; 
        bool initialboard = false;
        Chess chess;
        Player player = Player.WHITE;
        Piece piece = Piece.PAWN;

        
        private void Stop()
        {
            SetStatus(false, "Choose New Game or Manual Board.");
            Computer.STOP = true;
            chess = null;
            SetTurn(Player.WHITE);

            tmrWhite.Stop();
            tmrBlack.Stop();
            whiteClock = new TimeSpan(0);
            blackClock = new TimeSpan(0);
            lblWhiteTime.Text = whiteClock.ToString("c");
            lblBlackTime.Text = blackClock.ToString("c");

            SetBoard(new ChessBoard());
            txtLog.Text = "";

            check = false;
            computer = false;
            initialboard = false;

            manualBoardToolStripMenuItem.Enabled = true;
            endCurrentGameToolStripMenuItem.Enabled = false;
            if (initialboard || manual)
            {
                setPieceToolStripMenuItem.Enabled = false;
                manualBoardToolStripMenuItem.Checked = false;
            }
            endCurrentGameToolStripMenuItem.Enabled = false;
        }

        private void NewGame(int nPlayers)
        {
            
                if (!manual) Stop();

            computer = (nPlayers == 0);
            chess = new Chess(this, nPlayers, !manual);

            NewGame name = new NewGame();
            BlackName.Text = name.BlackPlayerName.Text;
            WhiteName.Text = name.WhitePlayerName.Text;

            SetTurn(Player.WHITE);
            SetStatus(false, "White's turn");
            whiteClock = new TimeSpan(0);
            blackClock = new TimeSpan(0);
            lblWhiteTime.Text = whiteClock.ToString("c");
            lblBlackTime.Text = blackClock.ToString("c");

            

            if (manual)
            {
                SetStatus(false, "You may now place pieces via the menu.");
                setPieceToolStripMenuItem.Enabled = true;
            }
            else
            {
                SetStatus(false, "White's Turn");
                if (computer)
                {
                    new Thread(chess.ComputerMove).Start();
                }
                tmrWhite.Start();
            }
            endCurrentGameToolStripMenuItem.Enabled = true;
        }

        public void SetTurn(Player p)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetTurn(p)));
                return;
            }

            if (chess != null)
            {
                picTurn.Image = graphics.TurnIndicator[chess.SwitchPlayer];
            }
            else
            {
                picTurn.Image = graphics.TurnIndicator[Player.WHITE];
            }

            if (!manual)
            {
                if (p == Player.WHITE)
                {
                    tmrBlack.Stop();
                    tmrWhite.Start();
                }
                else
                {
                    tmrWhite.Stop();
                    tmrBlack.Start();
                }

                if (chess != null && (check || chess.detectCheckmate()))
                {
                    tmrWhite.Stop();
                    tmrBlack.Stop();
                }
            }
        }
        public void SetBoard(ChessBoard board)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetBoard(board)));
                return;
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    SetPiece(board.Grid[i][j].piece, board.Grid[i][j].player, j, i);
        }

        public void LogMove(string move)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => LogMove(move)));
                return;
            }

            lblWhiteCheck.Visible = false;
            lblBlackCheck.Visible = false;

            if (move.Contains("+"))
            {
                lblWhiteCheck.Visible = chess.SwitchPlayer == Player.BLACK;
                lblBlackCheck.Visible = chess.SwitchPlayer == Player.WHITE;
            }

            txtLog.AppendText(move);
        }

        public void SetStatus(bool thinking, string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetStatus(thinking, message)));
                return;
            }

            lblStatus.Text = message;
            if (thinking)
            {
                prgThinking.MarqueeAnimationSpeed = 30;
                prgThinking.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                prgThinking.MarqueeAnimationSpeed = 0;
                prgThinking.Value = 0;
                prgThinking.Style = ProgressBarStyle.Continuous;
            }
        }

        private void saveGameToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            SoundEffect sound = new SoundEffect("../../Library/");
            sound.ClickSound();
        }

        private void loadGameToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            SoundEffect sound = new SoundEffect("../../Library/");
            sound.ClickSound();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SoundEffect sound = new SoundEffect("../../Library/");
            sound.ClickSound();
        }


        private void splitView_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SoundEffect sound = new SoundEffect("../../Library/");
            sound.ClickSound();
        }

        private void splitView_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void WhiteName_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
