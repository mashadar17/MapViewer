namespace Lantmäteriet.kartor
{
    using System;
    using System.Windows.Forms;
    using downloader;
    using static System.Int32;

    public partial class MapViewer : Form
    {
        public MapViewer()
        {
            InitializeComponent();
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
            var tmr = new TopMapRequest
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
    }
}