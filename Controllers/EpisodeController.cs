using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GamesGlobalAssessment.Data;
using GamesGlobalAssessment.Models;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace GamesGlobalAssessment.Controllers
{
    [Authorize]
    public class EpisodeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public EpisodeController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: Episode
        public async Task<IActionResult> Index(string search)
        {
            string username = _httpContextAccessor.HttpContext.Session.GetString("Username"); //Gets the username from the session
            var userID = from x in _context.Users.ToList() //Gets the userID by the username
                         where x.Username == username
                         select x.UserID;

            var results = await _context.ViewEpisodes.Where(x => x.UserID == userID.First()).ToListAsync();

            #region SearchFilters 
            if (!string.IsNullOrEmpty(search))
                results = results.Where(x => x.EpisodeName == search || x.Title == search || x.Year.ToString() == search).ToList();
            #endregion

            return View(results);
        }

        // GET: Episode/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Episode/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EpisodeID,EpisodeNo,Year,EpisodeName,Season,TVShowID,Watched")] Episode episode)
        {
            if (ModelState.IsValid)
            {
                Episode entity = new Episode();
                entity.EpisodeNo = episode.EpisodeNo;
                entity.EpisodeName = episode.EpisodeName;
                entity.Season = episode.Season;
                entity.TVShowID = episode.TVShowID;

                _context.Add(entity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(episode);
        }

        // GET: Episode/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var episode = await _context.Episode.FindAsync(id);
            if (episode == null)
            {
                return NotFound();
            }

            var getTVShow = from x in _context.ViewEpisodes
                            where x.EpisodeID == id
                            select x.Title;

            if (getTVShow != null && getTVShow.ToList().Count > 0)
                ViewBag.TVShow = getTVShow.FirstOrDefault().ToString();
            else
                ViewBag.TVShow = null;

            return View(episode);
        }

        // POST: Episode/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EpisodeID,EpisodeNo,Year,EpisodeName,Season,TVShowID,Watched")] Episode episode)
        {
            if (id != episode.EpisodeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(episode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EpisodeExists(episode.EpisodeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Episode/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var episode = await _context.Episode
                .FirstOrDefaultAsync(m => m.EpisodeID == id);
            if (episode == null)
            {
                return NotFound();
            }

            return View(episode);
        }

        // POST: Episode/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var episode = await _context.Episode.FindAsync(id);
            _context.Episode.Remove(episode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EpisodeExists(int id)
        {
            return _context.Episode.Any(e => e.EpisodeID == id);
        }

        [HttpPost, ActionName("MarkEpisodeWatched")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkEpisodeWatched(int episodeid)
        {
            var episode = await _context.Episode.FirstOrDefaultAsync(x => x.EpisodeID == episodeid);
            episode.Watched = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
