<%@ Page Title="Formulários" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Forms.aspx.cs" Inherits="WebForms_ConectaCiencia.Forms" Async="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div id="alertSuccess" class="toast toast-success d-none" role="alert"></div>
    <div id="alertError" class="toast toast-error d-none" role="alert"></div>

    <div class="d-flex justify-content-center align-items-center vh-100">
        <div class="container p-4" style="max-width: 1200px;"> 
            <div class="row">

                <div class="col-md-6 d-flex justify-content-center">
                    <div class="p-4 border shadow-lg" style="width: 100%; max-width: 400px;">
                        <h2 class="text-center">Sugerir Tema</h2>
                        <p class="text-center text-muted">
                            Utilize este formulário para sugerir um tema para um novo artigo.
                        </p>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtNomeTema" CssClass="form-control mb-2" runat="server" Placeholder="Nome*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtEmailTema" CssClass="form-control mb-2" runat="server" Placeholder="Email*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtTema" CssClass="form-control mb-2" runat="server" TextMode="MultiLine" Placeholder="Tema*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:DropDownList ID="ddlCategoriaTema" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Selecione uma Categoria" Value="" />
                            </asp:DropDownList>
                        </div>
                        <div class="text-center">
                            <asp:Button ID="BtnEnviarTema" CssClass="btn btn-primary mt-2" runat="server" Text="Enviar" OnClick="BtnEnviarTema_Click" Enabled="false" />
                        </div>
                    </div>
                </div>

                <div class="col-md-6 d-flex justify-content-center">
                    <div class="p-4 border shadow-lg" style="width: 100%; max-width: 400px;">
                        <h2 class="text-center">Sugerir Artigo</h2>
                        <p class="text-center text-muted">
                            Utilize este formulário para sugerir um artigo completo que poderá ser publicado.
                        </p>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtNomeArtigo" CssClass="form-control mb-2" runat="server" Placeholder="Nome*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtEmailArtigo" CssClass="form-control mb-2" runat="server" Placeholder="Email*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtTituloArtigo" CssClass="form-control mb-2" runat="server" Placeholder="Título*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtConteudoArtigo" CssClass="form-control mb-2" runat="server" TextMode="MultiLine" Placeholder="Conteúdo*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:DropDownList ID="ddlCategoriaArtigo" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Selecione uma Categoria" Value="" />
                            </asp:DropDownList>
                        </div>
                        <div class="text-center">
                            <asp:Button ID="BtnEnviarArtigo" CssClass="btn btn-primary mt-2" runat="server" Text="Enviar" OnClick="BtnEnviarArtigo_Click" Enabled="false" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function mostrarMensagem(idAlert, mensagem) {
            var alertSuccess = document.getElementById('alertSuccess');
            var alertError = document.getElementById('alertError');

            if (idAlert === "alertSuccess") {
                alertSuccess.textContent = mensagem;
                alertSuccess.classList.remove('d-none');
                alertError.classList.add('d-none');
            } else if (idAlert === "alertError") {
                alertError.textContent = mensagem;
                alertError.classList.remove('d-none');
                alertSuccess.classList.add('d-none');
            }

            setTimeout(function () {
                alertSuccess.classList.add('show');
                alertError.classList.add('show');
            }, 10);

            setTimeout(function () {
                alertSuccess.classList.remove('show');
                alertError.classList.remove('show');
            }, 5000);
        }

        function validarCamposTema() {
            var nomeTema = document.getElementById('<%= txtNomeTema.ClientID %>').value.trim();
            var emailTema = document.getElementById('<%= txtEmailTema.ClientID %>').value.trim();
            var tema = document.getElementById('<%= txtTema.ClientID %>').value.trim();
            var categoriaTema = document.getElementById('<%= ddlCategoriaTema.ClientID %>').value;

            var botaoEnviarTema = document.getElementById('<%= BtnEnviarTema.ClientID %>');

            if (nomeTema !== "" && emailTema !== "" && tema !== "" && categoriaTema !== "") {
                botaoEnviarTema.disabled = false;
            } else {
                botaoEnviarTema.disabled = true;
            }
        }

        function validarCamposArtigo() {
            var nome = document.getElementById('<%= txtNomeArtigo.ClientID %>').value.trim();
            var email = document.getElementById('<%= txtEmailArtigo.ClientID %>').value.trim();
            var titulo = document.getElementById('<%= txtTituloArtigo.ClientID %>').value.trim();
            var conteudo = document.getElementById('<%= txtConteudoArtigo.ClientID %>').value.trim();
            var categoria = document.getElementById('<%= ddlCategoriaArtigo.ClientID %>').value;

            var botaoEnviar = document.getElementById('<%= BtnEnviarArtigo.ClientID %>');

            if (nome !== "" && email !== "" && titulo !== "" && conteudo !== "" && categoria !== "") {
                botaoEnviar.disabled = false;
            } else {
                botaoEnviar.disabled = true;
            }
        }

        document.addEventListener('DOMContentLoaded', function () {
            document.getElementById('<%= txtNomeTema.ClientID %>').addEventListener('input', validarCamposTema);
            document.getElementById('<%= txtEmailTema.ClientID %>').addEventListener('input', validarCamposTema);
            document.getElementById('<%= txtTema.ClientID %>').addEventListener('input', validarCamposTema);
            document.getElementById('<%= ddlCategoriaTema.ClientID %>').addEventListener('change', validarCamposTema);
        });

        document.addEventListener('DOMContentLoaded', function () {
            document.getElementById('<%= txtNomeArtigo.ClientID %>').addEventListener('input', validarCamposArtigo);
            document.getElementById('<%= txtEmailArtigo.ClientID %>').addEventListener('input', validarCamposArtigo);
            document.getElementById('<%= txtTituloArtigo.ClientID %>').addEventListener('input', validarCamposArtigo);
            document.getElementById('<%= txtConteudoArtigo.ClientID %>').addEventListener('input', validarCamposArtigo);
            document.getElementById('<%= ddlCategoriaArtigo.ClientID %>').addEventListener('change', validarCamposArtigo);
        });
    </script>

    <style>
        .toast {
            position: fixed;
            top: 20px;
            right: 20px;
            min-width: 200px;
            padding: 15px;
            color: #fff;
            border-radius: 5px;
            opacity: 0;
            transition: opacity 0.5s ease-in-out;
            z-index: 1050;
        }

        .toast.show {
            opacity: 1;
        }

        .toast-success {
            background-color: #28a745;
        }

        .toast-error {
            background-color: #dc3545;
        }
    </style>

</asp:Content>
