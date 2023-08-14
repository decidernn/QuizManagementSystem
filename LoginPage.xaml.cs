using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

//чтобы текст был по центру

namespace QuizManagement
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        QuizManagementSytemEntities db = new QuizManagementSytemEntities();
        function fn = new function();
        public LoginPage()
        {
            InitializeComponent();

            comboBoxSelectUser.Items.Add("Студент");
            comboBoxSelectUser.Items.Add("Преподаватель");

            GridStudent.Visibility = Visibility.Hidden;
            GridTeacher.Visibility = Visibility.Hidden;
        }

        private void comboBoxSelectUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBoxSelectUser.SelectedIndex == 0) { 
                GridStudent.Visibility = Visibility.Visible;
                GridTeacher.Visibility= Visibility.Hidden;
            } else if (comboBoxSelectUser.SelectedIndex == 1)
            {
                GridStudent.Visibility = Visibility.Hidden;
                GridTeacher.Visibility = Visibility.Visible;
            }
        }

        private void checkBoxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            passwordTxtBox.Text = txtPassword.Password;
            txtPassword.Visibility = Visibility.Collapsed;
            passwordTxtBox.Visibility = Visibility.Visible;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

             if (string.IsNullOrEmpty(txtUsername.Text))
             {
                errors.AppendLine("Введите логин!");
             }
             if (string.IsNullOrWhiteSpace(txtPassword.Password))
             {
                errors.AppendLine("Введите пароль!");
             }

             if (errors.Length > 0)
             {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
             }

             var account = db.Organizer.AsNoTracking().FirstOrDefault(a => a.OrganizerLogin == txtUsername.Text && a.OrganizerPassword == txtPassword.Password);

            if(account == null)
            {
                MessageBox.Show("Пользователь с такими данными не найден!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

             MessageBox.Show("Вы успешно авторизировались как преподаватель!", "Внимание!");

             TeacherPage tp = new TeacherPage();
             Manager.MainFrame.Navigate(tp);
        }

        private void btnRegStudent_Click(object sender, RoutedEventArgs e)
        {
            StudentReg studentReg = new StudentReg();
            Manager.MainFrame.Navigate(studentReg);
        }

        private void btnLoginStudent_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxSelectUser.SelectedIndex == 0)
            {
                StringBuilder errors = new StringBuilder();

                if (string.IsNullOrEmpty(txtUsernameStudent.Text))
                {
                    errors.AppendLine("Введите логин!");
                }
                if (string.IsNullOrWhiteSpace(txtPasswordStudent.Password))
                {
                    errors.AppendLine("Введите пароль!");
                }

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                var account = db.Learner.AsNoTracking().FirstOrDefault(a => a.LearnerLogin == txtUsernameStudent.Text && a.LearnerPassword == txtPasswordStudent.Password);

                if (account == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                MessageBox.Show("Вы успешно авторизировались как студент!", "Внимание!");

                string query = "SELECT ID FROM Learner WHERE LearnerLogin = '" + txtUsernameStudent.Text + "'";
                DataSet ds = fn.getData(query);
                int id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                StudentPage tp = new StudentPage(id);
                Manager.MainFrame.Navigate(tp);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs s)
        {
            MainWindow mainWindow= new MainWindow();
            Manager.MainFrame.Navigate(mainWindow);
        }

        private void checkBoxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = passwordTxtBox.Text;
            passwordTxtBox.Visibility = Visibility.Collapsed;
            txtPassword.Visibility = Visibility.Visible;
        }
    }
}
