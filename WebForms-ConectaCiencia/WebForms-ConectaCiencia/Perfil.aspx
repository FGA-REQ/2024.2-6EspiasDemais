<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="WebForms_ConectaCiencia.Perfil" Async="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-100">
        <div class="profile-box border p-4 shadow text-center" style="width: 100%; max-width: 400px;">
            <h2 class="text-center">Olá, <asp:Literal ID="UserNameLiteral" runat="server" Text="{nome}"></asp:Literal></h2>

            <div class="form-group d-flex justify-content-center">
                <asp:Button ID="btnMeusArtigos" runat="server" Text="Meus artigos" CssClass="btn btn-primary w-100" OnClick="btnMeusArtigos_Click"/>
            </div>

            <div class="text-center mt-3">
                <asp:LinkButton ID="btnSair" runat="server" CssClass="text-danger" OnClick="btnSair_Click">Sair</asp:LinkButton>
            </div>
        </div>
    </div>

    <!-- Estrutura visual do Toast -->
    <div id="alertSuccess" class="toast toast-success d-none" role="alert"></div>
    <div id="alertError" class="toast toast-error d-none" role="alert"></div>

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

        .d-none {
            display: none !important;
        }
    </style>

    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", function () {
            var urlParams = new URLSearchParams(window.location.search);
            var cadastroStatus = urlParams.get('cadastro');

            if (cadastroStatus === 'sucesso') {
                var toast = document.getElementById("alertSuccess");
                toast.textContent = "Cadastro realizado com sucesso!";
                toast.classList.remove("d-none");
                toast.classList.add("show");

                setTimeout(function () {
                    toast.classList.remove("show");
                    toast.classList.add("d-none");
                }, 3000);
            } else if (cadastroStatus === 'erro') {
                var toast = document.getElementById("alertError");
                toast.textContent = "Ocorreu um erro no cadastro!";
                toast.classList.remove("d-none");
                toast.classList.add("show");

                setTimeout(function () {
                    toast.classList.remove("show");
                    toast.classList.add("d-none");
                }, 3000);
            }
        });
    </script>
</asp:Content>
