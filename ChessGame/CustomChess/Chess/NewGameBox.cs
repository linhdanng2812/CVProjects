using System;
using System.Windows.Forms;

namespace CustomChess
{

    public class NewGame : Form
    {
        SoundEffect sound = new SoundEffect("../../Library/");
        public string path = "../../Library/";     
        public bool bStartGame;           
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;

        public System.Windows.Forms.PictureBox BlackPlayerImage;
        public System.Windows.Forms.RadioButton PlayersCvC;
        public System.Windows.Forms.RadioButton PlayersHvC;
        public System.Windows.Forms.RadioButton PlayesrHvH;
        public System.Windows.Forms.RadioButton PlayerLevel3;
        public System.Windows.Forms.RadioButton PlayerLevel2;
        public System.Windows.Forms.RadioButton PlayerLevel1;
        public System.Windows.Forms.TextBox BlackPlayerName;
        public System.Windows.Forms.TextBox WhitePlayerName;
        public System.Windows.Forms.PictureBox WhitePlayerImage;
        private System.ComponentModel.Container components = null;

        public NewGame()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayersCvC = new System.Windows.Forms.RadioButton();
            this.PlayersHvC = new System.Windows.Forms.RadioButton();
            this.PlayesrHvH = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlayerLevel3 = new System.Windows.Forms.RadioButton();
            this.PlayerLevel2 = new System.Windows.Forms.RadioButton();
            this.PlayerLevel1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BlackPlayerName = new System.Windows.Forms.TextBox();
            this.BlackPlayerImage = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WhitePlayerName = new System.Windows.Forms.TextBox();
            this.WhitePlayerImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackPlayerImage)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WhitePlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.PlayersCvC);
            this.groupBox1.Controls.Add(this.PlayersHvC);
            this.groupBox1.Controls.Add(this.PlayesrHvH);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Options";
            // 
            // PlayersCvC
            // 
            this.PlayersCvC.Location = new System.Drawing.Point(17, 81);
            this.PlayersCvC.Name = "PlayersCvC";
            this.PlayersCvC.Size = new System.Drawing.Size(175, 18);
            this.PlayersCvC.TabIndex = 2;
            this.PlayersCvC.Text = "Computer Vs. Computer";
            this.PlayersCvC.CheckedChanged += new System.EventHandler(this.PlayesrType_CheckedChanged);
            // 
            // PlayersHvC
            // 
            this.PlayersHvC.Location = new System.Drawing.Point(17, 54);
            this.PlayersHvC.Name = "PlayersHvC";
            this.PlayersHvC.Size = new System.Drawing.Size(163, 23);
            this.PlayersHvC.TabIndex = 1;
            this.PlayersHvC.Text = "Human Vs. Computer";
            this.PlayersHvC.CheckedChanged += new System.EventHandler(this.PlayesrType_CheckedChanged);
            // 
            // PlayesrHvH
            // 
            this.PlayesrHvH.Checked = true;
            this.PlayesrHvH.Location = new System.Drawing.Point(17, 28);
            this.PlayesrHvH.Name = "PlayesrHvH";
            this.PlayesrHvH.Size = new System.Drawing.Size(163, 23);
            this.PlayesrHvH.TabIndex = 0;
            this.PlayesrHvH.TabStop = true;
            this.PlayesrHvH.Text = "Human Vs. Human";
            this.PlayesrHvH.CheckedChanged += new System.EventHandler(this.PlayesrType_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.PlayerLevel3);
            this.groupBox2.Controls.Add(this.PlayerLevel2);
            this.groupBox2.Controls.Add(this.PlayerLevel1);
            this.groupBox2.Location = new System.Drawing.Point(29, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Level";
            // 
            // PlayerLevel3
            // 
            this.PlayerLevel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PlayerLevel3.Location = new System.Drawing.Point(16, 74);
            this.PlayerLevel3.Name = "PlayerLevel3";
            this.PlayerLevel3.Size = new System.Drawing.Size(166, 23);
            this.PlayerLevel3.TabIndex = 2;
            this.PlayerLevel3.Text = "Hard";
            this.PlayerLevel3.UseVisualStyleBackColor = false;
            // 
            // PlayerLevel2
            // 
            this.PlayerLevel2.Location = new System.Drawing.Point(16, 51);
            this.PlayerLevel2.Name = "PlayerLevel2";
            this.PlayerLevel2.Size = new System.Drawing.Size(166, 23);
            this.PlayerLevel2.TabIndex = 1;
            this.PlayerLevel2.Text = "Medium";
            // 
            // PlayerLevel1
            // 
            this.PlayerLevel1.Checked = true;
            this.PlayerLevel1.Location = new System.Drawing.Point(16, 28);
            this.PlayerLevel1.Name = "PlayerLevel1";
            this.PlayerLevel1.Size = new System.Drawing.Size(166, 23);
            this.PlayerLevel1.TabIndex = 0;
            this.PlayerLevel1.TabStop = true;
            this.PlayerLevel1.Text = "Easy";
            this.PlayerLevel1.CheckedChanged += new System.EventHandler(this.PlayerLevel1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.BlackPlayerName);
            this.groupBox3.Controls.Add(this.BlackPlayerImage);
            this.groupBox3.Location = new System.Drawing.Point(230, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Black Player";
            // 
            // BlackPlayerName
            // 
            this.BlackPlayerName.Location = new System.Drawing.Point(80, 46);
            this.BlackPlayerName.Name = "BlackPlayerName";
            this.BlackPlayerName.Size = new System.Drawing.Size(96, 22);
            this.BlackPlayerName.TabIndex = 0;
            this.BlackPlayerName.Text = "Black Player";
            this.BlackPlayerName.Click += new System.EventHandler(this.PlayerName_Focus);
            this.BlackPlayerName.TextChanged += new System.EventHandler(this.BlackPlayerName_TextChanged);
            this.BlackPlayerName.Enter += new System.EventHandler(this.PlayerName_Focus);
            // 
            // BlackPlayerImage
            // 
            this.BlackPlayerImage.BackColor = System.Drawing.Color.Transparent;
            this.BlackPlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BlackPlayerImage.Location = new System.Drawing.Point(17, 28);
            this.BlackPlayerImage.Name = "BlackPlayerImage";
            this.BlackPlayerImage.Size = new System.Drawing.Size(54, 57);
            this.BlackPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlackPlayerImage.TabIndex = 1;
            this.BlackPlayerImage.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(332, 265);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 28);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "&Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox4.Controls.Add(this.WhitePlayerName);
            this.groupBox4.Controls.Add(this.WhitePlayerImage);
            this.groupBox4.Location = new System.Drawing.Point(230, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "White Player";
            // 
            // WhitePlayerName
            // 
            this.WhitePlayerName.Location = new System.Drawing.Point(80, 46);
            this.WhitePlayerName.Name = "WhitePlayerName";
            this.WhitePlayerName.Size = new System.Drawing.Size(96, 22);
            this.WhitePlayerName.TabIndex = 0;
            this.WhitePlayerName.Text = "White Player";
            this.WhitePlayerName.Click += new System.EventHandler(this.PlayerName_Focus);
            this.WhitePlayerName.Enter += new System.EventHandler(this.PlayerName_Focus);
            // 
            // WhitePlayerImage
            // 
            this.WhitePlayerImage.BackColor = System.Drawing.Color.Transparent;
            this.WhitePlayerImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WhitePlayerImage.Location = new System.Drawing.Point(17, 28);
            this.WhitePlayerImage.Name = "WhitePlayerImage";
            this.WhitePlayerImage.Size = new System.Drawing.Size(54, 57);
            this.WhitePlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WhitePlayerImage.TabIndex = 1;
            this.WhitePlayerImage.TabStop = false;
            // 
            // NewGame
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 314);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlackPlayerImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WhitePlayerImage)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            bStartGame = true;
            this.Close();   // close the form
            sound.ClickSound();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            bStartGame = false;
            sound.ClickSound();
            this.Close();   // close the form
            
        }
        private void PlayesrType_CheckedChanged(object sender, EventArgs e)
        {
            SoundEffect sound = new SoundEffect("../../Library/");
            sound.ClickSound();
            // Check the selected player types
            if (PlayesrHvH.Checked)
            {
                BlackPlayerImage.Image = System.Drawing.Image.FromFile(path + "User.jpg");
                WhitePlayerImage.Image = System.Drawing.Image.FromFile(path + "User_2.jpg");
            }
            else if (PlayersHvC.Checked)
            {
                BlackPlayerImage.Image = System.Drawing.Image.FromFile(path + "laptop.jpg");
                WhitePlayerImage.Image = System.Drawing.Image.FromFile(path + "User_2.jpg");
            }
            else if (PlayersCvC.Checked)
            {
                BlackPlayerImage.Image = System.Drawing.Image.FromFile(path + "laptop.jpg");
                WhitePlayerImage.Image = System.Drawing.Image.FromFile(path + "laptop_2.png");
            }
        }
        private void PlayerName_Focus(object sender, EventArgs e)
        {
            (sender as TextBox).Select(0, (sender as TextBox).Text.Length);
        }

        private void PlayerLevel1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BlackPlayerName_TextChanged(object sender, EventArgs e)
        {

        }
        private void NewGame_Load(object sender, EventArgs e)
        {
            PlayesrType_CheckedChanged(null, null);
        }
    }
}
