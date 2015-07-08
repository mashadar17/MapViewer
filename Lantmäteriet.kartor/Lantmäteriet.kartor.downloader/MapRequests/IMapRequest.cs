namespace Lantmäteriet.kartor.downloader
{
    using System.Net;

    public interface IMapRequest
    {
         string GetUrl();

         WebRequest GetRequest();

        IMapRequest Left(int steps = 1);
        IMapRequest Right(int steps = 1);
        IMapRequest Up(int steps = 1);
        IMapRequest Down(int steps = 1);
    }
}