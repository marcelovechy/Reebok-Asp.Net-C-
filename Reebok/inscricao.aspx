<%@ Page Title="" Language="C#" MasterPageFile="~/template_paginas.Master" AutoEventWireup="true" CodeBehind="inscricao.aspx.cs" Inherits="Reebok.inscricao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="schedule section" id="schedule">
        <div class="container">
            <div class="row">

                <div class="ml-auto col-lg-5 col-md-10 mx-auto col-12 text-center">
                    <h2 class="mb-4 pb-2" data-aos="fade-up" data-aos-delay="200">INSCRIÇÃO</h2>



                    <div action="#" method="post" class="contact-form webform" data-aos="fade-up" data-aos-delay="400" role="form">



                        <p>
                            Nome:
        <asp:TextBox ID="tb_nome" runat="server" type="text" class="form-control" name="cf-name" placeholder="Nome"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tb_nome" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                        </p>
                        <p>
                            Morada:<asp:TextBox ID="tb_morada" runat="server" OnTextChanged="tb_morada_TextChanged" TextMode="MultiLine" type="text" class="form-control" name="cf-name" placeholder="Morada"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tb_morada" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                        </p>
                        <p>

                            <asp:Label ID="lbl_mensagem" runat="server" Visible="False" Font-Italic="True" ForeColor="#CC0000"></asp:Label>

                        </p>

                        <asp:UpdatePanel ID="UpdatePanel3" ChildrenAsTriggers="true" UpdateMode="Conditional" runat="server">
                            <ContentTemplate>
                                <p>Regime: </p>
                                <asp:DropDownList ID="ddl_regime" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_regime_SelectedIndexChanged" type="text" class="form-control" name="cf-name">
                                    <asp:ListItem>---</asp:ListItem>
                                    <asp:ListItem>Diurno</asp:ListItem>
                                    <asp:ListItem>Noturno</asp:ListItem>
                                </asp:DropDownList>
                                <br />

                                <p>Curso: </p>
                                <asp:DropDownList ID="ddl_curso" runat="server" AutoPostBack="True" Width="111px" type="text" class="form-control" name="cf-name">
                                    <asp:ListItem>    </asp:ListItem>
                                </asp:DropDownList>
                                <br />
                            </ContentTemplate>
                        </asp:UpdatePanel>

                        <p>
                            Genero:
        <asp:RadioButton ID="rb_masculino" runat="server" GroupName="genero" OnCheckedChanged="rb_masculino_CheckedChanged" Text="masculino" />
                            &nbsp;<asp:RadioButton ID="rb_feminino" runat="server" GroupName="genero" OnCheckedChanged="rb_feminino_CheckedChanged" Text="feminino" />

                        </p>

                        <p>
                            Hobbies: 
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server" class="class-info">
                            <ContentTemplate>
                                <asp:CheckBoxList ID="cbl_hobbies" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbl_hobbies_SelectedIndexChanged">
                                    <asp:ListItem>Futebol</asp:ListItem>
                                    <asp:ListItem>Corrida</asp:ListItem>
                                    <asp:ListItem>Estudos</asp:ListItem>
                                    <asp:ListItem>Séries</asp:ListItem>
                                    <asp:ListItem>Viagens</asp:ListItem>
                                    <asp:ListItem>Video game</asp:ListItem>
                                </asp:CheckBoxList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        </p>
                        <p>
                            Email:
                            <asp:TextBox ID="tb_email" runat="server" type="text" class="form-control" name="cf-name" placeholder=" Email"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tb_email" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_email" ErrorMessage="*" ForeColor="#009900" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

                        </p>
                        <p>
                            Código Postal:
                            <asp:TextBox ID="tb_codigoPostal" runat="server" type="text" class="form-control" name="cf-name" placeholder="Código Postal"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tb_codigoPostal" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tb_codigoPostal" ErrorMessage="*" ForeColor="#006600" ValidationExpression="^\d{4}(-\d{3})?$"></asp:RegularExpressionValidator>

                        </p>

                        <p>
                            Palavra-passe:
        <asp:TextBox ID="tb_palavraPasse" runat="server" OnTextChanged="tb_palavraPasse_TextChanged" TextMode="Password" type="text" class="form-control" name="cf-name" placeholder="Palavra-passe"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tb_palavraPasse" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                        </p>
                        <p>
                            <asp:Label ID="lbl_resultado" runat="server" Visible="False" Font-Italic="True" ForeColor="#CC0000"></asp:Label>

                        </p>
                        <p>
                            <asp:Button ID="btn_submeter" runat="server" Text="Submeter" OnClick="btn_submeter_Click" type="submit" class="custom-btn-entrar"/>
                            &nbsp;
                            <asp:Button ID="btn_limpar" runat="server" Text="Limpar" Width="124px" OnClick="btn_limpar_Click" type="submit" class="custom-btn-entrar"/>

                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
