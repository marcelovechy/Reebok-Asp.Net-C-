using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reebok
{
    public partial class template_paginas : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_horas.Text = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString();
        }
    }
}