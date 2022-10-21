using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Reebok
{
    public partial class inscricao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Se a var session não existir redireciona para o login
            if (Session["utilizador"] == null) 
               Response.Redirect("home.aspx");
        }

        protected void tb_morada_TextChanged(object sender, EventArgs e)
        {
            /*if (tb_morada.Text.Contains("Rua") || tb_morada.Text.Contains("Avenida") || tb_morada.Text.Contains("Av") || tb_morada.Text.Contains("Praceta") || tb_morada.Text.Contains("Pc") || tb_morada.Text.Contains("Travessa") || tb_morada.Text.Contains("Tv"))
            {
                lbl_mensagem.Visible = false;
                
            }
            else
            {
                tb_morada.Text = "";
                lbl_mensagem.Visible = true;
                lbl_mensagem.Text = "Neste campo é obrigatório conter \"Rua\", \"Avenida\", \"Av\", \"Praceta\", \"Pc\", \"Travessa\" ou \"Tv\"";
            }*/
        }

        protected void ddl_regime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_curso.Items.Clear();



            if (ddl_regime.SelectedItem.Text == "Diurno")
            {
                ddl_curso.Items.Add("boxe");
                ddl_curso.Items.Add("cycle");
                ddl_curso.Items.Add("Musculação");

            }
            else if (ddl_regime.SelectedItem.Text == "Noturno")
            {
                ddl_curso.Items.Add("judo");
                ddl_curso.Items.Add("Karatê");
                ddl_curso.Items.Add("jiu jitsu");
            }


        }

        protected void rb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            Session["genero"] = "";
            rb_feminino.Checked = false;
            Session["genero"] = rb_masculino.Text;
        }

        protected void rb_feminino_CheckedChanged(object sender, EventArgs e)
        {
            Session["genero"] = "";
            rb_masculino.Checked = false;
            Session["genero"] = rb_feminino.Text;
        }

        protected void cbl_hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = 0;

            foreach (ListItem item in cbl_hobbies.Items)
            {
                if (item.Selected)
                {
                    aux++;
                    if (aux == 1)
                        Session["hobbies"] = item.Text;
                    if (aux == 2)
                        Session["hobbies"] += " , " + item.Text;
                    if (aux == 3)
                        Session["hobbies"] += " e " + item.Text;
                }
            }

            foreach (ListItem item in cbl_hobbies.Items)
            {

                if (!item.Selected && aux == 3)
                    item.Enabled = false;
                if (!item.Selected && aux < 3)
                    item.Enabled = true;
            }
        }

        protected void tb_palavraPasse_TextChanged(object sender, EventArgs e)
        {/*
            Regex maiusculas = new Regex("[A-Z]");
            Regex minusculas = new Regex("[a-z]");
            Regex numeros = new Regex("[0-9]");
            Regex especiais = new Regex("[^A-Za-z0-9]");
            Regex plica = new Regex("'");

            string tipo_pw = "Pw forte";

            if (tb_palavraPasse.Text.Length < 6)
                tipo_pw = "Pw fraca";
            if (maiusculas.Matches(tb_palavraPasse.Text).Count < 1)
                tipo_pw = "Pw fraca";
            if (minusculas.Matches(tb_palavraPasse.Text).Count < 1)
                tipo_pw = "Pw fraca";
            if (numeros.Matches(tb_palavraPasse.Text).Count < 1)
                tipo_pw = "Pw fraca";
            if (especiais.Matches(tb_palavraPasse.Text).Count < 1)
                tipo_pw = "Pw fraca";
            if (plica.Matches(tb_palavraPasse.Text).Count > 0)
                tipo_pw = "Pw fraca";

            lbl_resultado.Text = tipo_pw;

        */
        }

        protected void btn_submeter_Click(object sender, EventArgs e)
        {
            

            Session["nome"] = tb_nome.Text;
            Session["morada"] = tb_morada.Text;
            Session["email"] = tb_email.Text;
            Session["codigoPostal"] = tb_codigoPostal.Text;
            Session["palavraPasse"] = tb_palavraPasse.Text;

            if (ddl_regime.SelectedItem.Text == "---")
            {
                Session["regime"] = "";
                Session["curso"] = "";
               
            }
            else
            {
                Session["regime"] = ddl_regime.SelectedItem.Text;
                Session["curso"] = ddl_curso.SelectedItem.Text;
            }

            if (rb_feminino.Checked == false && rb_masculino.Checked == false)
            {
                Session["genero"] = "";
            }

            Regex maiusculas = new Regex("[A-Z]");
            Regex minusculas = new Regex("[a-z]");
            Regex numeros = new Regex("[0-9]");
            Regex especiais = new Regex("[^A-Za-z0-9]");
            Regex plica = new Regex("'");


            if (tb_palavraPasse.Text.Length < 6)
            {
                lbl_resultado.Text = "Pw fraca";
                lbl_resultado.Visible = true;

            }

            else if (maiusculas.Matches(tb_palavraPasse.Text).Count < 1)
            {
                lbl_resultado.Text = "Pw fraca";
                lbl_resultado.Visible = true;


            }
            else if (minusculas.Matches(tb_palavraPasse.Text).Count < 1)
            {
                lbl_resultado.Text = "Pw fraca";
                lbl_resultado.Visible = true;

            }
            else if (numeros.Matches(tb_palavraPasse.Text).Count < 1)
            {
                lbl_resultado.Text = "Pw fraca";
                lbl_resultado.Visible = true;

            }
            else if (especiais.Matches(tb_palavraPasse.Text).Count < 1)
            {
                lbl_resultado.Text = "Pw fraca";
                lbl_resultado.Visible = true;

            }
            else if (plica.Matches(tb_palavraPasse.Text).Count > 0)
            {
                lbl_resultado.Text = "Pw fraca";
                lbl_resultado.Visible = true;

            }


            else
            {
                lbl_resultado.Text = "Pw forte";
                // método replace para substituir o texto
                //tb_morada.Text.Replace(" ", "");
                lbl_resultado.Visible = true;

                if (tb_morada.Text.Contains("Rua") == true || tb_morada.Text.Contains("Avenida") == true || tb_morada.Text.Contains("Av") == true || tb_morada.Text.Contains("Praceta") == true ||
                    tb_morada.Text.Contains("Pc") == true || tb_morada.Text.Contains("Travessa") == true || tb_morada.Text.Contains("Tv") == true)
                {
                    lbl_mensagem.Visible = false;
                    Response.Redirect("dados.aspx");
                }
                else if (lbl_resultado.Text == "Pw fraca" && lbl_mensagem.Text == "Neste campo é obrigatório conter \"Rua\", \"Avenida\", \"Av\", \"Praceta\", \"Pc\", \"Travessa\" ou \"Tv\"")
                {
                    lbl_mensagem.Visible = true;
                    lbl_resultado.Visible = true;

                }
                else
                {
                    tb_morada.Text.Replace(" ", "");
                    lbl_mensagem.Text = "Neste campo é obrigatório conter \"Rua\", \"Avenida\", \"Av\", \"Praceta\", \"Pc\", \"Travessa\" ou \"Tv\"";
                    lbl_mensagem.Visible = true;
                }
            }

        }

        protected void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_morada.Text = "";
            ddl_regime.SelectedValue = "---";
            ddl_curso.Items.Clear();
            rb_masculino.Checked = false;
            rb_feminino.Checked = false;
            tb_email.Text = "";
            tb_codigoPostal.Text = "";
            tb_palavraPasse.Text = "";
            foreach (ListItem item in cbl_hobbies.Items)
            {
                item.Selected = false;
            }
        }
    }

}