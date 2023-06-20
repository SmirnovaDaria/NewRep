using OrganizationEvent.Pages;
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

namespace OrganizationEvent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MyFrame;
        public static Button ParButton;
        public static Button JurButton;
        public static Button OrgButton;
        public static Button ModButton;
        public static Button EntButton;
        public MainWindow()
        {
            InitializeComponent();
            EntButton = EnterBtn;
            ParButton = ParBtn;
            JurButton = JurBtn;
            OrgButton = OrgBtn;
            ModButton = ModBtn;
            ParBtn.Visibility = Visibility.Collapsed;
            OrgBtn.Visibility = Visibility.Collapsed;
            ModBtn.Visibility = Visibility.Collapsed;
            JurBtn.Visibility = Visibility.Collapsed;
            MyFrame = MainFrame;
        }

        private void EnterButton(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AutorizationPage();
        }

        private void EvBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new EventPage();
        }

        private void ParBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ParticipantPage();
        }

        private void JurBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new JuryPage();
        }

        private void OrgBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new OrganizerPage();
        }

        private void ModBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ModeratorPage();
        }
    }
}
