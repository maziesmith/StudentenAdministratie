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
    public partial class StudentenLijst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudenten();
            }
        }

        private void LoadStudenten()
        {
            gvStudenten.DataSource = StudentenDAL.StudentenLijst();
            gvStudenten.DataBind();
            
            ddlStudenten.DataSource = StudentenDAL.StudentenLijst();
            ddlStudenten.DataValueField = "studentID";
            ddlStudenten.DataTextField = "fullName";
            ddlStudenten.DataBind();
        }

        protected void btnShowVakken_Click(object sender, EventArgs e)
        {
            Session["studentNaam"] = ddlStudenten.SelectedItem;
            Session["studentID"] = ddlStudenten.SelectedValue;
            
            Response.Redirect("ShowVakkenVanStudent.aspx");
        }

        protected void btnNewStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertStudent.aspx");
        }

        protected void btnEditStudent_Click(object sender, EventArgs e)
        {
            Session["studentID"] = ddlStudenten.SelectedValue;
            Response.Redirect("EditStudent.aspx");
        }

        protected void lbtnVakken_Click(object sender, EventArgs e)
        {
            Response.Redirect("VakkenLijst.aspx");
        }
    }
}