using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes.cs;

namespace StudentenAdministratie
{
    public partial class ShowVakkenVanStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadPage();  
        }

        private void LoadPage()
        {
            if (Session["studentID"] != null)
            {
                if (!IsPostBack)
                {
                    lblStudentNaam.Text = Session["studentNaam"].ToString();
                    GetSession();
                }
            }
            else
            {
                Response.Redirect("StudentenLijst.aspx");
            }
        }

        private void GetSession()
        {
            Studenten student = new Studenten();
            student.studentID = Convert.ToInt32(Session["studentID"]);
            gvStudentVakken.DataSource = StudentenDAL.GetStudent(student);
            gvStudentVakken.DataBind();
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