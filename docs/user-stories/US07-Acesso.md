# US07 - Autenticação (Acesso)

## Descrição

Eu, como usuário, quero poder fazer login para publicar artigos no site.

---

## Critérios de Aceite:

1. O formulário de login deve estar disponível na página Acesso.
2. O formulário deve conter os seguintes campos obrigatórios:
   - **E-mail**: Campo de texto para o e-mail do usuário.
   - **Senha**: Campo de texto para a senha do usuário.
3. O botão de login deve permanecer desativado até que ambos os campos obrigatórios sejam preenchidos.
4. Após o envio do formulário:
   - Se o login for bem-sucedido, o usuário deve ser redirecionado para a página principal ou para o painel de publicação de artigos.
   - Se o login falhar, deve exibir uma mensagem de erro clara: "E-mail ou senha incorretos. Por favor, tente novamente."
5. O layout do formulário deve ser responsivo, garantindo boa visualização em dispositivos móveis e desktops.
6. O formulário deve garantir a segurança dos dados enviados, utilizando conexões HTTPS e boas práticas de proteção contra ataques como SQL Injection.
7. Após o envio do formulário:
   - Se o login for bem-sucedido, o usuário deve ser redirecionado para a página Perfil.
   - Se o login falhar, deve exibir uma mensagem de erro clara: "E-mail ou senha inválidos."
