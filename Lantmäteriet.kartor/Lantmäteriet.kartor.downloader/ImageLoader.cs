namespace Lantmäteriet.kartor.downloader
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Net;

    public static class ImageLoader
    {
        public static Image GetImage(string url)
        {
            Image i = null;
            var request = WebRequest.Create(url);
            try
            {
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null) i = Image.FromStream(stream);
                }
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Image GetImage(IMapRequest tmr)
        {
            Image i = null;
            var request = tmr.GetRequest();

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                if (stream != null) i = Image.FromStream(stream);
            }
            return i;
        }

        public static Image GetImage(TopMapRequest tmr, int v)
        {
            var images = new List<Image>();

            int startChange;

            if (v%2 == 0)
            {
                startChange = v/2 - 1;
            }
            else
            {
                startChange = (v - 1)/2;
            }


            var topMapRequest = tmr.Left(startChange);
            topMapRequest = topMapRequest.Up(startChange);


            for (var row = 0; row < v; row++)
            {
                for (var col = 0; col < v; col++)
                {
                    images.Add(GetImage(topMapRequest));
                    topMapRequest = topMapRequest.Right();
                }
                topMapRequest = topMapRequest.Left(v).Down();
            }

            images.TrimExcess();

            return JoinImages(images);
        }

        private static Image JoinImages(List<Image> images)
        {
            var height = images[0].Height;
            var width = images[0].Width;

            var count = images.Count;
            var tiles = (int) Math.Sqrt(count);


            var b = new Bitmap(width*tiles, height*tiles);
            var graphics = Graphics.FromImage(b);

            graphics.Clear(SystemColors.AppWorkspace);


            var enumerator = images.GetEnumerator();
            for (var row = 0; row < tiles; row++)
            {
                var currnetHeight = height*row;
                for (var column = 0; column < tiles; column++)
                {
                    var currentWidth = column*width;
                    enumerator.MoveNext();
                    var img = enumerator.Current;
                    graphics.DrawImage(img, new Point(currentWidth, currnetHeight));
                }
            }

            return b;
        }
    }
}