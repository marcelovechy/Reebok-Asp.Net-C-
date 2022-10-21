<%@ Page Title="" Language="C#" MasterPageFile="~/template_paginas.Master" AutoEventWireup="true" CodeBehind="dados.aspx.cs" Inherits="Reebok.dados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="class section" id="class">
        <div class="container">
            <div class="row">

                <div class="col-lg-12 col-12 text-center mb-5">
                    <h6 data-aos="fade-up"></h6>

                    <h2 data-aos="fade-up" data-aos-delay="200">Dados</h2>
                </div>

                <div class="col-lg-12 col-12 text-center mb-5" data-aos="fade-up" data-aos-delay="400">
                    <div class="class-thumb">
                        <div class="class-info">
                            <br />
                            <span>
                                <strong>Nome: </strong>
                                <asp:Label ID="lbl_nome" runat="server"></asp:Label>
                            </span>
                            <br />
                            <span>
                                <strong>Morada: </strong>
                                <asp:Label ID="lbl_morada" runat="server"></asp:Label>
                            </span>
                            <br />
                            <span>
                                <strong>Regime: </strong>
                                <asp:Label ID="lbl_regime" runat="server"></asp:Label>
                            </span>
                            <br />
                            <span>
                                <strong>Curso: </strong>
                                <asp:Label ID="lbl_curso" runat="server"></asp:Label>
                            </span>
                            <br />
                            <span>
                                <strong>Genero: </strong>
                                <asp:Label ID="lbl_genero" runat="server"></asp:Label>
                            </span>
                            <br />
                            <span>
                                <strong>Hobbies: </strong>
                                <asp:Label ID="lbl_hobbies" runat="server"></asp:Label>
                            </span>
                            <br />
                            <span>
                                <strong>Email: </strong>
                                <asp:Label ID="lbl_email" runat="server"></asp:Label>
                            </span>
                            <br />
                            <span>
                                <strong>Codigo Postal: </strong>
                                <asp:Label ID="lbl_codigoPostal" runat="server"></asp:Label>
                            </span>
                            <br />
                        </div>
                    </div>
                </div>
              
                  <div class="col-33% col-md-10 mx-auto col-6 center">
                      
                    <asp:Button ID="btn_xml" runat="server" Text="XML" OnClick="btn_xml_Click" class="btn custom-btn bg-color mt-3" data-aos="fade-up" data-aos-delay="300" data-toggle="modal" data-target="#membershipForm" />
                    &nbsp;
        <asp:Button ID="btn_excel" runat="server" Text="EXCEL" OnClick="btn_excel_Click" class="btn custom-btn bg-color mt-3" data-aos="fade-up" data-aos-delay="300" data-toggle="modal" data-target="#membershipForm" />
                    &nbsp;
        <asp:Button ID="btn_word" runat="server" Text="WORD" OnClick="btn_word_Click" class="btn custom-btn bg-color mt-3" data-aos="fade-up" data-aos-delay="300" data-toggle="modal" data-target="#membershipForm" />
                    &nbsp;
        <asp:Button ID="btn_pdf" runat="server" Text="PDF/email" OnClick="btn_pdf_Click" class="btn custom-btn bg-color mt-3" data-aos="fade-up" data-aos-delay="300" data-toggle="modal" data-target="#membershipForm" />
                    &nbsp;<asp:Label ID="lbl_mensagem" runat="server" Text="Label" Visible="False"></asp:Label>
                    </div>
               
                <br />
               <p>

               </p> 
            </div>
             <br />
            <asp:Button ID="btn_loja" runat="server" Text="Ver Loja" OnClick="btn_loja_Click" type="submit" class="custom-btn-b"/>
                &nbsp;<p>
        </div>
    </section>
</asp:Content>
