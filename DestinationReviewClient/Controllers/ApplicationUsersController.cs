using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DestinationReviewClient.Models;

namespace DestinationReviewClient.Controllers
{
  public class ApplicationUsersController : Controller
  {
    public IActionResult Index()
    {
      var allUsers = ApplicationUser.GetUsers();
      return View(allUsers);
    }
  }
}