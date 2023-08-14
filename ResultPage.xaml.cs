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

namespace QuizManagement
{
    /// <summary>
    /// Логика взаимодействия для ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage(int countAnsw, int countQuestionsTotal)
        {
            InitializeComponent();
            lblQuestionRes.Content = "Верных ответов - " + countAnsw;
            lblQuestionTotal.Content = "Всего вопросов - " + countQuestionsTotal;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            Manager.MainFrame.Navigate(lp);
        }
    }
}
