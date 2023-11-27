using ZXing;
using System;
using System.Drawing;



namespace C_PRL.Forms
{
    public class BarcodeReader : BarcodeReader<Bitmap>, IBarcodeReader
    {
        private static readonly Func<Bitmap, LuminanceSource> defaultCreateLuminanceSource = (Bitmap bitmap) => new BitmapLuminanceSource(bitmap);


        public BarcodeReader()
            : this(null, defaultCreateLuminanceSource, null)
        {
        }

        //
        // Summary:
        //     Initializes a new instance of the ZXing.BarcodeReader class.
        //
        // Parameters:
        //   reader:
        //     Sets the reader which should be used to find and decode the barcode. If null
        //     then MultiFormatReader is used
        //
        //   createLuminanceSource:
        //     Sets the function to create a luminance source object for a bitmap. If null,
        //     an exception is thrown when Decode is called
        //
        //   createBinarizer:
        //     Sets the function to create a binarizer object for a luminance source. If null
        //     then HybridBinarizer is used
        public BarcodeReader(Reader reader, Func<Bitmap, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer)
            : base(reader, createLuminanceSource ?? defaultCreateLuminanceSource, createBinarizer)
        {
        }

        //
        // Summary:
        //     Initializes a new instance of the ZXing.BarcodeReader class.
        //
        // Parameters:
        //   reader:
        //     Sets the reader which should be used to find and decode the barcode. If null
        //     then MultiFormatReader is used
        //
        //   createLuminanceSource:
        //     Sets the function to create a luminance source object for a bitmap. If null,
        //     an exception is thrown when Decode is called
        //
        //   createBinarizer:
        //     Sets the function to create a binarizer object for a luminance source. If null
        //     then HybridBinarizer is used
        //
        //   createRGBLuminanceSource:
        //     Sets the function to create a luminance source object for a rgb raw byte array.
        public BarcodeReader(Reader reader, Func<Bitmap, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer, Func<byte[], int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource> createRGBLuminanceSource)
            : base(reader, createLuminanceSource ?? defaultCreateLuminanceSource, createBinarizer, createRGBLuminanceSource)
        {
        }

        //internal Result Decode(Image image)
        //{
        //    var barcodeReader = new BarcodeReader();
        //    var bitmap = (Bitmap)image; // Chuyển đổi Image thành Bitmap

        //    var result = barcodeReader.Decode(bitmap);

        //    return result;
        //}
    }
}