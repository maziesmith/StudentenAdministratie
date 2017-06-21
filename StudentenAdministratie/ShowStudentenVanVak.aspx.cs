using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes.cs;
using DataAccessLayer;

namespace StudentenAdministratie
{
    public partial class ShowStudentenVanVak : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pageLoad();
        }

        private void pageLoad()
        {
            if (Session["ID"] != null)
            {
                if (!IsPostBack)
                {
                    lblTitle.Text = Session["Naam"].ToString();
                    LoadStudentenVanVak();                                        
                }
            }
            else
            {
                Response.Redirect("VakkenLijst.aspx");
            }
        }

        private void LoadStudentenVanVak()
        {
            
            Vakken vak = new Vakken();
            vak.vakID = Convert.ToInt32(Session["ID"]);

            gvStuVaLijst.DataSource = VakkenDAL.ShowStudentenVanVak(vak);

            gvStuVaLijst.DataBind();
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