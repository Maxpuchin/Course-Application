﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UploaderTest.Models;

namespace UploaderTest.Controllers
{
    public class GamesController : ApiController
    {
        private GameContext games = new GameContext();

        // GET: api/Games
        public IQueryable<Game> GetGames()
        {
            games.Games.Add(new Game { name = "Witcher 3", set = "lg1080", cpu_rate = 40, gpu_rate = 21, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Witcher 3", set = "hg1080", cpu_rate = 53, gpu_rate = 40, ram_rate = 16, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Witcher 3", set = "hg2160", cpu_rate = 60, gpu_rate = 85, ram_rate = 16, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Witcher 3", set = "lg2160", cpu_rate = 53, gpu_rate = 40, ram_rate = 16, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Battlefield 5", set = "lg1080", cpu_rate = 55, gpu_rate = 30, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Battlefield 5", set = "hg1080", cpu_rate = 65, gpu_rate = 45, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Battlefield 5", set = "hg2160", cpu_rate = 70, gpu_rate = 90, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Battlefield 5", set = "lg2160", cpu_rate = 65, gpu_rate = 45, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "CS:GO", set = "lg1080", cpu_rate = 34, gpu_rate = 15, ram_rate = 4, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "CS:GO", set = "hg1080", cpu_rate = 42, gpu_rate = 42, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "CS:GO", set = "hg2160", cpu_rate = 42, gpu_rate = 60, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "CS:GO", set = "lg2160", cpu_rate = 45, gpu_rate = 42, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "ps", set = "mp", cpu_rate = 58, gpu_rate = 24, ram_rate = 4, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "ps", set = "rp", cpu_rate = 64, gpu_rate = 62, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "ap", set = "mp", cpu_rate = 56, gpu_rate = 24, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "ap", set = "rp", cpu_rate = 59, gpu_rate = 40, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "WOW", set = "lg1080", cpu_rate = 44, gpu_rate = 14, ram_rate = 4, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "WOW", set = "hg1080", cpu_rate = 62, gpu_rate = 40, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "WOW", set = "hg2160", cpu_rate = 72, gpu_rate = 60, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "WOW", set = "lg2160", cpu_rate = 62, gpu_rate = 40, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Fortnite", set = "lg1080", cpu_rate = 44, gpu_rate = 14, ram_rate = 4, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Fortnite", set = "hg1080", cpu_rate = 62, gpu_rate = 40, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Fortnite", set = "hg2160", cpu_rate = 72, gpu_rate = 60, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Fortnite", set = "lg2160", cpu_rate = 62, gpu_rate = 40, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "PUBG", set = "lg1080", cpu_rate = 44, gpu_rate = 40, ram_rate = 4, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "PUBG", set = "hg1080", cpu_rate = 62, gpu_rate = 50, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "PUBG", set = "hg2160", cpu_rate = 72, gpu_rate = 70, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "PUBG", set = "lg2160", cpu_rate = 62, gpu_rate = 50, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Dota 2", set = "lg1080", cpu_rate = 34, gpu_rate = 14, ram_rate = 4, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Dota 2", set = "hg1080", cpu_rate = 42, gpu_rate = 24, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Dota 2", set = "hg2160", cpu_rate = 42, gpu_rate = 40, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });
            games.Games.Add(new Game { name = "Dota 2", set = "lg2160", cpu_rate = 45, gpu_rate = 24, ram_rate = 8, hdd_rate = 1, ssd_rate = 1 });


            games.SaveChanges();

            return games.Games;
        }

        // GET: api/Games/5
        [ResponseType(typeof(Game))]
        public IHttpActionResult GetGame(int id)
        {
            Game game = games.Games.Find(id);
            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }

        // PUT: api/Games/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGame(int id, Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != game.Id)
            {
                return BadRequest();
            }

            games.Entry(game).State = EntityState.Modified;

            try
            {
                games.SaveChanges();
            }
            catch (Exception ex)
            {
                if (!GameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Games
        [ResponseType(typeof(Game))]
        public IHttpActionResult PostGame(Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            games.Games.Add(game);
            games.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = game.Id }, game);
        }

        // DELETE: api/Games/5
        [ResponseType(typeof(Game))]
        public IHttpActionResult DeleteGame(int id)
        {
            Game game = games.Games.Find(id);
            if (game == null)
            {
                return NotFound();
            }

            games.Games.Remove(game);
            games.SaveChanges();

            return Ok(game);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                games.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GameExists(int id)
        {
            return games.Games.Count(e => e.Id == id) > 0;
        }
    }
}