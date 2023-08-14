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

namespace QuizManagement.Teacher_UC
{
    /// <summary>
    /// Логика взаимодействия для UC_StudentAccs.xaml
    /// </summary>
    public partial class UC_StudentAccs : UserControl
    {
        public UC_StudentAccs()
        {
            InitializeComponent();

            var query = from Learner in QuizManagementSytemEntities.GetContext().Learner
                        select new { Learner.ID, Learner.LearnerSurname, Learner.LearnerName, Learner.LearnerAge, Learner.LearnerLogin, Learner.LearnerPassword };

            dataGrid1.ItemsSource = query.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            TeacherPage tp = new TeacherPage();
            Manager.MainFrame.Navigate(tp);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
