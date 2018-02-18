using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio1proceso
{
    public partial class pantalla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            WebService1 t = new WebService1();
            string temp= t.quase_ordenado(Text33.Value, Text44.Value);
            Label6.Text = temp;
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WebService1 t = new WebService1();
            string auxi = t.maximo_minimo(TextBox22.Value);
            Label2.Text = auxi;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService1 t = new WebService1();
            string auxi = t.se_encuentram(TextBox44.Value);
            resultado1.Text = auxi;
      

        }

     
    }
}