namespace Pet_Simulator_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbPet = new PictureBox();
            pbPetBowl = new PictureBox();
            timeTimer = new System.Windows.Forms.Timer(components);
            btnBuyPetFood = new Button();
            petHungerMeter = new ProgressBar();
            playerEmotionalStateMeter = new ProgressBar();
            petAttentionMeter = new ProgressBar();
            lblClockTime = new Label();
            petSanitationMeter = new ProgressBar();
            lblGameDay = new Label();
            lblFinance = new Label();
            lblEmotionalState = new Label();
            lblPetAttention = new Label();
            lblPetHunger = new Label();
            lblPetSanitation = new Label();
            lblDisplayText = new Label();
            lblPetFood = new Label();
            btnStartGame = new Button();
            btnExit = new Button();
            lblGameTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPetBowl).BeginInit();
            SuspendLayout();
            // 
            // pbPet
            // 
            pbPet.BackColor = Color.Transparent;
            pbPet.Image = Properties.Resources.PetSanitationLevel1;
            pbPet.Location = new Point(265, 276);
            pbPet.Name = "pbPet";
            pbPet.Size = new Size(140, 140);
            pbPet.SizeMode = PictureBoxSizeMode.Zoom;
            pbPet.TabIndex = 0;
            pbPet.TabStop = false;
            pbPet.Click += pbPet_Click;
            // 
            // pbPetBowl
            // 
            pbPetBowl.BackColor = Color.Transparent;
            pbPetBowl.BackgroundImageLayout = ImageLayout.Zoom;
            pbPetBowl.Image = Properties.Resources.PetBowl;
            pbPetBowl.Location = new Point(12, 372);
            pbPetBowl.Name = "pbPetBowl";
            pbPetBowl.Size = new Size(140, 79);
            pbPetBowl.SizeMode = PictureBoxSizeMode.Zoom;
            pbPetBowl.TabIndex = 1;
            pbPetBowl.TabStop = false;
            pbPetBowl.Click += pbPetBowl_Click;
            // 
            // timeTimer
            // 
            timeTimer.Enabled = true;
            timeTimer.Interval = 1000;
            timeTimer.Tick += timeTimer_Tick;
            // 
            // btnBuyPetFood
            // 
            btnBuyPetFood.Location = new Point(713, 372);
            btnBuyPetFood.Name = "btnBuyPetFood";
            btnBuyPetFood.Size = new Size(75, 66);
            btnBuyPetFood.TabIndex = 2;
            btnBuyPetFood.Text = "Buy Pet Food";
            btnBuyPetFood.UseVisualStyleBackColor = true;
            btnBuyPetFood.Click += btnBuyPetFood_Click;
            // 
            // petHungerMeter
            // 
            petHungerMeter.Location = new Point(617, 66);
            petHungerMeter.Name = "petHungerMeter";
            petHungerMeter.Size = new Size(171, 21);
            petHungerMeter.TabIndex = 4;
            petHungerMeter.Value = 100;
            // 
            // playerEmotionalStateMeter
            // 
            playerEmotionalStateMeter.Location = new Point(617, 12);
            playerEmotionalStateMeter.Name = "playerEmotionalStateMeter";
            playerEmotionalStateMeter.Size = new Size(171, 21);
            playerEmotionalStateMeter.TabIndex = 6;
            playerEmotionalStateMeter.Value = 100;
            // 
            // petAttentionMeter
            // 
            petAttentionMeter.Location = new Point(617, 39);
            petAttentionMeter.Name = "petAttentionMeter";
            petAttentionMeter.Size = new Size(171, 21);
            petAttentionMeter.TabIndex = 7;
            petAttentionMeter.Value = 100;
            // 
            // lblClockTime
            // 
            lblClockTime.AutoSize = true;
            lblClockTime.BackColor = Color.Transparent;
            lblClockTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblClockTime.Location = new Point(12, 8);
            lblClockTime.Name = "lblClockTime";
            lblClockTime.Size = new Size(58, 25);
            lblClockTime.TabIndex = 10;
            lblClockTime.Text = "Clock";
            // 
            // petSanitationMeter
            // 
            petSanitationMeter.Location = new Point(617, 93);
            petSanitationMeter.Name = "petSanitationMeter";
            petSanitationMeter.Size = new Size(171, 21);
            petSanitationMeter.TabIndex = 11;
            petSanitationMeter.Value = 100;
            // 
            // lblGameDay
            // 
            lblGameDay.AutoSize = true;
            lblGameDay.BackColor = Color.Transparent;
            lblGameDay.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameDay.Location = new Point(12, 35);
            lblGameDay.Name = "lblGameDay";
            lblGameDay.Size = new Size(63, 25);
            lblGameDay.TabIndex = 12;
            lblGameDay.Text = "Day: 0";
            // 
            // lblFinance
            // 
            lblFinance.AutoSize = true;
            lblFinance.BackColor = Color.Transparent;
            lblFinance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFinance.Location = new Point(12, 62);
            lblFinance.Name = "lblFinance";
            lblFinance.Size = new Size(89, 25);
            lblFinance.TabIndex = 13;
            lblFinance.Text = "Money: 0";
            // 
            // lblEmotionalState
            // 
            lblEmotionalState.AutoSize = true;
            lblEmotionalState.BackColor = Color.Transparent;
            lblEmotionalState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmotionalState.Location = new Point(490, 12);
            lblEmotionalState.Name = "lblEmotionalState";
            lblEmotionalState.Size = new Size(121, 21);
            lblEmotionalState.TabIndex = 14;
            lblEmotionalState.Text = "Emotional State:";
            // 
            // lblPetAttention
            // 
            lblPetAttention.AutoSize = true;
            lblPetAttention.BackColor = Color.Transparent;
            lblPetAttention.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPetAttention.Location = new Point(509, 39);
            lblPetAttention.Name = "lblPetAttention";
            lblPetAttention.Size = new Size(102, 21);
            lblPetAttention.TabIndex = 15;
            lblPetAttention.Text = "Pet Attention:";
            // 
            // lblPetHunger
            // 
            lblPetHunger.AutoSize = true;
            lblPetHunger.BackColor = Color.Transparent;
            lblPetHunger.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPetHunger.Location = new Point(521, 66);
            lblPetHunger.Name = "lblPetHunger";
            lblPetHunger.Size = new Size(90, 21);
            lblPetHunger.TabIndex = 16;
            lblPetHunger.Text = "Pet Hunger:";
            // 
            // lblPetSanitation
            // 
            lblPetSanitation.AutoSize = true;
            lblPetSanitation.BackColor = Color.Transparent;
            lblPetSanitation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPetSanitation.Location = new Point(503, 93);
            lblPetSanitation.Name = "lblPetSanitation";
            lblPetSanitation.Size = new Size(108, 21);
            lblPetSanitation.TabIndex = 17;
            lblPetSanitation.Text = "Pet Sanitation:";
            // 
            // lblDisplayText
            // 
            lblDisplayText.AutoSize = true;
            lblDisplayText.BackColor = Color.Transparent;
            lblDisplayText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayText.Location = new Point(313, 135);
            lblDisplayText.Name = "lblDisplayText";
            lblDisplayText.Size = new Size(0, 21);
            lblDisplayText.TabIndex = 18;
            // 
            // lblPetFood
            // 
            lblPetFood.AutoSize = true;
            lblPetFood.BackColor = Color.Transparent;
            lblPetFood.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPetFood.Location = new Point(12, 87);
            lblPetFood.Name = "lblPetFood";
            lblPetFood.Size = new Size(104, 25);
            lblPetFood.TabIndex = 19;
            lblPetFood.Text = "Pet Food: 0";
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(261, 180);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(279, 42);
            btnStartGame.TabIndex = 20;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(261, 228);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(279, 42);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblGameTitle
            // 
            lblGameTitle.AutoSize = true;
            lblGameTitle.BackColor = Color.Transparent;
            lblGameTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGameTitle.Location = new Point(302, 152);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Size = new Size(197, 25);
            lblGameTitle.TabIndex = 22;
            lblGameTitle.Text = "Pet Simulator DOOM";
            lblGameTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.House;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGameTitle);
            Controls.Add(btnExit);
            Controls.Add(btnStartGame);
            Controls.Add(lblPetFood);
            Controls.Add(lblDisplayText);
            Controls.Add(lblPetSanitation);
            Controls.Add(lblPetHunger);
            Controls.Add(lblPetAttention);
            Controls.Add(lblEmotionalState);
            Controls.Add(lblFinance);
            Controls.Add(lblGameDay);
            Controls.Add(petSanitationMeter);
            Controls.Add(lblClockTime);
            Controls.Add(petAttentionMeter);
            Controls.Add(playerEmotionalStateMeter);
            Controls.Add(petHungerMeter);
            Controls.Add(btnBuyPetFood);
            Controls.Add(pbPet);
            Controls.Add(pbPetBowl);
            KeyPreview = true;
            Name = "Form1";
            Text = "Pet Simulator DOOM";
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pbPet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPetBowl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPet;
        private PictureBox pbPetBowl;
        private System.Windows.Forms.Timer timeTimer;
        private Button btnBuyPetFood;
        private ProgressBar petHungerMeter;
        private ProgressBar playerEmotionalStateMeter;
        private ProgressBar petAttentionMeter;
        private Label lblClockTime;
        private ProgressBar petSanitationMeter;
        private Label lblGameDay;
        private Label lblFinance;
        private Label lblEmotionalState;
        private Label lblPetAttention;
        private Label lblPetHunger;
        private Label lblPetSanitation;
        private Label lblDisplayText;
        private Label lblPetFood;
        private Button btnStartGame;
        private Button btnExit;
        private Label lblGameTitle;
    }
}