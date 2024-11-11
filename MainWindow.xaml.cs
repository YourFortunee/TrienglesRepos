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
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;


namespace TestingTriengles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           

        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            CheckBut.Visibility = Visibility.Visible;
            FirstSide.Visibility = Visibility.Visible;
            SecondSide.Visibility = Visibility.Visible;
            ThirdSide.Visibility = Visibility.Visible;
            InputBlock.Visibility = Visibility.Visible;
            CheckBut.IsEnabled = true;
            RestartBut.IsEnabled = false;
            Resultat.Visibility = Visibility.Hidden;
            RestartBut.Visibility = Visibility.Hidden;
            FirstSide.Text = string.Empty;
            SecondSide.Text = string.Empty;
            ThirdSide.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal a; //Проверим, чтобы у нас в текстбоксах были именно цифры
            if (decimal.TryParse(FirstSide.Text, out a))
            {
            }
            else
            {
                System.Windows.MessageBox.Show("Длина первой стороны должна быть указана в цифрах");
                FirstSide.Text = string.Empty;
                return;
            }
            decimal b;
            if (decimal.TryParse(SecondSide.Text, out b))
            {
            }
            else
            {
                System.Windows.MessageBox.Show("Длина второй стороны должна быть указана в цифрах");
                SecondSide.Text = string.Empty;
                return;
            }
            decimal c;
            if (decimal.TryParse(ThirdSide.Text, out c))
            {
            }
            else
            {
                System.Windows.MessageBox.Show("Длина третьей стороны должна быть указана в цифрах");
                ThirdSide.Text = string.Empty;
                return;
            }

            var First = FirstSide.Text;
            var Second = SecondSide.Text;
            var Third = ThirdSide.Text;
            string Result = "---";

            if ((Convert.ToDouble(First) + Convert.ToDouble(Second) < Convert.ToDouble(Third)) &&
               (Convert.ToDouble(Second) + Convert.ToDouble(Third) < Convert.ToDouble(First)) &&
                (Convert.ToDouble(First) + Convert.ToDouble(Third) < Convert.ToDouble(Second)))
                {
                System.Windows.MessageBox.Show("Вы точно уверены, что такой треугольник существует?");
                return;
            }
            else

            if (First == Second && Second == Third && First == Third) //Если все стороны равны...
            {
                //MessageBox.Show("Треугольник равносторонний");
                Result = "Треугольник равносторонний";
            }
            else if (First == Second || Second == Third || First == Third) //Если это не так, проверяем в парах
            {
                 //MessageBox.Show("Треугольник равнобедренный");
                Result = "Треугольник равнобедренный";
            }
            else //А если уж и попарно равных нет...
            {
                 //MessageBox.Show("Треугольник разносторонний");
                Result = "Треугольник разносторонний";
            }
            Resultat.Text = Result;
            CheckBut.Visibility = Visibility.Hidden;
            FirstSide.Visibility = Visibility.Hidden;
            SecondSide.Visibility = Visibility.Hidden; 
            ThirdSide.Visibility = Visibility.Hidden; 
            InputBlock.Visibility = Visibility.Hidden; 
            CheckBut.IsEnabled = false;
            RestartBut.IsEnabled = true;
            Resultat.Visibility = Visibility.Visible;
            RestartBut.Visibility = Visibility.Visible;
        }
    }
}
