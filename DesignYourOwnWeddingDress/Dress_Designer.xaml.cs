using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DesignYourOwnWeddingDress
{
    public enum DressPartType
    {
        FrontBodice, BackBodice, FrontSkirt, BackSkirt, FrontSleeves, BackSleeves
    }

    public partial class Dress_Designer : ContentPage
    {
        Dress dress;

        //TapGestures
        TapGestureRecognizer btnFlip = new TapGestureRecognizer();
        TapGestureRecognizer btnOptionSlections = new TapGestureRecognizer();
        TapGestureRecognizer btnPrevItemType = new TapGestureRecognizer();
        TapGestureRecognizer btnNextItemType = new TapGestureRecognizer();
        TapGestureRecognizer btnPrevItemSet = new TapGestureRecognizer();
        TapGestureRecognizer btnNextItemSet = new TapGestureRecognizer();

        List<Image> dressOptions = new List<Image>();

        DressPartType menuSelected = DressPartType.FrontBodice;
        int menuPosition = 0;
        float maxMenuPosition;


        public Dress_Designer()
        {
            InitializeComponent();

			dress = new Dress(imgModel, imgFrontBodice, imgBackBodice, imgFrontSkirt, imgBackSkirt, imgFrontSleeves, imgBackSleeves);
            btnFlip.Tapped += Flip;
            imgFlip.GestureRecognizers.Add(btnFlip);
            nextItemType.GestureRecognizers.Add(btnNextItemType);
            prevItemType.GestureRecognizers.Add(btnPrevItemType);
            nextItemSet.GestureRecognizers.Add(btnNextItemSet);
            prevItemSet.GestureRecognizers.Add(btnPrevItemSet);

            btnOptionSlections.Tapped += SelectDressOption;
            btnPrevItemType.Tapped += PrevDressItemType;
            btnNextItemType.Tapped += NextDressItemType;
            btnPrevItemSet.Tapped += PrevItemSet;
            btnNextItemSet.Tapped += NextItemSet;

            AddDressOption(2, 3, 5, 6);
            AddDressOption(4, 5, 5, 6);
            AddDressOption(6, 7, 5, 6);
            AddDressOption(8, 9, 5, 6);

            AddDressOption(2, 3, 7, 8);
            AddDressOption(4, 5, 7, 8);
            AddDressOption(6, 7, 7, 8);
            AddDressOption(8, 9, 7, 8);

			dress.FrontBodiceOptions(dressOptions, menuPosition);
			maxMenuPosition = dress.GetLength(menuSelected) / 8; //Sets max menu position to stop us moving to far along in the menu

		}

        /// <summary>
        /// Used to create a new button for the dress options
        /// </summary>
        /// <param name="left">left placement in grid.</param>
        /// <param name="right">Right placement in grid.</param>
        /// <param name="top">Top placement in grid.</param>
        /// <param name="bottom">Bottom placement in grid.</param>
        void AddDressOption(int left, int right, int top, int bottom)
        {

            dressOptions.Add(new Image());
            dressOptions[dressOptions.Count - 1].Aspect = Aspect.AspectFill;
            dressOptions[dressOptions.Count - 1].GestureRecognizers.Add(btnOptionSlections);
            grid.Children.Add(dressOptions[dressOptions.Count - 1], left, right, top, bottom);
        }

        void SelectDressOption(object sender, EventArgs e)
        {
            if (sender is Image)
            {
                for (int iDressOption = 0; iDressOption < dressOptions.Count; iDressOption++)
                {
                    if (((Image)sender) == dressOptions[iDressOption])
                    {
                        dress.SelectPart(menuSelected, iDressOption + (8 * menuPosition));
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Used when the flip icon is clicked
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void Flip(object sender, EventArgs e)
        {
            dress.Flip();
        }

        void NextDressItemType(object sender, EventArgs e)
        {
            switch (menuSelected)
            {
                case DressPartType.FrontBodice:
                    menuPosition = 0;
                    dress.BackBodiceOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.BackBodice;
                    break;
                case DressPartType.BackBodice:
                    menuPosition = 0;
                    dress.FrontSkirtOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.FrontSkirt;
                    break;
                case DressPartType.FrontSkirt:
                    menuPosition = 0;
                    dress.BackSkirtOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.BackSkirt;
                    break;
                case DressPartType.BackSkirt:
                    menuPosition = 0;
                    dress.SleevesOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.FrontSleeves;
                    break;
                case DressPartType.FrontSleeves:

                    break;
            }
            maxMenuPosition = dress.GetLength(menuSelected) / 8; //Sets max menu position to stop us moving to far along in the menu
        }

        void PrevDressItemType(object sender, EventArgs e)
        {
            switch (menuSelected)
            {
                case DressPartType.FrontBodice:

                    break;
                case DressPartType.BackBodice:
                    menuPosition = 0;
                    dress.FrontBodiceOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.FrontBodice;
                    break;
                case DressPartType.FrontSkirt:
                    menuPosition = 0;
                    dress.BackBodiceOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.BackBodice;
                    break;
                case DressPartType.BackSkirt:
                    menuPosition = 0;
                    dress.FrontSkirtOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.FrontSkirt;
                    break;
                case DressPartType.FrontSleeves:
                    menuPosition = 0;
                    dress.BackSkirtOptions(dressOptions, menuPosition * 8);
                    menuSelected = DressPartType.BackSkirt;
                    break;
            }
            maxMenuPosition = dress.GetLength(menuSelected) / 8; //Sets max menu position to stop us moving to far along in the menu
        }

        void NextItemSet(object sender, EventArgs e)
        {
            if (menuPosition + 1 < maxMenuPosition)
            {
                menuPosition++;
                RefreshItemSet();
            }
        }

        void PrevItemSet(object sender, EventArgs e)
        {
            if (menuPosition > 0)
            {
                menuPosition--;
                RefreshItemSet();
            }

        }

        void RefreshItemSet()
        {
            switch (menuSelected)
            {
                case DressPartType.FrontBodice:
                    dress.FrontBodiceOptions(dressOptions, menuPosition * 8);
                    break;
                case DressPartType.BackBodice:
                    dress.BackBodiceOptions(dressOptions, menuPosition * 8);
                    break;
                case DressPartType.FrontSkirt:
                    dress.FrontSkirtOptions(dressOptions, menuPosition * 8);
                    break;
                case DressPartType.BackSkirt:
                    dress.BackSkirtOptions(dressOptions, menuPosition * 8);
                    break;
                case DressPartType.FrontSleeves:
                    dress.SleevesOptions(dressOptions, menuPosition * 8);
                    break;
            }
        }
    }

    enum Facing
    {
        Front, Back
    }

    [System.Serializable]
    public class Dress
    {
        ImageSource frontModelPath = ImageSource.FromFile("pose front.bmp");
        ImageSource backModelPath = ImageSource.FromFile("pose back.bmp");

        Image modelImage;

        Facing facing;

        FrontBodice frontBodice;
        BackBodice backBodice;

        FrontSkirt frontSkirt;
        BackSkirt backSkirt;

        Sleeves sleeves;

        public Dress(Image pModelImage, Image frontBodiceImage, Image backBodiceImage, Image frontSkirtImage, Image backSkirtImage, Image frontSleevesImage, Image backSleevesImage)
        {
            facing = Facing.Front;
            modelImage = pModelImage;
            frontBodice = new FrontBodice(frontBodiceImage);
            backBodice = new BackBodice(backBodiceImage);
            frontSkirt = new FrontSkirt(frontSkirtImage);
            backSkirt = new BackSkirt(backSkirtImage);
            sleeves = new Sleeves(frontSleevesImage, backSleevesImage);
            modelImage.Source = frontModelPath;
            backSkirt.Hide();
            backBodice.Hide();
        }

        /// <summary>
        /// Flips the dress to face the other direction
        /// </summary>
        public void Flip()
        {
            if (facing == Facing.Front)
            {
                facing = Facing.Back;
                modelImage.Source = frontModelPath;
                frontBodice.Show();
                frontSkirt.Show();
                backSkirt.Hide();
                backBodice.Hide();
				sleeves.FrontShow();
				sleeves.BackHide();
            }
            else
            {
                facing = Facing.Front;
                modelImage.Source = backModelPath;
                frontBodice.Hide();
                frontSkirt.Hide();
                backSkirt.Show();
				backBodice.Show();
				sleeves.FrontHide();
				sleeves.BackShow();
            }
        }

        public void FrontBodiceOptions(List<Image> dressOptions, int startingIndex)
        {
            frontBodice.PopulateMenu(dressOptions, startingIndex);
        }

        public void BackBodiceOptions(List<Image> dressOptions, int startingIndex)
        {
            backBodice.PopulateMenu(dressOptions, startingIndex);
        }

        public void FrontSkirtOptions(List<Image> dressOptions, int startingIndex)
        {
            frontSkirt.PopulateMenu(dressOptions, startingIndex);
        }

        public void BackSkirtOptions(List<Image> dressOptions, int startingIndex)
        {
            backSkirt.PopulateMenu(dressOptions, startingIndex);
        }

        public void SleevesOptions(List<Image> dressOptions, int startingIndex)
        {
            sleeves.PopulateMenu(dressOptions, startingIndex);
        }

        public void SelectPart(DressPartType menuSelected, int index)
        {
            switch (menuSelected)
            {
                case DressPartType.FrontBodice:
                    frontBodice.SelectPart(index);
                    if (facing == Facing.Front)
                    {
                        Flip();
                    }
                    break;

                case DressPartType.BackBodice:
                    backBodice.SelectPart(index);
                    if (facing == Facing.Back)
                    {
                        Flip();
                    }
                    break;

                case DressPartType.FrontSkirt:
                    frontSkirt.SelectPart(index);
                    if (facing == Facing.Front)
                    {
                        Flip();
                    }
                    break;

                case DressPartType.BackSkirt:
                    backSkirt.SelectPart(index);
                    if (facing == Facing.Back)
                    {
                        Flip();
                    }
                    break;

                case DressPartType.FrontSleeves:
                    sleeves.SelectPart(index);
                    if (facing == Facing.Front){
						sleeves.BackHide();
						sleeves.FrontShow();
                    } else {
                        sleeves.BackShow();
                        sleeves.FrontHide();
                    }
                    break;
            }
        }

        public int GetLength(DressPartType menuSelected)
        {
            switch (menuSelected)
            {
                case DressPartType.FrontBodice:
                    return frontBodice.GetLength();

                case DressPartType.BackBodice:
                    return backBodice.GetLength();

                case DressPartType.FrontSkirt:
                    return frontSkirt.GetLength();

                case DressPartType.BackSkirt:
                    return backSkirt.GetLength();

                case DressPartType.FrontSleeves:
                    return sleeves.GetLength();
                default:
                    return 0;
            }
        }
    }

    [System.Serializable]
    public class DressPart
    {
        //Sprite image;
        protected Image renderer;
        protected DressPartType partType;

        public DressPart(Image pRenderer)
        {
            renderer = pRenderer;
        }

        public int GetLength()
        {
            return DDAssetLibraryManager.GetOptionAmount(partType);
        }

        /// <summary>
        /// Pulls out the 8 next icons and adds them to the options list
        /// </summary>
        /// <param name="dressOptions">Dress options to be populated</param>
        /// <param name="startingIndex">The index to start gathering icons from</param>
		public void PopulateMenu(List<Image> dressOptions, int startingIndex)
        {
            for (int iDressOption = 0; iDressOption < 8; iDressOption++)
            {
                if (iDressOption + startingIndex < DDAssetLibraryManager.GetOptionAmount(partType))
                {
                    dressOptions[iDressOption].Source = DDAssetLibraryManager.GetPartIcon(partType,iDressOption + startingIndex);
                }
                else
                {
                    dressOptions[iDressOption].Source = "";
                }
            }

        }

        /// <summary>
        /// Adds the part selected to the model. Note if the part is already selected it will remove the selction
        /// </summary>
        /// <param name="index">Index of the part</param>
        public virtual void SelectPart(int index)
        {
            if (renderer.Source != DDAssetLibraryManager.GetPartImage(partType, index)){
                if (index < DDAssetLibraryManager.GetOptionAmount(partType)){
                    renderer.Source = DDAssetLibraryManager.GetPartImage(partType, index);
                }
            } else {
                renderer.Source = "";
            }
        }

        public virtual void Show()
        {
            renderer.IsVisible = true;
        }

        public virtual void Hide()
        {
            renderer.IsVisible = false;
        }

    }

    [System.Serializable]
    public class FrontBodice : DressPart
    {
        public FrontBodice(Image pRenderer) : base(pRenderer)
        {
            partType = DressPartType.FrontBodice;
        }

    }

    [System.Serializable]
    public class BackBodice : DressPart
    {
        public BackBodice(Image pRenderer) : base(pRenderer)
        {
            partType = DressPartType.BackBodice;
        }

    }

    [System.Serializable]
    public class FrontSkirt : DressPart
    {
        public FrontSkirt(Image pRenderer) : base(pRenderer)
        {
            partType = DressPartType.FrontSkirt;
        }
    }

    [System.Serializable]
    public class BackSkirt : DressPart
    {
        public BackSkirt(Image pRenderer) : base(pRenderer)
        {
            partType = DressPartType.BackSkirt;
        }
    }

    [System.Serializable]
    public class Sleeves : DressPart
	{
        Image backRenderer;
        
        public Sleeves(Image pRenderer, Image pBackRenderer) : base(pRenderer)
        {
            partType = DressPartType.FrontSleeves;
            backRenderer = pBackRenderer;
        }

		override public void SelectPart(int index)
		{
			if (renderer.Source != DDAssetLibraryManager.GetPartImage(partType, index))
			{
				if (index < DDAssetLibraryManager.GetOptionAmount(partType))
				{
					renderer.Source = DDAssetLibraryManager.GetPartImage(partType, index);
                    backRenderer.Source = DDAssetLibraryManager.GetPartImage(DressPartType.BackSleeves, index);
				}
			}
			else
			{
				renderer.Source = "";
			}
		}

		override public void Show()
		{
			renderer.IsVisible = true;
            backRenderer.IsVisible = false;
		}

		override public void Hide()
		{
			renderer.IsVisible = false;
			backRenderer.IsVisible = true;
		}

        public void FrontShow(){
            renderer.IsVisible = true;
        }

		public void FrontHide()
		{
            renderer.IsVisible = false;
		}

		public void BackShow()
		{
			backRenderer.IsVisible = true;
		}

		public void BackHide()
		{
            backRenderer.IsVisible = false;
		}

    }

    static public class DDAssetLibraryManager{
        static Dictionary<DressPartType, List<ImageSource>> images = new Dictionary<DressPartType, List<ImageSource>>();
		static Dictionary<DressPartType, List<ImageSource>> icons = new Dictionary<DressPartType, List<ImageSource>>();

        /// <summary>
        /// Used to get an image for a part to go on the model.
        /// </summary>
        /// <returns>The part image.</returns>
        /// <param name="partType">Part type.</param>
        /// <param name="index">Index.</param>
        static public ImageSource GetPartImage(DressPartType partType, int index){
            return images[partType][index];
        }

		/// <summary>
		/// Used to get an image for a part to be used as an Icon.
		/// </summary>
		/// <returns>The part icon.</returns>
		/// <param name="partType">Part type.</param>
		/// <param name="index">Index.</param>
		static public ImageSource GetPartIcon(DressPartType partType, int index){
			return icons[partType][index];
		}

		/// <summary>
		/// Gets the amount of options.
		/// </summary>
		/// <returns>The amount of options.</returns>
		/// <param name="partType">Part type.</param>
		static public int GetOptionAmount(DressPartType partType)
		{
			if (images[partType].Count < icons[partType].Count)
				return images[partType].Count;
			else
				return icons[partType].Count;
		}

        static DDAssetLibraryManager()
        {
            images.Add(DressPartType.FrontBodice, new List<ImageSource>(){
                ImageSource.FromFile("DD_FrontBodice_1.png"),
                ImageSource.FromFile("dd_frontbodice_asymetricleft.png"),
                ImageSource.FromFile("dd_frontbodice_asymetricright.png"),
                ImageSource.FromFile("dd_frontbodice_bandeau.png"),
                ImageSource.FromFile("dd_frontbodice_bardot.png"),
                ImageSource.FromFile("dd_frontbodice_bateau.png"),
                ImageSource.FromFile("dd_frontbodice_cowl.png"),
                ImageSource.FromFile("dd_frontbodice_curved.png"),
                ImageSource.FromFile("dd_frontbodice_deepv.png"),
                ImageSource.FromFile("dd_frontbodice_halterneck.png"),
                ImageSource.FromFile("dd_frontbodice_highneckwithcollar.png"),
                ImageSource.FromFile("dd_frontbodice_highroundcollar.png"),
                ImageSource.FromFile("dd_frontbodice_keyhole.png"),
                ImageSource.FromFile("dd_frontbodice_lowscoop.png"),
                ImageSource.FromFile("dd_frontbodice_notched.png"),
                ImageSource.FromFile("dd_frontbodice_offshoulderhighneck.png"),
                ImageSource.FromFile("dd_frontbodice_offshoulderv.png"),
                ImageSource.FromFile("dd_frontbodice_queenannesoftdip.png"),
                ImageSource.FromFile("dd_frontbodice_queenannesweetheart.png"),
                ImageSource.FromFile("dd_frontbodice_scoop.png"),
                ImageSource.FromFile("dd_frontbodice_scoopnotched.png"),
                ImageSource.FromFile("dd_frontbodice_softdip.png"),
                ImageSource.FromFile("dd_frontbodice_squareneckline.png"),
                ImageSource.FromFile("dd_frontbodice_sweetheart.png"),
                ImageSource.FromFile("dd_frontbodice_vneck.png")
            });

            icons.Add(DressPartType.FrontBodice, new List<ImageSource>(){
                ImageSource.FromFile("DD_FrontBodice_1_icon.png"),
                ImageSource.FromFile("dd_frontbodice_asymetricleft_icon.png"),
                ImageSource.FromFile("dd_frontbodice_asymetricright_icon.png"),
                ImageSource.FromFile("dd_frontbodice_bandeau_icon.png"),
                ImageSource.FromFile("dd_frontbodice_bardot_icon.png"),
                ImageSource.FromFile("dd_frontbodice_bateau_icon.png"),
                ImageSource.FromFile("dd_frontbodice_cowl_icon.png"),
                ImageSource.FromFile("dd_frontbodice_curved_icon.png"),
                ImageSource.FromFile("dd_frontbodice_deepv_icon.png"),
                ImageSource.FromFile("dd_frontbodice_halterneck_icon.png"),
                ImageSource.FromFile("dd_frontbodice_highneckwithcollar_icon.png"),
                ImageSource.FromFile("dd_frontbodice_highroundcollar_icon.png"),
                ImageSource.FromFile("dd_frontbodice_keyhole_icon.png"),
                ImageSource.FromFile("dd_frontbodice_lowscoop_icon.png"),
                ImageSource.FromFile("dd_frontbodice_notched_icon.png"),
                ImageSource.FromFile("dd_frontbodice_offshoulderhighneck_icon.png"),
                ImageSource.FromFile("dd_frontbodice_offshoulderv_icon.png"),
                ImageSource.FromFile("dd_frontbodice_queenannesoftdip_icon.png"),
                ImageSource.FromFile("dd_frontbodice_queenannesweetheart_icon.png"),
                ImageSource.FromFile("dd_frontbodice_scoop_icon.png"),
                ImageSource.FromFile("dd_frontbodice_scoopnotched_icon.png"),
                ImageSource.FromFile("dd_frontbodice_softdip_icon.png"),
                ImageSource.FromFile("dd_frontbodice_squareneckline_icon.png"),
                ImageSource.FromFile("dd_frontbodice_sweetheart_icon.png"),
                ImageSource.FromFile("dd_frontbodice_vneck_icon.png")
            });

            images.Add(DressPartType.BackBodice, new List<ImageSource>(){
				ImageSource.FromFile("dd_backbodice_asymetricright.png"),
				ImageSource.FromFile("dd_backbodice_asymtericleft.png"),
				ImageSource.FromFile("dd_backbodice_bardot.png"),
				ImageSource.FromFile("dd_backbodice_deepscoop.png"),
				ImageSource.FromFile("dd_backbodice_deepv.png"),
				ImageSource.FromFile("dd_backbodice_deepvback.png"),
				ImageSource.FromFile("dd_backbodice_halterback.png"),
				ImageSource.FromFile("dd_backbodice_halterwithracerback.png"),
				ImageSource.FromFile("dd_backbodice_halterwithstrap.png"),
				ImageSource.FromFile("dd_backbodice_halterwithstrapraisedback.png"),
				ImageSource.FromFile("dd_backbodice_highbateau.png"),
				ImageSource.FromFile("dd_backbodice_highkeyhole.png"),
				ImageSource.FromFile("dd_backbodice_highneck.png"),
				ImageSource.FromFile("dd_backbodice_highneckwithcollar.png"),
				ImageSource.FromFile("dd_backbodice_highscoop.png"),
				ImageSource.FromFile("dd_backbodice_highvback.png"),
				ImageSource.FromFile("dd_backbodice_keyhole.png"),
				ImageSource.FromFile("dd_backbodice_lowkeyhole.png"),
			    ImageSource.FromFile("dd_backbodice_lowsquareback.png"),
				ImageSource.FromFile("dd_backbodice_lowvback.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderlowv.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderscoop.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderwithlowback.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderwithraisedback.png"),
	            ImageSource.FromFile("dd_backbodice_raisedback.png"),
	            ImageSource.FromFile("dd_backbodice_vback.png")
			});

			icons.Add(DressPartType.BackBodice, new List<ImageSource>(){
				ImageSource.FromFile("dd_backbodice_asymetricright_icon.png"),
				ImageSource.FromFile("dd_backbodice_asymtericleft_icon.png"),
				ImageSource.FromFile("dd_backbodice_bardot_icon.png"),
				ImageSource.FromFile("dd_backbodice_deepscoop_icon.png"),
				ImageSource.FromFile("dd_backbodice_deepv_icon.png"),
				ImageSource.FromFile("dd_backbodice_deepvback_icon.png"),
				ImageSource.FromFile("dd_backbodice_halterback_icon.png"),
				ImageSource.FromFile("dd_backbodice_halterwithracerback_icon.png"),
				ImageSource.FromFile("dd_backbodice_halterwithstrap_icon.png"),
				ImageSource.FromFile("dd_backbodice_halterwithstrapraisedback_icon.png"),
				ImageSource.FromFile("dd_backbodice_highbateau_icon.png"),
				ImageSource.FromFile("dd_backbodice_highkeyhole_icon.png"),
				ImageSource.FromFile("dd_backbodice_highneck_icon.png"),
				ImageSource.FromFile("dd_backbodice_highneckwithcollar_icon.png"),
				ImageSource.FromFile("dd_backbodice_highscoop_icon.png"),
				ImageSource.FromFile("dd_backbodice_highvback_icon.png"),
				ImageSource.FromFile("dd_backbodice_keyhole_icon.png"),
				ImageSource.FromFile("dd_backbodice_lowkeyhole_icon.png"),
				ImageSource.FromFile("dd_backbodice_lowsquareback_icon.png"),
				ImageSource.FromFile("dd_backbodice_lowvback_icon.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderlowv_icon.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderscoop_icon.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderwithlowback_icon.png"),
				ImageSource.FromFile("dd_backbodice_offshoulderwithraisedback_icon.png"),
				ImageSource.FromFile("dd_backbodice_raisedback_icon.png"),
				ImageSource.FromFile("dd_backbodice_vback_icon.png")
			});

            images.Add(DressPartType.FrontSkirt, new List<ImageSource>()
            {
                ImageSource.FromFile("DD_FrontSkirt_1.png")
            });

			icons.Add(DressPartType.FrontSkirt, new List<ImageSource>()
			{
				ImageSource.FromFile("DD_BackSkirt_1.png")

			});

            images.Add(DressPartType.BackSkirt, new List<ImageSource>()
			{
				ImageSource.FromFile("DD_BackSkirt_1.png")

			});

			icons.Add(DressPartType.BackSkirt, new List<ImageSource>()
			{
				ImageSource.FromFile("DD_BackSkirt_1.png")

			});

            images.Add(DressPartType.FrontSleeves, new List<ImageSource>()
			{
                ImageSource.FromFile("DD_frontsleeve_34withfrill.png"),
                ImageSource.FromFile("DD_frontsleeve_angel.png"),
                ImageSource.FromFile("DD_frontsleeve_cap.png"),
                ImageSource.FromFile("DD_frontsleeve_cappuff.png"),
                ImageSource.FromFile("DD_frontsleeve_cappuffwithcuff.png"),
                ImageSource.FromFile("DD_frontsleeve_coldshoulder.png"),
                ImageSource.FromFile("DD_frontsleeve_coldshoulder34.png"),
                ImageSource.FromFile("DD_frontsleeve_coldshouldershort.png"),
                ImageSource.FromFile("DD_frontsleeve_drapped.png"),
				ImageSource.FromFile("DD_frontsleeve_fitandflare.png"),
				ImageSource.FromFile("DD_frontsleeve_flared.png"),
				ImageSource.FromFile("DD_frontsleeve_juliet.png"),
				ImageSource.FromFile("DD_frontsleeve_lanternsleeve.png"),
				ImageSource.FromFile("DD_frontsleeve_legomutton.png"),
				ImageSource.FromFile("DD_frontsleeve_longjuliet.png"),
				ImageSource.FromFile("DD_frontsleeve_longwithpuff.png"),
				ImageSource.FromFile("DD_frontsleeve_offshoulder34.png"),
				ImageSource.FromFile("DD_frontsleeve_offshouldercap.png"),
				ImageSource.FromFile("DD_frontsleeve_offshoulderlong.png"),
				ImageSource.FromFile("DD_frontsleeve_peasant.png"),
				ImageSource.FromFile("DD_frontsleeve_petal.png"),
				ImageSource.FromFile("DD_frontsleeve_raglan.png"),
				ImageSource.FromFile("DD_frontsleeve_slightcap.png"),
				ImageSource.FromFile("DD_frontsleeve_trumpet.png.png"),
				ImageSource.FromFile("DD_frontsleeve_tshirt.png")
			});

			icons.Add(DressPartType.FrontSleeves, new List<ImageSource>()
			{
				ImageSource.FromFile("DD_frontsleeve_34withfrill.png"),
				ImageSource.FromFile("DD_frontsleeve_angel.png"),
				ImageSource.FromFile("DD_frontsleeve_cap.png"),
				ImageSource.FromFile("DD_frontsleeve_cappuff.png"),
				ImageSource.FromFile("DD_frontsleeve_cappuffwithcuff.png"),
				ImageSource.FromFile("DD_frontsleeve_coldshoulder.png"),
				ImageSource.FromFile("DD_frontsleeve_coldshoulder34.png"),
				ImageSource.FromFile("DD_frontsleeve_coldshouldershort.png"),
				ImageSource.FromFile("DD_frontsleeve_drapped.png"),
				ImageSource.FromFile("DD_frontsleeve_fitandflare.png"),
				ImageSource.FromFile("DD_frontsleeve_flared.png"),
				ImageSource.FromFile("DD_frontsleeve_juliet.png"),
				ImageSource.FromFile("DD_frontsleeve_lanternsleeve.png"),
				ImageSource.FromFile("DD_frontsleeve_legomutton.png"),
				ImageSource.FromFile("DD_frontsleeve_longjuliet.png"),
				ImageSource.FromFile("DD_frontsleeve_longwithpuff.png"),
				ImageSource.FromFile("DD_frontsleeve_offshoulder34.png"),
				ImageSource.FromFile("DD_frontsleeve_offshouldercap.png"),
				ImageSource.FromFile("DD_frontsleeve_offshoulderlong.png"),
				ImageSource.FromFile("DD_frontsleeve_peasant.png"),
				ImageSource.FromFile("DD_frontsleeve_petal.png"),
				ImageSource.FromFile("DD_frontsleeve_raglan.png"),
				ImageSource.FromFile("DD_frontsleeve_slightcap.png"),
				ImageSource.FromFile("DD_frontsleeve_trumpet.png.png"),
				ImageSource.FromFile("DD_frontsleeve_tshirt.png")
			});

            images.Add(DressPartType.BackSleeves, new List<ImageSource>()
            {
				ImageSource.FromFile("DD_backsleeve_34withfrill.png"),
				ImageSource.FromFile("DD_backsleeve_angel.png"),
				ImageSource.FromFile("DD_backsleeve_cap.png"),
				ImageSource.FromFile("DD_backsleeve_cappuff.png"),
				ImageSource.FromFile("DD_backsleeve_cappuffwithcuff.png"),
				ImageSource.FromFile("DD_backsleeve_coldshoulder.png"),
				ImageSource.FromFile("DD_backsleeve_coldshoulder34.png"),
				ImageSource.FromFile("DD_backsleeve_coldshouldershort.png"),
				ImageSource.FromFile("DD_backsleeve_drapped.png"),
				ImageSource.FromFile("DD_backsleeve_fitandflare.png"),
				ImageSource.FromFile("DD_backsleeve_flared.png"),
				ImageSource.FromFile("DD_backsleeve_juliet.png"),
				ImageSource.FromFile("DD_backsleeve_lanternsleeve.png"),
				ImageSource.FromFile("DD_backsleeve_legomutton.png"),
				ImageSource.FromFile("DD_backsleeve_longjuliet.png"),
				ImageSource.FromFile("DD_backsleeve_longwithpuff.png"),
				ImageSource.FromFile("DD_backsleeve_offshoulder34.png"),
				ImageSource.FromFile("DD_backsleeve_offshouldercap.png"),
				ImageSource.FromFile("DD_backsleeve_offshoulderlong.png"),
				ImageSource.FromFile("DD_backsleeve_peasant.png"),
				ImageSource.FromFile("DD_backsleeve_petal.png"),
				ImageSource.FromFile("DD_backsleeve_raglan.png"),
				ImageSource.FromFile("DD_backsleeve_slightcap.png"),
				ImageSource.FromFile("DD_backsleeve_trumpet.png.png"),
				ImageSource.FromFile("DD_backsleeve_tshirt.png")
            });

			icons.Add(DressPartType.BackSleeves, new List<ImageSource>()
			{
				ImageSource.FromFile("DD_backsleeve_34withfrill.png"),
				ImageSource.FromFile("DD_backsleeve_angel.png"),
				ImageSource.FromFile("DD_backsleeve_cap.png"),
				ImageSource.FromFile("DD_backsleeve_cappuff.png"),
				ImageSource.FromFile("DD_backsleeve_cappuffwithcuff.png"),
				ImageSource.FromFile("DD_backsleeve_coldshoulder.png"),
				ImageSource.FromFile("DD_backsleeve_coldshoulder34.png"),
				ImageSource.FromFile("DD_backsleeve_coldshouldershort.png"),
				ImageSource.FromFile("DD_backsleeve_drapped.png"),
				ImageSource.FromFile("DD_backsleeve_fitandflare.png"),
				ImageSource.FromFile("DD_backsleeve_flared.png"),
				ImageSource.FromFile("DD_backsleeve_juliet.png"),
				ImageSource.FromFile("DD_backsleeve_lanternsleeve.png"),
				ImageSource.FromFile("DD_backsleeve_legomutton.png"),
				ImageSource.FromFile("DD_backsleeve_longjuliet.png"),
				ImageSource.FromFile("DD_backsleeve_longwithpuff.png"),
				ImageSource.FromFile("DD_backsleeve_offshoulder34.png"),
				ImageSource.FromFile("DD_backsleeve_offshouldercap.png"),
				ImageSource.FromFile("DD_backsleeve_offshoulderlong.png"),
				ImageSource.FromFile("DD_backsleeve_peasant.png"),
				ImageSource.FromFile("DD_backsleeve_petal.png"),
				ImageSource.FromFile("DD_backsleeve_raglan.png"),
				ImageSource.FromFile("DD_backsleeve_slightcap.png"),
				ImageSource.FromFile("DD_backsleeve_trumpet.png.png"),
				ImageSource.FromFile("DD_backsleeve_tshirt.png")
			});
        }
    }
}
