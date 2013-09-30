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

namespace PopulationExercise
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double organisms = 0;
            double.TryParse(organismsTextBox.Text, out organisms);
            double increase = 0;
            double.TryParse(increaseTextBox.Text, out increase);
            double multiply = 0;
            double.TryParse(multiplyTextBox.Text, out multiply);

            if (organisms != 0 && increase != 0 && multiply != 0)
            {
                int m = (int)multiply;
                string[] output = new string[m];
                for (int i = 0; i < output.Length; i++)
                {
                    //output[i] = organisms + (i * 1+(increase/100);
                    //output[i] = (int.Parse(output[i-1]) + (int.Parse(output[i-1])*increase/100)).ToString();
                    double k = i;
                    output[i] = (i + 1) + ":\t\t\t\t\t    " + (organisms * Math.Pow((1 + increase / 100), k)).ToString("n2");

                }
                answerListBox.ItemsSource = output;

            }
        }
    }
}
