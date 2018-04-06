﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DesignYourOwnWeddingDress
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Current_Collection : ContentPage
	{
		public Current_Collection ()
		{
			InitializeComponent ();

            //Create TapGestureRecognizers for each dress button
            var BtnSarahRecognizer = new TapGestureRecognizer();
            var BtnRhianRecognizer = new TapGestureRecognizer();
            var BtnDarlaRecognizer = new TapGestureRecognizer();
            var BtnPoppyRecognizer = new TapGestureRecognizer();
            var BtnMillieRecognizer = new TapGestureRecognizer();
            var BtnBeatriceRecognizer = new TapGestureRecognizer();
            var BtnLeonoraRecognizer = new TapGestureRecognizer();
            var BtnCharlotteRecognizer = new TapGestureRecognizer();
            var BtnClaireRecognizer = new TapGestureRecognizer();
            var BtnFlorenceRecognizer = new TapGestureRecognizer();
            var BtnFrancesRecognizer = new TapGestureRecognizer();
            var BtnJocelynRecognizer = new TapGestureRecognizer();
            var BtnElizaRecognizer = new TapGestureRecognizer();
            var BtnDaisyRecognizer = new TapGestureRecognizer();
            var BtnPrimroseRecognizer = new TapGestureRecognizer();
            var BtnMaggieRecognizer = new TapGestureRecognizer();
            var BtnMercyRecognizer = new TapGestureRecognizer();
            var BtnLilyRecognizer = new TapGestureRecognizer();
            var BtnEvieRecognizer = new TapGestureRecognizer();
            var BtnMaeRecognizer = new TapGestureRecognizer();

            //Binding events and associating tap with image
            BtnSarahRecognizer.Tapped += tapImage_TappedSarah;
            BtnSarah.GestureRecognizers.Add(BtnSarahRecognizer);
            BtnRhianRecognizer.Tapped += tapImage_TappedRhian;
            BtnRhian.GestureRecognizers.Add(BtnRhianRecognizer);
            BtnDarlaRecognizer.Tapped += tapImage_TappedDarla;
            BtnDarla.GestureRecognizers.Add(BtnDarlaRecognizer);
            BtnPoppyRecognizer.Tapped += tapImage_TappedPoppy;
            BtnPoppy.GestureRecognizers.Add(BtnPoppyRecognizer);
            BtnMillieRecognizer.Tapped += tapImage_TappedMillie;
            BtnMillie.GestureRecognizers.Add(BtnMillieRecognizer);
            BtnBeatriceRecognizer.Tapped += tapImage_TappedBeatrice;
            BtnBeatrice.GestureRecognizers.Add(BtnBeatriceRecognizer);
            BtnLeonoraRecognizer.Tapped += tapImage_TappedLeonora;
            BtnLeonora.GestureRecognizers.Add(BtnLeonoraRecognizer);
            BtnCharlotteRecognizer.Tapped += tapImage_TappedCharlotte;
            BtnLeonora.GestureRecognizers.Add(BtnLeonoraRecognizer);
            BtnClaireRecognizer.Tapped += tapImage_TappedClaire;
            BtnClaire.GestureRecognizers.Add(BtnClaireRecognizer);
            BtnFlorenceRecognizer.Tapped += tapImage_TappedFlorence;
            BtnFlorence.GestureRecognizers.Add(BtnFlorenceRecognizer);
            BtnFrancesRecognizer.Tapped += tapImage_TappedFrances;
            BtnFrances.GestureRecognizers.Add(BtnFrancesRecognizer);
            BtnJocelynRecognizer.Tapped += tapImage_TappedJocelyn;
            BtnJocelyn.GestureRecognizers.Add(BtnJocelynRecognizer);
            BtnElizaRecognizer.Tapped += tapImage_TappedEliza;
            BtnEliza.GestureRecognizers.Add(BtnElizaRecognizer);
            BtnDaisyRecognizer.Tapped += tapImage_TappedDaisy;
            BtnDaisy.GestureRecognizers.Add(BtnDaisyRecognizer);
            BtnPrimroseRecognizer.Tapped += tapImage_TappedPrimrose;
            BtnPrimrose.GestureRecognizers.Add(BtnPrimroseRecognizer);
            BtnMaggieRecognizer.Tapped += tapImage_TappedMaggie;
            BtnMaggie.GestureRecognizers.Add(BtnMaggieRecognizer);
            BtnMercyRecognizer.Tapped += tapImage_TappedMercy;
            BtnMercy.GestureRecognizers.Add(BtnMercyRecognizer);
            BtnLilyRecognizer.Tapped += tapImage_TappedLily;
            BtnLily.GestureRecognizers.Add(BtnLilyRecognizer);
            BtnEvieRecognizer.Tapped += tapImage_TappedEvie;
            BtnEvie.GestureRecognizers.Add(BtnEvieRecognizer);
            BtnMaeRecognizer.Tapped += tapImage_TappedMae;
            BtnMae.GestureRecognizers.Add(BtnMaeRecognizer);



            //Dress-Specific Functions change the content of modal depending on which dress image is tapped, then pop modal.
            //Push DressModal page to modal stack for dress 1
            void tapImage_TappedSarah(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                string GlryMainVal = "Single01Sarah.png";
                
                string DescValShort = "Short Tea Length full lace wedding dress with cap sleeves";
                string DescValLong = "Sarah is a super cute short tea length wedding dress. The satin bodice is overlaid with a sophisticated delicate ivory lace. A batteau neckline with scallop lace edging leading onto cap sleeves. Shown her in the apricot with an apricot satin detachable belt. The dress is worn with our in house ruffle petticoat for added volume. Buttons at the back of the dress complete this vintage early 1960's look.";
                //Pop Dressmodal page, passing above values on
                var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedRhian(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single02Rhian.png";

                string DescValShort = "Spot tulle short tea length dress with elbow length sleeves and daisy lace trim";
                string DescValLong = "Stunning spot tulle tea length gown with bateau  neckline with daisy lace trim and 3/4 length sleeves. A fixed belt with a retro flat bow finishes off the early 1960's look. Dress is worn with a ruffle petticoat made in house to fit our dress designs.";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedDarla(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single03Darla.png";

                string DescValShort = "Tulle and lace vintage inspired short calf length wedding gown with elbow length fitted sleeves.";
                string DescValLong = "Beautiful soft and feminine tulle and french lace short calf length wedding dress with subtle delicate lace sleeves. A detailed illusion lace back design to give a modern twist to a classic design";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedPoppy(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single04Poppy.png";

                string DescValShort = "Blush tea length tulle and lace gown with illusion neckline and cap sleeves.";
                string DescValLong = "A blush / soft champagne tulle tea length dress overlayed in gorgeous hand dyed lace trickling over the bodice and skirt. The sheer illusion neckline and back detail make this dress ideal for those who want a little more coverage without hiding too much. Pearl buttons and a bow belt finish it off";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedMillie(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single05Millie.png";

                string DescValShort = "Short tea length lace and tulle wedding dress with 3/4 sleeves";
                string DescValLong = "Gloriously cute and girlie 1950's vintage inspired tea length wedding dress. Full satin circle skirt overlaid in plain ivory tulle. Structured bodice with full lace illusion neckline and 3/4 length sleeves. Love V back detail with edges trimmed in pearls.";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedBeatrice(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single06Beatrice.png";

                string DescValShort = "Short vintage 1960's full French lace and fitted lace sleeves tea length wedding dress";
                string DescValLong = "A shorter sister to Isabella this full French lace tea length wedding dress is suitable for the discerning bride Full circle skirt overlaid in delicate corded French Lace V neck detail with long fitted sleeves. Illusion back with covered buttons";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedLeonora(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
               
                string GlryMainVal = "Single07Leonora.png";

                string DescValShort = "Short tea length tulle and lace gown - A signature Mooshki cutie Pie";
                string DescValLong = "Soft blush satin overlaid in ivory tulle and lace. A sweet diamond keyhole back compliments the keyhole decolletage and the signature flirty 1950’s inspired full circle skirt is finished with hand sewn guipure lace detail.";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedCharlotte(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single08Charlotte.png";

                string DescValShort = "A tea length gown with long sleeves and sheer back decorated in ivory guipure lace that creeps over the arms and down the bodice";
                string DescValLong = "Fairy tale meets 1950s tea length gowns, Charlotte mixes our two favored trends. A Mooshki fairy tale tea length gown featured in blush. Long sheer tulle sleeves and sheer back are a fabulous base for the organic floral guipure lace that creeps over the arms and down the bodice. The lace continues to cascade down the dress onto a full tulle skirt for a princess feel";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedClaire(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
               
                string GlryMainVal = "Single09Claire.png";

                string DescValShort = "Short Calf length spot tulle wedding dress with illusion neckline";
                string DescValLong = "A divine spotty and lace short calf length wedding dress with illusion spotty neckline and scallop edge trim in French corded lace. Beautiful lowered back detail and teamed with a duck egg blue bow belt.";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedFlorence(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single10Florence.png";

                string DescValShort = "Short tea length vintage inspired wedding dress with sweetheart bodice, illusion neckline and cap sleeves.";
                string DescValLong = "Glamorous Florence.... Full satin circle skirt overlaid in layers of tulle. The bodice is covered in a delicate lace and the lace peplum to the skirt offers a modern twist. A soft dip bustline leading to an illusion decolletage and lace cap sleeve. Covered buttons to the back";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedFrances(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single11Frances.png";

                string DescValShort = "Full beaded champagne vintage tea length wedding dress with 3/4 length sleeves";
                string DescValLong = "A decadent and opulent vintage tea length wedding dress. Made from our custom champagne lace over champagne satin and heavily embellishment to the lace. A fully structured satin sweetheart bodice overlaid for a bateau illusion neckline and 3/4 length sleeves. The dress has a modern champagne leather belt to add a modern touch and has a V back detailing.";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedJocelyn(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single12Jocelyn.png";

                string DescValShort = "Calf length vintage inspired wedding dress with a soft champagne tulle overlay ivory sweetheart bodice. Beaded champagne lace to bodice and straps";
                string DescValLong = "A stunning ivory calf length vintage inspired wedding dress with a soft champagne tulle overlay. Hand dyed guipure lace appliqued to the bodice and skirt with a scattering of pearls embroidered to the lace for a decadent look.";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedEliza(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single13Eliza.png";

                string DescValShort = "Calf Length Ostrich feather gown with pockets. After a couple of years, feathers make a dramatic return to Mooshki.";
                string DescValLong = "A seriously fun and flirty short calf length dress. Full Mikado satin bodice and circular skirt with an ostrich feather trim peeking out at the hem. Sleeveless with a bateau neckline and back coupled with button fastening for a sleek sophisticated look with added pockets, this dress will sure to wow the crowd";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedDaisy(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
               
                string GlryMainVal = "Single14Daisy.png";

                string DescValShort = "Spot tulle tea length gown with short cap sleeves and satin bow and pearl buttons";
                string DescValLong = "A fabulous signature spot tulle tea length gown called Daisy. Shown in vanilla with an ivory overlay and large treble vanilla bow.";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedPrimrose(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single15Primrose.png";

                string DescValShort = "Full lace tea length gown with elbow lace sleeves and sheer illusion back panels and neckline";
                string DescValLong = "Primrose is a beautiful sophisticated full lace gown shown in vanilla with ivory lace overlay.An elbow length sleeve for coverage but coupled with a low back bodice and sheer illusion panels for added elegance.";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedMaggie(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single16Maggie.png";

                string DescValShort = "A calf tea length ivory Mikado satin gown with a scalloped neckline";
                string DescValLong = "Simple and elegant this Mikado satin gown is classic in the extreme. A calf length ivory Mikado satin gown with a scalloped neckline and low back for a little drama. A simple fitted belt and bow to finish off the look.";
				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedMercy(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single17Mercy.png";

                string DescValShort = "Contemporary tea length wedding dress with shirt collar detail";
                string DescValLong = "Mercy is a contemporary take on a vintage tea length wedding dress. Halter neck style with modern shirt collar this simple yet stunning gown is an ideal city wedding dress. 2 connnecting straps across the bare back give a sexy feel to this dress. Finished with a contrasting blush leather belt";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedLily(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single18Lily.png";

                string DescValShort = "A fabulous blush and champagne tulle tea length gown with hand dyed guipure lace appliqued to the bodice.";
                string DescValLong = "A super cute tea length gown in blush with daring low back. Too gorgeous for words, blush satin overlaid in champagne tulle and hand dyed guipure lace to the bodice. Sheer illusion neckline and sleeves for a delicate touch while the low V back adds drama.";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedEvie(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
                
                string GlryMainVal = "Single19Evie.png";
                string DescValShort = "A hand dyed short tea length gown. Layered skirt with applique guipure lace, illusion neckline and cap sleeves.";
                string DescValLong = "Layers upon layers of champagne tulle create a tier effect skirt edges with hand dyed guipure lace. Cute yet elegant, Evie is shown in champagne satin overlaid in champagne tulle and hand tied lace. A completely sheer back is finished with champagne buttons, hand dyed lace climbs the sides of the back, the bodice and the cap sleeves, the cascades onto the tiered skirt and finally finishing the hem edge.";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }
            void tapImage_TappedMae(object sender, EventArgs e)
            {
                //Declare Modal Title, ImageGallery Srcs and Description in strings.
               
                string GlryMainVal = "Single20Mae.png";

                string DescValShort = "Calf length short full guipure lace Dior inspired gown with off the shoulder straps.";
                string DescValLong = "Classic in design from a bi-gone era where Dior ruled the catwalks this gown is reminiscent of days gone by when ladies were elegant and stylish.";

				//Pop Dressmodal page, passing above values on
				var detailPage = new DressModal(DescValShort, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, GlryMainVal, DescValLong);
                Navigation.PushModalAsync(detailPage);

            }





        }

        
    }
}