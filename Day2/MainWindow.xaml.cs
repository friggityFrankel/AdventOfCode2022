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

namespace Day2
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
                var pointsList1 = new List<int>();
                var lines = InputText.Text.Split(Environment.NewLine);
                foreach (var item in lines)
                {
                    var points = 0;
                    if (item.Length > 0)
                    {
                        if (item[2] == 'X')
                        {
                            points += 1;
                            if (item[0] == 'A')
                            {
                                points += 3;
                            }
                            else if (item[0] == 'C')
                            {
                                points += 6;
                            }
                        }
                        else if (item[2] == 'Y')
                        {
                            points += 2;
                            if (item[0] == 'A')
                            {
                                points += 6;
                            }
                            else if (item[0] == 'B')
                            {
                                points += 3;
                            }
                        }
                        else if (item[2] == 'Z')
                        {
                            points += 3;
                            if (item[0] == 'B')
                            {
                                points += 6;
                            }
                            else if (item[0] == 'C')
                            {
                                points += 3;
                            }
                        }
                    }
                    pointsList1.Add(points);
                }

                var pointsList2 = new List<int>();
                foreach (var item in lines)
                {
                    var points = 0;
                    if (item.Length > 0)
                    {
                        if (item[2] == 'X')
                        {
                            if (item[0] == 'A')
                            {
                                points += 3;
                            }
                            else if (item[0] == 'B')
                            {
                                points += 1;
                            }
                            else if (item[0] == 'C')
                            {
                                points += 2;
                            }
                        }
                        else if (item[2] == 'Y')
                        {
                            points = 3;
                            if (item[0] == 'A')
                            {
                                points += 1;
                            }
                            else if (item[0] == 'B')
                            {
                                points += 2;
                            }
                            else if (item[0] == 'C')
                            {
                                points += 3;
                            }
                        }
                        else if (item[2] == 'Z')
                        {
                            points = 6;
                            if (item[0] == 'A')
                            {
                                points += 2;
                            }
                            else if (item[0] == 'B')
                            {
                                points += 3;
                            }
                            else if (item[0] == 'C')
                            {
                                points += 1;
                            }
                        }
                    }
                    pointsList2.Add(points);
                }

                var resultFirst = $"Total Points Part 1: {pointsList1.Sum(x => x)}";
                var resultSecond = $"Total Points Part 2: {pointsList2.Sum(x => x)}";

                OutputText.Text = resultFirst + Environment.NewLine + resultSecond;
            }
        }
    }
}