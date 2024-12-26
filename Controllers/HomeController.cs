using System;
using System.Web.Mvc;
using JoshuaBaeslerApp.Models;
using Newtonsoft.Json;

namespace JoshuaBaeslerApp.Controllers
{
    public class HomeController : Controller
    {
        //Main page of the app
        public ActionResult Calculator()
        {
            return View();
        }

        //Post request for the calculation
        [HttpPost]
        public string Calculator(CalculationLog log) //takes request as a CalculationLog Model
        {
            string result = "V ≈ ";
            string formula = "";
            if (log.shape == "Cuboid" && log.input3.HasValue) //cuboid l*w*h formula
            {
                result = (log.input1 * log.input2 * log.input3).ToString();
                formula = "V = lwh = " + log.input1 + " * " + log.input2 + " * " + log.input3 + " ≈ " + result;
            }
            else if (log.shape == "Cylinder")//cylinder pi*r^2h formula
            {
                result = (Math.Round((Math.PI * log.input1 * log.input1 * log.input2) * 100000) / 100000).ToString();
                formula = "V = πr²h = π * " + log.input1 + "² * " + log.input2 + " ≈ " + result;
            }
            else if (log.shape == "Cone")//cone pi*r^2(h/3) formula
            {
                result = (Math.Round((Math.PI * log.input1 * log.input1 * (log.input2 / 3.0)) * 100000) / 100000).ToString();
                formula = "V = πr²(h/3) = π * " + log.input1 + "² * (" + log.input2 + "/3) ≈ " + result;
            }
            else //until other shapes and/or formula types are added default to an exception being thrown
            {
                throw new Exception("Invalid Shape");
            }
            result = "V ≈ " + result;
            //Here I would have the log saved to the modeldb using 
            //the Dbset function to save to local db,
            //or add a JDBC connection to post to an SQL db


            string[] arr = { result, formula };
            return JsonConvert.SerializeObject(new { result, formula });

        }
    }
}