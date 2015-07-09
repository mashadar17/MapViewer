namespace Lantmäteriet.kartor.downloader.MapRequests
{
    using Lantmäteriet.kartor.downloader;
    using System;
    using System.Net;

    public class TopoMapRequest : IMapRequest
    {
        private readonly string host = "kso.lantmateriet.se";
        private readonly string path = "karta/topowebb/v1/wmts";
        private readonly string scheme = "http";

        public TopoMapRequest()
        {
            Service = Service.WMTS;
            Request = Request.GetTile;
            Version = "1.0.0";
            Layer = TopoLayers.Topowebb;
            Style = "default";
            Format = "image%2Fpng";
        }

        public string Format { get; set; }
        public Enum Layer { get; set; }
        public Request Request { get; set; }
        public Service Service { get; set; }
        public string Style { get; set; }
        public int Tilecol { get; set; }
        public int Tilematrix { get; set; }
        public int Tilematrixset { get; set; }
        public int Tilerow { get; set; }
        public string Version { get; set; }
        public string Query => GetQuery();


        public string GetUrl()
        {
            var s = $"{scheme}://{host}/{path}?{Query}";

            return s;
        }

        public WebRequest GetRequest()
        {
            var request = WebRequest.Create(GetUrl());

            return request;
        }

        public IMapRequest Left(int steps = 1)
        {
            var topMapRequest = (TopoMapRequest) MemberwiseClone();
            topMapRequest.Tilecol = Tilecol - steps;
            return topMapRequest;
        }

        public IMapRequest Right(int steps = 1)
        {
            var topMapRequest = (TopoMapRequest) MemberwiseClone();
            topMapRequest.Tilecol = Tilecol + steps;
            return topMapRequest;
        }

        public IMapRequest Up(int steps = 1)
        {
            var topMapRequest = (TopoMapRequest) MemberwiseClone();
            topMapRequest.Tilerow = Tilerow - steps;
            return topMapRequest;
        }

        public IMapRequest Down(int steps = 1)
        {
            var topMapRequest = (TopoMapRequest) MemberwiseClone();
            topMapRequest.Tilerow = Tilerow + steps;
            return topMapRequest;
        }

        private string GetQuery()
        {
            string s = $"SERVICE={Service}&";
            s += $"REQUEST={Request}&";
            s += $"VERSION={Version}&";
            s += $"LAYER={Layer.ToString().ToLower()}&";
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