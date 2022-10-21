<%@ Page Title="" Language="C#" MasterPageFile="~/template_paginas.Master" AutoEventWireup="true" CodeBehind="loja.aspx.cs" Inherits="Reebok.loja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="schedule section" id="schedule">
        <div class="container">
            <div class="row">

                <div class="col-lg-12 col-12 text-center">
                    <h6 data-aos="fade-up">
         
                            Ténis:<asp:DropDownList ID="ddl_loja" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_loja_SelectedIndexChanged">
                                <asp:ListItem>Todos</asp:ListItem>
                                <asp:ListItem>Homem</asp:ListItem>
                                <asp:ListItem>Senhora</asp:ListItem>
                                <asp:ListItem>Unissexo</asp:ListItem>
                            </asp:DropDownList>
                        
                    </h6>
                    <h2 class="text-white" data-aos="fade-up" data-aos-delay="200">Loja</h2>
                </div>

                <div class="col-lg-12 py-5 col-md-12 col-12">
                    <table class="table table-bordered table-responsive schedule-table" data-aos="fade-up" data-aos-delay="300">

                            <asp:Xml ID="Xml_loja" runat="server" DocumentSource="~/loja.xml" TransformSource="~/loja_todos.xslt"></asp:Xml>
                      
                    </table>
                </div>

            </div>
        </div>
    </section>
</asp:Content>
