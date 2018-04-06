using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignYourOwnWeddingDress
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class New_Collection : ContentPage
	{
		public New_Collection ()
		{

            InitializeComponent();

            // Creating TapGestureRecognizers
            var tapGestureRecognizerDress1 = new TapGestureRecognizer();
            var tapGestureRecognizerDress2 = new TapGestureRecognizer();
            var tapGestureRecognizerDress3 = new TapGestureRecognizer();
            var tapGestureRecognizerDress4 = new TapGestureRecognizer();
            var tapGestureRecognizerDress5 = new TapGestureRecognizer();
            var tapGestureRecognizerDress6 = new TapGestureRecognizer();
            var tapGestureRecognizerDress7 = new TapGestureRecognizer();
            var tapGestureRecognizerDress8 = new TapGestureRecognizer();
            var tapGestureRecognizerDress9 = new TapGestureRecognizer();
            var tapGestureRecognizerDress10 = new TapGestureRecognizer();

            //Binding events  




            tapGestureRecognizerDress9.Tapped += tapImage_TappedDress9;
            tapGestureRecognizerDress10.Tapped += tapImage_TappedDress10;

            //Associating tap events to the image buttons  



            BtnCarla.GestureRecognizers.Add(tapGestureRecognizerDress9);
            BtnFifi.GestureRecognizers.Add(tapGestureRecognizerDress10);




            //Declare Datetime Vars and Unlock dates for dresses.
            var DressDate1 = new DateTime();
            var DressDate2 = new DateTime();
            var DressDate3 = new DateTime();
            var DressDate4 = new DateTime();
            var DressDate5 = new DateTime();
            var DressDate6 = new DateTime();
            var DressDate7 = new DateTime();
            var DressDate8 = new DateTime();

            var DateNow = new DateTime();
            DateNow = DateTime.Now;


            //Convert DressDateString to datetime
            //CHANGE THE DATE FORMAT IF THE APP IS NOT WORKING TO UK LAYOUT.
            DressDate1 = DateTime.Parse("06/18/2017");
            DressDate2 = DateTime.Parse("06/19/2017");
            DressDate3 = DateTime.Parse("06/20/2017");
            DressDate4 = DateTime.Parse("06/21/2017");
            DressDate5 = DateTime.Parse("06/22/2017");
            DressDate6 = DateTime.Parse("06/23/2017");
            DressDate7 = DateTime.Parse("06/24/2017");
            DressDate8 = DateTime.Parse("06/25/2017");

            //IF datenow is before unlock date, display padlock and prevent clicking. Else Unlock and run tapImage_TappedDress.
            if (DateNow.Date >= DressDate1.Date)
            {
                //Binding events and associating tap with imagebutton.
                tapGestureRecognizerDress1.Tapped += tapImage_TappedDress1;
                BtnApril.GestureRecognizers.Add(tapGestureRecognizerDress1);
                BtnApril.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 1
                void tapImage_TappedDress1(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "Single01Sarah.png";
                    string DescValShort = "French Lace Ballgown wedding dress with a semi sweetheart bodice, illusion neckline and full length fitted sleeves\r\n\r\nFull satin ballgown with 2 meter long train wedding dress. Structured ivory bodice with sweetheart bustline overlaid in French lace. Illusion and bateau neckline lead to long fitted sleeves. This dress is full on lace heaven and is finished with a delicate bow belt. A true Mooshki favourite and is also available in tea length.";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }
            }
            else
            {
                BtnApril.Source = "ComingSoon.png";
            }

            if (DateNow.Date >= DressDate2.Date)
            {
                //Binding events and associating tap with imagebutton.
                tapGestureRecognizerDress2.Tapped += tapImage_TappedDress2;
                BtnBlossom.GestureRecognizers.Add(tapGestureRecognizerDress2);
                BtnBlossom.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 2
                void tapImage_TappedDress2(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "alice.jpg";
                    string DescValShort = "Alice Dress Description";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }
            }
            else
            {
                BtnBlossom.Source = "ComingSoon.png";
            }

            if (DateNow.Date >= DressDate3.Date)
            {
                //Binding events and associating tap with imagebutton.
                tapGestureRecognizerDress3.Tapped += tapImage_TappedDress3;
                BtnMelody.GestureRecognizers.Add(tapGestureRecognizerDress3);
                BtnMelody.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 3
                void tapImage_TappedDress3(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "alice.jpg";
                    
                    string DescValShort = "Alice Dress Description";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }
            }
            else
            {
                BtnMelody.Source = "ComingSoon.png";
            }

            if (DateNow.Date >= DressDate4.Date)
            {
                tapGestureRecognizerDress4.Tapped += tapImage_TappedDress4;
                BtnTrixie.GestureRecognizers.Add(tapGestureRecognizerDress4);
                BtnTrixie.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 4
                void tapImage_TappedDress4(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "alice.jpg";
                    
                    string DescValShort = "Alice Dress Description";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }

            }
            else
            {
                BtnTrixie.Source = "ComingSoon.png";
            }

            if (DateNow.Date >= DressDate5.Date)
            {
                tapGestureRecognizerDress5.Tapped += tapImage_TappedDress5;
                BtnAnya.GestureRecognizers.Add(tapGestureRecognizerDress5);
                BtnAnya.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 5
                void tapImage_TappedDress5(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "alice.jpg";
                    
                    string DescValShort = "Alice Dress Description";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }
            }
            else
            {
                BtnAnya.Source = "ComingSoon.png";
            }

            if (DateNow.Date >= DressDate6.Date)
            {
                tapGestureRecognizerDress6.Tapped += tapImage_TappedDress6;
                BtnNina.GestureRecognizers.Add(tapGestureRecognizerDress6);
                BtnNina.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 6
                void tapImage_TappedDress6(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "alice.jpg";
                    
                    string DescValShort = "Alice Dress Description";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }

            }
            else
            {
                BtnNina.Source = "ComingSoon.png";
            }

            if (DateNow.Date >= DressDate7.Date)
            {
                tapGestureRecognizerDress7.Tapped += tapImage_TappedDress7;
                BtnLaurie.GestureRecognizers.Add(tapGestureRecognizerDress7);
                BtnLaurie.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 7
                void tapImage_TappedDress7(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "alice.jpg";
                    
                    string DescValShort = "Alice Dress Description";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }
            }
            else
            {
                BtnLaurie.Source = "ComingSoon.png";
            }
            if (DateNow.Date >= DressDate8.Date)
            {
                tapGestureRecognizerDress8.Tapped += tapImage_TappedDress8;
                BtnHermione.GestureRecognizers.Add(tapGestureRecognizerDress8);

                BtnHermione.Source = "Thumb01April.png";
                //Push DressModal page to modal stack for dress 8
                void tapImage_TappedDress8(object sender, EventArgs e)
                {
                    //Declare Modal Title, ImageGallery Srcs and Description in strings.
                    string GlryMainVal = "alice.jpg";
                    
                    string DescValShort = "Alice Dress Description";
                    string DescValLong = "";
					//Pop Dressmodal page, passing above values on
					var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                    Navigation.PushModalAsync(detailPage);

                }
            }
            else
            {
                BtnHermione.Source = "ComingSoon.png";
            }

            

            //Push DressModal page to modal stack for dress 9
            void tapImage_TappedDress9(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                string GlryMainVal = "alice.jpg";
               
                string DescValShort = "Alice Dress Description";
                string DescValLong = "";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            //Push DressModal page to modal stack for dress 10
            void tapImage_TappedDress10(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                string GlryMainVal = "alice.jpg";
               
                string DescValShort = "Alice Dress Description";
                string DescValLong = "";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }





        }
    }
}