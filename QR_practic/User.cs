using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace QR_practic
{
    public class User
    {
        public string login;
        public string password;

        public void SaveQr()
        {
            string qr_text = login + " " + password;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap bitmap = encoder.Encode(qr_text);

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(save.FileName);
            }
            
        }
    }
}
