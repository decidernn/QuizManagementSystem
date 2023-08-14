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

namespace QuizManagement.Teacher_UC
{
    /// <summary>
    /// Логика взаимодействия для UC_AddNewQuestion.xaml
    /// </summary>
    public partial class UC_AddNewQuestion : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 questionNo = 1;
        public UC_AddNewQuestion()
        {
            InitializeComponent();

            query = "select max(QSET) from Questions";
            ds = fn.getData(query);

            if ((ds.Tables[0].Rows.Count != 0) && (ds.Tables[0].Rows[0][0].ToString()!=""))
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtSet.Text = (id + 2).ToString();
            } else
            {
                txtSet.Text = "1";
            }

            questionLabel.Content = questionNo.ToString();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(txtQuestion.Text))
            {
                errors.AppendLine("Введите вопрос!");
            }
            if (string.IsNullOrWhiteSpace(txtOption1.Text))
            {
                errors.AppendLine("Введите вариант 1!");
            }
            if (string.IsNullOrWhiteSpace(txtOption2.Text))
            {
                errors.AppendLine("Введите вариант 2!");
            }
            if (string.IsNullOrWhiteSpace(txtOption3.Text))
            {
                errors.AppendLine("Введите вариант 3!");
            }
            if (string.IsNullOrWhiteSpace(txtOption4.Text))
            {
                errors.AppendLine("Введите вариант 4!");
            }
            if (string.IsNullOrWhiteSpace(txtAnsw.Text))
            {
                errors.AppendLine("Введите ответ!");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            int q = Convert.ToInt32(questionLabel.Content) + 1;
            String qset = txtSet.Text;
            String qNo = q.ToString();
            String question = txtQuestion.Text;
            String option1 = txtOption1.Text;
            String option2 = txtOption2.Text;
            String option3 = txtOption3.Text;
            String option4 = txtOption4.Text;
            String answ = txtAnsw.Text;

            query = "insert into Questions (QSET,QNO,Question,OptionA,OptionB,OptionC,OptionD,Answer) values ('" + qset + "','" + qNo + "','" + question + "','" + option1 + "','" + option2 + "','" + option3 + "','" + option4 + "','" + answ + "')";
            fn.setData(query, "Вопрос добавлен!");
            //clearAll();
            questionNo++;
            questionLabel.Content = questionNo.ToString();
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnsw.Clear();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Несохраненные данные будут утеряны!", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                clearAll();
            }
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Set will be Changed.", "Warming", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                txtSet.Text = (Int64.Parse(txtSet.Text.ToString()) + 1).ToString();
                questionLabel.Content = "1";
            }
        }

        private void txtSet_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtSet.Text != "")
            {
                query = "select QNO from Questions WHERE QSET = '"+txtSet.Text+"'";
                ds = fn.getData(query);

                if ((ds.Tables[0].Rows.Count != 0) && (ds.Tables[0].Rows[0][0].ToString() != ""))
                {
                    questionLabel.Content = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(questionLabel.Content.ToString());
                } else
                {
                    questionLabel.Content = "1";
                    questionNo = Int64.Parse(questionLabel.Content.ToString());
                }
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            TeacherPage tp = new TeacherPage();
            Manager.MainFrame.Navigate(tp);
        }
    }
}
