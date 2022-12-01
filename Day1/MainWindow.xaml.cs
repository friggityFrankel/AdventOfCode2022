using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                var lines = InputText.Text.Split("\r\n");
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
                var results = caloriesList.OrderByDescending(x => x).Take(3).Sum(y => y);
                OutputText.Text = string.Join(Environment.NewLine, results);
            }
        }
    }
}