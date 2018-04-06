using Xamarin.Forms;

namespace DesignYourOwnWeddingDress
{
    public partial class DesignYourOwnWeddingDressPage : MasterDetailPage
    {

        public int NavIndex { get; set; }

        public DesignYourOwnWeddingDressPage()
        {
            InitializeComponent();

            IsPresented = true;
            

    //Attaching Gesture Recognizers to Button pngs and then change to inverse.
        var BtnHomeRecognizer = new TapGestureRecognizer();
            BtnHomeRecognizer.Tapped += tapImage_TappedHome;
            BtnHome.GestureRecognizers.Add(BtnHomeRecognizer);
            void tapImage_TappedHome(object sender, System.EventArgs e)
            {
                
                
                switch (NavIndex)
                {
                    case 0: Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnHome.Source = "HomepageInvert.png";
                        IsPresented = false;
                        break;
                    
                    case 1: Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnDressDesigner.Source = "Designer.png";
                        BtnHome.Source = "HomepageInvert.png";
						IsPresented = false;

                        break;
                    case 2: Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnStockistFinder.Source = "Stockist.png";
                        BtnHome.Source = "HomepageInvert.png";
						IsPresented = false;

                        break;
                    case 3:
                        Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnCurrentCollection.Source = "CurrentCollection.png";
                        BtnHome.Source = "HomepageInvert.png";
						IsPresented = false;

                        break;
                    case 4:
                        Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnNewCollection.Source = "NewCollection.png";
                        BtnHome.Source = "HomepageInvert.png";
						IsPresented = false;
                       
                        break;
                    case 5:
                        Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnMyDresses.Source = "MyDresses.png";
                        BtnHome.Source = "HomepageInvert.png";
						IsPresented = false;

                        break;
                    case 6:
                        Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnContact.Source = "Contact.png";
                        BtnHome.Source = "HomepageInvert.png";
						IsPresented = false;

                        break;
                }


                NavIndex = 0;


                
                
                

            }

            var BtnDesignerRecognizer = new TapGestureRecognizer();
            BtnDesignerRecognizer.Tapped += tapImage_TappedDesigner;
            BtnDressDesigner.GestureRecognizers.Add(BtnDesignerRecognizer);
            void tapImage_TappedDesigner(object sender, System.EventArgs e)
            {
                switch (NavIndex)
                {
                    case 0:
                        Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnHome.Source = "Homepage.png";
                        BtnDressDesigner.Source = "DesignerInvert.png";
						IsPresented = false;
                       
                        break;
                    case 1:
                        Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
						IsPresented = false;
                        BtnDressDesigner.Source = "DesignerInvert.png";
                       
                        break;
                    case 2:
                        Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnStockistFinder.Source = "Stockist.png";
                        BtnDressDesigner.Source = "DesignerInvert.png";
						IsPresented = false;

                        break;
                    case 3:
                        Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnCurrentCollection.Source = "CurrentCollection.png";
                        BtnDressDesigner.Source = "DesignerInvert.png";
						IsPresented = false;

                        break;
                    case 4:
                        Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnNewCollection.Source = "NewCollection.png";
                        BtnDressDesigner.Source = "DesignerInvert.png";
						IsPresented = false;
                      
                        break;
                    case 5:
                        Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnMyDresses.Source = "MyDresses.png";
                        BtnDressDesigner.Source = "DesignerInvert.png";
						IsPresented = false;
                      
                        break;
                    case 6:
                        Detail = new NavigationPage(new Dress_Designer()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnContact.Source = "Contact.png";
                        BtnDressDesigner.Source = "DesignerInvert.png";
						IsPresented = false;

                        break;
                }


                NavIndex = 1;

            }

            var BtnStockistRecognizer = new TapGestureRecognizer();
            BtnStockistRecognizer.Tapped += tapImage_TappedStockist;
            BtnStockistFinder.GestureRecognizers.Add(BtnStockistRecognizer);
            void tapImage_TappedStockist(object sender, System.EventArgs e)
            {
                switch (NavIndex)
                {
                    case 0:
                        Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnHome.Source = "Homepage.png";
                        BtnStockistFinder.Source = "StockistInvert.png";
						IsPresented = false;
                    
                        break;
                    case 1:
                        Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnDressDesigner.Source = "Designer.png";
                        BtnStockistFinder.Source = "StockistInvert.png";
						IsPresented = false;
                      
                        break;
                    case 2:
                        Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnStockistFinder.Source = "StockistInvert.png";
                        IsPresented = false;
                        break;
                    case 3:
                        Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnCurrentCollection.Source = "CurrentCollection.png";
                        BtnStockistFinder.Source = "StockistInvert.png";
						IsPresented = false;
                     
                        break;
                    case 4:
                        Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnNewCollection.Source = "NewCollection.png";
                        BtnStockistFinder.Source = "StockistInvert.png";
						IsPresented = false;
                       
                        break;
                    case 5:
                        Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnMyDresses.Source = "MyDresses.png";
                        BtnStockistFinder.Source = "StockistInvert.png";
						IsPresented = false;
                     
                        break;
                    case 6:
                        Detail = new NavigationPage(new Map()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnContact.Source = "Contact.png";
                        BtnStockistFinder.Source = "StockistInvert.png";
						IsPresented = false;
                     
                        break;
                }


                NavIndex = 2;

            }

            var BtnCurrentCollectionRecognizer = new TapGestureRecognizer();
            BtnCurrentCollectionRecognizer.Tapped += tapImage_TappedCurrentCollection;
            BtnCurrentCollection.GestureRecognizers.Add(BtnCurrentCollectionRecognizer);
            void tapImage_TappedCurrentCollection(object sender, System.EventArgs e)
            {
                switch (NavIndex)
                {
                    case 0:
                        Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnHome.Source = "Homepage.png";
                        BtnCurrentCollection.Source = "CurrentCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 1:
                        Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnDressDesigner.Source = "Designer.png";
                        BtnCurrentCollection.Source = "CurrentCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 2:
                        Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnStockistFinder.Source = "Stockist.png";
                        BtnCurrentCollection.Source = "CurrentCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 3:
                        Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnCurrentCollection.Source = "CurrentCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 4:
                        Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnNewCollection.Source = "NewCollection.png";
                        BtnCurrentCollection.Source = "CurrentCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 5:
                        Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnMyDresses.Source = "MyDresses.png";
                        BtnCurrentCollection.Source = "CurrentCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 6:
                        Detail = new NavigationPage(new Current_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnContact.Source = "Contact.png";
                        BtnCurrentCollection.Source = "CurrentCollectionInvert.png";
						IsPresented = false;
                        break;
                }


                NavIndex = 3;
            }

            
            var BtnNewCollectionRecognizer = new TapGestureRecognizer();
            BtnNewCollectionRecognizer.Tapped += tapImage_TappedNewCollection;
            BtnNewCollection.GestureRecognizers.Add(BtnNewCollectionRecognizer);
            void tapImage_TappedNewCollection(object sender, System.EventArgs e)
            {
                switch (NavIndex)
                {
                    case 0:
                        Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnHome.Source = "Homepage.png";
                        BtnNewCollection.Source = "NewCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 1:
                        Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnDressDesigner.Source = "Designer.png";
                        BtnNewCollection.Source = "NewCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 2:
                        Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnStockistFinder.Source = "Stockist.png";
                        BtnNewCollection.Source = "NewCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 3:
                        Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnCurrentCollection.Source = "CurrentCollection.png";
                        BtnNewCollection.Source = "NewCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 4:
                        Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnNewCollection.Source = "NewCollectionInvert.png";
                        IsPresented = false;
                        break;
                    case 5:
                        Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnMyDresses.Source = "MyDresses.png";
                        BtnNewCollection.Source = "NewCollectionInvert.png";
						IsPresented = false;
                        break;
                    case 6:
                        Detail = new NavigationPage(new New_Collection()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnContact.Source = "Contact.png";
                        BtnNewCollection.Source = "NewCollectionInvert.png";
						IsPresented = false;
                        break;
                }


                NavIndex = 4;

            }


            //These two may need the navigation changing if different page names are used.
            var BtnMyDressesRecognizer = new TapGestureRecognizer();
            BtnMyDressesRecognizer.Tapped += tapImage_TappedMyDresses;
            BtnMyDresses.GestureRecognizers.Add(BtnMyDressesRecognizer);
            void tapImage_TappedMyDresses(object sender, System.EventArgs e)
            {
                switch (NavIndex)
                {
                    case 0:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnHome.Source = "Homepage.png";
                        BtnMyDresses.Source = "MyDressesInvert.png";
						IsPresented = false;
                        break;
                    case 1:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnDressDesigner.Source = "Designer.png";
                        BtnMyDresses.Source = "MyDressesInvert.png";
						IsPresented = false;
                        break;
                    case 2:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnStockistFinder.Source = "Stockist.png";
                        BtnMyDresses.Source = "MyDressesInvert.png";
						IsPresented = false;
                        break;
                    case 3:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnCurrentCollection.Source = "CurrentCollection.png";
                        BtnMyDresses.Source = "MyDressesInvert.png";
						IsPresented = false;
                        break;
                    case 4:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnNewCollection.Source = "NewCollection.png";
                        BtnMyDresses.Source = "MyDressesInvert.png";
						IsPresented = false;
                        break;
                    case 5:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnMyDresses.Source = "MyDressesInvert.png";
						IsPresented = false;
                        break;
                    case 6:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnContact.Source = "Contact.png";
                        BtnMyDresses.Source = "MyDressesInvert.png";
                        IsPresented = false;
                        break;
                }


                NavIndex = 5;

            }

            var BtnContactRecognizer = new TapGestureRecognizer();
            BtnContactRecognizer.Tapped += tapImage_TappedContact;
            BtnContact.GestureRecognizers.Add(BtnContactRecognizer);
            void tapImage_TappedContact(object sender, System.EventArgs e)
            {
                switch (NavIndex)
                {
                    case 0:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnHome.Source = "Homepage.png";
                        BtnContact.Source = "ContactInvert.png";
						IsPresented = false;
                        break;
                    case 1:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnDressDesigner.Source = "Designer.png";
                        BtnContact.Source = "ContactInvert.png";
						IsPresented = false;
                        break;
                    case 2:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnStockistFinder.Source = "Stockist.png";
                        BtnContact.Source = "ContactInvert.png";
						IsPresented = false;
                        break;
                    case 3:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnCurrentCollection.Source = "CurrentCollection.png";
                        BtnContact.Source = "ContactInvert.png";
						IsPresented = false;
                        break;
                    case 4:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnNewCollection.Source = "NewCollection.png";
                        BtnContact.Source = "ContactInvert.png";
						IsPresented = false;
                        break;
                    case 5:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnMyDresses.Source = "MyDresses.png";
                        BtnContact.Source = "ContactInvert.png";
						IsPresented = false;
                        break;
                    case 6:
                        Detail = new NavigationPage(new MyDresses()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
                        BtnContact.Source = "ContactInvert.png";
                        IsPresented = false;
                        break;
                }


                NavIndex = 6;

            }


        }

        















        /*Old Buttons
        void Homepage_Button(object sender, System.EventArgs e)
        {
            // Detail = new NavigationPage(new Homepage()) { BarBackgroundColor = Color.FromHex("#3A3A3A"), BarTextColor = Color.White };
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
        } */
    }
    }


