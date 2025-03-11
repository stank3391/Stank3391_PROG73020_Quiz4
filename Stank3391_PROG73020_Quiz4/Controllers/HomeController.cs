using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stank3391_PROG73020_Quiz4.Entities;
using Stank3391_PROG73020_Quiz4.Models;

namespace Stank3391_PROG73020_Quiz4.Controllers;

public class HomeController : Controller
{
    //This is the private logger. It is built in through VS
    private readonly ILogger<HomeController> _logger;

	//This is my private database conenction.
	private BpmeasurementsContext _bpmeasurementsContext;


    //Here is my Constructor to connect the BP measurements to the controller.
	public HomeController(BpmeasurementsContext bpmeasurementsContext, ILogger<HomeController> logger)
	{
		_bpmeasurementsContext = bpmeasurementsContext;
		_logger = logger;
	}

	public IActionResult Index()
    {
        //This will query the database to pull all the bpmeasurements.
        //I need to specifically include the measurements
        //Per requirements, I need to order the list by the date in descending order.
        List<Bpmeasurement> bpmeasurements = _bpmeasurementsContext.Bpmeasurements.Include(bp => bp.MeasurementPosition).OrderByDescending(bp => bp.MeasurementDate).ToList();
		return View(bpmeasurements);
    }

    //This is the built in Privacy Page.
    public IActionResult Privacy()
    {
        return View();
    }

    //This is the built in Error page.
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
