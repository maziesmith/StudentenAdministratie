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
    public partial class VakkenLijst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            if(!IsPostBack)
            {
                LoadVakken();
                LoadDropDownVakken();
            }            
        }

        protected void LoadVakken()
        {
            gvVakken.DataSource = VakkenDAL.VakkenLijst();
            gvVakken.DataBind();
        }
        
        protected void LoadDropDownVakken()
        {
            ddlVakken.DataSource = VakkenDAL.VakkenLijst();
            ddlVakken.DataValueField = "vakID";
            ddlVakken.DataTextField = "vakNaam";
            ddlVakken.DataBind();
        }

        
        
        protected void btnSelectVak_Click(object sender, EventArgs e)
        {
            string naam = ddlVakken.SelectedItem.ToString();
            int id = int.Parse(ddlVakken.SelectedValue);
            Session["ID"] = id;
            Session["Naam"] = naam;
            Response.Redirect("ShowStudentenVanVak.aspx");
        }

        protected void btnEditVak_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddlVakken.SelectedValue);
            string naam = ddlVakken.SelectedItem.ToString();
            Session["vakID"] = id;
            Session["vakNaam"] = naam;
            Response.Redirect("EditVak.aspx");
        }

        protected void lbtnStudenten_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentenLijst.aspx");
        }

        protected void btnNieuweVak_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertVak.aspx");
        }
    }   
}