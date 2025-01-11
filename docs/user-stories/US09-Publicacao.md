# US09 - Publicação de Artigos

## Descrição
Eu, como usuário logado, quero poder publicar artigos para compartilhar conteúdos científicos no site.

---

## Critérios de Aceite:
1. A funcionalidade de publicação deve estar disponível na página **Publicar.aspx** e ser acessível apenas para usuários logados.
2. O formulário de publicação deve conter os seguintes campos obrigatórios:
   - **Título**: Campo de texto para o título do artigo.
   - **Conteúdo**: Campo de texto ou editor para o corpo do artigo.
   - **Categoria**: Campo dropdown para selecionar uma categoria. As categorias devem ser carregadas de uma lista fornecida pela API.
3. O botão de publicação deve permanecer desativado até que todos os campos obrigatórios sejam preenchidos.
4. Após o envio do formulário:
   - Se a publicação for bem-sucedida, deve exibir uma mensagem de sucesso: "Artigo publicado com sucesso!"
   - Em caso de erro, deve exibir uma mensagem clara com o motivo do erro: "Erro ao publicar o artigo. Tente novamente mais tarde."
5. Os seguintes dados devem ser preenchidos automaticamente:
   - **Autor**: Obtido a partir da autenticação do usuário logado.
   - **Data e Hora**: Preenchidos automaticamente com a data e hora do momento da publicação.
6. O layout da página deve ser responsivo, garantindo boa visualização em dispositivos móveis e desktops.
7. O formulário deve validar os seguintes critérios:
   - O título deve ter no mínimo 5 caracteres.
   - O conteúdo deve ter no mínimo 100 caracteres.
8. Deve haver uma opção para cancelar a publicação, limpando o formulário e retornando o usuário para a página anterior.

---

### Fluxo de Publicação:
1. O usuário logado acessa a página de publicação.
2. Preenche os campos obrigatórios: Título, Conteúdo e Categoria.
3. O botão de publicação é ativado.
4. Após clicar em "Publicar", os dados são enviados para a API para processamento.
5. A resposta da API determina se o artigo foi publicado com sucesso ou se houve erro.
