using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		private void DecryptButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string fileName = openFileDialog.FileName;
				byte[] array = File.ReadAllBytes(fileName);
				string text = "t36gref9u84y7f43g";
				bool flag2 = string.IsNullOrEmpty(text);
				if (flag2)
				{
					MessageBox.Show("Please provide a decryption password");
				}
				else
				{
					byte[] array2 = new byte[16];
					Array.Copy(array, array2, 16);
					byte[] array3 = new byte[array.Length - 16];
					Array.Copy(array, 16, array3, 0, array.Length - 16);
					try
					{
						Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(text, array2, 100);
						byte[] bytes = rfc2898DeriveBytes.GetBytes(16);
						using (Aes aes = Aes.Create())
						{
							aes.Mode = CipherMode.CBC;
							aes.Padding = PaddingMode.PKCS7;
							aes.Key = bytes;
							aes.IV = array2;
							ICryptoTransform transform = aes.CreateDecryptor();
							using (MemoryStream memoryStream = new MemoryStream(array3))
							{
								using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
								{
									using (StreamReader streamReader = new StreamReader(cryptoStream))
									{
										string contents = streamReader.ReadToEnd();
										string path = Path.Combine(Path.GetDirectoryName(fileName), "DecryptedSaveFile.txt");
										File.WriteAllText(path, contents);
										MessageBox.Show("File decrypted successfully and saved as 'DecryptedSaveFile.txt'");
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("Decryption error: " + ex.Message);
						MessageBox.Show("Decryption error: Please make sure you're selecting the 'SaveFile' not the 'SaveData'");
					}
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002244 File Offset: 0x00000444
		private void EncryptButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string fileName = openFileDialog.FileName;
				bool flag2 = fileName == null;
				if (flag2)
				{
					MessageBox.Show("No file chosen. Please select a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					byte[] array = new byte[16];
					using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
					{
						rngcryptoServiceProvider.GetBytes(array);
					}
					string s = "t36gref9u84y7f43g";
					byte[] bytes = Encoding.UTF8.GetBytes(s);
					try
					{
						using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 100))
						{
							ICryptoTransform transform = new RijndaelManaged
							{
								KeySize = 128,
								BlockSize = 128,
								Mode = CipherMode.CBC,
								Padding = PaddingMode.PKCS7
							}.CreateEncryptor(rfc2898DeriveBytes.GetBytes(16), array);
							using (MemoryStream memoryStream = new MemoryStream())
							{
								using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
								{
									byte[] array2 = File.ReadAllBytes(fileName);
									cryptoStream.Write(array2, 0, array2.Length);
								}
								byte[] array3 = memoryStream.ToArray();
								byte[] array4 = new byte[array.Length + array3.Length];
								Buffer.BlockCopy(array, 0, array4, 0, array.Length);
								Buffer.BlockCopy(array3, 0, array4, array.Length, array3.Length);
								SaveFileDialog saveFileDialog = new SaveFileDialog();
								string path = Path.Combine(Path.GetDirectoryName(fileName), "EncryptedFile.txt");
								File.WriteAllBytes(path, array4);
								MessageBox.Show("File encrypted and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
						}
					}
					catch (Exception value)
					{
						Console.WriteLine(value);
						MessageBox.Show("Failed to encrypt the file. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}
	}
}
