namespace CustomChess
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAIGame = new System.Windows.Forms.ToolStripMenuItem();
            this.endCurrentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manualBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.White_Pawn = new System.Windows.Forms.ToolStripMenuItem();
            this.White_Rook = new System.Windows.Forms.ToolStripMenuItem();
            this.White_Knight = new System.Windows.Forms.ToolStripMenuItem();
            this.White_Bishop = new System.Windows.Forms.ToolStripMenuItem();
            this.White_Queen = new System.Windows.Forms.ToolStripMenuItem();
            this.White_King = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Black_Pawn = new System.Windows.Forms.ToolStripMenuItem();
            this.Black_Rook = new System.Windows.Forms.ToolStripMenuItem();
            this.Black_Knight = new System.Windows.Forms.ToolStripMenuItem();
            this.Black_Bishop = new System.Windows.Forms.ToolStripMenuItem();
            this.Black_Queen = new System.Windows.Forms.ToolStripMenuItem();
            this.Black_King = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMoveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prgThinking = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitView = new System.Windows.Forms.SplitContainer();
            this.lblBlackCheck = new System.Windows.Forms.Label();
            this.lblWhiteCheck = new System.Windows.Forms.Label();
            this.picTurn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblWhiteTime = new System.Windows.Forms.Label();
            this.lblBlackTime = new System.Windows.Forms.Label();
            this.WhiteName = new System.Windows.Forms.Label();
            this.BlackName = new System.Windows.Forms.Label();
            this.tmrWhite = new System.Windows.Forms.Timer(this.components);
            this.tmrBlack = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitView)).BeginInit();
            this.splitView.Panel2.SuspendLayout();
            this.splitView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.showToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAIGame,
            this.endCurrentGameToolStripMenuItem,
            this.toolStripSeparator2,
            this.manualBoardToolStripMenuItem,
            this.setPieceToolStripMenuItem,
            this.doneToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.fileToolStripMenuItem.Text = "Game";
            // 
            // newAIGame
            // 
            this.newAIGame.Name = "newAIGame";
            this.newAIGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newAIGame.Size = new System.Drawing.Size(218, 26);
            this.newAIGame.Text = "New Game";
            this.newAIGame.Click += new System.EventHandler(this.NewGame);
            // 
            // endCurrentGameToolStripMenuItem
            // 
            this.endCurrentGameToolStripMenuItem.Name = "endCurrentGameToolStripMenuItem";
            this.endCurrentGameToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.endCurrentGameToolStripMenuItem.Text = "End current game";
            this.endCurrentGameToolStripMenuItem.Click += new System.EventHandler(this.endGame);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // manualBoardToolStripMenuItem
            // 
            this.manualBoardToolStripMenuItem.CheckOnClick = true;
            this.manualBoardToolStripMenuItem.Name = "manualBoardToolStripMenuItem";
            this.manualBoardToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.manualBoardToolStripMenuItem.Text = "Manual Board";
            this.manualBoardToolStripMenuItem.CheckedChanged += new System.EventHandler(this.manualBoardToolStripMenuItem_CheckedChanged);
            // 
            // setPieceToolStripMenuItem
            // 
            this.setPieceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem1,
            this.blackToolStripMenuItem1});
            this.setPieceToolStripMenuItem.Enabled = false;
            this.setPieceToolStripMenuItem.Name = "setPieceToolStripMenuItem";
            this.setPieceToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.setPieceToolStripMenuItem.Text = "Set Piece";
            // 
            // whiteToolStripMenuItem1
            // 
            this.whiteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.White_Pawn,
            this.White_Rook,
            this.White_Knight,
            this.White_Bishop,
            this.White_Queen,
            this.White_King});
            this.whiteToolStripMenuItem1.Name = "whiteToolStripMenuItem1";
            this.whiteToolStripMenuItem1.Size = new System.Drawing.Size(131, 26);
            this.whiteToolStripMenuItem1.Text = "White";
            // 
            // White_Pawn
            // 
            this.White_Pawn.Name = "White_Pawn";
            this.White_Pawn.Size = new System.Drawing.Size(137, 26);
            this.White_Pawn.Text = "Pawn";
            this.White_Pawn.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // White_Rook
            // 
            this.White_Rook.Name = "White_Rook";
            this.White_Rook.Size = new System.Drawing.Size(137, 26);
            this.White_Rook.Text = "Rook";
            this.White_Rook.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // White_Knight
            // 
            this.White_Knight.Name = "White_Knight";
            this.White_Knight.Size = new System.Drawing.Size(137, 26);
            this.White_Knight.Text = "Knight";
            this.White_Knight.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // White_Bishop
            // 
            this.White_Bishop.Name = "White_Bishop";
            this.White_Bishop.Size = new System.Drawing.Size(137, 26);
            this.White_Bishop.Text = "Bishop";
            this.White_Bishop.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // White_Queen
            // 
            this.White_Queen.Name = "White_Queen";
            this.White_Queen.Size = new System.Drawing.Size(137, 26);
            this.White_Queen.Text = "Queen";
            this.White_Queen.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // White_King
            // 
            this.White_King.Name = "White_King";
            this.White_King.Size = new System.Drawing.Size(137, 26);
            this.White_King.Text = "King";
            this.White_King.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // blackToolStripMenuItem1
            // 
            this.blackToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Black_Pawn,
            this.Black_Rook,
            this.Black_Knight,
            this.Black_Bishop,
            this.Black_Queen,
            this.Black_King});
            this.blackToolStripMenuItem1.Name = "blackToolStripMenuItem1";
            this.blackToolStripMenuItem1.Size = new System.Drawing.Size(131, 26);
            this.blackToolStripMenuItem1.Text = "Black";
            // 
            // Black_Pawn
            // 
            this.Black_Pawn.Name = "Black_Pawn";
            this.Black_Pawn.Size = new System.Drawing.Size(137, 26);
            this.Black_Pawn.Text = "Pawn";
            this.Black_Pawn.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // Black_Rook
            // 
            this.Black_Rook.Name = "Black_Rook";
            this.Black_Rook.Size = new System.Drawing.Size(137, 26);
            this.Black_Rook.Text = "Rook";
            this.Black_Rook.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // Black_Knight
            // 
            this.Black_Knight.Name = "Black_Knight";
            this.Black_Knight.Size = new System.Drawing.Size(137, 26);
            this.Black_Knight.Text = "Knight";
            this.Black_Knight.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // Black_Bishop
            // 
            this.Black_Bishop.Name = "Black_Bishop";
            this.Black_Bishop.Size = new System.Drawing.Size(137, 26);
            this.Black_Bishop.Text = "Bishop";
            this.Black_Bishop.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // Black_Queen
            // 
            this.Black_Queen.Name = "Black_Queen";
            this.Black_Queen.Size = new System.Drawing.Size(137, 26);
            this.Black_Queen.Text = "Queen";
            this.Black_Queen.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // Black_King
            // 
            this.Black_King.Name = "Black_King";
            this.Black_King.Size = new System.Drawing.Size(137, 26);
            this.Black_King.Text = "King";
            this.Black_King.Click += new System.EventHandler(this.SetManualPiece);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Enabled = false;
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.doneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Shutdown);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.editToolStripMenuItem.Text = "Save";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMoveLogToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // showMoveLogToolStripMenuItem
            // 
            this.showMoveLogToolStripMenuItem.Checked = true;
            this.showMoveLogToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMoveLogToolStripMenuItem.Name = "showMoveLogToolStripMenuItem";
            this.showMoveLogToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.showMoveLogToolStripMenuItem.Text = "Show Move Log";
            this.showMoveLogToolStripMenuItem.Click += new System.EventHandler(this.showMoveLogToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prgThinking,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(843, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prgThinking
            // 
            this.prgThinking.Name = "prgThinking";
            this.prgThinking.Size = new System.Drawing.Size(133, 18);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 20);
            this.lblStatus.Text = "Thinking...";
            // 
            // splitView
            // 
            this.splitView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitView.BackgroundImage")));
            this.splitView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitView.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitView.IsSplitterFixed = true;
            this.splitView.Location = new System.Drawing.Point(0, 28);
            this.splitView.Margin = new System.Windows.Forms.Padding(4);
            this.splitView.Name = "splitView";
            // 
            // splitView.Panel1
            // 
            this.splitView.Panel1.BackColor = System.Drawing.Color.Gray;
            this.splitView.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitView.Panel1.BackgroundImage")));
            this.splitView.Panel1.Resize += new System.EventHandler(this.ResizeBoard);
            this.splitView.Panel1MinSize = 400;
            // 
            // splitView.Panel2
            // 
            this.splitView.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitView.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitView.Panel2.BackgroundImage")));
            this.splitView.Panel2.Controls.Add(this.lblBlackCheck);
            this.splitView.Panel2.Controls.Add(this.lblWhiteCheck);
            this.splitView.Panel2.Controls.Add(this.picTurn);
            this.splitView.Panel2.Controls.Add(this.label3);
            this.splitView.Panel2.Controls.Add(this.txtLog);
            this.splitView.Panel2.Controls.Add(this.lblWhiteTime);
            this.splitView.Panel2.Controls.Add(this.lblBlackTime);
            this.splitView.Panel2.Controls.Add(this.WhiteName);
            this.splitView.Panel2.Controls.Add(this.BlackName);
            this.splitView.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitView_Panel2_Paint);
            this.splitView.Panel2MinSize = 200;
            this.splitView.Size = new System.Drawing.Size(843, 515);
            this.splitView.SplitterDistance = 571;
            this.splitView.SplitterWidth = 5;
            this.splitView.TabIndex = 2;
            this.splitView.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitView_SplitterMoved);
            // 
            // lblBlackCheck
            // 
            this.lblBlackCheck.AutoSize = true;
            this.lblBlackCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBlackCheck.Location = new System.Drawing.Point(204, 60);
            this.lblBlackCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlackCheck.Name = "lblBlackCheck";
            this.lblBlackCheck.Size = new System.Drawing.Size(62, 17);
            this.lblBlackCheck.TabIndex = 6;
            this.lblBlackCheck.Text = "In Check";
            this.lblBlackCheck.Visible = false;
            // 
            // lblWhiteCheck
            // 
            this.lblWhiteCheck.AutoSize = true;
            this.lblWhiteCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWhiteCheck.Location = new System.Drawing.Point(17, 60);
            this.lblWhiteCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhiteCheck.Name = "lblWhiteCheck";
            this.lblWhiteCheck.Size = new System.Drawing.Size(62, 17);
            this.lblWhiteCheck.TabIndex = 6;
            this.lblWhiteCheck.Text = "In Check";
            this.lblWhiteCheck.Visible = false;
            // 
            // picTurn
            // 
            this.picTurn.BackColor = System.Drawing.Color.Transparent;
            this.picTurn.Location = new System.Drawing.Point(130, 15);
            this.picTurn.Margin = new System.Windows.Forms.Padding(4);
            this.picTurn.Name = "picTurn";
            this.picTurn.Size = new System.Drawing.Size(52, 25);
            this.picTurn.TabIndex = 5;
            this.picTurn.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(113, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Moves";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLog.Location = new System.Drawing.Point(20, 142);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(248, 324);
            this.txtLog.TabIndex = 3;
            // 
            // lblWhiteTime
            // 
            this.lblWhiteTime.AutoSize = true;
            this.lblWhiteTime.BackColor = System.Drawing.Color.Transparent;
            this.lblWhiteTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWhiteTime.Location = new System.Drawing.Point(17, 39);
            this.lblWhiteTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhiteTime.Name = "lblWhiteTime";
            this.lblWhiteTime.Size = new System.Drawing.Size(76, 17);
            this.lblWhiteTime.TabIndex = 2;
            this.lblWhiteTime.Text = "00:00:00.0";
            // 
            // lblBlackTime
            // 
            this.lblBlackTime.AutoSize = true;
            this.lblBlackTime.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBlackTime.Location = new System.Drawing.Point(190, 39);
            this.lblBlackTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlackTime.Name = "lblBlackTime";
            this.lblBlackTime.Size = new System.Drawing.Size(76, 17);
            this.lblBlackTime.TabIndex = 2;
            this.lblBlackTime.Text = "00:00:00.0";
            // 
            // WhiteName
            // 
            this.WhiteName.AutoSize = true;
            this.WhiteName.BackColor = System.Drawing.Color.Transparent;
            this.WhiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WhiteName.Location = new System.Drawing.Point(16, 15);
            this.WhiteName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WhiteName.Name = "WhiteName";
            this.WhiteName.Size = new System.Drawing.Size(52, 20);
            this.WhiteName.TabIndex = 1;
            this.WhiteName.Text = "White";
            this.WhiteName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BlackName
            // 
            this.BlackName.AutoSize = true;
            this.BlackName.BackColor = System.Drawing.Color.Transparent;
            this.BlackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BlackName.Location = new System.Drawing.Point(190, 15);
            this.BlackName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlackName.Name = "BlackName";
            this.BlackName.Size = new System.Drawing.Size(51, 20);
            this.BlackName.TabIndex = 1;
            this.BlackName.Text = "Black";
            this.BlackName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tmrWhite
            // 
            this.tmrWhite.Tick += new System.EventHandler(this.WhiteClock);
            // 
            // tmrBlack
            // 
            this.tmrBlack.Tick += new System.EventHandler(this.BlackClock);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 569);
            this.Controls.Add(this.splitView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(861, 605);
            this.Name = "MainForm";
            this.Text = "Custom Chess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.windowClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitView.Panel2.ResumeLayout(false);
            this.splitView.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitView)).EndInit();
            this.splitView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prgThinking;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.SplitContainer splitView;
        private System.Windows.Forms.Label BlackName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblWhiteTime;
        private System.Windows.Forms.Label lblBlackTime;
        private System.Windows.Forms.Label WhiteName;
        private System.Windows.Forms.PictureBox picTurn;
        private System.Windows.Forms.Label lblBlackCheck;
        private System.Windows.Forms.Label lblWhiteCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem manualBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem setPieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem White_Pawn;
        private System.Windows.Forms.ToolStripMenuItem White_Rook;
        private System.Windows.Forms.ToolStripMenuItem White_Knight;
        private System.Windows.Forms.ToolStripMenuItem White_Bishop;
        private System.Windows.Forms.ToolStripMenuItem White_King;
        private System.Windows.Forms.ToolStripMenuItem White_Queen;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Black_Pawn;
        private System.Windows.Forms.ToolStripMenuItem Black_Rook;
        private System.Windows.Forms.ToolStripMenuItem Black_Knight;
        private System.Windows.Forms.ToolStripMenuItem Black_Bishop;
        private System.Windows.Forms.ToolStripMenuItem Black_Queen;
        private System.Windows.Forms.ToolStripMenuItem Black_King;
        private System.Windows.Forms.ToolStripMenuItem endCurrentGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.Timer tmrWhite;
        private System.Windows.Forms.Timer tmrBlack;
        private System.Windows.Forms.ToolStripMenuItem newAIGame;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMoveLogToolStripMenuItem;
    }
}

