using Microsoft.AspNetCore.Mvc;
using PROG6212.Models;
using System.Collections.Generic;
namespace PROG6212.Controllers;

public class ViewClaimsController : Controller
{
    private static List<Claim> claims = new List<Claim>
    {
        new Claim
        {
            Id = "C001",
            LectureName = "John",
            LectureSurname = "Doe",
            SubjectName = "Mathematics",
            LecturerEmail = "john.doe@example.com",
            SubjectCode = 101,
            CampusLocation = "Main Campus",
            HoursWorked = 5,
            Message = "Worked extra hours on tutorial."
        },
        new Claim
        {
            Id = "C002",
            LectureName = "Jane",
            LectureSurname = "Smith",
            SubjectName = "Physics",
            LecturerEmail = "jane.smith@example.com",
            SubjectCode = 102,
            CampusLocation = "North Campus",
            HoursWorked = 3,
            Message = "Assisted in lab sessions."
        },
        new Claim
        {
            Id = "C003",
            LectureName = "Robert",
            LectureSurname = "Brown",
            SubjectName = "Chemistry",
            LecturerEmail = "robert.brown@example.com",
            SubjectCode = 103,
            CampusLocation = "Main Campus",
            HoursWorked = 4,
            Message = "Conducted practical demonstration."
        }
    };
    
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ClaimList()
    {
        return View(claims);
    }

    public IActionResult ClaimView(string id)
    {
            var claim = claims.Find(x => x.Id == id);

            if (claims == null)
            {
                return RedirectToAction("Index");
            }
            return View(claim);
    } 

}