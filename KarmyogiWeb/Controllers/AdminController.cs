using Karmyogi.Data;
using Karmyogi.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KarmyogiWeb.Controllers
{
    public class AdminController : Controller
    {
        private KarmyogiService service;

        public AdminController(IUnitOfWork unitOfWorkN)
        {
            service = new KarmyogiService(unitOfWorkN);
        }

        // GET: Admin
        [AuthorizeRole(Roles ="Admin")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchUser()
        {
            var LookingFor = new List<SelectListItem> {
                new SelectListItem{ Text="* Select Gender", Value = "", Selected = true },
                new SelectListItem{ Text="Bride", Value = "M" },
                new SelectListItem{ Text="Groom", Value = "F" }
            };

            var religions = service.AllReligions(includeProperties: "Castes");

            var model = new AdminSearchModel
            {
                LookingForList = LookingFor,
                States = new SelectList(service.GetStateByCountryId(25), "Id", "StateName"),
                Religions = new SelectList(service.AllReligions(), "Id", "ReligionName"),
                Castes = new SelectList(service.GetCasteByReligionId(0), "Id", "CasteName"),
                AgeFrom = 18,
                AgeTo = 25
            };

            return View(model);
        }

        public PartialViewResult ProfileSearch()
        {
            SearchModel obj = new SearchModel
            {
                AgeFrom = 18,
                AgeTo = 45,
                CasteId = 0,
                LookingFor = "",
                MotherTougueId = 0,
                ReligionId = 0,
                StateId = 0
            };
            var result = service.Profile.ProfileSearch(obj);
            return PartialView("_AdminProfileSearch", result);
        }

        [HttpPost]
        public ActionResult ProfileSearch(AdminSearchModel model)
        {
            SearchModel obj = new SearchModel
            {
                AgeFrom = model.AgeFrom,
                AgeTo = model.AgeTo,
                CasteId = model.CasteId,
                LookingFor = string.IsNullOrEmpty(model.LookingFor) ? "" : model.LookingFor,
                MotherTougueId = model.MotherTougueId,
                ReligionId = model.ReligionId,
                StateId = model.StateId
            };
            var result = service.Profile.ProfileSearch(obj);
            return PartialView("_AdminProfileSearch", result);
        }

        [HttpPost]
        public ActionResult DeleteProfile(int id)
        {
            return Json(new { id }, JsonRequestBehavior.AllowGet);
        }



    }
}