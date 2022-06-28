namespace TransparentScreenshot
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.pictureBoxWhite = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxWhite = new System.Windows.Forms.CheckBox();
            this.buttonBatch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonWhite, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBlack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxWhite, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxBlack, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonWhite
            // 
            this.buttonWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWhite.Location = new System.Drawing.Point(3, 3);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(394, 24);
            this.buttonWhite.TabIndex = 0;
            this.buttonWhite.Text = "Select white background screenshot";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlack.Location = new System.Drawing.Point(403, 3);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(394, 24);
            this.buttonBlack.TabIndex = 1;
            this.buttonBlack.Text = "Select black background screenshot";
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWhite.Location = new System.Drawing.Point(3, 33);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(394, 384);
            this.pictureBoxWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWhite.TabIndex = 2;
            this.pictureBoxWhite.TabStop = false;
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBlack.Location = new System.Drawing.Point(403, 33);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(394, 384);
            this.pictureBoxBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlack.TabIndex = 3;
            this.pictureBoxBlack.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(403, 423);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(394, 24);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save transparent screenshot";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxWhite);
            this.panel1.Controls.Add(this.buttonBatch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 24);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxWhite
            // 
            this.checkBoxWhite.AutoSize = true;
            this.checkBoxWhite.Location = new System.Drawing.Point(106, 4);
            this.checkBoxWhite.Name = "checkBoxWhite";
            this.checkBoxWhite.Size = new System.Drawing.Size(159, 17);
            this.checkBoxWhite.TabIndex = 1;
            this.checkBoxWhite.Text = "White background algorithm";
            this.checkBoxWhite.UseVisualStyleBackColor = true;
            // 
            // buttonBatch
            // 
            this.buttonBatch.Location = new System.Drawing.Point(0, 0);
            this.buttonBatch.Name = "buttonBatch";
            this.buttonBatch.Size = new System.Drawing.Size(99, 23);
            this.buttonBatch.TabIndex = 0;
            this.buttonBatch.Text = "Batch command";
            this.buttonBatch.UseVisualStyleBackColor = true;
            this.buttonBatch.Click += new System.EventHandler(this.buttonBatch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG|*.png";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG|*.png";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Transparent Screenshot Very Epic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button buttonWhite;
		private System.Windows.Forms.Button buttonBlack;
		private System.Windows.Forms.PictureBox pictureBoxWhite;
		private System.Windows.Forms.PictureBox pictureBoxBlack;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxWhite;
		private System.Windows.Forms.Button buttonBatch;
	}
}

