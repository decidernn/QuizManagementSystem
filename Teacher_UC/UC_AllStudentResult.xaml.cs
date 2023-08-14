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
    /// Логика взаимодействия для UC_AllStudentResult.xaml
    /// </summary>
    public partial class UC_AllStudentResult : UserControl
    {
        public List<Learner> Learners { get; set; }
        public List<Result> Results { get; set; }
        public List<LearnerResult> LearnerResults { get; set; }


        public UC_AllStudentResult()
        {
            InitializeComponent();

            var query = from LearnerResult in QuizManagementSytemEntities.GetContext().LearnerResult
                        join Learner in QuizManagementSytemEntities.GetContext().Learner
                        on LearnerResult.IDLearner equals Learner.ID
                        join Result in QuizManagementSytemEntities.GetContext().Result
                        on LearnerResult.IDResult equals Result.ID
                        select new { Result.ID, Learner.LearnerSurname, Learner.LearnerName, Result.MarkObtained, Result.CountQuestions };

            dataGrid1.ItemsSource = query.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            TeacherPage tp = new TeacherPage();
            Manager.MainFrame.Navigate(tp);
        }
    }
}
