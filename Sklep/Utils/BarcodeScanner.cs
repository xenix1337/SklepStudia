using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Imaging;
using AForge.Math;
using AForge.Video.DirectShow;
using ZXing;
using AForge.Imaging.Filters;
using System.Drawing;
using System.Windows.Forms;
namespace Sklep.Utils
{
    public class BarcodeScanner
    {
        public event EventHandler<string> CodeScanned; // event

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        ContrastCorrection filter;
        BarcodeReader reader;
        public PictureBox pictureBox = null;

        public void startScanning()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            filter = new ContrastCorrection(60);
            reader = new BarcodeReader();
            reader.Options.TryHarder = true;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            filter.ApplyInPlace(bitmap);
            var result = reader.Decode(bitmap);
            if(pictureBox != null)
                pictureBox.Image = bitmap;
            if(result != null)
            {
                OnScanningCompleted(result.ToString());
            }
        }

        protected virtual void OnScanningCompleted(string code) //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            CodeScanned?.Invoke(this,code);
        }
        public void stopScanning()
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }


        ~BarcodeScanner()
        {
            stopScanning();
        }
        
    }
}
