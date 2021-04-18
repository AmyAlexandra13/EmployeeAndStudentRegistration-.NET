using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoFinal.Models;
using CapaNegocio;
using System.Data.SqlClient;


namespace ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public ActionResult Index() ///Login
        {
            return View();
        }

        void ConnectionString()
        {
            con.ConnectionString = "data source=CANDIDA/AMYSERVER; database=ProyectoFinalProg2; integrated security=SSPI";
        }

        [HttpPost]
        public ActionResult Verify(Account cuenta)
        {
            ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Usuario where Id='"+cuenta.IdUser+"' and Contra='"+cuenta.Password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Menu");
                
            }
            else
            {
                con.Close();
                return View("Error");
               
            }

           
            
        }


    }
}