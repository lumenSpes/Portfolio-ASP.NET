using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            string name = "MD. MONZURUL KABIR ZHANDA";
            string email = "monzurulkabir@gmail.com";
            string bio = "Creative thinker, passionate learner, and problem solver. Dedicated to continuous growth, seeking inspiration in the world around and striving to make a positive impact through words and actions.";
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Bio = bio;
            return View();
        }

        public ActionResult Profile()
        {
            MyProfile myProfile = new MyProfile();
            myProfile.Name = "MD. MONZURUL KABIR ZHANDA";
            myProfile.DOB = new DateTime(2023,06,12);
            myProfile.Nation = "BANGLADESH";
            myProfile.BloodGroup = "B+";
            myProfile.Address = "Dhaka, Bangladesh";
            myProfile.ContactNo = "017123456789";
            myProfile.Hobbies = new string[] {"chess" , "hiking", "gaming"};
            return View(myProfile);
        }
        public ActionResult Education() 
        {
            MyEducation[] myEducation = new MyEducation[]
            {
                new MyEducation
                {
                    Degree = "BSC", Institution = "AMERICAN INTERNATIONAL UNIVERSITY - BANGLADESH", Year = 2023
                },
                new MyEducation
                {
                    Degree = "HSC", Institution = "IBRAHIM KHAN GOVT. COLLAGE", Year = 2019
                },
                new MyEducation
                {
                    Degree = "SSC", Institution = "BHUAPUR MODEL PILOT HIGH SCHOOL", Year = 2017                }
            };

            ViewBag.Education = myEducation;

            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Reference()
        {
            return View();
        }
    }
}