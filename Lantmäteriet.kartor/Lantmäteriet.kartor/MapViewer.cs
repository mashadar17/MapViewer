using System;
using System.Drawing;
using System.Windows.Forms;
using Lantmäteriet.kartor.downloader;
using Lantmäteriet.kartor.downloader.MapRequests;

namespace Lantmäteriet.kartor
{
    using static Int32;

    public partial class MapViewer : Form
    {
        private readonly Brush _selectionBrush = new SolidBrush(Color.FromArgb(25, 189, 145, 220));
        private BBox ActiveBBox;
        private Rectangle Rect;
        private Point _rectStartPoint;

        public MapViewer()
        {
            InitializeComponent();
            cbMapType.DataSource = Enum.GetValues((typeof (GeneralLayers)));
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            var url = tbURL.Text;

            try
            {
                var image = ImageLoader.GetImage(url);
                pbMap.Image = image;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btnGetTopoMap_Click(object sender, EventArgs e)
        {
            var tmr = new TopoMapRequest
            {
                Tilematrixset = Parse(tbTopoMatrixSet.Text),
                Tilematrix = Parse(tbTopoMatrix.Text),
                Tilerow = Parse(tbTopoRow.Text),
                Tilecol = Parse(tbTopoCol.Text)
            };

            var i = Parse(tbNrOfTiles.Text);


            try
            {
                var image = ImageLoader.GetImage(tmr, i);
                pbMap.Image = image;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btnTranspose_Click(object sender, EventArgs e)
        {
            var Xpos = Parse(tbposX.Text);
            var Ypos = Parse(tbPosY.Text);
            var Xsize = Parse(tbSizeX.Text);
            var Ysize = Parse(tbSizeY.Text);

            var left = Xpos - Xsize/2;
            var top = Ypos + Ysize/2;
            var right = Xpos + Xsize/2;
            var bottom = Ypos - Ysize/2;

            tbTop.Text = top.ToString();
            tbLeft.Text = left.ToString();
            tbRight.Text = right.ToString();
            tbBottom.Text = bottom.ToString();
        }

        private void pbMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
            }
            // Determine the initial rectangle coordinates...
            _rectStartPoint = e.Location;
            Invalidate();
        }

        private void pbMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            var tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(_rectStartPoint.X, tempEndPoint.X),
                Math.Min(_rectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(_rectStartPoint.X - tempEndPoint.X),
                Math.Abs(_rectStartPoint.Y - tempEndPoint.Y));
            pbMap.Invalidate();
           
        }

        private void pbMap_Paint(object sender, PaintEventArgs e)
        {
            if (pbMap.Image == null) return;
            if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
            {
                e.Graphics.FillRectangle(_selectionBrush, Rect);
            }
        }

        private void pbMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (ActiveBBox == null) return;


            var left = Rect.Width > Rect.Height ? Rect.Left : (Rect.Left + Rect.Right)/2 - Rect.Height/2;
            var right = Rect.Width > Rect.Height ? Rect.Right : (Rect.Left + Rect.Right) / 2 + Rect.Height / 2;

            var top = Rect.Width < Rect.Height
                ? pbMap.Height - Rect.Top
                : (pbMap.Height - Rect.Top + pbMap.Height - Rect.Bottom)/2 + Rect.Width/2;
            var bottom = Rect.Width < Rect.Height
                ? pbMap.Height - Rect.Bottom
                : (pbMap.Height - Rect.Top + pbMap.Height - Rect.Bottom)/2 - Rect.Width/2;


            var aLeft = ActiveBBox.Left;
            var aBottom = ActiveBBox.Bottom;
            var aWidth = ActiveBBox.Width;
            var aHeight = ActiveBBox.Height;

            var d = aWidth/(double) pbMap.Width;
            var newLeft = (int) (aLeft + d*left);
            var newRight = (int) (aLeft + d*right);

            var d1 = aHeight/(double) pbMap.Height;
            var newTop = (int) (aBottom + d1*top);
            var newBottom = (int) (aBottom + d1*bottom);


            tbTop.Text = newTop.ToString();
            tbLeft.Text = newLeft.ToString();
            tbRight.Text = (newRight).ToString();
            tbBottom.Text = (newBottom).ToString();
        }

        private void GetMap_Click(object sender, EventArgs e)
        {
            var selectedText = cbMapType.SelectedValue.ToString();

            var selectedMap = (GeneralLayers) Enum.Parse(typeof (GeneralLayers), selectedText);

            var left = Parse(tbLeft.Text);
            var right = Parse(tbRight.Text);
            var top = Parse(tbTop.Text);
            var bottom = Parse(tbBottom.Text);

            ActiveBBox = new BBox(left, bottom, right, top);

            int imageY;
            if (ActiveBBox.Ratio > 1)
            {
                var d = 800/ActiveBBox.Ratio;
                imageY = (int) d;
            }
            else
            {
                imageY = 800;
            }
            int imageX;
            if (ActiveBBox.Ratio > 1)
            {
                imageX = 800;
            }
            else
            {
                var d = 800*ActiveBBox.Ratio;
                imageX = (int) d;
            }


            var tmr = new GeneralMapRequest
            {
                Layers = selectedMap,
                BBOX = ActiveBBox,
                WIDTH = imageX,
                HEIGHT = imageY
            };


            try
            {
                var image = ImageLoader.GetImage(tmr, 1);
                pbMap.Image = image;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        // Copy the selected area to the clipboard.
        private void CopyToClipboard(Rectangle src_rect)
        {
            // Make a bitmap for the selected area's image.
            var bm = new Bitmap(src_rect.Width, src_rect.Height);

            // Copy the selected area into the bitmap.
            using (var gr = Graphics.FromImage(bm))
            {
                var dest_rect = new Rectangle(0, 0, src_rect.Width, src_rect.Height);
                gr.DrawImage(OriginalImage, dest_rect, src_rect,
                    GraphicsUnit.Pixel);
            }

            // Copy the selection image to the clipboard.
            Clipboard.SetImage(bm);
        }
        private void CopyAllToClipboard()
        {
            var image = pbMap.Image;

            // Copy the selection image to the clipboard.
            Clipboard.SetImage(image);
        }


        public Image OriginalImage => pbMap.Image;

        // Copy the selected area to the clipboard.
        private void mnuEditCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard(SelectedRect);         
        }

        private void mnuEditCopyAll_Click(object sender, EventArgs e)
        {
            CopyAllToClipboard();
            System.Media.SystemSounds.Beep.Play();
        }

        public Rectangle SelectedRect => Rect;
    }
}