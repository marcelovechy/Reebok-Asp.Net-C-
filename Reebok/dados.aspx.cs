using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Configuration;
using System.Xml;
using System.Net;
using System.Net.Mail;


namespace Reebok
{
    public partial class dados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se a var session nao existir volta para o login
            if (Session["utilizador"] == null)
               Response.Redirect("home.aspx");

            lbl_nome.Text = Session["nome"].ToString();
            lbl_morada.Text = Session["morada"].ToString();
            lbl_regime.Text = Session["regime"].ToString();
            lbl_curso.Text = Session["curso"].ToString();
            lbl_genero.Text = Session["genero"].ToString();
            lbl_hobbies.Text = Session["hobbies"].ToString();
            lbl_email.Text = Session["email"].ToString();
            lbl_codigoPostal.Text = Session["codigoPostal"].ToString();
            

        }

        protected void btn_xml_Click(object sender, EventArgs e)
        {
            // para limpar já a memória
            Response.Clear();
            // ficheiro a criar e nome a dar
            Response.AddHeader("Content-Disposition", "attachment; filename=xmlfile.xml");

            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            Response.ContentType = "text/xml";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            htw.Write("<dados><cliente><nome>" + lbl_nome.Text + "</nome>\n<morada>" + lbl_morada.Text + "</morada>\n<regime>" + lbl_regime.Text + "</regime>\n<curso>" + lbl_curso.Text + "</curso>\n<genero>" + lbl_genero.Text + "</genero><hobbies>" + lbl_hobbies.Text + "</hobbies>\n<email>" + lbl_email.Text + "</email>\n<codigoPostal>" + lbl_codigoPostal.Text + "</codigoPostal></cliente></dados>");

            Response.Write(sw.ToString());
            Response.End();
        }

        protected void btn_excel_Click(object sender, EventArgs e)
        {
            // para limpar já a memória
            Response.Clear();
            // ficheiro a criar e nome a dar
            Response.AddHeader("Content-Disposition", "attachment; filename=excel.xls");
            // digo q quero descarregar um ficheiro via attachment

            // tenho q dizer que nao quero usar cache
            Response.Cache.SetCacheability(HttpCacheability.NoCache); // para nunca guardar nada e nao passar para os prox users
            // agora dizemos que é fich EXCEL 
            Response.ContentType = "application/vnd.ms-excel";
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            // mandar escrever dentro do fich excel 

            StringWriter sw = new StringWriter(); // instanciar um obeto para ter string grande e escrever

            // Interpretar o obj string
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            htw.Write("<table><tr><td>Nome:</td><td>" + lbl_nome.Text + "</td></tr><tr><td>Morada:</td><td>" + lbl_morada.Text + "</td></tr><tr><td>Regime:</td><td>" + lbl_regime.Text + "</td></tr><tr><td>Curso:</td><td>" + lbl_curso.Text + "</td></tr><tr><td>Genero:</td><td>" + lbl_genero.Text + "</td></tr><tr><td>Hobbies:</td><td>" + lbl_hobbies.Text + "</td></tr><tr><td>Email:</td><td>" + lbl_email.Text + "</td></tr><tr><td>Código postal:</td><td>" + lbl_codigoPostal.Text + "</td></tr></table>");
            
            Response.Write(sw.ToString());
            Response.End();
        }

        protected void btn_word_Click(object sender, EventArgs e)
        {
            // para limpar já a memória
            Response.Clear();
            // ficheiro a criar e nome a dar
            Response.AddHeader("Content-Disposition", "attachment; filename=wordfile.doc");
            // digo q quero descarregar um ficheiro via attachment

            // tenho q dizer que nao quero usar cache
            Response.Cache.SetCacheability(HttpCacheability.NoCache); // para nunca guardar nada e nao passar para os prox users
            // agora dizemos que é fich word 
            Response.ContentType = "application/vnd.ms-word";
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());
            // mandar escrever dentro do fich excel 

            StringWriter sw = new StringWriter(); // instanciar um obeto para ter string grande e escrever

            // Interpretar o obj string
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            htw.Write("<table><tr><td>Nome:</td><td>" + lbl_nome.Text + "</td></tr><tr><td>Morada:</td><td>" + lbl_morada.Text + "</td></tr><tr><td>Regime:</td><td>" + lbl_regime.Text + "</td></tr><tr><td>Curso:</td><td>" + lbl_curso.Text + "</td></tr><tr><td>Genero:</td><td>" + lbl_genero.Text + "</td></tr><tr><td>Hobbies:</td><td>" + lbl_hobbies.Text + "</td></tr><tr><td>Email:</td><td>" + lbl_email.Text + "</td></tr><tr><td>Código postal:</td><td>" + lbl_codigoPostal.Text + "</td></tr></table>");


            Response.Write(sw.ToString());
            Response.End();
        }

        protected void btn_pdf_Click(object sender, EventArgs e)
        {
            // fazemos a busca do caminho e do url no web_Config, facilitando alterações futuras por parte do cliente
            string caminho = ConfigurationSettings.AppSettings.Get("PathFicheirosPDFS");
            string urlsite = ConfigurationSettings.AppSettings.Get("SiteURL");

            // apontar para o nosso template que é igual ao nosso caminho concatenado com a pasta template e o nome do ficheiro.pdf
            string pdfTemplate = caminho + "Templates\\GYM_REEBOK.pdf";


            // criar novo ficheiro e o nome nunca ser igual
            string nomePDF = DateTime.Now.ToString().Replace(":", "").Replace("/", "").Replace(" ", "") + ".pdf";


            string novoFicheiro = caminho + nomePDF;

            // fazendo a leitura do pdf template
            PdfReader pdfreader = new PdfReader(pdfTemplate);

            //criar um novo ficheiro com base no template pdfreader 
            PdfStamper pdfstamper = new PdfStamper(pdfreader, new FileStream(novoFicheiro, FileMode.Create));

            // nos templates para ler e escrever neles usamos
            AcroFields campos = pdfstamper.AcroFields;
            campos.SetField("nome", lbl_nome.Text);
            campos.SetField("morada", lbl_morada.Text);
            campos.SetField("regime", lbl_regime.Text);
            campos.SetField("curso", lbl_curso.Text);
            campos.SetField("genero", lbl_genero.Text);
            campos.SetField("hobbies", lbl_hobbies.Text);
            campos.SetField("email", lbl_email.Text);
            campos.SetField("codigoPostal", lbl_codigoPostal.Text);

            pdfstamper.Close();

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient servidor = new SmtpClient();

                // Envia de um para vários destinos
                mail.From = new MailAddress("agatha.vechy.t0121524@edu.atec.pt");
                mail.To.Add(new MailAddress(lbl_email.Text));
                mail.Subject = "Inscrição" + lbl_curso;
                // para dizer que é html
                mail.IsBodyHtml = true;
                mail.Body = "";
                
                // criando o anexo
                System.Net.Mail.Attachment anexo;
                anexo = new System.Net.Mail.Attachment(novoFicheiro);
                mail.Attachments.Add(anexo);

                servidor.Host = "smtp.office365.com";
                servidor.Port = 587;
                servidor.Credentials = new NetworkCredential
                    ("agatha.vechy.t0121524@edu.atec.pt", "A1m9a0@513");//trocar email, falta senha

                servidor.EnableSsl = true;
                servidor.Send(mail);

                lbl_mensagem.Text = "Email enviado com sucesso";
            }
            catch (Exception ex)
            {
                // se der erro 
                lbl_mensagem.Text = ex.Message;
            }

            // agr redirecionar para o ficheiro mostrar na tela
            Response.Redirect(urlsite + "/PDFS/" + nomePDF);
            Response.End();
        }

        protected void btn_loja_Click(object sender, EventArgs e)
        {
                
                Response.Redirect("loja.aspx");
        }
    }
}