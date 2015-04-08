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

namespace D3GemCalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gem GemCalculator = new Gem();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string[] output;
            listbox1.Items.Clear();
            output = GemCalculator.SanityCheck(combobox1.SelectedIndex, combobox2.SelectedIndex, textbox1.Text, combobox1.Text, combobox2.Text);

            foreach (string message in output)
            {
                if (message == "")
                {
                    ; //no deathsbreath text, so do nothing.
                }
                else
                    listbox1.Items.Add(message);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Diablo 3 Gem Calculator by Jose Araujo.\n Thanks to William for annoying me into porting this to WPF.", "About D3 Gem Calc WPF");
        }
    }
}
