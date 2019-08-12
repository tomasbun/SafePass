using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SafePass
{
    public partial class login : Form
    {
        static string filename = "userdata";
        static string directory_path = @"c:\safepass";
        string file_path = directory_path + @"\" + ComputeSha256Hash(filename) + ".txt";

        int number_of_files = 0;
        List<User> all_users = new List<User>();

        public login()
        {
            InitializeComponent();
           

            username_txtbox.Focus();
            if (Directory.Exists(directory_path))
                number_of_files = Directory.GetFiles(directory_path).Length;
            
            if ( (!Directory.Exists(directory_path)) || (number_of_files == 0) || (!File.Exists(file_path)) )
            {
                Directory.CreateDirectory(directory_path);
                File.WriteAllText(file_path, EncryptData("admin 1234", "admin") + "\n");
                MessageBox.Show("No profiles detected please register first! ");
                repeat_password_txtbox.TabStop = true;
                panel1.Height = 125;
                button1.Text = "Register";
                button2.Text = "Login";
                button2.Enabled = false;                
            }
        }

       //------------------------- events ---------------------------------------------------

        private void username_txtbox_Enter(object sender, EventArgs e)
        {
            if (username_txtbox.Text == "Username")
            {
                username_txtbox.Text = "";
                username_txtbox.ForeColor = Color.Black;
            }

            if (password_txtbox.Text == "")
            {
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
            }

            if (repeat_password_txtbox.Text == "")
            {
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
        }

        private void password_txtbox_Enter(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "Password")
            {
                password_txtbox.Text = "";
                password_txtbox.ForeColor = Color.Black;
            }

            if (username_txtbox.Text == "")
            {
                username_txtbox.Text = "Username";
                username_txtbox.ForeColor = Color.DarkGray;
            }
            if (repeat_password_txtbox.Text == "")
            {
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
        }
        
        private void repeat_password_txtbox_Enter(object sender, EventArgs e)
        {
            if (repeat_password_txtbox.Text == "Repeat password")
            {
                repeat_password_txtbox.Text = "";
                repeat_password_txtbox.ForeColor = Color.Black;
            }

            if (username_txtbox.Text == "")
            {
                username_txtbox.Text = "Username";
                username_txtbox.ForeColor = Color.DarkGray;
                            }
            if (password_txtbox.Text == "")
            {
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Register")
            {
                if (username_txtbox.Text.Length < 5 )
                {
                    MessageBox.Show("Username has to be at least 5 characters long");
                }
                else if (username_txtbox.Text.Contains(' ') || password_txtbox.Text.Contains(' '))
                {
                    MessageBox.Show("No spaces allowed");
                }
                else if (password_txtbox.Text != repeat_password_txtbox.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else
                {                   
                    using (StreamWriter file = new StreamWriter(file_path, true))
                    {
                      file.WriteLine(EncryptData(username_txtbox.Text.Trim() + " " + password_txtbox.Text.Trim(), username_txtbox.Text.Trim()) );
                    }
                                        
                    MessageBox.Show("Registration successful!");
                    this.Hide();
                    Control control_form = new Control(username_txtbox.Text);
                    control_form.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                read_users();
                foreach (User u in all_users)
                {
                    if ((u.GetUsername() == username_txtbox.Text) && (u.GetPassword() == password_txtbox.Text))
                    {
                        this.Hide();
                        Control control_form = new Control(username_txtbox.Text);
                        control_form.ShowDialog();
                        this.Close();
                    }
                }
                MessageBox.Show("Username or password incorect!");
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Register")
            {
                panel1.Height = 125;
                button1.Text = "Register";
                button2.Text = "Login";
                repeat_password_txtbox.TabStop = true;
                username_txtbox.Focus();
                username_txtbox.Text = "";
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
            else
            {
                panel1.Height = 84;
                button1.Text = "Login";
                button2.Text = "Register";
                repeat_password_txtbox.TabStop = false;
                username_txtbox.Focus();
                username_txtbox.Text = "";
                password_txtbox.Text = "Password";
                password_txtbox.ForeColor = Color.DarkGray;
                repeat_password_txtbox.Text = "Repeat password";
                repeat_password_txtbox.ForeColor = Color.DarkGray;
            }
        }
        
        //------------------------- methods -------------------------------------------------

        private void read_users()
        {
            
            String[] lines = File.ReadAllLines(file_path);
            foreach (string line in lines)
            {
                string n = DecryptData_nopadding(line, username_txtbox.Text);
                if ( n.Trim().Contains(' '))
                {
                    string[] details = DecryptData(line, username_txtbox.Text).Split();
                    User new_user = new User(details[0], details[1]);
                    all_users.Add(new_user);                       
                }
                    
            }
           
        }

        static void Encryptfile(string filepath, string key)
        {
            byte[] plainContent = File.ReadAllBytes(filepath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;


                using (var memStream = new MemoryStream())
                {
                     CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filepath, memStream.ToArray());
                    MessageBox.Show("Encryption succesfull");
                }

            }

        }

        static void Decryptfile(string filepath, string key)
        {
            byte[] encrypted = File.ReadAllBytes(filepath);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;


                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(),
                       CryptoStreamMode.Write);

                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filepath, memStream.ToArray());
                    MessageBox.Show("Decryption succesfull");
                }

            }

        }
               
        public string EncryptData(string textData, string Encryptionkey)
        {
            RijndaelManaged objrij = new RijndaelManaged();
            //set the mode for operation of the algorithm
            objrij.Mode = CipherMode.CBC;
            //set the padding mode used in the algorithm.
            //objrij.Padding = PaddingMode.None;
            objrij.Padding = PaddingMode.PKCS7;
            //set the size, in bits, for the secret key.
            objrij.KeySize = 0x80;
            //set the block size in bits for the cryptographic operation.
            objrij.BlockSize = 0x80;
            //set the symmetric key that is used for encryption & decryption.
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            //set the initialization vector (IV) for the symmetric algorithm
            byte[] EncryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }

            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            //Creates symmetric AES object with the current key and initialization vector IV.
            ICryptoTransform objtransform = objrij.CreateEncryptor();
            byte[] textDataByte = Encoding.UTF8.GetBytes(textData);
            //Final transform the test string.
            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));

        }

        public string DecryptData(string EncryptedText, string Encryptionkey)

        {
            RijndaelManaged objrij = new RijndaelManaged();
            objrij.Mode = CipherMode.CBC;
            objrij.Padding = PaddingMode.PKCS7;
            objrij.BlockSize = 0x80;
            byte[] encryptedTextByte = Convert.FromBase64String(EncryptedText);
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            byte[] EncryptionkeyBytes = new byte[0x10];
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            byte[] TextByte = objrij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            return Encoding.UTF8.GetString(TextByte);  
        }

        public string DecryptData_nopadding(string EncryptedText, string Encryptionkey)

        {
            RijndaelManaged objrij = new RijndaelManaged();
            objrij.Mode = CipherMode.CBC;
            objrij.Padding = PaddingMode.None;
            objrij.BlockSize = 0x80;
            byte[] encryptedTextByte = Convert.FromBase64String(EncryptedText);
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            byte[] EncryptionkeyBytes = new byte[0x10];
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            objrij.Key = EncryptionkeyBytes;
            objrij.IV = EncryptionkeyBytes;
            byte[] TextByte = objrij.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            return Encoding.UTF8.GetString(TextByte);
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
