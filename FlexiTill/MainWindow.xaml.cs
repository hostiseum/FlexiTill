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

namespace FlexiTill
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] pageNames = { "NumbersPage", "ArticleKeysPage", "BakeryServicesPageOne", "BakeryServicesPageTwo", "BreadRollPage", "WrapsPage", "TeaCakesPage", "CakesPage", "TraditionalToastingPage", "LotteryPage", "FruitVegPage", "EntertainmentPage", "DepartmentsPage", "CardsPage" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnArticleKeys_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("ArticleKeysPage");
            
            Navigation.Text += "ArticleKeys";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ShowPage("NumbersPage");
        }

        private void BakeryServices_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("BakeryServicesPageOne");

            Navigation.Text += ">> Bakery Services";
        }

        private void Bread_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("BakeryServicesPageTwo");

            Navigation.Text += ">> Bread";
        }

        private void BreadRoll_Click(object sender, RoutedEventArgs e)
        {

            ShowPage("BreadRollPage");
            BreadRollPage.Visibility = Visibility.Visible;

            Navigation.Text += ">> BreadRoll";
        }

        private void WPN_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("WrapsPage");
            WrapsPage.Visibility = Visibility.Visible;

            Navigation.Text += ">> Wraps, Pitta and Naan";
        }

        private void CBP_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("CrossiantsPage");
            CrossiantsPage.Visibility = Visibility.Visible;

            Navigation.Text += ">> Crossiants Brioche, Pastries ";
        }

        private void TToast_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("TraditionalToastingPage");

            Navigation.Text += ">> Traditional Toasting ";
        }

        private void CakesPies_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("CakesPage");

            Navigation.Text += ">> Cake and Pies ";
        }

        //private void FreshBakery_Click(object sender, RoutedEventArgs e)
        //{
        //    ArticleKeys.Visibility = Visibility.Collapsed;
        //    Numbers.Visibility = Visibility.Collapsed;
        //    BakeryServicesPageOne.Visibility = Visibility.Collapsed;
        //    BakeryServicesPageTwo.Visibility = Visibility.Collapsed;
        //    FreshBakeryP.Visibility = Visibility.Visible;

        //    Navigation.Text += ">> Traditional Toasting ";
        //}

        private void SpecialistBakery_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("SpecialistBakery");

            Navigation.Text += ">> Traditional Toasting ";
        }

        private void TFS_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("TeaCakesPage");

            Navigation.Text += ">> Tea Cakes";
        }

        private void Wraps_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("WrapsPage");

            Navigation.Text += ">> xx Toasting ";

        }

        private void Pitta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Naan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Crossiants_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BakeryS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CrMuPa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TCFLS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CelebrationCake_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SmallCakes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrganicCake_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CakeSlices_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SeasonalCakes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FruitPie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HealthierCake_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FlapJack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SweetTreats_Click(object sender, RoutedEventArgs e)
        {

        }

      
        private void ShowPage(string pageName)
        {

            foreach(string page in pageNames)
            {
                if (page != pageName)
                    (this.FindName(page) as StackPanel).Visibility = Visibility.Collapsed;
            }

            //ArticleKeysPage.Visibility = Visibility.Visible;
             (this.FindName(pageName) as StackPanel).Visibility = Visibility.Visible;
        }

    }
}