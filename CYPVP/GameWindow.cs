using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CYPVP
{
    public partial class GameWindow : Form
    {
        private Game Game { get; set; }
        private int Count { get; set; } = 0;

        public static SoundPlayer SlimeRadiationSound { get; set; }

        public List<String> List0fTips { get; set; } = new List<string>();
    
        public GameWindow(String Difficulty)
        {
            InitializeComponent();
            Game = new Game(this.Height, this.Width, Character, Slime);
            SetUpDiffuculty(Difficulty);
            SetUpTimers(); 
            UpdateTime();
            UpdateScore();
            GenerateTips();
            GiveTip();
            SlimeRadiationSound = new SoundPlayer(Properties.Resources.slime_radiation_sound);
           
        }
        
        private void SetUpDiffuculty(String Difficulty)
        {
            if (Difficulty == "Easy")
            {
                Game.Score = 10;
                Game.MainSlime.speed = 2;
            }
            else
            {
                Game.Score = -10;
                Game.MainSlime.speed = 7;
                Game.SlimeRadiationPoints = 10;
            }

        }
        private void SetUpTimers()
        {
            StarsSpawn.Interval = 5000;
            StarsSpawn.Start();
            CharacterMovements.Interval = 200;
            CharacterMovements.Start();
            SlimeMovements.Interval = 200;
            SlimeMovements.Start();
            SlimeRadiation.Start();
            SlimeRadiation.Interval = 2000;
            ScorePoints.Interval = 1000;
            ScorePoints.Start();
            TipsTimer.Interval = 10000;
            TipsTimer.Start();
            StarsFade.Interval = 12000;
            StarsFade.Start();
            ChestTImer.Start();
            ChestTImer.Interval = 5000;
        }
        private void StopGame()
        {
            StarsSpawn.Stop();
            CharacterMovements.Stop();
            SlimeMovements.Stop();
            ScorePoints.Stop();
            TipsTimer.Stop();
            StarsFade.Stop();
            SlimeRadiation.Stop();
            
        }
        private void ContinueGame()
        {
            StarsSpawn.Start();
            CharacterMovements.Start();
            SlimeMovements.Start();
            ScorePoints.Start();
            TipsTimer.Start();
            StarsFade.Start();
            SlimeRadiation.Start();
        }
        private void UpdateTime()
        {
            lb_TimeLeft.Text = $"TIMELEFT: {string.Format("{0:00}:{1:00}", Game.Time / 60, Game.Time % 60)}";

        }
        private void UpdateScore()
        {
            lb_Points.Text = $"POINTS: {Game.Score}";
        }
        private void GiveTip()
        {
            lb_Heading_text.Text = List0fTips[CYPVP.Random.Next(0,List0fTips.Count)];
        }
        private void GenerateTips()
        {
            List0fTips.Add("Cure radiation by eating stars");
            List0fTips.Add("Collect the stars to increase points!");
            List0fTips.Add("Avoid losing 5/10 points by dodging the slime!");
            List0fTips.Add("The radiation of the slime can hit you within 8cm");
            List0fTips.Add("Stars give you 10 points!");
            List0fTips.Add("You can pause the game  with ESC and unpause with F");
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
            {
                if (Game.MainCharacter.CanMoveUp == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.up_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_left;

                }
                Game.MainCharacter.CanMoveUp = true;

            }
            else if (e.KeyValue == (char)Keys.S)
            {
                if (Game.MainCharacter.CanMoveDown == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.down_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_right;

                }
                Game.MainCharacter.CanMoveDown = true;
            }
            else if (e.KeyValue == (char)Keys.D)
            {
                if (Game.MainCharacter.CanMoveRight == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.right_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_right;

                }
                Game.MainCharacter.CanMoveRight = true;

            }
            else if (e.KeyValue == (char)Keys.A)
            {
                if (Game.MainCharacter.CanMoveLeft == false)
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.left_running;
                    Game.MainSlime.SlimeSkin.Image = Properties.Resources.slime_left;

                }
                Game.MainCharacter.CanMoveLeft = true;
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.E)
            {
                if (Game.Chest != null)
                {
                    if (Game.Chest.isOpen == false)
                    {
                        if (Game.Distance0f(Game.MainCharacter.CharacterSkin.Location, Game.Chest.ChestSkin.Location) < 50)
                        {
                            StopGame();
                            int random = CYPVP.Random.Next(0, Game.List0fQuestions.Count);
                            QuestionForm questionForm = new QuestionForm(Game.List0fQuestions[random].Text, Game.List0fQuestions[random].CorrectAnswer);
                            if (questionForm.ShowDialog() == DialogResult.OK)
                            {
                                Game.Score += 10;
                            }
                            else
                            {
                                Game.Score -= 20;
                            }
                            Game.List0fQuestions[random].IsItAnswered = true;
                            ContinueGame();
                        }
                    }
                }
            }

            if (e.KeyValue == (char)Keys.Escape)
            {
                StopGame();
                lb_Paused.Text = "GAME PAUSED";
                lb_Paused1.Text = "PRESS F TO UNPAUSE";
            }
            if (e.KeyValue == (char)Keys.F)
            {
                ContinueGame();
                lb_Paused.Text = "";
                lb_Paused1.Text = "";
            }

            if (e.KeyValue == (char)Keys.W)
            {
                Game.MainCharacter.CanMoveUp = false;
                if (Game.MainCharacter.Check())
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.up_standing;

                }

            }
            else if (e.KeyValue == (char)Keys.S)
            {
                Game.MainCharacter.CanMoveDown = false;
                if (Game.MainCharacter.Check())
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.down_standing;

                }

            }
            else if (e.KeyValue == (char)Keys.D)
            {
                Game.MainCharacter.CanMoveRight = false;
                if (Game.MainCharacter.Check())
                {
                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.right_standing;

                }
            }
            else if (e.KeyValue == (char)Keys.A)
            {
                Game.MainCharacter.CanMoveLeft = false;
                if (Game.MainCharacter.Check())
                {

                    Game.MainCharacter.CharacterSkin.Image = Properties.Resources.left_standing;

                }
            }
        }

        private void RemoveStars()
        {
           for(int i = Game.List0fStars.Count - 1; i >= 0; i--)
            {
                if (Game.List0fStars[i].IsEaten)
                {
                    Game.CollectCoinSound.Play();
                    Game.MainSlime.isCloseEnough = false;
                    this.Controls.Remove(Game.List0fStars[i].StarSkin);
                    Game.List0fStars.RemoveAt(i);
                }else if (Game.List0fStars[i].isSelected && !Game.List0fStars[i].IsEaten)
                {
                    this.Controls.Remove(Game.List0fStars[i].StarSkin);
                    Game.List0fStars.RemoveAt(i);
                }
            }
            
        }
    
        private void Movements_Tick(object sender, EventArgs e)
        {
            Game.MoveCharacter(this.Height, this.Width);
            Game.CheckIfEaten();
            UpdateScore();
            RemoveStars();
        }
        private void SlimeMovements_Tick(object sender, EventArgs e)
        {
            Game.MoveSlime();
            if (Game.MainSlime.isCloseEnough)
            {
                SlimeRadiationSound.PlayLooping();
            }
            
            
        }

      

        private void ScorePoints_Tick(object sender, EventArgs e)
        {
            if (Game.Time % 20 == 0)
            {

                Count++;
                if (Count == 1)
                {
                    TimeLeftLabel.Image = Properties.Resources._2_statusbar;

                }
                else if (Count == 2)
                {
                    TimeLeftLabel.Image = Properties.Resources._3_statusbar;


                }
                else if (Count == 3)
                {
                    TimeLeftLabel.Image = Properties.Resources._4_statusbar;


                }
                else if (Count == 4)
                {
                    TimeLeftLabel.Image = Properties.Resources._5_statusbar;
                    
                }
            }
            if (Game.Time > 0)
            {
                Game.Time--;
            }
            else if(Game.Time==0)
            {
                this.Hide();
                StopGame();
                TimeLeft.Stop();
                EndGame endGame = new EndGame(Game.Score);
                endGame.ShowDialog();

            }

          
            UpdateTime();
        }

        private PictureBox MakeChest()
        {
            PictureBox Chest = new PictureBox();
            Chest.BackColor = Color.Transparent;
            Chest.Image = Properties.Resources.chest_unopen;
            int x = CYPVP.Random.Next(25, 696);
            int y = CYPVP.Random.Next(93, 486);
            Chest.Location = new Point(x, y);
            return Chest;
        }
        private PictureBox MakeStar()
        {
            PictureBox star = new PictureBox();
            star.BackColor = Color.Transparent;
            star.Image = Properties.Resources.star;
            int x = CYPVP.Random.Next(25, 696);
            int y = CYPVP.Random.Next(93, 486);
            star.Location = new Point(x, y);
            return star;
        }
        private bool Check(PictureBox box)
        {
            foreach(Star star in Game.List0fStars)
            {
                if (Game.Distance0f(box.Location, star.StarSkin.Location) < 70)
                {
                    return false;
                }
            }
            return true;
        }
        private void StarsSpawn_Tick(object sender, EventArgs e)
        {       
            PictureBox NewStar = MakeStar();
            while (Check(NewStar) != true)
            {
                NewStar=MakeStar();
            }
            Game.List0fStars.Add(new Star(NewStar));
            this.Controls.Add(NewStar);
 
        }

        private void TipsTimer_Tick(object sender, EventArgs e)
        {
            GiveTip();
            
        }

        private void StarsFade_Tick(object sender, EventArgs e)
        {
            if (Game.List0fStars.Count > 1)
            {
                Game.List0fStars[CYPVP.Random.Next(0, Game.List0fStars.Count)].isSelected = true;
                RemoveStars();
            }
            
        }

        private void SlimeRadiation_Tick(object sender, EventArgs e)
        {
            if (Game.MainSlime.isCloseEnough)
            {
                Game.Score -= Game.SlimeRadiationPoints;
            }
            UpdateScore();
            
        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SlimeRadiation.Stop();
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            SlimeRadiation.Stop();

        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        private void ChestTImer_Tick(object sender, EventArgs e)
        {
            PictureBox Chest = MakeChest();
            while (Check(Chest) != true)
            {
                Chest = MakeChest();
            }
            Game.Chest = new Chest(Chest);
            this.Controls.Add(Chest);

            ChestTImer.Stop();
        }
    }
}

