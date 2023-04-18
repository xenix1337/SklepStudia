using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Imaging;
using AForge.Math;
using AForge.Video.DirectShow;
using ZXing.Windows.Compatibility;
using AForge.Imaging.Filters;
using System.Drawing;
using System.Windows.Forms;
namespace Sklep.Utils
{
    public class BarcodeScanner
    {
        public event EventHandler<string> CodeScanned;
        public Stack<PictureBox> pictureBoxes = new Stack<PictureBox>();
        public int cameraIndex = 0;
        private DateTime lastScanTime = DateTime.Now;
        private string lastScannedBarcode = "";

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        ContrastCorrection filter;
        BarcodeReader reader;
        public BarcodeScanner()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice); ;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraIndex].MonikerString);
            filter = new ContrastCorrection(60);
            reader = new BarcodeReader();
            reader.Options.TryHarder = true;
        }
        public void startScanning()
        {
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            filter.ApplyInPlace(bitmap);
            var result = reader.Decode(bitmap);
            if(pictureBoxes.Count > 0)
            {
                pictureBoxes.Peek().Image = bitmap;
            }

            if (result == null || !EANValidator.validateBarcode(result.ToString())) return;
            if (DateTime.Now.Subtract(lastScanTime).TotalSeconds > 2 || result.ToString() != lastScannedBarcode) return;
            
            lastScanTime = DateTime.Now;
            lastScannedBarcode = result.ToString();
            OnScanningCompleted(result.ToString());
        }

        protected virtual void OnScanningCompleted(string code)
        {
            CodeScanned?.Invoke(this, code);
        }
        public void stopScanning()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                videoCaptureDevice.SignalToStop();
            }
        }


        ~BarcodeScanner()
        {
            stopScanning();
        }

    }
}
