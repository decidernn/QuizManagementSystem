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
using QuizManagement.Teacher_UC;

namespace QuizManagement
{
    /// <summary>
    /// Логика взаимодействия для Teacher.xaml
    /// </summary>
    public partial class TeacherPage : Page
    {
        public TeacherPage()
        {
            InitializeComponent();
        }

        private void btnAddNewQuestion_Click(object sender, RoutedEventArgs e)
        {
            UC_AddNewQuestion usercontrol1 = new UC_AddNewQuestion();
            mainGrid.Children.Add(usercontrol1);
        }

        private void btnUpdateQuestions_Click(object sender, RoutedEventArgs e)
        {
            UC_UpdateQuestion usercontrol2 = new UC_UpdateQuestion();
            mainGrid.Children.Add(usercontrol2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UC_ViewDeleteQuestion usercontrol3 = new UC_ViewDeleteQuestion();
            mainGrid.Children.Add(usercontrol3);
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Вы уверены что хотите выйти?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                LoginPage lp = new LoginPage();
                Manager.MainFrame.Navigate(lp);
            }
        }

        private void btnAllStudentResult_Click(object sender, RoutedEventArgs e)
        {
            UC_AllStudentResult usercontrol4 = new UC_AllStudentResult();
            mainGrid.Children.Add(usercontrol4);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            Manager.MainFrame.Navigate(lp);
        }

        private void btnStudentAccs_Click(object sender, RoutedEventArgs e)
        {
            UC_StudentAccs usercontrol5 = new UC_StudentAccs();
            mainGrid.Children.Add(usercontrol5);
        }
    }
}
