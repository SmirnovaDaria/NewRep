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

namespace OrganizationEvent.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.EntButton.Content == "Вход")
            {
                bool isOk = false;
                var login = LoginTB.Text;
                var password = PasswordB.Password;
                var DBparticipant = ContextDB.GetContext().Participant.ToList();
                foreach (var item in DBparticipant)
                {
                    if (login == item.ID.ToString() && password == item.Password)
                    {
                        MainWindow.MyFrame.Content = new ParticipantPage();
                        isOk = true;
                        MainWindow.ParButton.Visibility = Visibility.Visible;
                    }
                }
                var DBjury = ContextDB.GetContext().Jury.ToList();
                foreach (var item in DBjury)
                {
                    if (login == item.ID.ToString() && password == item.Password)
                    {
                        MainWindow.MyFrame.Content = new JuryPage();
                        isOk = true;
                        MainWindow.JurButton.Visibility = Visibility.Visible;
                    }
                }
                var DBorganizer = ContextDB.GetContext().Organizer.ToList();
                foreach (var item in DBorganizer)
                {
                    if (login == item.ID.ToString() && password == item.Password)
                    {
                        MainWindow.MyFrame.Content = new OrganizerPage();
                        isOk = true;
                        MainWindow.OrgButton.Visibility = Visibility.Visible;
                    }
                }
                if (isOk == false)
                {
                    MessageBox.Show("Не верный логин или пароль");
                }
                else
                {
                    MainWindow.EntButton.Content = "Выйти";
                }
            }
            else
            {
                MainWindow.EntButton.Content = "Вход";
            }
        }
    }
}
