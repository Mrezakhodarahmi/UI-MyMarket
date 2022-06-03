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

namespace uii_foroshgah.UserControls
{
    /// <summary>
    /// Interaction logic for ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(string ProductName,int ProductRate,string ProductPrice,string ProductDiscount)
        {
            InitializeComponent();
            ProductNameTextBlock.Text = ProductName;
            ProductRatingBar.Value = ProductRate;
            productPriceTextBlock.Text = ProductPrice;
            ProductDiscountTextBlock.Text = ProductDiscount;
        }

        private void Buy1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
