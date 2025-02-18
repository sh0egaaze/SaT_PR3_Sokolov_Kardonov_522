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

namespace SaT_PR3_Sokolov_Kardonov_522
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Внимание!");
            }
            else if (radioButton1.IsChecked == false && radioButton2.IsChecked == false && radioButton3.IsChecked == false && radioButton4.IsChecked == false)
            {
                MessageBox.Show("Выберите хотя бы один переключатель!", "Внимание!");
            }
            else if (Convert.ToDouble(textBox2.Text) == 0 && radioButton4.IsChecked == true)
            {
                MessageBox.Show("Нельзя делить на 0!", "Внимание!");
            }
            else
            {
                if (radioButton1.IsChecked == true)
                {
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
                }
                else if (radioButton2.IsChecked == true)
                {
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
                }
                else if (radioButton3.IsChecked == true)
                {
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
                }
                else if (radioButton4.IsChecked == true)
                {
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
                }
            }
        }

        private void textBox1_TextChanged(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) && e.Text != ",")
            {
                e.Handled = true;
            }
            if (e.Text == "," && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) && e.Text != ",")
            {
                e.Handled = true;
            }
            if (e.Text == "," && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
