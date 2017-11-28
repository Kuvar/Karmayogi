using Karmyogi.Data;
using Karmyogi.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarmyogiWeb.Controllers
{
    public class HomeController : Controller
    {
        private KarmyogiService service;

        public HomeController(IUnitOfWork unitOfWorkN)
        {
            service = new KarmyogiService(unitOfWorkN);
        }

        public ActionResult Index()
        {
            //var role = roleRepository.Table.AsEnumerable().ToList();
            //var role = service.AllRoles();
            //var counry = service.AllCountries();
            //var c = DateTime.Now.ToString().GetHashCode().ToString("x") + Guid.NewGuid().ToString().GetHashCode().ToString("x");
            //var test = service.TestSearch();
            //var city = service.AllCities(includeProperties: "Country,State").ToList();
            //var user = service.ProfileSearch(new SearchModel { LookingFor = "M", AgeFrom = 27, AgeTo = 35 });
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult ProfileSearch()
        {
            var LookingFor = new List<SelectListItem> {
                new SelectListItem{ Text="* Select Gender", Value = "", Selected = true },
                new SelectListItem{ Text="Bride", Value = "M" },
                new SelectListItem{ Text="Groom", Value = "F" }
            };

            var religions = service.AllReligions(includeProperties: "Castes");

            var model = new SearchViewModel
            {
                LookingForList = LookingFor,
                States = new SelectList(service.GetStateByCountryId(25), "Id", "StateName"),
                Religions = new SelectList(service.AllReligions(), "Id", "ReligionName"),
                Castes = new SelectList(service.GetCasteByReligionId(0),"Id", "CasteName"),
                AgeFrom = 18,
                AgeTo = 25
            };
            return PartialView("_ProfileSearch", model);
        }

        [HttpPost]
        public ActionResult ProfileSearch(SearchViewModel model)
        {
            
            SearchModel obj = new SearchModel {
                AgeFrom = model.AgeFrom,
                AgeTo = model.AgeTo,
                CasteId = model.CasteId,
                LookingFor = model.LookingFor,
                MotherTougueId = model.MotherTougueId,
                ReligionId = model.ReligionId,
                StateId = model.StateId
            };
           var result = service.Profile.ProfileSearch(obj);
            return View("matches", result);
        }

        [ChildActionOnly]
        public PartialViewResult RightSidebars()
        {
            return PartialView("_RightSidebars", service.Profile.GetAllProfiles());
        }

        public ActionResult ViewProfile(string id)
        {
            var data = service.Profile.ViewProfile(id);
            service.ViewedProfile.ViewedProfile(2, data.ProfileID);
            return View(data);
        }

        [ChildActionOnly]
        public PartialViewResult ViewSimilarProfiles(Profile model)
        {
            try
            {
                SearchModel obj = new SearchModel
                {
                    AgeFrom = 22,
                    AgeTo = 35,
                    CasteId = model.Caste_Id.Value,
                    LookingFor = model.Gender,
                    MotherTougueId = model.Mother_TongueId,
                    ReligionId = model.Religion_Id.Value,
                    StateId = model.LiveInStateId
                };
                var result = service.Profile.ProfileSearch(obj).SkipWhile(c => c.ProfileID == model.ProfileID);
                return PartialView("_ViewSimilarProfiles", result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetCasteByReligionId(int id)
        {
            if (id > 0)
            {
                var casteList = service.GetCasteByReligionId(id);

                var casteData = casteList.Select(m => new SelectListItem()
                {
                    Text = m.CasteName,
                    Value = Convert.ToString(m.Id)
                });
                return Json(casteData, JsonRequestBehavior.AllowGet);
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}