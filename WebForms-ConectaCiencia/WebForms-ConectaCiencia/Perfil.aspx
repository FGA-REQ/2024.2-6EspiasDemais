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
</asp:Content>