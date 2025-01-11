# US08 - Perfil

## Descrição
Eu, como usuário logado, quero acessar uma tela com meu perfil para visualizar minhas informações e publicações pessoais.

---

## Critérios de Aceite:
1. A tela de perfil deve estar disponível na página **Perfil.aspx** e ser acessível apenas para usuários logados.
2. A tela deve exibir as seguintes informações do usuário logado:
   - Nome.
   - E-mail.
3. A tela deve listar todas as publicações feitas pelo usuário logado, apresentando:
   - Título de cada publicação.
   - Data de publicação.
   - Categoria associada.
   - Link para visualizar ou editar a publicação (se aplicável).
4. Deve haver um botão ou link para **Sair**, que:
   - Redirecione o usuário para a página de login após a confirmação do logout.
   - Encerre a sessão do usuário com segurança.
5. O layout da página deve ser responsivo, garantindo boa visualização em dispositivos móveis e desktops.
6. Caso o usuário não tenha publicações, deve exibir a mensagem: "Você ainda não publicou nenhum artigo."
7. A página deve exibir o nome do usuário logado no cabeçalho ou em um local destacado como saudação (exemplo: "Olá, [Nome]!").
