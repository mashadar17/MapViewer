namespace Lantmäteriet.kartor.downloader.test
{
    using MapRequests;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TopoMapRequestTest
    {
        private readonly string call =
            "http://kso.lantmateriet.se/karta/topowebb/v1/wmts?SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0&LAYER=topowebb&STYLE=default&TILEMATRIXSET=3006&TILEMATRIX=11&TILEROW=4436&TILECOL=3288&FORMAT=image%2Fpng";

        private readonly string query =
            "SERVICE=WMTS&REQUEST=GetTile&VERSION=1.0.0&LAYER=topowebb&STYLE=default&TILEMATRIXSET=3006&TILEMATRIX=11&TILEROW=4436&TILECOL=3288&FORMAT=image%2Fpng";

   
        private readonly TopoMapRequest tmr = new TopoMapRequest
        {
            Service = Service.WMTS,
            Request = Request.GetTile,
            Version = "1.0.0",
            Layer = TopoLayers.Topowebb,
            Style = "default",
            Tilematrixset = 3006,
            Tilematrix = 11,
            Tilerow = 4436,
            Tilecol = 3288,
            Format = "image%2Fpng"
        };

        [TestMethod]
        public void VerifyCorrectQuery()
        {
            var qa = tmr.Query;

            Assert.AreEqual(query, qa);
        }

        [TestMethod]
        public void VerifyCorrectUrl()
        {
            var qa = tmr.GetUrl();

            Assert.AreEqual(call, qa);
        }

        [TestMethod]
        public void VerifyRightReturnsCorrectTile()
        {
            var right = (TopoMapRequest) tmr.Right();

            Assert.AreEqual(tmr.Service, right.Service);
            Assert.AreEqual(tmr.Request, right.Request);
            Assert.AreEqual(tmr.Version, right.Version);
            Assert.AreEqual(tmr.Layer, right.Layer);
            Assert.AreEqual(tmr.Style, right.Style);
            Assert.AreEqual(tmr.Format, right.Format);
            Assert.AreEqual(tmr.Tilematrixset, right.Tilematrixset);
            Assert.AreEqual(tmr.Tilematrix, right.Tilematrix);
            Assert.AreEqual(tmr.Tilerow, right.Tilerow);
            Assert.AreEqual(tmr.Tilecol + 1, right.Tilecol);
        }

        [TestMethod]
        public void VerifyLeftReturnsCorrectTile()
        {
            var left = (TopoMapRequest) tmr.Left();

            Assert.AreEqual(tmr.Service, left.Service);
            Assert.AreEqual(tmr.Request, left.Request);
            Assert.AreEqual(tmr.Version, left.Version);
            Assert.AreEqual(tmr.Layer, left.Layer);
            Assert.AreEqual(tmr.Style, left.Style);
            Assert.AreEqual(tmr.Format, left.Format);
            Assert.AreEqual(tmr.Tilematrixset, left.Tilematrixset);
            Assert.AreEqual(tmr.Tilematrix, left.Tilematrix);
            Assert.AreEqual(tmr.Tilerow, left.Tilerow);
            Assert.AreEqual(tmr.Tilecol - 1, left.Tilecol);
        }

        [TestMethod]
        public void VerifyOverReturnsCorrectTile()
        {
            var over = (TopoMapRequest) tmr.Up();

            Assert.AreEqual(tmr.Service, over.Service);
            Assert.AreEqual(tmr.Request, over.Request);
            Assert.AreEqual(tmr.Version, over.Version);
            Assert.AreEqual(tmr.Layer, over.Layer);
            Assert.AreEqual(tmr.Style, over.Style);
            Assert.AreEqual(tmr.Format, over.Format);
            Assert.AreEqual(tmr.Tilematrixset, over.Tilematrixset);
            Assert.AreEqual(tmr.Tilematrix, over.Tilematrix);
            Assert.AreEqual(tmr.Tilerow - 1, over.Tilerow);
            Assert.AreEqual(tmr.Tilecol, over.Tilecol);
        }

        [TestMethod]
        public void VerifyUnderReturnsCorrectTile()
        {
            var under = (TopoMapRequest) tmr.Down();

            Assert.AreEqual(tmr.Service, under.Service);
            Assert.AreEqual(tmr.Request, under.Request);
            Assert.AreEqual(tmr.Version, under.Version);
            Assert.AreEqual(tmr.Layer, under.Layer);
            Assert.AreEqual(tmr.Style, under.Style);
            Assert.AreEqual(tmr.Format, under.Format);
            Assert.AreEqual(tmr.Tilematrixset, under.Tilematrixset);
            Assert.AreEqual(tmr.Tilematrix, under.Tilematrix);
            Assert.AreEqual(tmr.Tilerow + 1, under.Tilerow);
            Assert.AreEqual(tmr.Tilecol, under.Tilecol);
        }
    }
}