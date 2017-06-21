using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace StudentenAdministratie
{
    public partial class InsertVak : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

       

        private void GetText()
        { 
            string vaknaam = tbVakNaam.Text;
            VakkenDAL.AddVakToDatabase(vaknaam);
            SendToList();
        }

        private void SendToList()
        {
            Response.Redirect("VakkenLijst.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbVakNaam.Text != null)
            {
                GetText();
            }
            else
            {
                Response.Write("Text field is empty.");
            }
        }

        protected void lbtnVakken_Click(object sender, EventArgs e)
        {
            Response.Redirect("VakkenLijst.aspx");
        }

        protected void lbtnStudenten_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentenLijst.aspx");
        }
    }
}