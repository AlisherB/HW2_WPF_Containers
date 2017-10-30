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

namespace HW2_WPF_Containers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randX = new Random();
        Random randY = new Random();
        private int posX, posY, posZ;
        private int beginX = 10, beginY = 10, endX = 260,  endY = 110;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("А я тебе не верю.");
        }

        private void NoButton_MouseMove(object sender, MouseEventArgs e)
        {
            posX = (int)(noButton.Margin.Left - noButton.Width);
            posY = (int)(noButton.Margin.Top - noButton.Width);
            posZ = (int)(noButton.Margin.Left + noButton.Width);

            if (CheckPosition(e))
            {
                noButton.Margin = new Thickness(Convert.ToDouble(randX.Next(beginX, endX)),
                                                Convert.ToDouble(randY.Next(beginY, endY)), 0, 0);
            }
        }
        
        private bool CheckPosition(MouseEventArgs e)
        {
            if (e.GetPosition(null).X >= posX && e.GetPosition(null).X <= posZ)
            {
                if (e.GetPosition(null).Y >= posY)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
