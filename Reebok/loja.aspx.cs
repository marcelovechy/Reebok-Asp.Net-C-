using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Reebok
{
    public partial class loja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["utilizador"] == null) Response.Redirect("home.aspx");

        }

        protected void ddl_loja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_loja.SelectedItem.Text == "Todos")
            {
                Xml_loja.TransformSource = "loja_todos.xslt";
            }
            if (ddl_loja.SelectedItem.Text == "Homem")
            {
                Xml_loja.TransformSource = "loja_homem.xslt";
            }
            if (ddl_loja.SelectedItem.Text == "Senhora")
            {
                Xml_loja.TransformSource = "loja_senhora.xslt";
            }
            if (ddl_loja.SelectedItem.Text == "Unissexo")
            {
                Xml_loja.TransformSource = "loja_unissexo.xslt";
            }
        }
    }
}