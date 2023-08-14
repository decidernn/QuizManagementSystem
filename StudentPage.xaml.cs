using QuizManagement.Teacher_UC;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace QuizManagement
{
    /// <summary>
    /// Логика взаимодействия для StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        int id;
        public StudentPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btn5question_Click(object sender, RoutedEventArgs e)
        {
            UC_Quiz usercontrol1 = new UC_Quiz(5, id);
            mainGrid.Children.Add(usercontrol1);
        }

        private void btn10question_Click(object sender, RoutedEventArgs e)
        {
            UC_Quiz usercontrol1 = new UC_Quiz(10, id);
            mainGrid.Children.Add(usercontrol1);
        }

        private void btn15question_Click(object sender, RoutedEventArgs e)
        {
            UC_Quiz usercontrol1 = new UC_Quiz(15, id);
            mainGrid.Children.Add(usercontrol1);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            Manager.MainFrame.Navigate(lp);
        }
    }
}
