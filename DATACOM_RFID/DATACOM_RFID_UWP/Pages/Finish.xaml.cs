using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DATACOM_RFID_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Finish : Page
    {
        public Finish()
        {
            DetectRFID();
            TakePicture();
            WriteToDatabase();
        }

      

        private void TakePicture()
        {
            
       
            //WebRequest request = (HttpWebRequest)WebRequest.Create("http://172.23.49.1/axis-cgi/jpg/image.cgi");
            //request.Credentials = new NetworkCredential("student", "voetbal");
            //var response = request.GetResponse();


            //// var source = response.ResponseUri;

            //using (var client = new WebClient())
            //{
            //    client.Credentials = new NetworkCredential("student", "voetbal");
            //    client.DownloadFile(response.ResponseUri, "img.png");
            //    BitmapImage image = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "img.png"));
            //    ipimage.Height = image.Height;
            //    ipimage.Width = image.Width;
            //    ipimage.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "img.png"));
            //    //  byteArrayToImage(imagedata);

            //}

        }
    

        private void DetectRFID()
        {
           
        }
        private void WriteToDatabase()
        {
            throw new NotImplementedException();
        }

        private void txtRFIDdetect_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyStatus == Keys)

        }
    }
}
