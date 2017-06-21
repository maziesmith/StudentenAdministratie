using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using Classes.cs;

namespace StudentenAdministratie
{
    public partial class EditVak : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            LaadPagina();
        }
        
        
        

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateVak();
        }

        private void LaadPagina()
        {
            tbVakNaam.Text = Session["vakNaam"].ToString();            
        }

        private void UpdateVak()
        {
            Vakken vak = new Vakken();
            vak.vakID = Convert.ToInt32(Session["vakID"]);
            

            if (tbVakNaam.Text != null)
            {
                vak.vakNaam = tbVakNaam.Text;
                VakkenDAL.UpdateVak(vak);
                Response.Redirect("VakkenLijst.aspx");
            }
            else
            {
                Response.Write("Tekstveld is leeg.");
            }
        }

        protected void lbtnStudenten_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentenLijst.aspx");
        }

        protected void lbtnVakken_Click(object sender, EventArgs e)
        {
            Response.Redirect("VakkenLijst.aspx");
        }
    }
}