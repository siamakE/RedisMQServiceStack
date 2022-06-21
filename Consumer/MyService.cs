using System;
using System.Collections.Generic;
using System.Text;
using MyApp.ServiceModel;
using ServiceStack;

namespace MyApp
{
    public class MyService : Service
    {
        public object Any(DeleteAlbums request) => new
        {
            Result = $"Deleted ID =  {request.AlbumId}!"
        };
        public object Any(CreateAlbums request) => new
        {
            Result = $"Album =  {request.Title}, {request.ArtistId}!"
        };
    }
}
