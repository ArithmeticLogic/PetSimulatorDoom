using Pet_Simulator_Project.Properties;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Pet_Simulator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartAndEndGame();
            lblDisplayText.Text = string.Empty;
        }

        // Pet Happiness isnt needed as Pet Attention is essentially the same thing
        // Player Therapy makes the game to easy so it has to be removed

        int day, playerFinance, amountPetFood = 0;
        sbyte[] time = new sbyte[2];
        bool petAttention = true, gameRunning = false;
        string errorType = "Error: Unknown";

        // Game Start and End
        private void StartAndEndGame()
        {
            try
            {
                if (gameRunning)
                {
                    // Invisible Assets
                    lblGameTitle.Visible = false;
                    btnStartGame.Visible = false;
                    btnExit.Visible = false;

                    // Visible Assets
                    timeTimer.Start();
                    btnBuyPetFood.Visible = true;
                    lblFinance.Visible = true;
                    lblClockTime.Visible = true;
                    lblGameDay.Visible = true;
                    playerEmotionalStateMeter.Visible = true;
                    petAttentionMeter.Visible = true;
                    petHungerMeter.Visible = true;
                    petSanitationMeter.Visible = true;
                    lblPetAttention.Visible = true;
                    lblPetHunger.Visible = true;
                    lblPetSanitation.Visible = true;
                    lblEmotionalState.Visible = true;
                    lblPetFood.Visible = true;
                    pbPet.Visible = true;
                    lblDisplayText.Text = "Game Started!";
                }
                else if (!gameRunning)
                {
                    // Visible Assets
                    lblGameTitle.Visible = true;
                    btnStartGame.Visible = true;
                    btnExit.Visible = true;

                    // Invisible Assets
                    timeTimer.Stop();
                    btnBuyPetFood.Visible = false;
                    lblFinance.Visible = false;
                    lblClockTime.Visible = false;
                    lblGameDay.Visible = false;
                    playerEmotionalStateMeter.Visible = false;
                    petAttentionMeter.Visible = false;
                    petHungerMeter.Visible = false;
                    petSanitationMeter.Visible = false;
                    lblPetAttention.Visible = false;
                    lblPetHunger.Visible = false;
                    lblPetSanitation.Visible = false;
                    lblEmotionalState.Visible = false;
                    lblPetFood.Visible = false;
                    pbPet.Visible = false;


                    // Bug fixed based on feedback values resetting after game restart
                    // Resetting Values
                    playerEmotionalStateMeter.Value = 100;
                    petAttentionMeter.Value = 100;
                    petHungerMeter.Value = 100;
                    petSanitationMeter.Value = 100;
                    lblGameDay.Text = "Day: " + 0;
                    day = 0;
                    lblFinance.Text = "Money: " + 0;
                    playerFinance = 0;
                    lblPetFood.Text = "Pet Food: " + 0;
                    amountPetFood = 0;
                    time[0] = 0;
                    time[1] = 0;

                    // Game Over Text
                    lblDisplayText.Text = "Game Over!";
                }
            }
            catch
            {
                errorType = "Error: Cant determine if the game has started or not";
                MessageBox.Show(errorType);
            }
        }

        // Start the game
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            gameRunning = true;
            StartAndEndGame();
        }

        // Exit the Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // FIX // 50 Minutes i find no fix
        // Pauses the progress when the key Escape is pressed
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape && !lblGameTitle.Visible)
            {
                // Visible Assets
                lblGameTitle.Visible = true;
                btnStartGame.Visible = true;
                btnExit.Visible = true;

                // Pause Timer
                timeTimer.Stop();
            }
            else if (e.KeyChar == (char)Keys.Escape && lblGameTitle.Visible)
            {
                // Visible Assets
                lblGameTitle.Visible = false;
                btnStartGame.Visible = false;
                btnExit.Visible = false;

                // Start Timer
                timeTimer.Start();
            }
        }

        // playerEmotionalStateMeter
        private void PlayerEmotionalState()
        {
            if (playerEmotionalStateMeter.Value < 1)
            {
                gameRunning = false;
                StartAndEndGame();
            }
        }

        // Pet Attention
        private void PetAttention()
        {
            if (petAttentionMeter.Value < 1)
            {
                if (playerEmotionalStateMeter.Value >= 10)
                {
                    playerEmotionalStateMeter.Value -= 10;
                }
            }
        }
        private void pbPet_Click(object sender, EventArgs e)
        {
            if (petAttention)
            {
                if (petAttentionMeter.Value <= 75)
                {
                    petAttentionMeter.Value += 25;
                }
                petAttention = false;
                if (petSanitationMeter.Value <= 90)
                {
                    petSanitationMeter.Value += 10;
                }
            }
            else if (!petAttention)
            {
                lblDisplayText.Text = "Wait 30 Minutes in Game Time";
            }
        }

        // petHungerMeter
        private void PetHunger()
        {
            if (petHungerMeter.Value > 0 && (new[] { 29, 59 }).Contains(time[1]))
            {
                if (petHungerMeter.Value >= 15)
                {
                    petHungerMeter.Value -= 15;
                }
            }
            else if (petHungerMeter.Value < 15 && playerEmotionalStateMeter.Value > 0 && (new[] { 9, 19, 29, 39, 49, 59 }).Contains(time[1]))
            {
                if (playerEmotionalStateMeter.Value >= 10)
                {
                    playerEmotionalStateMeter.Value -= 10;
                }
            }
        }

        // Player Finance
        private void PlayerFinance()
        {
            Random random = new Random();
            if (petAttentionMeter.Value >= 25 && time[1] == 59)
            {
                int randomIncome = random.Next(0, 100);
                playerFinance += randomIncome;
                lblFinance.Text = "Money: " + playerFinance;
            }
        }

        //Pet Sanitation
        private void PetSanitation()
        {
            if (petSanitationMeter.Value >= 25 && (new[] { 29, 59 }).Contains(time[1]))
            {
                petSanitationMeter.Value -= 25;
            }

            switch (petSanitationMeter.Value)
            {
                case >= 85: // Stage 1
                    {
                        pbPet.Image = Resources.PetSanitationLevel1;
                    }
                    break;
                case > 50 or 75: // Stage 2
                    {
                        pbPet.Image = Resources.PetSanitationLevel2;
                    }
                    break;
                case > 25 or 50: // Stage 3
                    {
                        pbPet.Image = Resources.PetSanitationLevel3;
                    }
                    break;
                case <= 25: // Stage 4
                    {
                        pbPet.Image = Resources.PetSanitationLevel4;
                    }
                    break;
            }
        }

        // Buy Pet Food
        private void btnBuyPetFood_Click(object sender, EventArgs e)
        {
            if (playerFinance >= 10) // Bug fixed from feedback // Value was originally set to 25 stopping players from buying pet food if they had below that amount of money even 10.
            {
                amountPetFood += 1;
                playerFinance -= 10;
                lblFinance.Text = "Money: " + playerFinance;
                lblPetFood.Text = "Pet Food: " + amountPetFood;
                lblDisplayText.Text = string.Empty;
            }
            else if (playerFinance < 10)
            {
                lblDisplayText.Text = "Not Enough Money";
            }
        }

        // Feed Pet
        private void pbPetBowl_Click(object sender, EventArgs e)
        {
            if (amountPetFood >= 1)
            {
                if (petHungerMeter.Value <= 90)
                {
                    petHungerMeter.Value += 10;
                }
                if (petAttentionMeter.Value <= 95)
                {
                    petAttentionMeter.Value += 5;
                }
                amountPetFood -= 1;
                pbPetBowl.Image = Resources.PetBowlFull;
                lblPetFood.Text = "Pet Food: " + amountPetFood;
                lblDisplayText.Text = string.Empty;
                if (petSanitationMeter.Value <= 85)
                {
                    petSanitationMeter.Value += 15;
                }
            }
            else if (amountPetFood < 1)
            {
                lblDisplayText.Text = "No Pet Food";
            }
        }

        // 24 Hour Clock
        private void TwentyFourHourClock()
        {
            try
            {
                // Minutes
                if (time[1] < 59)
                {
                    time[1] += 1;
                }
                else if (time[1] == 59)
                {
                    time[0] += 1;
                    time[1] = 0;
                }

                // Hours
                if (time[0] == 24)
                {
                    time[0] = 0;
                    // Days // Days Display
                    day += 1;
                    lblGameDay.Text = "Day: " + day;
                }
                else if (time[0] <= 24)
                {

                }
            }
            catch
            {
                errorType = "Error: Clock Time";
                MessageBox.Show(errorType);
            }
        }

        // 24 Hour Clock Time display
        // Fix should be like 00:00
        private void TimeDisplay(int timevalue0 = 0, string timeSpacer = ":") // int where value of time = 0 // string where time0 and time1 are spaced. time0:time1
        {
            try
            {
                if (time[0] < 10 && time[1] < 10)
                {
                    lblClockTime.Text = timevalue0 + time[0] + timeSpacer + timevalue0 + time[1];
                }
                else if (time[0] < 10)
                {
                    lblClockTime.Text = timevalue0 + time[0] + timeSpacer + time[1];
                }
                else if (time[1] < 10)
                {
                    lblClockTime.Text = time[0] + timeSpacer + timevalue0 + time[1];
                }
                else if (time[0] >= 10 && time[1] >= 10)
                {
                    lblClockTime.Text = time[0] + timeSpacer + time[1];
                }
            }
            catch
            {
                errorType = "Error: Clock Time Count Display";
                MessageBox.Show(errorType);
            }
        }

        // Clock/Time
        private void timeTimer_Tick(object sender, EventArgs e)
        {
            // Real Timer/Game Ticks
            timeTimer.Interval = 250; // 1 second is ... in game time

            // 24 Hour Clock
            TwentyFourHourClock();

            // 24 Hour Clock Time display
            TimeDisplay();

            // Player Finance
            PlayerFinance();

            // Player Emotional State
            PlayerEmotionalState();

            // Pet Attention
            PetAttention();
            if ((new[] { 29, 59 }).Contains(time[1]))
            {
                petAttention = true;
                if (petAttentionMeter.Value >= 25)
                {
                    petAttentionMeter.Value -= 25;
                }
            }

            // Pet Hunger
            PetHunger();

            // Pet Bowl Transparent
            if ((new[] { 14, 29, 44, 59 }).Contains(time[1]))
            {
                pbPetBowl.Image = Resources.PetBowl;
            }

            // Pet Sanitation
            PetSanitation();
        }
    }
}