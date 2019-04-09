using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ado_net_spajanje_na_bazu.Controllers
{
    public class SqlConnectionObjectController : Controller
    {
        // GET: SqlConnectionObject direktno
        public ActionResult Index()
        {
            // Prvo kreiramo conn vezu
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            // Nakon toga instanca Sqlconnection
            SqlConnection conn = new SqlConnection(connString);

            // Otvaramo vezu s bazom
            try
            {
                conn.Open();
                // Ako je veza otvorena, uspjeli smo se spojiti
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela");
                }
            }
            catch (SqlException sqex)
            {
                Response.Write("Greška spajanja na bazu" + sqex.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("Neka greška" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            

            return View();
        }

        // GET: SqlConnectionObjekt preko WEB.config
        public ActionResult SpojPrekoWebKonfiga()
        {
            // Prvo kreiramo conn vezu
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;
            // Nakon toga instanca Sqlconnection
            SqlConnection conn = new SqlConnection(connString);

            // Otvaramo vezu s bazom
            try
            {
                conn.Open();
                // Ako je veza otvorena, uspjeli smo se spojiti
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela");
                }
            }
            catch (SqlException sqex)
            {
                Response.Write("Greška spajanja na bazu" + sqex.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("Neka greška" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }


            return View();
        }
    }
}