using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace TransparentScreenshot
{

	public partial class Form1 : Form
	{
		Bitmap whiteMap = null;
		Bitmap blackMap = null;

		public Form1()
		{
			InitializeComponent();
		}

		private static unsafe Bitmap DifferentiateAlpha(Bitmap whiteBitmap, Bitmap blackBitmap, bool whiteAlgorithm)
		{
			if (whiteBitmap == null || blackBitmap == null || whiteBitmap.Width != blackBitmap.Width || whiteBitmap.Height != blackBitmap.Height)
				return null;
			int sizeX = whiteBitmap.Width;
			int sizeY = whiteBitmap.Height;
			var final = new Bitmap(sizeX, sizeY, PixelFormat.Format32bppArgb);
			var a = new UnsafeBitmap(whiteBitmap);
			var b = new UnsafeBitmap(blackBitmap);
			var f = new UnsafeBitmap(final);
			a.LockImage();
			b.LockImage();
			f.LockImage();

			bool empty = true;

			for (int x = 0, y = 0; x < sizeX && y < sizeY;)
			{
				PixelData* pixelA = a.GetPixel(x, y);
				PixelData* pixelB = b.GetPixel(x, y);
				PixelData* pixelF = f.GetPixel(x, y);

				pixelF->Alpha = ToByte((pixelB->Red - pixelA->Red + 255 + pixelB->Green - pixelA->Green + 255 + pixelB->Blue - pixelA->Blue + 255) / 3);
				if (pixelF->Alpha > 0)
				{
					if (whiteAlgorithm)
					{
						// Following math creates an image optimized to be displayed on a white background
						pixelF->Red = ToByte(255 * (pixelA->Red + pixelF->Alpha - 255) / pixelF->Alpha);
						pixelF->Green = ToByte(255 * (pixelA->Green + pixelF->Alpha - 255) / pixelF->Alpha);
						pixelF->Blue = ToByte(255 * (pixelA->Blue + pixelF->Alpha - 255) / pixelF->Alpha);
					}
					else
					{
						// Following math creates an image optimized to be displayed on a black background
						pixelF->Red = ToByte(255 * pixelB->Red / pixelF->Alpha);
						pixelF->Green = ToByte(255 * pixelB->Green / pixelF->Alpha);
						pixelF->Blue = ToByte(255 * pixelB->Blue / pixelF->Alpha);
					}
				}
				if (empty && pixelF->Alpha > 0)
					empty = false;

				if (x == sizeX - 1)
				{
					y++;
					x = 0;
					continue;
				}
				x++;
			}

			a.UnlockImage();
			b.UnlockImage();
			f.UnlockImage();
			return empty ? null : final;
		}

		private static byte ToByte(int i)
		{
			return (byte)(i > 255 ? 255 : (i < 0 ? 0 : i));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBoxWhite.Image = whiteMap;
			pictureBoxBlack.Image = blackMap;

		}

		private void buttonWhite_Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() != DialogResult.OK) return;

			whiteMap = new Bitmap(openFileDialog1.FileName);
			pictureBoxWhite.Image = whiteMap;
			pictureBoxWhite.Refresh();
		}

		private void buttonBlack_Click(object sender, EventArgs e)
		{
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            blackMap = new Bitmap(openFileDialog1.FileName);
			pictureBoxBlack.Image = blackMap;
			pictureBoxBlack.Refresh();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
            if (whiteMap == null || blackMap == null)
			{
				MessageBox.Show("You need to select both screenshots.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
				
			if(whiteMap.Width != blackMap.Width || whiteMap.Height != blackMap.Height)
			{
                MessageBox.Show("Screenshot resolutions don't match.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.ShowDialog();
		}

		private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Bitmap f = DifferentiateAlpha(whiteMap, blackMap, checkBoxWhite.Checked);
			f.Save(saveFileDialog1.FileName, ImageFormat.Png);
		}

		private void buttonBatch_Click(object sender, EventArgs e)
		{
			openFileDialog1.Multiselect = true;
			this.openFileDialog1.Title = "Choose white background images";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            String[] whites = openFileDialog1.FileNames;
			this.openFileDialog1.Title = "Choose black background images";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            String[] blacks = openFileDialog1.FileNames;
			if(whites.Length == blacks.Length)
			{
				int i = 0;
				foreach(String whiteFile in whites)
				{
					String blackFile = blacks[i];
					Bitmap f = DifferentiateAlpha(new Bitmap(whiteFile), new Bitmap(blackFile), checkBoxWhite.Checked);
					f.Save($"{Path.GetDirectoryName(whiteFile)}\\{Path.GetFileNameWithoutExtension(whiteFile)}_transparent.png", ImageFormat.Png);
					i++;
				}
			}
			else
			{
				MessageBox.Show("You have to use the same amount of files both times.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}
	}
}
