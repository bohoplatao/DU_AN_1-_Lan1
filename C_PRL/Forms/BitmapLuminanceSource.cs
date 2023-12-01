using ZXing;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace C_PRL.Forms
{
    public class BitmapLuminanceSource : BaseLuminanceSource
    {
        //
        
        // Khởi tạo một phiên bản mới của lớp ZXing.BitmapLuminanceSource.
        //
        // Thông số:
        //   chiều rộng:
        // Chiều rộng.
        //
        //   chiều cao:
        //     Chiều cao.
        protected BitmapLuminanceSource(int width, int height)
            : base(width, height)
        {
        }

        //
        // Bản tóm tắt:
        // Khởi tạo một phiên bản mới của lớp ZXing.BitmapLuminanceSource với
        // hình ảnh của một phiên bản Bitmap
        //
        // Thông số:
        // bitmap:
        // Bản đồ bit.
        public BitmapLuminanceSource(Bitmap bitmap)
            : base(bitmap.Width, bitmap.Height)
        {
            CalculateLuminanceValues(bitmap, luminances);
        }

        //
        // Bản tóm tắt:
        // tính toán các giá trị độ chói cho bitmap
        //
        // Thông số:
        // bitmap:
        //
        // độ chói:
        protected static void CalculateLuminanceValues(Bitmap bitmap, byte[] luminances)
        {
            int num = bitmap.Height;
            int num2 = bitmap.Width;
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, num2, num), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            try
            {
                int num3 = Math.Abs(bitmapData.Stride) / num2;
                if (num3 > 4)
                {
                    CalculateLuminanceValuesSlow(bitmap, luminances);
                    return;
                }

                if (bitmap.PixelFormat == PixelFormat.Format32bppArgb || bitmap.PixelFormat == PixelFormat.Format32bppPArgb)
                {
                    num3 = 40;
                }

                if (bitmap.PixelFormat == (PixelFormat)8207 || (bitmap.Flags & 0x20) == 32)
                {
                    num3 = 41;
                }

                switch (num3)
                {
                    case 0:
                        if (bitmap.PixelFormat == PixelFormat.Format4bppIndexed)
                        {
                            CalculateLuminanceValuesForIndexed4Bit(bitmap, bitmapData, luminances);
                        }
                        else
                        {
                            CalculateLuminanceValuesForIndexed1Bit(bitmap, bitmapData, luminances);
                        }

                        break;
                    case 1:
                        CalculateLuminanceValuesForIndexed8Bit(bitmap, bitmapData, luminances);
                        break;
                    case 2:
                        CalculateLuminanceValues565(bitmap, bitmapData, luminances);
                        break;
                    case 3:
                        CalculateLuminanceValues24Bit(bitmap, bitmapData, luminances);
                        break;
                    case 4:
                        CalculateLuminanceValues32BitWithoutAlpha(bitmap, bitmapData, luminances);
                        break;
                    case 40:
                        CalculateLuminanceValues32BitWithAlpha(bitmap, bitmapData, luminances);
                        break;
                    case 41:
                        CalculateLuminanceValues32BitCMYK(bitmap, bitmapData, luminances);
                        break;
                    default:
                        throw new NotSupportedException();
                }
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }
        }

        //
        // Bản tóm tắt:
        // cách chậm cũ cho độ sâu bit không được hỗ trợ
        //
        // Thông số:
        // bitmap:
        //
        // độ chói:
        protected static void CalculateLuminanceValuesSlow(Bitmap bitmap, byte[] luminances)
        {
            int num = bitmap.Height;
            int num2 = bitmap.Width;
            for (int i = 0; i < num; i++)
            {
                int num3 = i * num2;
                for (int j = 0; j < num2; j++)
                {
                    Color pixel = bitmap.GetPixel(j, i);
                    luminances[num3 + j] = (byte)(19562 * pixel.R + 38550 * pixel.G + 7424 * pixel.B >> 16);
                }
            }
        }
        //
        // Bản tóm tắt:
        // tính toán các giá trị độ sáng cho bitmap được lập chỉ mục 1 bit
        //
        // Thông số:
        // bitmap:
        //
        //   dữ liệu:
        //
        // độ chói:
        protected static void CalculateLuminanceValuesForIndexed1Bit(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            if (num4 != 0)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            byte[] array2 = new byte[256];
            int num5 = Math.Min(bitmap.Palette.Entries.Length, array2.Length);
            for (int i = 0; i < num5; i++)
            {
                Color color = bitmap.Palette.Entries[i];
                array2[i] = (byte)(19562 * color.R + 38550 * color.G + 7424 * color.B >> 16);
            }

            for (int j = 0; j < num; j++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num6 = j * num2;
                for (int k = 0; k * 8 < num2; k++)
                {
                    int num7 = 8 * k;
                    int num8 = num6 + num7;
                    for (int l = 0; l < 8 && num7 + l < num2; l++)
                    {
                        int num9 = (array[k] >> 7 - l) & 1;
                        luminances[num8 + l] = array2[num9];
                    }
                }
            }
        }

        
        // tính toán các giá trị độ sáng cho bitmap được lập chỉ mục 4 bit
        //
        // Thông số:
        // bitmap:
        //
        //   dữ liệu:
        //
        // độ chói:
        protected static void CalculateLuminanceValuesForIndexed4Bit(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            if (bitmap.PixelFormat != PixelFormat.Format4bppIndexed)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            int num5 = num2 / 2 * 2;
            if (num4 != 0)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            byte[] array2 = new byte[256];
            int num6 = Math.Min(bitmap.Palette.Entries.Length, array2.Length);
            for (int i = 0; i < num6; i++)
            {
                Color color = bitmap.Palette.Entries[i];
                array2[i] = (byte)(19562 * color.R + 38550 * color.G + 7424 * color.B >> 16);
            }

            for (int j = 0; j < num; j++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num7 = j * num2;
                int num8 = 0;
                int k = 0;
                byte b = 0;
                for (; k < num5; k += 2)
                {
                    b = array[num8];
                    int num9 = b & 0xF;
                    luminances[num7 + k + 1] = array2[num9];
                    num9 = (b >> 4) & 0xF;
                    luminances[num7 + k] = array2[num9];
                    num8++;
                }

                if (num2 > num5)
                {
                    int num10 = (b >> 4) & 0xF;
                    luminances[num7 + k] = array2[num10];
                }
            }
        }

        //
        // Bản tóm tắt:
        // tính toán các giá trị độ chói cho bitmap được lập chỉ mục 8 bit
        //
        // Thông số:
        // bitmap:
        //
        //   dữ liệu:
        //
        // độ chói:
        protected static void CalculateLuminanceValuesForIndexed8Bit(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            if (num4 != 1)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            byte[] array2 = new byte[256];
            int num5 = Math.Min(bitmap.Palette.Entries.Length, array2.Length);
            for (int i = 0; i < num5; i++)
            {
                Color color = bitmap.Palette.Entries[i];
                array2[i] = (byte)(19562 * color.R + 38550 * color.G + 7424 * color.B >> 16);
            }

            for (int j = 0; j < num; j++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num6 = j * num2;
                for (int k = 0; k < num2; k++)
                {
                    luminances[num6 + k] = array2[array[k]];
                }
            }
        }

        //
        // Bản tóm tắt:
        // tính toán các giá trị độ chói cho 565 bitmap được mã hóa
        //
        // Thông số:
        // bitmap:
        //
        //   dữ liệu:
        //
        // độ chói:
        private static void CalculateLuminanceValues565(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            if (num4 != 2)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            for (int i = 0; i < num; i++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num5 = i * num2;
                int num6 = 2 * num2;
                for (int j = 0; j < num6; j += 2)
                {
                    byte num7 = array[j];
                    byte b = array[j + 1];
                    int num8 = num7 & 0x1F;
                    int num9 = (((num7 & 0xE0) >> 5) | ((b & 3) << 3)) & 0x1F;
                    int num10 = ((b >> 2) & 0x1F) * 527 + 23 >> 6;
                    int num11 = num9 * 527 + 23 >> 6;
                    int num12 = num8 * 527 + 23 >> 6;
                    luminances[num5] = (byte)(19562 * num10 + 38550 * num11 + 7424 * num12 >> 16);
                    num5++;
                }
            }
        }

        //
        // Bản tóm tắt:
        // tính toán các giá trị độ chói cho bitmap được mã hóa 24 bit
        //
        // Thông số:
        // bitmap:
        //
        //   dữ liệu:
        //
        // độ chói:
        private static void CalculateLuminanceValues24Bit(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            if (num4 != 3)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            for (int i = 0; i < num; i++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num5 = i * num2;
                int num6 = num2 * 3;
                for (int j = 0; j < num6; j += 3)
                {
                    byte b = (luminances[num5] = (byte)(7424 * array[j] + 38550 * array[j + 1] + 19562 * array[j + 2] >> 16));
                    num5++;
                }
            }
        }

        //
        
        // tính toán các giá trị độ chói cho bitmap được mã hóa 32 bit mà không tôn trọng
        // kênh alpha
        //
        // Thông số:
        // bitmap:
        //
        //   dữ liệu:
        //
        // độ chói:
        private static void CalculateLuminanceValues32BitWithoutAlpha(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            int num5 = 4 * num2;
            if (num4 != 4)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            for (int i = 0; i < num; i++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num6 = i * num2;
                for (int j = 0; j < num5; j += 4)
                {
                    byte b = (luminances[num6] = (byte)(7424 * array[j] + 38550 * array[j + 1] + 19562 * array[j + 2] >> 16));
                    num6++;
                }
            }
        }

        private static void CalculateLuminanceValues32BitWithAlpha(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            int num5 = 4 * num2;
            if (num4 != 4)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            for (int i = 0; i < num; i++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num6 = i * num2;
                for (int j = 0; j < num5; j += 4)
                {
                    byte b = (byte)(7424 * array[j] + 38550 * array[j + 1] + 19562 * array[j + 2] >> 16);
                    byte b2 = array[j + 3];
                    b = (luminances[num6] = (byte)((b * b2 >> 8) + (255 * (255 - b2) >> 8) + 1));
                    num6++;
                }
            }
        }

        private static void CalculateLuminanceValues32BitCMYK(Bitmap bitmap, BitmapData data, byte[] luminances)
        {
            int num = data.Height;
            int num2 = data.Width;
            int num3 = Math.Abs(data.Stride);
            int num4 = num3 / num2;
            int stride = data.Stride;
            byte[] array = new byte[num3];
            IntPtr intPtr = data.Scan0;
            int num5 = 4 * num2;
            if (num4 != 4)
            {
                throw new InvalidOperationException("Unsupported pixel format: " + bitmap.PixelFormat);
            }

            for (int i = 0; i < num; i++)
            {
                Marshal.Copy(intPtr, array, 0, num3);
                intPtr = IntPtr.Add(intPtr, stride);
                int num6 = i * num2;
                for (int j = 0; j < num5; j += 4)
                {
                    byte b = (luminances[num6] = (byte)(255 - (7424 * array[j] + 38550 * array[j + 1] + 19562 * array[j + 2] >> 16)));
                    num6++;
                }
            }
        }

        //
       
        // Nên tạo nguồn sáng mới với đúng loại lớp. Phương pháp này là
        // được sử dụng trong các phương thức cắt và xoay.
        //
        // Thông số:
        // độ sáng mới:
        // Độ sáng mới.
        //
        //   chiều rộng:
        // Chiều rộng.
        //
        //   chiều cao:
        //     Chiều cao.
        protected override LuminanceSource CreateLuminanceSource(byte[] newLuminances, int width, int height)
        {
            return new BitmapLuminanceSource(width, height)
            {
                luminances = newLuminances
            };
        }
    }
 }