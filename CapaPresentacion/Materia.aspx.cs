using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Materia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("~/login.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MateriaBD materia = new MateriaBD();
            if(materia.comprobar(int.Parse(TextBox1.Text)) == true)
            {
                Label2.Visible = true;
                Label4.Visible = true;
                Label5.Text = materia.Nombre;
                Button1.Visible = false;
                Label5.Visible = true;
                DropDownList1.Visible = true;
                RadioButtonList1.Visible = true;
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}