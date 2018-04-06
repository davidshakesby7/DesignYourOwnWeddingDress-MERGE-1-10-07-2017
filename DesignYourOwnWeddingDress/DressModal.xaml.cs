﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DesignYourOwnWeddingDress
{
    public partial class DressModal : ContentPage
    {
        private DressModal()
        {
            InitializeComponent();

        }

        public DressModal(string TitleVal, string GlryMainVal, string GlryItem1Val, string GlryItem2Val, string GlryItem3Val, string GlryItem4Val, string DescVal)
        {
            InitializeComponent();

            //Declare strings to read values from Collections into image sources and descriptions, saving creating multiple pages.

            string GlryMainSrc = GlryMainVal;
            
            string DescShort = TitleVal;
            string DescLong = DescVal;

            //Then attach string to GlryMain, and Descs.
            GlryMain.Source = GlryMainSrc;
            GlryDescShort.Text = DescShort;
            GlryDescLong.Text = DescLong;

            
            //Back Button Gesture Recognizer
            var tapGestureRecognizerBack = new TapGestureRecognizer();
            //Binding events  
            
            tapGestureRecognizerBack.Tapped += tapImage_TappedBack;
            //Associating tap events to the Back icon  
            BackBtn.GestureRecognizers.Add(tapGestureRecognizerBack);


            //Event
            //Back Btn Event
            void tapImage_TappedBack(object sender, EventArgs e)
            {
                //Go Back to main page.
                Navigation.PopModalAsync ();
            }



        }
    }
}
