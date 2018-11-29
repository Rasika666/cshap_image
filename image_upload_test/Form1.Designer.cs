namespace image_upload_test
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_ID = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_view = new System.Windows.Forms.Button();
			this.btn_browse = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(106, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(106, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// txt_ID
			// 
			this.txt_ID.Location = new System.Drawing.Point(206, 79);
			this.txt_ID.Name = "txt_ID";
			this.txt_ID.Size = new System.Drawing.Size(252, 22);
			this.txt_ID.TabIndex = 1;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(206, 133);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(252, 22);
			this.txt_name.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(639, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(231, 261);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(175, 329);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(75, 23);
			this.btn_save.TabIndex = 3;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_view
			// 
			this.btn_view.Location = new System.Drawing.Point(354, 329);
			this.btn_view.Name = "btn_view";
			this.btn_view.Size = new System.Drawing.Size(75, 23);
			this.btn_view.TabIndex = 3;
			this.btn_view.Text = "View";
			this.btn_view.UseVisualStyleBackColor = true;
			this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
			// 
			// btn_browse
			// 
			this.btn_browse.Location = new System.Drawing.Point(709, 397);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(75, 23);
			this.btn_browse.TabIndex = 3;
			this.btn_browse.Text = "Browse";
			this.btn_browse.UseVisualStyleBackColor = true;
			this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(302, 444);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(418, 22);
			this.textBox1.TabIndex = 4;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 529);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btn_browse);
			this.Controls.Add(this.btn_view);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.txt_ID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_ID;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_view;
		private System.Windows.Forms.Button btn_browse;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}

