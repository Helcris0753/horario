using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUsuario_TextChanged()
        {

        }
        //Función para acceder al menú principal.
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            LoginBD login = new LoginBD();

            //Llamada la clase para autentificar el login.
            if (login.comprobar(int.Parse(txtUsuario.Text), txtPassword.Text) == false)
                Label1.Visible = true;
            //En caso de que no coincida el usuario o contraseña, apararecerá una notificación.
            else
            {
                Session["Usuario"] = login.Nombre.ToString();
                //Almacena el ID del usuario que accedió a la aplicación.
                Menu menu = new Menu();
                //Redicciona al menú principal.
                Response.Redirect("~/Menu.aspx");
                //Almacena si el usuario es coordinador o no.
                Session["Coordinador"] = login.Coordinador;
            }
               
            
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}