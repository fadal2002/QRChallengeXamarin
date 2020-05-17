using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QRcodeGenerator
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void generate_Button_Clicked(object sender, EventArgs e)
        {
            //Handling the generate button click event
            String textVal = QRTextEntry.Text;
            //Checking if the user has inputted some text to convert or not before generating 
            if(textVal == null || textVal == "")
            {
                //Display an alert if the user tries to generate without entering a text to convert
                await DisplayAlert("Alert", "You need to enter some text!", "OK");
            }
            else
            {
                //Generate a QR code and reset the entry text 
                QRImage.BarcodeValue = textVal;
                QRTextEntry.Text = "";
            }
        }

        async private void scan_Button_Clicked(object sender, EventArgs e)
        {
            //Handling the scan button click event
            //Open the scan page when scan button is clicked
            await Navigation.PushAsync(new ScanPage());
        }
    }
}
