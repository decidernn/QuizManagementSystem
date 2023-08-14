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
    /// Логика взаимодействия для UC_ViewDeleteQuestion.xaml
    /// </summary>
    public partial class UC_ViewDeleteQuestion : UserControl
    {
        public List<Questions> questions { get; set; }
        function fn = new function();
        String query;

        public UC_ViewDeleteQuestion()
        {
            InitializeComponent();

            comboSet.Items.Clear();
            comboSet.Items.Add("All Questions");
            
            query = "select distinct QSET from Questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            dataGrid1.ItemsSource = QuizManagementSytemEntities.GetContext().Questions.ToList();
        }

        private void comboSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(comboSet.SelectedIndex != 0)
            {
                query = "select ID,QNO,Question,OptionA,OptionB,OptionC,OptionD,Answer from Questions where QSET = '"+comboSet.Text +"'";
                DataSet ds = fn.getData(query);
                dataGrid1.DataContext = ds.Tables[0];
            } else
            {
                
                query = "select ID,QNO,Question,OptionA,OptionB,OptionC,OptionD,Answer from Questions";
                DataSet ds = fn.getData(query);
                dataGrid1.DataContext = ds.Tables[0];
                
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var removing = dataGrid1.SelectedItems.Cast<Questions>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {removing.Count} элемент(а)?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    QuizManagementSytemEntities.GetContext().Questions.RemoveRange(removing);
                    QuizManagementSytemEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dataGrid1.ItemsSource = QuizManagementSytemEntities.GetContext().Questions.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

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
