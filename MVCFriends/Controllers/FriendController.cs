using Microsoft.AspNetCore.Mvc;
using MVCFriends.Models;

namespace MVCFriends.Controllers
{
    public class FriendController : Controller
    {
        public ActionResult Index()
        {
            List<Friend> friends = new List<Friend>
            {
                new Friend { FriendId = 1, FriendName = "Vera", Place = "Kyiv", DOB =  new DateTime(1988, 04, 11), FavouriteColor = "Dark blue"},
                new Friend { FriendId = 2, FriendName = "Sasha", Place = "Kyiv", DOB =  new DateTime(1989, 04, 11), FavouriteColor = "Dark red"},
                new Friend { FriendId = 3, FriendName = "Nick", Place = "Kyiv", DOB =  new DateTime(1990, 04, 11), FavouriteColor = "Dark yellow"},
                new Friend { FriendId = 4, FriendName = "Jack", Place = "Kyiv", DOB =  new DateTime(1991, 04, 11), FavouriteColor = "Dark black"},
                new Friend { FriendId = 5, FriendName = "Will", Place = "Kyiv", DOB =  new DateTime(1992, 04, 11), FavouriteColor = "Dark pink"},

            };

            return View(friends);

        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Friend friend)
        {
            if (ModelState.IsValid)
            {
                // Insert new friend into database
                
                return RedirectToAction("Index");
            }

            return View(friend);
        }

        public ActionResult Edit(int id)
        {
            // Retrieve friend from database
            Friend friend = new Friend
            {
                FriendId = id,
                FriendName = "Vera",
                Place = "Kyiv",
                DOB = new DateTime(2011, 01, 11),
                FavouriteColor = "Dark blue"

            };
            return View(friend);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            int friendId = int.Parse(form["FriendId"]);
            string friendName = form["FriendName"];
            string place = form["Place"];
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            // Retrieve friend from database
            Friend friend = new Friend { FriendId = id};

            return View(friend);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            // Delete friend from database

            return RedirectToAction("Index");
        }


    }
}
