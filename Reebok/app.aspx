<%@ Page Title="" Language="C#" MasterPageFile="~/template_paginas.Master" AutoEventWireup="true" CodeBehind="app.aspx.cs" Inherits="Reebok.app" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="class section" id="class">
        <div class="container">
            <div class="row">

                <div class="col-lg-12 col-12 text-center mb-5">
                    <h6 data-aos="fade-up">Veja:
                        <asp:DropDownList ID="ddl_noticias" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_noticias_SelectedIndexChanged">
                          <asp:ListItem>todas as noticias</asp:ListItem>
                          <asp:ListItem>5 ultimas noticias</asp:ListItem>
                          <asp:ListItem>10 ultimas noticias</asp:ListItem>
                          <asp:ListItem>25 ultimas noticias</asp:ListItem>
                        </asp:DropDownList>
                    </h6>
                    <h2 data-aos="fade-up" data-aos-delay="200">Notícias</h2>
                </div>

                <asp:Xml ID="XmlNoticias" runat="server" TransformSource="~/formatacao_todas.xslt"></asp:Xml>

            </div>
            <asp:Button ID="btn_incricao" runat="server" OnClick="btn_incricao_Click" type="submit" class="custom-btn-b" Text="Inscreva-se" />

        </div>
    </section>
</asp:Content>
