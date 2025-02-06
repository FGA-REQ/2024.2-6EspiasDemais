# US06 - Autenticação (Cadastro)

## Descrição

Eu, como usuário, quero poder me cadastrar para publicar artigos no site.

---

## Critérios de Aceite:

1. O formulário de cadastro deve estar disponível na página Acesso/Cadastro.
2. O formulário deve conter os seguintes campos obrigatórios:
   - **Nome**: Campo de texto para o nome do usuário.
   - **E-mail**: Campo de texto para o e-mail do usuário.
   - **Senha**: Campo de texto para a senha do usuário.
3. O botão de cadastro deve permanecer desativado até que todos os campos obrigatórios sejam preenchidos de forma válida.
4. Deve ser realizada a validação do e-mail, garantindo que seja inserido um endereço válido.
5. A senha deve ser validada com os seguintes critérios:

   - Tamanho mínimo de 8 caracteres;
   - Pelo menos uma letra maiúscula;
   - Pelo menos uma letra minúscula;
   - Pelo menos um número;
   - Enquanto a senha não for preenchida de forma correta deve exibir a mensagem: “A senha deve ter pelo menos 8 caracteres, incluindo uma letra maiúscula, uma letra minúscula e um número”.

6. Após o envio do formulário:
   - Em caso de sucesso, deve exibir a mensagem ”Cadastro realizado com sucesso!”.
   - Em caso de erro, deve exibir a mensagem “Ocorreu um erro no cadastro!”.
