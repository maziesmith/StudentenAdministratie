using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using Classes.cs;
using System.Windows.Forms;

namespace StudentenAdministratie
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            GetInputDetails();
        }

        private void GetInputDetails()
        {
            try
            {
                if (tbAchterNaam.Text != null && tbVoorNaam.Text != null)
                {
                    string firstName = tbVoorNaam.Text;
                    string lastName = tbAchterNaam.Text;
                    Studenten student = new Studenten();
                    student.voorNaam = firstName;
                    student.achterNaam = lastName;
                    StudentenDAL.AddStudentToDatabase(student);
                }
                else
                {
                    string message = "One or more fields are blank.";
                    MessageBox.Show(message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Response.Redirect("StudentenLijst.aspx");
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