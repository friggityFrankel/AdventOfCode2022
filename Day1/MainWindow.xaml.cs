using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Day1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, TextChangedEventArgs e)
        {
            if (InputText.Text.Trim() != "")
            {
                var lines = InputText.Text.Split(Environment.NewLine);
                var caloriesList = new List<int>();
                var caloriesCount = 0;
                foreach (var item in lines)
                {
                    if (item != "")
                    {
                        var caloriesAdd = 0;
                        int.TryParse(item, out caloriesAdd);
                        caloriesCount += caloriesAdd;
                    }
                    else
                    {
                        caloriesList.Add(caloriesCount);
                        caloriesCount = 0;
                    }
                }

                var resultFirst = $"Most Calories: {caloriesList.OrderByDescending(x => x).FirstOrDefault()}";
                var resultSecond = $"Top 3 Calories Combined: {caloriesList.OrderByDescending(x => x).Take(3).Sum(y => y)}";

                OutputText.Text = resultFirst + Environment.NewLine + resultSecond;
            }
        }
    }
}