<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebForms_ConectaCiencia.Cadastro" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-100"> 
        <div class="login-box border p-4 shadow" style="width: 100%; max-width: 400px;">
            <h2 class="text-center">Cadastro</h2>

            <div class="form-group d-flex justify-content-center">
                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control text-center" placeholder="Nome*" style="width: 100%; max-width: 300px;" onkeyup="verificarCampos()"></asp:TextBox>
            </div>
            
            <div class="form-group d-flex justify-content-center">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control text-center" placeholder="E-mail*" style="width: 100%; max-width: 300px;" onkeyup="verificarCampos()"></asp:TextBox>
            </div>

            <div class="form-group d-flex justify-content-center">
                <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control text-center" TextMode="Password" placeholder="Senha*" style="width: 100%; max-width: 300px;" onkeyup="verificarCampos()"></asp:TextBox>
            </div>

            <div class="text-center">
                <span id="senhaMensagem" class="text-danger" style="font-size: 0.9rem;"></span>
            </div>

            <div class="text-center">
                <asp:Button ID="btnCadastrar" runat="server" CssClass="btn btn-primary" Text="Cadastrar" OnClick="btnCadastrar_Click" Disabled="True" />
            </div>

            <div>
                <asp:Label ID="lblMensagem" runat="server" CssClass="text-danger text-center" Visible="false"></asp:Label>
            </div>

            <div class="text-center mt-3">
                <p>Já tem uma conta? <a href="Acesso.aspx">Acesse aqui</a></p>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function verificarCampos() {
            var nome = document.getElementById('<%= txtNome.ClientID %>').value.trim();
            var email = document.getElementById('<%= txtEmail.ClientID %>').value.trim();
            var senha = document.getElementById('<%= txtSenha.ClientID %>').value.trim();
            var botaoCadastrar = document.getElementById('<%= btnCadastrar.ClientID %>');
            var senhaMensagem = document.getElementById('senhaMensagem');

            var senhaValida = validarSenha(senha);
            var emailValido = validarEmail(email);

            senhaMensagem.textContent = senhaValida || !senha
                ? ""
                : "A senha deve ter pelo menos 8 caracteres, incluindo uma letra maiúscula, uma letra minúscula e um número.";

            botaoCadastrar.disabled = !(nome && emailValido && senhaValida);

            console.log(
                "Nome:", nome,
                "Email:", email,
                "Email válido:", emailValido,
                "Senha:", senha,
                "Botão habilitado:", !botaoCadastrar.disabled
            ); // Debug
        }

        function validarSenha(senha) {
            var regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$/;
            return regex.test(senha);
        }

        function validarEmail(email) {
            var regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            return regex.test(email);
        }

    </script>

</asp:Content>
