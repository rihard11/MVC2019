﻿using ado_net_spajanje_na_bazu.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ado_net_spajanje_na_bazu.Controllers
{
    public class SqlDataReaderObjektController : Controller
    {
        // GET: SqlDataReaderObjekt
        public ActionResult Index()
        {
            // Prvo kreiramo conn vezu
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;

            // Prazna nista tecajeva
            List<Tecaj> lstTecaj = new List<Tecaj>();

            // Nakon toga instanca Sqlconnection
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "SELECT * FROM [dbo].[tbltecajevi] ";


                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Tecaj t1 = new Tecaj();

                        t1.Id = (int)reader["id"];
                        t1.Naziv = (string)reader["naziv"];
                        t1.Opis = (string)reader["opis"];

                        lstTecaj.Add(t1);
                    }
                }
                else
                {
                    ViewBag.Message = "Zapis nije izmjenjen ili nije pronadjen u bazi";
                }
            }
            return View("Index", lstTecaj);
        }
    }
}
    
