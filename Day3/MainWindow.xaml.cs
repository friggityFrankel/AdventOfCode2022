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

namespace Day3
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
            var charList = new List<char>() { '_', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            var lines = InputText.Text.Split(Environment.NewLine);
            var results1 = new List<int>();
            var results2 = new List<int>();
            foreach (var line in lines)
            {
                var lineChars = new List<char>();
                lineChars.AddRange(line);
                var result = lineChars.Take(lineChars.Count / 2).Intersect(lineChars.Skip(lineChars.Count / 2));
                var index = charList.IndexOf(result.FirstOrDefault());
                results1.Add(index);
            }
            for (int i = 0; i < lines.Count(); i+=3)
            {
                var firstCompare = lines[i].Intersect(lines[i+1]);
                var secondCompare = firstCompare.Intersect(lines[i + 2]);
                var index = charList.IndexOf(secondCompare.FirstOrDefault());
                results2.Add(index);
            }

            var line1 = $"Sum of Properties = {results1.Sum(x => x)}";
            var line2 = $"Sum of Properties = {results2.Sum(x => x)}";
            OutputText.Text = line1 + Environment.NewLine + line2;
        }
    }
}
