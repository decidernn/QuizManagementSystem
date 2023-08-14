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
    /// Логика взаимодействия для StudentReg.xaml
    /// </summary>
    public partial class StudentReg : Page
    {
        public StudentReg()
        {
            InitializeComponent();
        }

        private void btnRegStudent_Click(object sender, RoutedEventArgs e)
        {
            QuizManagementSytemEntities db = new QuizManagementSytemEntities();
            Learner learner = new Learner();

            learner.LearnerName = txtName.Text;
            learner.LearnerSurname = txtSurname.Text;
            learner.LearnerAge = Convert.ToInt32(txtAge.Text);
            learner.LearnerLogin = txtLogin.Text;
            learner.LearnerPassword = txtPassword.Password;

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                errors.AppendLine("Необходимо указать логин");
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                errors.AppendLine("Необходимо указать пароль");
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errors.AppendLine("Необходимо указать имя");
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errors.AppendLine("Необходимо указать фамилию");
            }
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                errors.AppendLine("Необходимо указать возраст");
            }
            if(txtPassword.Password.Length < 8)
            {
                errors.AppendLine("Пароль должен содержать минимум 8 символов");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
            }
            else
            {
                db.Learner.Add(learner);
                db.SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован!");
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            Manager.MainFrame.Navigate(lp);
        }
    }
}
