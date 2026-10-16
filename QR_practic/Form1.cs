using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.DirectoryServices;
using System.Runtime.Intrinsics.Arm;

namespace QR_practic
{
    public partial class Form1 : Form
    {
        public List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Reg_Button_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                login = t_login.Text,
                password = t_password.Text
            };
            users.Add(user);
            user.SaveQr();
            
        }

        private void Ent_Button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog load = new OpenFileDialog();
                load.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
                if (load.ShowDialog() == DialogResult.OK)
                {
                    Bitmap loaded_Qr = new Bitmap(load.FileName);
                    QRCodeDecoder decoder = new QRCodeDecoder();
                    string decoded_text = decoder.decode(new QRCodeBitmapImage(loaded_Qr as Bitmap));
                    string[] user = decoded_text.Split(" ");
                    if (users.Count != 0)
                    {
                        foreach (User u in users)
                        {
                            if (u.login == user[0] && u.password == user[1])
                            {
                                MessageBox.Show($"Hello {user[0]}");
                            }
                            else { MessageBox.Show($"User not found"); }
                        }
                    }
                    else { MessageBox.Show($"User not found"); }
                }
            }
            catch { MessageBox.Show("wrong format."); }
        }
    }
}
