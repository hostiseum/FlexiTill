using FlexiTill.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
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

        ObservableCollection<Item> PurchasedItems = new ObservableCollection<Item>();

        string[] pageNames = { "NumbersPage", "ArticleKeysPage", "BakeryServicesPageOne", "BakeryServicesPageTwo", "BreadRollPage", "WrapsPage", "TeaCakesPage", "CakesPage", "TraditionalToastingPage", "LotteryPage", "CardsPGone", "CardsPGtwo", "DepartmentsPage", "EntertainmentPGone", "CDsDvdsBooksPGtwo", "BatteriesCamerasPG", "AudioVisualCompPG", "MobilePhonePG", "MagazinesNewspapersPG", "StampsPG", "PartiesOccasionPG", "OfficeArtCraftsPG", "PayZoonPGone", "ETopUpPGOne", "ETopUpPGtwo", "ETopUpPGthree", "ETopUpPGfour", "PickMixPGone", "PickMixPGtwo", "PickMixPGthree", "PickMixPGfour", "PickMixPGfive", "MoreFunctionPGone", "MoreMOPsPGone", "OutsideSalesPGone", "FruitVegPGone" };
        public MainWindow()
        {
            InitializeComponent();

            List<Item> items = new List<Item>();
            PurchasedItems.Add(new Item() { ItemId = 1, ItemName = "Colgate", Price = 23.5F , Quantity = 2});
            PurchasedItems.Add(new Item() { ItemId = 2, ItemName = "Nuts", Price = 23.5F, Quantity = 1 });
            PurchasedItems.Add(new Item() { ItemId = 3, ItemName = "Vegetables", Price = 23.5F, Quantity =3 });
            PurchasedItems.Add(new Item() { ItemId = 4, ItemName = "Colgate", Price = 23.5F, Quantity = 4 });

            ItemsPurchasedView.ItemsSource = PurchasedItems;

            UserName.Text = WindowsIdentity.GetCurrent().Name;
        }



        private void btnArticleKeys_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("ArticleKeysPage");
            
            ////Navigation.Text += "ArticleKeys";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ShowPage("NumbersPage");
        }

        private void BakeryServices_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("BakeryServicesPageOne");

            //Navigation.Text += ">> Bakery Services";
        }

        private void Bread_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("BakeryServicesPageTwo");

            //Navigation.Text += ">> Bread";
        }

        private void BreadRoll_Click(object sender, RoutedEventArgs e)
        {

            ShowPage("BreadRollPage");
           // BreadRollPage.Visibility = Visibility.Visible;

            //Navigation.Text += ">> BreadRoll";
        }

        private void WPN_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("WrapsPage");
            //WrapsPage.Visibility = Visibility.Visible;

            //Navigation.Text += ">> Wraps, Pitta and Naan";
        }

        private void CBP_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("CrossiantsPage");
           // CrossiantsPage.Visibility = Visibility.Visible;

            //Navigation.Text += ">> Crossiants Brioche, Pastries ";
        }

        private void TToast_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("TraditionalToastingPage");

            //Navigation.Text += ">> Traditional Toasting ";
        }

        private void CakesPies_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("CakesPage");

            //Navigation.Text += ">> Cake and Pies ";
        }

        //private void FreshBakery_Click(object sender, RoutedEventArgs e)
        //{
        //    ArticleKeys.Visibility = Visibility.Collapsed;
        //    Numbers.Visibility = Visibility.Collapsed;
        //    BakeryServicesPageOne.Visibility = Visibility.Collapsed;
        //    BakeryServicesPageTwo.Visibility = Visibility.Collapsed;
        //    FreshBakeryP.Visibility = Visibility.Visible;

        //    //Navigation.Text += ">> Traditional Toasting ";
        //}

        private void SpecialistBakery_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("SpecialistBakery");

            //Navigation.Text += ">> Traditional Toasting ";
        }

        private void TFS_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("TeaCakesPage");

            //Navigation.Text += ">> Tea Cakes";
        }

        private void Wraps_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("WrapsPage");

            //Navigation.Text += ">> xx Toasting ";

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

        private void btnMoreMops_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("MoreMOPsPGone");
            //Navigation.Text += "MoreMOPsPGone";

        }

        private void btn_MoreFunction_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("MoreFunctionPGone");
            //Navigation.Text += "MoreFunctionPGone Page";

        }

        private void PickAndMix_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("PickMixPGone");
            //Navigation.Text += "PickMixPGone";
        }

        private void OutsideSale_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("OutsideSalesPGone");
            //Navigation.Text += "OutsideSalesPGone";

        }

        private void FruitAndVeg_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("FruitVegPGone");
            //Navigation.Text += ">> Wraps, Pitta and Naan";

        }

        private void Department_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("DepartmentsPage");
            //Navigation.Text += "Departments Page";

        }


        private void PayZone_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("PayZoonPGone");
            //Navigation.Text += "PayZoonPGone";

        }

        private void ETopUP_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("ETopUpPGOne");
            //Navigation.Text += "ETopUpPGOne";

        }

        private void cdDvsBook_Click(object sender, RoutedEventArgs e)
        {

            ShowPage("CDsDvdsBooksPGtwo");
            //Navigation.Text += "CDsDvdsBooksPGtwo";

        }

        private void BatteriesCamera_Click(object sender, RoutedEventArgs e)
        {
            // "AudioVisualCompPG", "MobilePhonePG", "MagazinesNewspapersPG", "StampsPG", "PartiesOccasionPG", "OfficeArtCraftsPG"

            ShowPage("BatteriesCamerasPG");
            //Navigation.Text += "BatteriesCamerasPG";
        }

        private void AudioVisualComputing_Click(object sender, RoutedEventArgs e)
        {


            ShowPage("AudioVisualCompPG");
            //Navigation.Text += "AudioVisualCompPG";

        }

        private void MobilePhoneAccessories_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("MobilePhonePG");
            //Navigation.Text += "MobilePhonePG";

        }

        private void MagazinesNewspapers_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("MagazinesNewspapersPG");
            //Navigation.Text += "MagazinesNewspapersPG";

        }

        private void Stamps_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("StampsPG");
            //Navigation.Text += "StampsPG";

        }

        private void PartiesOccasions_Click(object sender, RoutedEventArgs e)
        {

            ShowPage("PartiesOccasionPG");
            //Navigation.Text += "PartiesOccasionPG";
        }

        private void OfficeArtCrafts_Click(object sender, RoutedEventArgs e)
        {

            ShowPage("OfficeArtCraftsPG");
            //Navigation.Text += "OfficeArtCraftsPG";

        }

        private void TightsStockings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CarCare_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DIY_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ValentinesDays_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Toys_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BKEntertainment_Click(object sender, RoutedEventArgs e)
        {

            //  "BakeryServicesPageTwo", "BreadRollPage", "WrapsPage", "TeaCakesPage", "CakesPage", "TraditionalToastingPage", "LotteryPage", "CardsPGone", "CardsPGtwo" , "DepartmentsPage" , "EntertainmentPGone" , "CDsDvdsBooksPGtwo", "BatteriesCamerasPG", "AudioVisualCompPG", "MobilePhonePG", "MagazinesNewspapersPG", "StampsPG", "PartiesOccasionPG", "OfficeArtCraftsPG"
        }

        private void NextPGcardA_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("CardsPGtwo");
            //Navigation.Text += "Cards";
        }

        private void BackPGcardA_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("CardsPGone");
            //Navigation.Text += "Cards";

        }

        private void ArticlePGcard_Click(object sender, RoutedEventArgs e)
        {
            ShowPage("ArticleKeysPage");
            //Navigation.Text += "Article Page";

        }
        private void ShowPage(string pageName)
        {

           /* foreach(string page in pageNames)
            {
                if (page != pageName)
                    (this.FindName(page) as StackPanel).Visibility = Visibility.Collapsed;
            }

            ArticleKeysPage.Visibility = Visibility.Visible;
             (this.FindName(pageName) as StackPanel).Visibility = Visibility.Visible;
  */
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            QuantityWindow inputDialog = new QuantityWindow(PurchasedItems[0]);
            if (inputDialog.ShowDialog() == true)
            {
                PurchasedItems[0] = inputDialog.ItemWithQuantity;
                ItemsPurchasedView.ItemsSource = PurchasedItems;
                
            }
                
        }
    }
}