using Xamarin.Forms;

namespace DesignYourOwnWeddingDress
{
    public partial class DesignYourOwnWeddingDressPage : MasterDetailPage
    {
        public DesignYourOwnWeddingDressPage()
        {
            InitializeComponent();


            Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };

            //Attaching Gesture Recognizers to Button pngs and then change to inverse.
            var BtnHomeRecognizer = new TapGestureRecognizer();
            BtnHomeRecognizer.Tapped += tapImage_TappedHome;
            BtnHome.GestureRecognizers.Add(BtnHomeRecognizer);
            void tapImage_TappedHome(object sender, System.EventArgs e)
            {
                Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                BtnHome.Source = "1-Homepage-invert.png";
                BtnDressDesigner.Source = "2-Designer.png";
                BtnStockistFinder.Source = "3-Stockist.png";
                BtnCurrentCollection.Source = "4-CurrentCollection.png";
                BtnNewCollection.Source = "5-NewCollection.png";
                BtnMyDresses.Source = "6-MyDresses.png";
                BtnContact.Source = "7-Contact.png";

            }

            var BtnDesignerRecognizer = new TapGestureRecognizer();
            BtnDesignerRecognizer.Tapped += tapImage_TappedDesigner;
            BtnDressDesigner.GestureRecognizers.Add(BtnDesignerRecognizer);
            void tapImage_TappedDesigner(object sender, System.EventArgs e)
            {
                Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                BtnHome.Source = "1-Homepage.png";
                BtnDressDesigner.Source = "2-Designer-invert.png";
                BtnStockistFinder.Source = "3-Stockist.png";
                BtnCurrentCollection.Source = "4-CurrentCollection.png";
                BtnNewCollection.Source = "5-NewCollection.png";
                BtnMyDresses.Source = "6-MyDresses.png";
                BtnContact.Source = "7-Contact.png";

            }

            var BtnStockistRecognizer = new TapGestureRecognizer();
            BtnStockistRecognizer.Tapped += tapImage_TappedStockist;
            BtnStockistFinder.GestureRecognizers.Add(BtnStockistRecognizer);
            void tapImage_TappedStockist(object sender, System.EventArgs e)
            {
                Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                BtnHome.Source = "1-Homepage.png";
                BtnDressDesigner.Source = "2-Designer";
                BtnStockistFinder.Source = "3-Stockist-invert.png";
                BtnCurrentCollection.Source = "4-CurrentCollection.png";
                BtnNewCollection.Source = "5-NewCollection.png";
                BtnMyDresses.Source = "6-MyDresses.png";
                BtnContact.Source = "7-Contact.png";

            }

            var BtnCurrentCollectionRecognizer = new TapGestureRecognizer();
            BtnCurrentCollectionRecognizer.Tapped += tapImage_TappedCurrentCollection;
            BtnCurrentCollection.GestureRecognizers.Add(BtnCurrentCollectionRecognizer);
            void tapImage_TappedCurrentCollection(object sender, System.EventArgs e)
            {
                Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                BtnHome.Source = "1-Homepage.png";
                BtnDressDesigner.Source = "2-Designer.png";
                BtnStockistFinder.Source = "3-Stockist.png";
                BtnCurrentCollection.Source = "4-CurrentCollection-invert.png";
                BtnNewCollection.Source = "5-NewCollection.png";
                BtnMyDresses.Source = "6-MyDresses.png";
                BtnContact.Source = "7-Contact.png";

            }

            
            var BtnNewCollectionRecognizer = new TapGestureRecognizer();
            BtnNewCollectionRecognizer.Tapped += tapImage_TappedNewCollection;
            BtnNewCollection.GestureRecognizers.Add(BtnNewCollectionRecognizer);
            void tapImage_TappedNewCollection(object sender, System.EventArgs e)
            {
                Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                BtnHome.Source = "1-Homepage.png";
                BtnDressDesigner.Source = "2-Designer.png";
                BtnStockistFinder.Source = "3-Stockist.png";
                BtnCurrentCollection.Source = "4-CurrentCollection.png";
                BtnNewCollection.Source = "5-NewCollection-invert.png";
                BtnMyDresses.Source = "6-MyDresses.png";
                BtnContact.Source = "7-Contact.png";

            }


            //These two may need the navigation changing if different page names are used.
            var BtnMyDressesRecognizer = new TapGestureRecognizer();
            BtnMyDressesRecognizer.Tapped += tapImage_TappedMyDresses;
            BtnMyDresses.GestureRecognizers.Add(BtnMyDressesRecognizer);
            void tapImage_TappedMyDresses(object sender, System.EventArgs e)
            {
                Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                BtnHome.Source = "1-Homepage.png";
                BtnDressDesigner.Source = "2-Designer.png";
                BtnStockistFinder.Source = "3-Stockist.png";
                BtnCurrentCollection.Source = "4-CurrentCollection.png";
                BtnNewCollection.Source = "5-NewCollection.png";
                BtnMyDresses.Source = "6-MyDresses-invert.png";
                BtnContact.Source = "7-Contact.png";

            }

            var BtnContactRecognizer = new TapGestureRecognizer();
            BtnContactRecognizer.Tapped += tapImage_TappedContact;
            BtnContact.GestureRecognizers.Add(BtnContactRecognizer);
            void tapImage_TappedContact(object sender, System.EventArgs e)
            {
                Detail = new NavigationPage(new Contact()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                BtnHome.Source = "1-Homepage.png";
                BtnDressDesigner.Source = "2-Designer.png";
                BtnStockistFinder.Source = "3-Stockist.png";
                BtnCurrentCollection.Source = "4-CurrentCollection.png";
                BtnNewCollection.Source = "5-NewCollection.png";
                BtnMyDresses.Source = "6-MyDresses.png";
                BtnContact.Source = "7-Contact-invert.png";

            }


        }

        















        //Old Buttons
        void Homepage_Button(object sender, System.EventArgs e)
         {
             Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
         }

         void DressDesigner_Button(object sender, System.EventArgs e)
         {
            Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
         }

        void Map_Button(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
        }

        void Current_Collection_Button(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
        }
        void New_Collection_Button(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
        }
    }
    }


