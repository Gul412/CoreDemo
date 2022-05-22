﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DAL.EntityFramework;
using EntityKatmani.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager( new EfWriterRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv =new WriterValidator();
			ValidationResult results =wv.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme Test";
				wm.TAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
