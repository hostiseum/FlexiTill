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
using System.Windows.Shapes;

namespace FlexiTill.Dialogs
{
    /// <summary>
    /// Interaction logic for QuantityWindow.xaml
    /// </summary>
    public partial class QuantityWindow : Window
    {
       

        public QuantityWindow()
        {
            InitializeComponent();
            
        }



        public QuantityWindow(Item i)
        {
            DataContext = this;
            InitializeComponent();
            ItemWithQuantity = i;
            DataContext = ItemWithQuantity;


        }


        public Item ItemWithQuantity
        {
            set;

            get;
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
