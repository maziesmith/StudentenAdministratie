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
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LaadPagina();
        }

        private void LaadPagina()
        { 
            if(!IsPostBack)
            {
                SetFields();
                FillDropDown();
            }
        }

        private void SetFields()
        {
            Studenten student = new Studenten();           
            int id = Convert.ToInt32(Session["studentID"]);
            student.studentID = id;
            tbVoorNaam.Text = StudentenDAL.GetFirstName(student);
            tbAchterNaam.Text = StudentenDAL.GetLastName(student);
            gvVakken.DataSource = StudentenDAL.GetStudent(student);
            gvVakken.DataBind();
        }

        private void FillDropDown()
        {
            ddlVakken.DataSource = VakkenDAL.VakkenLijst();
            ddlVakken.DataTextField = "vakNaam";
            ddlVakken.DataValueField = "vakID";
            ddlVakken.DataBind();
        }

        protected void btnVoegVak_Click(object sender, EventArgs e)
        {
            VakAanStudent();
        }

        private void VakAanStudent()
        {
            int vakid = Convert.ToInt32(ddlVakken.SelectedValue);
            int studentid = Convert.ToInt32(Session["studentID"]);

            Vakken vak = new Vakken();
            Studenten student = new Studenten();

            vak.vakID = vakid;
            student.studentID = studentid;

            VakkenDAL.VoegVakToeAanStudent(vak, student);

            SetFields();


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