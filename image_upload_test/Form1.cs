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
using image_upload_test.model;
using MySql.Data.MySqlClient;

namespace image_upload_test
{
	public partial class Form1 : Form
	{
		MySqlDataAdapter adapter;
		String imageLoc = "";
		public Form1()
		{
			InitializeComponent();
			DB.initializedDB();
		}

		private void btn_browse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				imageLoc = dialog.FileName.ToString();
				pictureBox1.ImageLocation = imageLoc;
			}
			textBox1.Text = imageLoc;
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			byte[] img = imgToByteArray(pictureBox1.Image);
			/*FileStream stream = new FileStream(imageLoc,FileMode.Open,FileAccess.Read);
			BinaryReader breader = new BinaryReader(stream);
			img = breader.ReadBytes((int)stream.Length);*/

			MessageBox.Show(File.ReadAllBytes(textBox1.Text).ToString());
			MessageBox.Show(imgToByteArray(pictureBox1.Image).ToString());

			
			String sql = "INSERT INTO bio_data(id, name, image) " +
								"VALUES('"+ txt_ID.Text + "','"+ txt_name.Text + "',@image)";

			if (DB.putDataImg(sql, img) > 0)
			{
				MessageBox.Show("Image saved sucessfully!");
			}

			/*MySqlConnection dbConn = DB.getConn();
			MySqlCommand cmd = new MySqlCommand(sql, dbConn);
			dbConn.Open();

			
			cmd.Parameters.Add("@image", MySqlDbType.Blob);

			cmd.Parameters["@image"].Value = img;

			int RowsAffected = cmd.ExecuteNonQuery();

			if (RowsAffected > 0)
			{
				MessageBox.Show("Image saved sucessfully!");
			}

			dbConn.Close();*/
		}

		public byte[] imgToByteArray(Image img)
		{
			using (MemoryStream mStream = new MemoryStream())
			{
				img.Save(mStream, img.RawFormat);
				return mStream.ToArray();
			}
		}
		private void btn_view_Click(object sender, EventArgs e)
		{

			adapter = new MySqlDataAdapter();

			String sql = String.Format("SELECT * FROM bio_data " +
				"WHERE id = '{0}'", txt_ID.Text);

			var record = DB.getData(sql);

			if(record == null)
			{
				MessageBox.Show("no data");
				return;
			}
			//convert datareader to data table
			//then I can fetch one row
			while(record.Read())
			{
				txt_ID.Text = record["id"].ToString();
				txt_name.Text = record["name"].ToString();
				byte[] img = (byte[])record["image"];
				//convert binary to image
				MemoryStream ms = new MemoryStream(img);
				pictureBox1.Image = System.Drawing.Image.FromStream(ms);
			}
			

			
			

			
			
			
			

		}
	}
}
