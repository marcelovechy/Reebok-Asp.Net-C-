using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Reebok
{
    public partial class app : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["utilizador"] == null)
                Response.Redirect("home.aspx");

            // Criar um xml e fazer a leitura dos dados a partir deste url de noticias e vamos carregar xmlDocument
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("https://www.noticiasaominuto.com/rss/desporto");

            XmlNoticias.Document = xmlDoc;
        }

        protected void btn_incricao_Click(object sender, EventArgs e)
        {
            Response.Redirect("inscricao.aspx");
        }

        protected void ddl_noticias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_noticias.SelectedItem.Text == "todas as noticias")
            {
                XmlNoticias.TransformSource = "formatacao_todas.xslt";
            }
            else if (ddl_noticias.SelectedItem.Text == "25 ultimas noticias")
            {
                XmlNoticias.TransformSource = "formatacao_vinteCinco.xslt";
            }
            else if (ddl_noticias.SelectedItem.Text == "10 ultimas noticias")
            {
                XmlNoticias.TransformSource = "formatacao_dez.xslt";
            }
            else if (ddl_noticias.SelectedItem.Text == "5 ultimas noticias")
            {
                XmlNoticias.TransformSource = "formatacao_cinco.xslt";
            }
        }
    }
}