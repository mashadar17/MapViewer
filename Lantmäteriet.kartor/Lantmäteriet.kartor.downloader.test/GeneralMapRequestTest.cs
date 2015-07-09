namespace Lantmäteriet.kartor.downloader.test
{
    using MapRequests;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GeneralMapRequestTest
    {
        private string url =
            "http://kso.lantmateriet.se/karta/allmannakartor/wms/v1?Layers=sverigekartan&EXCEPTIONS=application%2Fvnd.ogc.se_xml&FORMAT=image%2Fpng&TRANSPARENT=TRUE&STYLES=default&SERVICE=WMS&VERSION=1.1.1&REQUEST=GetMap&SRS=EPSG%3A3006&BBOX=372864,7059296,503936,7190368&WIDTH=512&HEIGHT=512";

        private string query ="Layers=sverigekartan&EXCEPTIONS=application%2Fvnd.ogc.se_xml&FORMAT=image%2Fpng&TRANSPARENT=TRUE&STYLES=default&SERVICE=WMS&VERSION=1.1.1&REQUEST=GetMap&SRS=EPSG%3A3006&BBOX=372864,7059296,503936,7190368&WIDTH=512&HEIGHT=512";
GeneralMapRequest gmr = new GeneralMapRequest()
            {Layers = GeneralLayers.Sverigekartan,
                EXCEPTIONS = "application%2Fvnd.ogc.se_xml",
                FORMAT = "image%2Fpng",
                TRANSPARENT = true, 
                STYLES = "default",
                SERVICE = Service.WMS,
                VERSION = "1.1.1",
                REQUEST = Request.GetMap,
                SRS = "EPSG%3A3006",
                BBOX = new BBox(372864,7059296,503936,7190368),
                WIDTH = 512, 
                HEIGHT = 512,
               
            };

        [TestMethod]
        public void VerifyCorrectQuery()
        {
            
            var qa = gmr.Query;
           
            Assert.AreEqual(query, qa);
        }

        

        [TestMethod]
        public void VerifyCorrectUrl()
        {
           
            var qa = gmr.GetUrl();
          
            Assert.AreEqual(url, qa);
        }

    }
}