using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        // creates a new List object, and initializes two Song objects.
        // This is hard coded just for demonstration/testing Get and Post requests on Postman
        private static List<Song> songs = new List<Song>()
        {
            new Song(){Id = 0, Title = "Willow", Language = "English" },
            new Song(){Id = 1, Title = "After Glow", Language = "English" },

        };

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            // this method returns IEnumerable because we want to get the list of songs
            return songs;
        }

        [HttpPost]
        public void Post([FromBody]Song song)
        {
            // FromBody specifies that we will get the song data from the body of the request
            songs.Add(song);
        }

    }
}