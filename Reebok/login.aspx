<%@ Page Title="" Language="C#" MasterPageFile="~/template_login.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Reebok.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="schedule section" id="schedule">
        <div class="container">
            <div class="row">

                <div class="ml-auto col-lg-5 col-md-10 mx-auto col-12 text-center">
                    <h2 class="mb-4 pb-2" data-aos="fade-up" data-aos-delay="200">LOGIN</h2>



                    <div action="#" method="post" class="contact-form webform" data-aos="fade-up" data-aos-delay="400" role="form">



                        <asp:TextBox ID="tb_utilizador" runat="server" type="text" class="form-control" name="cf-name" placeholder=" Utilizador"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_utilizador" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />


                        <asp:TextBox ID="tb_palavraPasse" runat="server" TextMode="Password" type="text" class="form-control" name="cf-name" placeholder="Palavra-passe"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_palavraPasse" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <br />
                        <asp:Button ID="btn_entrar" runat="server" OnClick="btn_entrar_Click" Text="Entrar" type="submit" class="custom-btn-entrar" />
                        <br />
                        <br />
                        <asp:Label ID="lbl_mensagem" runat="server" Text="Erro! Utilizador ou Palavra-passe Incorretos!" ForeColor="Red" Visible="False"></asp:Label>
                      


                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
