using System;
using Microsoft.Maui.Controls;

namespace Dice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int sides = 6;
            string imageName = "dice_6.png";

            if (K4RadioButton.IsChecked)
            {
                sides = 4;
                imageName = "dice4.png";
            }
            else if (K6RadioButton.IsChecked)
            {
                sides = 6;
                imageName = "dice6.png";
            }
            else if (K10RadioButton.IsChecked)
            {
                sides = 10;
                imageName = "dice10.png";
            }
            else if (K12RadioButton.IsChecked)
            {
                sides = 12;
                imageName = "dice12.png";
            }

            int roll = random.Next(1, sides + 1);
            ResultLabel.Text = $"You rolled a {roll}";

            // Ustawienie źródła obrazka
            DiceImage.Source = imageName;
        }
    }
}
