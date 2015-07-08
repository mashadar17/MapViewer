namespace Lantmäteriet.kartor.downloader
{
    using System;
    using System.Net;

    public class TopMapRequest : IMapRequest
    {
        private readonly string host = "kso.lantmateriet.se";
        private readonly string path = "karta/topowebb/v1/wmts";
        private readonly string scheme = "http";

        public TopMapRequest()
        {
            Service = "WMTS";
            Request = "GetTile";
            Version = "1.0.0";
            Layer = "topowebb";
            Style = "default";
            Format = "image%2Fpng";
        }

        public string Format { get; set; }
        public string Layer { get; set; }
        public string Request { get; set; }
        public string Service { get; set; }
        public string Style { get; set; }
        public int Tilecol { get; set; }
        public int Tilematrix { get; set; }
        public int Tilematrixset { get; set; }
        public int Tilerow { get; set; }
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
            var topMapRequest = (TopMapRequest) MemberwiseClone();
            topMapRequest.Tilecol = Tilecol - steps;
            return topMapRequest;
        }

        public IMapRequest Right(int steps = 1)
        {
            var topMapRequest = (TopMapRequest) MemberwiseClone();
            topMapRequest.Tilecol = Tilecol + steps;
            return topMapRequest;
        }

        public IMapRequest Up(int steps = 1)
        {
            var topMapRequest = (TopMapRequest) MemberwiseClone();
            topMapRequest.Tilerow = Tilerow - steps;
            return topMapRequest;
        }

        public IMapRequest Down(int steps = 1)
        {
            var topMapRequest = (TopMapRequest) MemberwiseClone();
            topMapRequest.Tilerow = Tilerow + steps;
            return topMapRequest;
        }

        private string GetQuery()
        {
            string s = $"SERVICE={Service}&";
            s += $"REQUEST={Request}&";
            s += $"VERSION={Version}&";
            s += $"LAYER={Layer}&";
            s += $"STYLE={Style}&";
            s += $"TILEMATRIXSET={Tilematrixset}&";
            s += $"TILEMATRIX={Tilematrix}&";
            s += $"TILEROW={Tilerow}&";
            s += $"TILECOL={Tilecol}&";
            s += $"FORMAT={Format}";
            return s;
        }
    }
}