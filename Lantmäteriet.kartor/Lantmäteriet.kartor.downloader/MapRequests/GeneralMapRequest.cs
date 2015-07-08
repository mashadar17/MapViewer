namespace Lantmäteriet.kartor.downloader
{
    using System;
    using System.Net;

    public class GeneralMapRequest : IMapRequest
    {
        private readonly string host = "kso.lantmateriet.se";
        private readonly string path = "karta/allmannakartor/wms/v1";
        private readonly string scheme = "http";

        public GeneralMapRequest(string url)
        {
            Service = "WMS";
            Request = "GetTile";
            Version = "1.1.1";
            Layer = "terrangkartan";
            Style = "default";
            Format = "image%2Fpng";
            Exceptions = "application%2Fvnd.ogc.se_xml";
            Transparent = true;
            Srs = "EPSG%3A3006";
            BBox = new BBox(482824.27469952, 6225778.7269399, 484178.11562848, 6227132.5678689);
            Width = 512;
            Height = 512;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public BBox BBox { get; set; }
        public string Srs { get; set; }
        public bool Transparent { get; set; }
        public string Exceptions { get; set; }
        public string Format { get; set; }
        public string Layer { get; set; }
        public string Request { get; set; }
        public string Service { get; set; }
        public string Style { get; set; }
        public string Version { get; set; }
        public string Query => GetQuery();

        public string GetUrl()
        {
            var ub = new UriBuilder(scheme, host)
            {
                Path = path,
                Query = Query
            };
            var uri = ub.Uri;
            return uri.ToString();
        }

        public WebRequest GetRequest()
        {
            var request = WebRequest.Create(GetUrl());
            return request;
        }

        public IMapRequest Left(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBox = BBox.Left(steps);
            return mapRequest;
        }

        public IMapRequest Right(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBox = BBox.Right(steps);
            return mapRequest;
        }

        public IMapRequest Up(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBox = BBox.Up(steps);
            return mapRequest;
        }

        public IMapRequest Down(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBox = BBox.Down(steps);
            return mapRequest;
        }

        private string GetQuery()
        {
            string g = $"LAYERS={Layer}&";
            g += $"EXCEPTIONS={Exceptions}&";
            g += $"FORMAT={Format}&";
            g += $"TRANSPARENT={Transparent.ToString().ToUpper()}&";
            g += $"STYLES={Style}&";
            g += $"SERVICE={Service}&";
            g += $"VERSION={Version}&";
            g += $"REQUEST={Request}&";
            g += $"SRS={Srs}&";
            g += $"BBOX={BBox}&";
            g += $"WIDTH={Width}&";
            g += $"HEIGHT={Height}";

            return g;
        }
    }
}