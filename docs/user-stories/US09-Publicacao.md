# US09 - Publicação de Artigos

## Descrição

Eu, como usuário logado, quero poder publicar artigos para compartilhar conteúdos científicos no site.

---

## Critérios de Aceite:

1. A funcionalidade de publicação deve estar disponível na página Meus Artigos e ser acessível apenas para usuários logados.
2. O formulário de publicação deve conter os seguintes campos obrigatórios:
   - Título: Campo de texto para o título do artigo.
   - Conteúdo: Campo de texto ou editor para o corpo do artigo.
   - Categoria: Campo dropdown para selecionar uma categoria. As categorias devem ser carregadas de uma lista fornecida pela API.
3. O botão de publicação deve permanecer desativado até que todos os campos obrigatórios sejam preenchidos.
4. Os seguintes dados devem ser preenchidos automaticamente:
   - Autor: Obtido a partir da autenticação do usuário logado.
   - Data: Preenchida automaticamente com a data do momento da publicação.
5. O layout da página deve ser responsivo, garantindo boa visualização em dispositivos móveis e desktops.

6. Após o envio do formulário
   - Em caso de sucesso, deve exibir a mensagem ”Artigo publicado com sucesso!”.
   - Em caso de erro, deve exibir a mensagem “Erro ao publicar artigo. Tente novamente.” ou “Erro ao publicar artigo. Tente novamente.”

---

### Fluxo de Publicação:

1. O usuário logado acessa a página de publicação.
2. Preenche os campos obrigatórios: Título, Conteúdo e Categoria.
3. O botão de publicação é ativado.
4. Após clicar em "Publicar", os dados são enviados para a API para processamento.
5. A resposta da API determina se o artigo foi publicado com sucesso ou se houve erro.
