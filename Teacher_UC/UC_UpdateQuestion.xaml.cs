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
    /// Логика взаимодействия для UC_UpdateQuestion.xaml
    /// </summary>
    public partial class UC_UpdateQuestion : UserControl
    {
        function fn = new function();
        String query;
        String queryID;
        int getID;
        QuizManagementSytemEntities db = new QuizManagementSytemEntities();
        public UC_UpdateQuestion()
        {
            InitializeComponent();

            query = "SELECT distinct QNO FROM Questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboQuestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            query = "select Question,OptionA,OptionB,OptionC,OptionD,Answer FROM Questions WHERE QNO = '"+comboQuestion.SelectedValue+"'";

            DataSet ds = fn.getData(query);

            txtQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            txtOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            txtOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            txtOption4.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][5].ToString();

            queryID = "SELECT ID FROM Questions WHERE QNO = '" + comboQuestion.SelectedValue + "'";

            DataSet dss = fn.getData(queryID);

            getID = Convert.ToInt32(dss.Tables[0].Rows[0][0]);

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
            //comboQuestion.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(comboQuestion.SelectedIndex != -1) 
            {
                query = "UPDATE Questions SET Question = '" + txtQuestion.Text + "', OptionA = '" + txtOption1.Text + "',  OptionB = '" + txtOption2.Text + "',  OptionC = '" + txtOption3.Text + "',  OptionD = '" + txtOption4.Text + "', Answer = '" + txtAnswer.Text + "' WHERE ID = '" + getID + "'";
                fn.setData(query, "Question updated");

            } else
            {
                MessageBox.Show("Сначала выберите вопрос!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            TeacherPage tp = new TeacherPage();
            Manager.MainFrame.Navigate(tp);
        }
    }
}
