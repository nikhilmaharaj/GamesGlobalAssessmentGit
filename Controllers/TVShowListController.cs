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
using System.Xml;

namespace GamesGlobalAssessment.Controllers
{
    [Authorize]
    public class TVShowListController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public TVShowListController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: TVShowList
        public async Task<IActionResult> Index(string search)
        {
            string username = _httpContextAccessor.HttpContext.Session.GetString("Username"); //Gets the username from the session
            var userID = from x in _context.Users.ToList() //Gets the userID by the username
                         where x.Username == username
                         select x.UserID;

            var results = await _context.ViewTVShows.Where(x => x.UserID == userID.First()).ToListAsync();

            #region SearchFilters 
            if (!string.IsNullOrEmpty(search))
                results = results.Where(x => x.Title == search || x.CreatedBy == search || x.Year.ToString() == search).ToList();
            #endregion

            #region GetNextEpisodes
            var getNextEpisodes = _context.ViewEpisodes.Where(x => x.UserID == userID.First() && x.Watched == false).ToList(); 
            if (getNextEpisodes.Count > 0)
                ViewData["Episode"] = getNextEpisodes;
            else
                ViewData["Episode"] = null;
            #endregion

            return View(results);
        }

        // GET: TVShowList/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TVShowList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TVShowID,Title,Year,CreatedBy,UserID")] TVShow tvshow)
        {
            if (ModelState.IsValid)
            {
                string username = _httpContextAccessor.HttpContext.Session.GetString("Username"); //Gets the username from the session
                var userID = from x in _context.Users.ToList() //Gets the userID by the username
                             where x.Username == username
                             select x.UserID;

                TVShow entity = new TVShow();
                entity.Title = tvshow.Title;
                entity.Year = tvshow.Year;
                entity.CreatedBy = tvshow.CreatedBy;
                entity.UserID = Convert.ToInt32(userID.First());

                _context.Add(entity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tvshow);
        }

        // GET: TVShowList/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tvshow = await _context.TVShow.FindAsync(id);
            if (tvshow == null)
            {
                return NotFound();
            }

            var getTvShow = from x in _context.ViewTVShows
                                    where x.TVShowID == id
                                    select x.Title;

            if (getTvShow != null && getTvShow.ToList().Count > 0)
                ViewBag.TVTitle = getTvShow.FirstOrDefault().ToString();
            else
                ViewBag.TVTitle = null;


            return View(tvshow);
        }

        // POST: TVShowList/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TVShowID,Title,Year,CreatedBy,UserID")] TVShow tvshow)
        {
            string username = _httpContextAccessor.HttpContext.Session.GetString("Username"); //Gets the username from the session
            var userID = from x in _context.Users.ToList() //Gets the userID by the username
                         where x.Username == username
                         select x.UserID;

            if (id != tvshow.TVShowID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tvshow.UserID = Convert.ToInt32(userID.First());
                    _context.Update(tvshow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TVShowExists(tvshow.TVShowID))
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
            return View(tvshow);
        }

        // GET: TVShowList/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tvShow = await _context.TVShow
                .FirstOrDefaultAsync(m => m.TVShowID == id);
            if (tvShow == null)
            {
                return NotFound();
            }

            return View(tvShow);
        }

        // POST: TVShowList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tvShow = await _context.TVShow.FindAsync(id);

            var items = from y in _context.Episode.ToList() //Gets the Episode List of the TV Show
                         where y.TVShowID == id
                         select y;

            foreach (var item in items) //Deletes all Episodes linked to the TV Show
            {
                _context.Episode.Remove(item);
            }

            _context.TVShow.Remove(tvShow);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TVShowExists(int id)
        {
            return _context.TVShow.Any(e => e.TVShowID == id);
        }

        public JsonResult GetTVShows(string search)
        {
            string username = _httpContextAccessor.HttpContext.Session.GetString("Username"); //Gets the username from the session
            var userID = from x in _context.Users.ToList() //Gets the userID by the username
                         where x.Username == username
                         select x.UserID;

            var Data = (from x in  _context.ViewTVShows.Take(10)
                             where x.UserID == userID.First() && x.Title.StartsWith(search)
                             select new
                             {
                                 label = x.Title,
                                 val = x.TVShowID
                             }).Distinct().ToList();

            return Json(Data);
        }
    }
}
