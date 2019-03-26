using HumaneSocietyPets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HumaneSocietyPets.Controllers

{

    public class AnimalController : Controller

    {

        private AnimalDBContext db = new AnimalDBContext();



        // GET: ANIMAL

        public ActionResult Index()

        {

            return View(db.Animals.ToList());

        }



        // GET: Animal/Create

        public ActionResult Create()

        {

            return View();

        }



        // POST: Animal/Create

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Create(Animal animal)

        {

            if (ModelState.IsValid)

            {

                db.Animals.Add(animal);

                db.SaveChanges();

                return RedirectToAction("Index");

            }



            return View(animal);

        }



        // GET: ANimal/Details/id

        public ActionResult Details(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Animal animal = db.Animals.Find(id);

            if (animal == null)

            {

                return HttpNotFound();

            }

            return View(animal);

        }



        // GET: ANIMAL/Edit/id

        public ActionResult Edit(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Animal animal = db.Animals.Find(id);

            if (animal == null)

            {

                return HttpNotFound();

            }

            return View(animal);

        }



        // POST: ANIMAL/Edit/id

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Edit(Animal animal)

        {

            if (ModelState.IsValid)

            {

                db.Entry(animal).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(animal);

        }



        // GET: ANIMAL/Delete/id

        public ActionResult Delete(int? id)

        {

            if (id == null)

            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Animal animal = db.Animals.Find(id);

            if (animal == null)

            {

                return HttpNotFound();

            }

            return View(animal);

        }



        // POST: ANIMAL/Delete/id

        [HttpPost]

        [ActionName("Delete")]

        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)

        {

           Animal animal = db.Animals.Find(id);

            db.Animals.Remove(animal);

            db.SaveChanges();

            return RedirectToAction("Index");

        }

    }

}