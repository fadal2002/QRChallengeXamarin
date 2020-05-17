using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRcodeGenerator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        public ScanPage()
        {
            InitializeComponent();
        }

        private void scanView_OnScanResult(ZXing.Result result)
        {
            //Handling the QR code scanner's on scan result event 
            Device.BeginInvokeOnMainThread(() =>
            {
                //Set the result label text to the result returned from the QR code scanner
                resultLabel.Text = "Result: " + result.Text;
            });

        }
    }
}