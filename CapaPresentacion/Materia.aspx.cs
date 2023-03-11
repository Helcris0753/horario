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
        bool r = false;
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
                Label5.Visible = true;
                DropDownList1.Visible = true;
                RadioButtonList1.Visible = true;
                Button2.Visible = true;  
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "ID no encontrado" + "');", true);



        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MateriaBD materia = new MateriaBD();
            if (materia.insertar(int.Parse(TextBox1.Text), DropDownList1.Text, int.Parse(RadioButtonList1.Text)) == true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Se ha Guardado" + "');", true); 
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "ERRO!!" + "');", true);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ReportViewer1.LocalReport.Refresh();
            ReportViewer1.Visible = true;
            r = true;

        }
    }
}