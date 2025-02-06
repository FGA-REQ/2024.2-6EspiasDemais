# US11 - Editar e Apagar Publicação

## Descrição

Eu, como usuário logado, quero poder editar ou excluir meus artigos diretamente da página **Meus Artigos**.

---

## Critérios de Aceite:

1. A funcionalidade de edição e exclusão deve estar disponível em cada artigo da página Meus Artigos.
2. Editar Artigo:
   - Ao clicar no botão de editar, deve abrir um modal com os seguintes campos pré-preenchidos:
     - Título.
     - Conteúdo.
     - Categoria.
   - O usuário pode modificar qualquer um desses campos.
   - Após a edição, o usuário pode salvar as alterações e o artigo será atualizado e será exibida a mensagem “Artigo editado com sucesso!”.
3. Excluir Artigo:
   - Ao clicar no botão de excluir, deve exibir uma caixa de confirmação com a mensagem: "Você tem certeza de que deseja excluir este artigo?"
   - O artigo só será excluído após a confirmação do usuário.
   - Após a exclusão, a lista de artigos deve ser atualizada para refletir a remoção e deve ser exibida a mensagem “Artigo excluído com sucesso”.
4. A listagem dos artigos deve ser carregada com dados vinculados ao usuário logado, garantindo que apenas os artigos do usuário atual sejam exibidos.
5. A página deve ser responsiva, garantindo boa visualização em dispositivos móveis e desktops.
6. O layout da página deve ser claro e intuitivo, facilitando a navegação e a interação com os artigos.

---

### Fluxo de Edição e Exclusão:

1. O usuário acessa a página **Meus Artigos**.
2. Para editar um artigo, o usuário clica no botão de editar, faz as alterações no modal e salva.
3. Para excluir um artigo, o usuário clica no botão de excluir, confirma a exclusão e o artigo é removido da lista.
