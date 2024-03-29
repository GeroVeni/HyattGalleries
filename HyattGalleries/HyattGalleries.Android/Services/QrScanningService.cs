﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HyattGalleries.Services;
using ZXing.Mobile;
using Xamarin.Forms;
using System.Diagnostics;

[assembly: Dependency(typeof(HyattGalleries.Droid.Services.QrScanningService))]

namespace HyattGalleries.Droid.Services
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            if (scanResult == null) return null;
            return scanResult.Text;
        }
    }
}