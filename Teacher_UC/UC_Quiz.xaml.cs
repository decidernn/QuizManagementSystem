using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Логика взаимодействия для UC_Quiz.xaml
    /// </summary>
    public partial class UC_Quiz : UserControl
    {
        function fn = new function();
        Random rnd = new Random();
        int countAnsw = 0; //количество верных ответов (для итогового результата)
        int countQuestionsTotal; //количество вопросов в квесте
        int countQuestions = 0;
        int random; //для рандома
        int k;
        int a;
        int id;
        int[] answer; //массив ответов студента
        int answ;
        QuizManagementSytemEntities db = new QuizManagementSytemEntities();

        public UC_Quiz(int count, int id)
        {
            InitializeComponent();
            this.id = id;
            countQuestionsTotal = count;//задали количество вопросов в квесте
            answer = new int[countQuestionsTotal];
            random = rnd.Next(1, 12);
            setQuestion(random);
            a = countQuestions + 1;
            lblQuestionNumber.Content = "Вопрос: " + a + "/" + countQuestionsTotal;
            countAnsw += checkAnswer(answ, getButton());
            countQuestions++;
        }
        public void setQuestion(int number) //задаем новый вопрос, number - случайное число
        {
            String query;
            DataSet ds;

            query = "SELECT Question,OptionA,OptionB,OptionC,OptionD,Answer FROM Questions WHERE ID = '" + number + "'";
            ds = fn.getData(query);

            lblQuestion.Content = ds.Tables[0].Rows[0][0].ToString();
            rb1.Content = ds.Tables[0].Rows[0][1].ToString();
            rb2.Content = ds.Tables[0].Rows[0][2].ToString();
            rb3.Content = ds.Tables[0].Rows[0][3].ToString();
            rb4.Content = ds.Tables[0].Rows[0][4].ToString();
            answ = Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString());
        }

        public int getButton()
        {
            if (rb1.IsChecked == true)
            {
                k = 1;
            }
            if (rb2.IsChecked == true)
            {
                k = 2;
            }
            if (rb3.IsChecked == true)
            {
                k = 3;
            }
            if (rb4.IsChecked == true)
            {
                k = 4;
            }

            return k;
        }

        public int checkAnswer(int correctAnswer, int userAnser)
        {
            int a = correctAnswer;
            int b = userAnser;
            int count;
            if (a == b)
            {
                count = 1;
            } else
            {
                count = 0;
            }

            return count;
        }

        private void btnConfitrm_Click(object sender, RoutedEventArgs e)
        {
            if(countQuestions < countQuestionsTotal)
            {
                random = rnd.Next(1, 12);
                countAnsw += checkAnswer(answ, getButton());
                setQuestion(random);
                a = countQuestions + 1;
                lblQuestionNumber.Content = "Вопрос: " + a + "/" + countQuestionsTotal;
                countQuestions++;
                
                if(countQuestions == countQuestionsTotal)
                {
                    btnConfitrm.Content = "Завершить";
                }

            } else
            {
                countAnsw += checkAnswer(answ, getButton());
                if(MessageBox.Show("Вы уверены что хотите завершить тест?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Result r = new Result();
                    r.IDQuestions = 1;
                    r.MarkObtained = countAnsw;
                    r.CountQuestions = countQuestionsTotal;
                    db.Result.Add(r);
                    db.SaveChanges();

                    string query = "SELECT MAX(ID) FROM Result";
                    DataSet ds = fn.getData(query);
                    int idres = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                    LearnerResult st = new LearnerResult();
                    st.IDLearner = id;
                    st.IDResult = idres;
                    db.LearnerResult.Add(st);
                    db.SaveChanges();

                    ResultPage rp = new ResultPage(countAnsw, countQuestionsTotal);
                    Manager.MainFrame.Navigate(rp);
                }
            }
        }
    }
}
