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
using uii_foroshgah.UserControls;

namespace uii_foroshgah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddProduct();
        }

        private void Nextbtn_Click(object sender, RoutedEventArgs e)
        {
            FirstSignUPPage.Visibility = Visibility.Collapsed;
            Second_SignUpPage.Visibility = Visibility.Visible;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = FirstNameTextBox.Text;
            string LastName = LastNameTextBox.Text;
            string PhoneNumber = PhoneNumberTextBox.Text;
            string UserName = UserNameTextBox.Text;
            string Password = PasswordBox.Password;
            string ConfirimPassword = ConfirimPasswordBox.Password;
            Second_SignUpPage.Visibility = Visibility.Collapsed;
            MainPanel.Visibility = Visibility.Visible;
        }
        
        void AddProduct()
        {
            for(int i=0;i<2;i++)
            {
                var Product = new ProductUserControl("پردازنده", i * 2,Convert.ToString((i+1)*150000),"35%") ;
                ProductWrapPanel.Children.Add(Product);
            }
        }
        void CartAddProduct()
        {
            var Cart = new CartUserControl();
            CartWrapPanel.Children.Add(Cart);
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Second_SignUpPage.Visibility = Visibility.Collapsed;
            FirstSignUPPage.Visibility = Visibility.Visible;
        }

        private void BackContact_Click(object sender, RoutedEventArgs e)
        {
            MainPanel.Visibility = Visibility.Visible;
            ContactPage.Visibility = Visibility.Collapsed;
        }

        private void ManagmentItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CartItem_Click(object sender, RoutedEventArgs e)
        {
            MainPanel.Visibility = Visibility.Collapsed;
            CartPanel.Visibility = Visibility.Visible;
        }

        private void ContactItem_Click(object sender, RoutedEventArgs e)
        {
            MainPanel.Visibility = Visibility.Collapsed;
            ContactPage.Visibility = Visibility.Visible;
        }

        private void GoToSignUpPage_Click(object sender, RoutedEventArgs e)
        {
            SignInPage.Visibility = Visibility.Collapsed;
            FirstSignUPPage.Visibility = Visibility.Visible;

        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            SignInPage.Visibility = Visibility.Collapsed;
            MainPanel.Visibility = Visibility.Visible;
        }

        private void BackToSignIn_Click(object sender, RoutedEventArgs e)
        {
            FirstSignUPPage.Visibility = Visibility.Collapsed;
            SignInPage.Visibility = Visibility.Visible;
        }

        private void cpu_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            cpu.Visibility = Visibility.Collapsed;
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            CartAddProduct();
        }

        private void FinalCartBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("خرید شما نهایی شد " +
                "مرسی از خرید شما");
        }

        private void CartBackBtn_Click(object sender, RoutedEventArgs e)
        {
            CartPanel.Visibility = Visibility.Collapsed;
            MainPanel.Visibility = Visibility.Visible;
        }

        private void LogOutItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("به امید دیدار مجدد");
            CartPanel.Visibility = Visibility.Collapsed;
            SignInPage.Visibility = Visibility.Visible;
        }

        private void logOutt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("به امید دیدار مجدد");
            MainPanel.Visibility = Visibility.Collapsed;
            SignInPage.Visibility = Visibility.Visible;
        }
    }
}
