# US06 - Autenticação (Cadastro)

## Descrição
Eu, como usuário, quero poder me cadastrar para publicar artigos no site.

---

## Critérios de Aceite:
1. O formulário de cadastro deve estar disponível na página cadastro.
2. O formulário deve conter os seguintes campos obrigatórios:
   - **Nome**: Campo de texto para o nome do usuário.
   - **E-mail**: Campo de texto para o e-mail do usuário.
   - **Senha**: Campo de texto para a senha do usuário.
3. O botão de cadastro deve permanecer desativado até que todos os campos obrigatórios sejam preenchidos de forma válida.
4. Deve ser realizada a validação do e-mail, garantindo que seja inserido um endereço válido.
5. A senha deve ser validada com os seguintes critérios (se aplicável):
   - Tamanho mínimo de 8 caracteres.
   - Deve conter pelo menos uma letra maiúscula, uma letra minúscula e um número.
6. Após o envio do formulário:
   - Se o cadastro for bem-sucedido, deve exibir uma mensagem de confirmação: "Cadastro realizado com sucesso! Você já pode fazer login."
   - Em caso de erro, deve exibir uma mensagem clara com o motivo do erro.
