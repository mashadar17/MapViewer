namespace Lantmäteriet.kartor.downloader.MapRequests
{
    using System;
    using System.Net;

    public class GeneralMapRequest :  IMapRequest
    {
        string host = "kso.lantmateriet.se";
        string path = "karta/allmannakartor/wms/v1";
        string scheme = "http";
        public GeneralMapRequest()
        {
            
            SERVICE = Service.WMS;
            REQUEST = Request.GetMap;
            VERSION = "1.1.1";
            Layers = GeneralLayers.Terrangkartan;
            STYLES = "default";
            FORMAT = "image%2Fpng";
            EXCEPTIONS = "application%2Fvnd.ogc.se_xml";
            TRANSPARENT = true;
            SRS = "EPSG%3A3006";
        }

        public string GetUrl()
        {
            var s = $"{scheme}://{host}/{path}?{Query}";

            return s;
        }

        public BBox BBOX { get; set; }
        public Enum Layers { get; set; }
        public string EXCEPTIONS { get; set; }
        public string Query => GetQuery();
        public bool TRANSPARENT { get; set; }
        public string STYLES { get; set; }
        public Service SERVICE { get; set; }
        public string VERSION { get; set; }
        public Request REQUEST { get; set; }
        public string SRS { get; set; }
        //
        //värden mellan 0 och 4096
        //
        public int WIDTH { get; set; }
        public int HEIGHT { get; set; }
        public string FORMAT { get; set; }

        public WebRequest GetRequest()
        {
            var request = WebRequest.Create(GetUrl());
            return request;
        }

        public IMapRequest Left(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBOX = BBOX.GetBoxLeft(steps);
            return mapRequest;
        }

        public IMapRequest Right(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBOX = BBOX.GetBoxRight(steps);
            return mapRequest;
        }

        public IMapRequest Up(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBOX = BBOX.GetBoxOver(steps);
            return mapRequest;
        }

        public IMapRequest Down(int steps = 1)
        {
            var mapRequest = (GeneralMapRequest) MemberwiseClone();
            mapRequest.BBOX = BBOX.GetBoxUnder(steps);
            return mapRequest;
        }

        private string GetQuery()
        {
            string g = $"LAYERS={Layers.ToString().ToLower()}&";
            g += $"EXCEPTIONS={EXCEPTIONS}&";
            g += $"FORMAT={FORMAT}&";
            g += $"TRANSPARENT={TRANSPARENT.ToString().ToUpper()}&";
            g += $"STYLES={STYLES}&";
            g += $"SERVICE={SERVICE}&";
            g += $"VERSION={VERSION}&";
            g += $"REQUEST={REQUEST}&";
            g += $"SRS={SRS}&";
            g += $"BBOX={BBOX}&";
            g += $"WIDTH={WIDTH}&";
            g += $"HEIGHT={HEIGHT}";

            return g;
        }
    }

}