using DesarrolloModelos.Models;
using DesarrolloModelos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace DesarrolloModelos.Controllers
{
	public class ButterflyController : Controller
	{
		private IDataService _data;
		private Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
		private IButterfliesQuantityService _quantityService;
		public ButterflyController(IDataService data, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment, IButterfliesQuantityService quantityService)
		{
			_data = data;
			_environment = environment;
			_quantityService = quantityService;
		}

		private void InitializeButterfliesData()
		{
			if(_data.ButterfliesList == null)
			{
				List<Butterfly> butterflies = _data.ButterfliesInitializeData();
				foreach(Butterfly b in butterflies)
				{
					_quantityService.AddButterfliesQuantityData(b);
				}
			}
		}

		public IActionResult Index()
		{
			InitializeButterfliesData();
			IndexViewModel indexViewModel = new IndexViewModel();
			indexViewModel.Butterflies = _data.ButterfliesList;
			return View(indexViewModel);
		}
		public IActionResult GetImage(int id)
		{
			Butterfly requestdButterfly = _data.GetButterflyById(id);
			if (requestdButterfly != null)
			{
				string weebRootPath = _environment.WebRootPath;
				string folderPath = "\\images\\";
				string fullPath = weebRootPath + folderPath + requestdButterfly.ImageName;
				if (System.IO.File.Exists(fullPath))
				{
					FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
					byte[] fileBytes;
					using (BinaryReader br = new BinaryReader(fileOnDisk))
					{
						fileBytes = br.ReadBytes((int)fileOnDisk.Length);
					}
					return File(fileBytes, requestdButterfly.ImageMimeType);
				}
				else
				{
					if (true)
					{
						return File(requestdButterfly.PhotoFile,requestdButterfly.ImageMimeType);
					}
					else
					{
						return NotFound();						
					}
				}
			}
			else
			{
				return NotFound();
			}		
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Butterfly butterfly)
		{
			if (ModelState.IsValid)
			{
				Butterfly lastButterfly = _data.ButterfliesList.LastOrDefault();
				butterfly.CreateDate = DateTime.Today;
				if (butterfly.PhotoAvatar != null && butterfly.PhotoAvatar.Length > 0)
				{
					butterfly.ImageMimeType = butterfly.PhotoAvatar.ContentType;
					butterfly.ImageName = Path.GetFileName(butterfly.PhotoAvatar.FileName);
					butterfly.Id = lastButterfly.Id + 1;
					_quantityService.AddButterfliesQuantityData(butterfly);
					using (var memoryStream = new MemoryStream())
					{
						butterfly.PhotoAvatar.CopyTo(memoryStream);
						butterfly.PhotoFile = memoryStream.ToArray();
					}
					_data.addButterfly(butterfly);
					return RedirectToAction("Index");
				}
				return View(butterfly);
			}
			else
			{
				return View(butterfly);
			}
		}

	}
}
