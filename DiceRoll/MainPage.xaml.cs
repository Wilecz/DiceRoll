namespace DiceRoll
{
    public partial class MainPage : ContentPage
    {
        int ScoreForGame = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void RollFunc(object? sender, EventArgs e)
        {
            Random rnd = new Random();
            int RndNumber1 = rnd.Next(1,7);
            int RndNumber2 = rnd.Next(1, 7);
            int RndNumber3 = rnd.Next(1, 7);
            int RndNumber4 = rnd.Next(1, 7);
            int RndNumber5 = rnd.Next(1, 7);
            int RndNumber6 = rnd.Next(1, 7);
            Image1.Source = "k" + RndNumber1.ToString() + ".jpg";
            Image2.Source = "k" + RndNumber2.ToString() + ".jpg";
            Image3.Source = "k" + RndNumber3.ToString() + ".jpg";
            Image4.Source = "k" + RndNumber4.ToString() + ".jpg";
            Image5.Source = "k" + RndNumber5.ToString() + ".jpg";
            Image6.Source = "k" + RndNumber6.ToString() + ".jpg";
            if(RndNumber1 != RndNumber2 && RndNumber1 != RndNumber3 && RndNumber1 != RndNumber4 && RndNumber1 != RndNumber5 && RndNumber1 != RndNumber6)
            {
                RndNumber1 = 0;
            }
            if (RndNumber2 != RndNumber1 && RndNumber2 != RndNumber3 && RndNumber2 != RndNumber4 && RndNumber2 != RndNumber5 && RndNumber2 != RndNumber6)
            {
                RndNumber2 = 0;
            }
            if (RndNumber3 != RndNumber1 && RndNumber3 != RndNumber2 && RndNumber3 != RndNumber4 && RndNumber3 != RndNumber5 && RndNumber3 != RndNumber6)
            {
                RndNumber3 = 0;
            }
            if (RndNumber4 != RndNumber1 && RndNumber4 != RndNumber2 && RndNumber4 != RndNumber3 && RndNumber4 != RndNumber5 && RndNumber4 != RndNumber6)
            {
                RndNumber4 = 0;
            }
            if (RndNumber5 != RndNumber1 && RndNumber5 != RndNumber2 && RndNumber5 != RndNumber3 && RndNumber5 != RndNumber4 && RndNumber5 != RndNumber6)
            {
                RndNumber5 = 0;
            }
            if (RndNumber6 != RndNumber1 && RndNumber6 != RndNumber2 && RndNumber6 != RndNumber3 && RndNumber6 != RndNumber4 && RndNumber6 != RndNumber5)
            {
                RndNumber6 = 0;
            }
            int ScoreForThisRoll = RndNumber1 + RndNumber2 + RndNumber3 + RndNumber4 + RndNumber5 + RndNumber6;
            ScoreForGame = ScoreForGame + ScoreForThisRoll;
            RollScoreTxt.Text = "Roll Score: " + ScoreForThisRoll.ToString();
            ScoreTxt.Text = "Score:" + ScoreForGame.ToString();
        }
        private void ResetScoreFunc(object? sender, EventArgs e)
        {
            ScoreForGame = 0;
            ScoreTxt.Text = "Score:" + ScoreForGame.ToString();
        }
    }
}
