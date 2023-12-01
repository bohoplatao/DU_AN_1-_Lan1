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
        
        // Khởi tạo một phiên bản mới của lớp ZXing.BarcodeReader.
        //
        // Thông số:
        //   người đọc:
        // Đặt đầu đọc sẽ được sử dụng để tìm và giải mã mã vạch. Nếu không
        // sau đó MultiFormatReader được sử dụng
        //
        // createLuminanceSource:
        // Đặt hàm để tạo đối tượng nguồn độ chói cho bitmap. Nếu không,
        // một ngoại lệ được đưa ra khi Decode được gọi
        //
        // createBinarizer:
        // Đặt hàm để tạo đối tượng binarizer cho nguồn độ chói. Nếu không
        // sau đó HybridBinarizer được sử dụng
        public BarcodeReader(Reader reader, Func<Bitmap, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer)
            : base(reader, createLuminanceSource ?? defaultCreateLuminanceSource, createBinarizer)
        {
        }

        //
        
        // Khởi tạo một phiên bản mới của lớp ZXing.BarcodeReader.
        //
        // Thông số:
        //   người đọc:
        // Đặt đầu đọc sẽ được sử dụng để tìm và giải mã mã vạch. Nếu không
        // sau đó MultiFormatReader được sử dụng
        //
        // createLuminanceSource:
        // Đặt hàm để tạo đối tượng nguồn độ chói cho bitmap. Nếu không,
        // một ngoại lệ được đưa ra khi Decode được gọi
        //
        // createBinarizer:
        // Đặt hàm để tạo đối tượng binarizer cho nguồn độ chói. Nếu không
        // sau đó HybridBinarizer được sử dụng
        //
        // createRGBLuminanceSource:
        // Đặt hàm để tạo đối tượng nguồn độ chói cho mảng byte thô rgb.
        public BarcodeReader(Reader reader, Func<Bitmap, LuminanceSource> createLuminanceSource, Func<LuminanceSource, Binarizer> createBinarizer, Func<byte[], int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource> createRGBLuminanceSource)
            : base(reader, createLuminanceSource ?? defaultCreateLuminanceSource, createBinarizer, createRGBLuminanceSource)
        {
        }

      
    }
}