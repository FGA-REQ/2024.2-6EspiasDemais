# Regras de Negócio

## Requisitos do Sistema

### Requisitos Funcionais

#### Categorias
1. Cada **categoria** deve possuir um **nome único e descritivo**.

#### Formulário Tema
1.  Os campos **nome**, **email**, **tema** e **categoria** são obrigatórios para cada sugestão.
2.  A **categoria** deve referenciar uma categoria existente.

#### Formulário Artigo
1. Os campos **nome**, **email**, **título**, **conteúdo** e **categoria** são obrigatórios.
2. A **categoria** deve referenciar uma categoria existente.

#### Artigos
1. Cada **artigo** deve ter um **título** e **conteúdo** associados a um **autor identificado**.
2. Apenas **usuários cadastrados** podem submeter artigos, vinculados ao **id_usuario**.
3. Um artigo deve estar obrigatoriamente associado a uma **categoria válida**.
4. A **data de submissão** é automaticamente registrada e não pode ser alterada manualmente.

#### Usuários
1. O **email dos usuários** deve ser **único** no banco de dados.
2. A **senha** deve ser armazenada de forma segura, utilizando técnicas de **hash**.
3. Apenas **usuários autenticados** devem ter permissão para criar, modificar artigos e interagir com artigos já publicados.

#### Relacionamentos
1. Um **usuário** pode submeter vários artigos, mas cada **artigo pertence a um único usuário**.
2. Cada **artigo** deve estar associado a uma **única categoria**.

### Requisitos Não Funcionais

#### Segurança
1. As **senhas dos usuários** devem ser armazenadas de forma segura utilizando técnicas de **hash**.

#### Usabilidade
1. O **email** dos usuários deve ser único, garantindo um bom fluxo de cadastro.

#### Performance
1. As operações de **submissão de artigos** devem ser realizadas de forma eficiente, sem impactar na experiência do usuário.

#### Integridade de Dados
1. A **categoria associada** aos artigos e aos temas deve ser válida e existirem previamente cadastradas no sistema.

## Regras de Negócio da API

### Requisitos Funcionais

#### Categorias

1. Todas as categorias cadastradas devem ser retornadas, ordenadas por nome em ordem alfabética.

#### Feed (Artigos)

1. Deve existir a opção de adicionar Artigo:

   - O título e o conteúdo do artigo são obrigatórios e devem conter no mínimo 10 caracteres.
   - A categoria associada deve existir no sistema.
   - Somente usuários autenticados podem adicionar artigos.

2. Deve ser possível pesquisar Artigos:

   - Os filtros de pesquisa devem ser opcionais.
   - Artigos devem ser retornados em ordem decrescente de data de publicação por padrão.

3. Alterar Artigo:

   - Apenas o autor do artigo ou administradores podem alterar um artigo.
   - O título e o conteúdo não podem ser atualizados para valores vazios.

4. Excluir Artigo:
   - Apenas o autor ou administradores podem excluir um artigo.

#### Formulários (Sugestões)

1. Adicionar Tema:

   - O nome, e-mail, categoria e descrição do tema são obrigatórios.
   - A categoria associada à sugestão deve ser válida e previamente cadastrada.

2. Adicionar Artigo:
   - O nome, e-mail, categoria, título e conteúdo do artigo sugerido são obrigatórios.
   - Sugestões de artigos não criam publicações automaticamente.

#### Login e Cadastro

1. Realizar Login:

   - O sistema deve validar e-mails e senhas em conformidade com a autenticação segura.
   - O login falhará caso o e-mail não esteja cadastrado ou a senha esteja incorreta.

2. Registrar Usuário:
   - O nome, e-mail e senha são obrigatórios para o cadastro.
   - E-mails devem ser únicos no sistema.
   - Senhas devem conter no mínimo 8 caracteres.

### Requisitos Não Funcionais

#### Segurança
1. As senhas dos usuários devem ser armazenadas de forma segura utilizando técnicas de hash.
2. Todos os endpoints devem validar a entrada do usuário para prevenir ataques de SQL Injection.

#### Usabilidade
1. Os filtros de pesquisa de artigos devem ser opcionais, facilitando a navegação do usuário.

#### Performance
1. Os artigos devem ser retornados em ordem decrescente de data de publicação por padrão, garantindo consultas rápidas e organizadas.

#### Conformidade
1. O sistema de autenticação deve seguir boas práticas de segurança.

## Segurança e Auditoria

1. Todos os endpoints devem validar a entrada do usuário para prevenir ataques de SQL Injection.

## Regras de Negócio para o FrontEnd

### Requisitos Funcionais

#### Páginas Públicas

1. **Sobre.aspx:** Deve exibir informações gerais do blog.
2. **Feed.aspx:** Deve apresentar um feed de artigos publicados, organizados por ordem cronológica. Usuários podem aplicar filtros de busca por:

   - Categoria,
   - Data de publicação,
   - Palavras-chave no título ou conteúdo.

3. **Formularios.aspx:** Deve apresentar os formulários para envio de sugestões de temas e artigos:
   - **Sugestão de Tema:** Requer nome, email, categoria e descrição do tema.
   - **Sugestão de Artigo:** Requer nome, email, categoria, título e conteúdo.
   - Todos os campos obrigatórios devem ser preenchidos para ativar o botão de envio.
   - Mensagens de confirmação ou erro devem ser exibidas após tentativa de envio.
   - Deve ser realizada a validação de email.

#### Página Login

1. **Acesso.aspx:**

   - Campos obrigatórios: email e senha.
   - Ao falhar no login, exibir mensagem indicando erro.

2. **Cadastro.aspx:**
   - Campos obrigatórios: nome, email e senha.
   - O botão de cadastro só é ativado após o preenchimento de todos os campos obrigatórios de forma válida.

#### Páginas Logadas

1. **Perfil.aspx:** Deve exibir as informações do usuário logado e suas publicações pessoais. Deve oferecer a opção de Sair.
2. **MeusArtigos.aspx:** Deve ser uma página de feed pessoal do usuário, onde ele pode:

   - Criar novos artigos (redirecionamento para Publicar.aspx).
   - Editar artigos existentes por meio de modal: Título, conteúdo e categoria podem ser modificados e devem vir pré-preenchidos.
   - Excluir artigos: Deve exibir uma caixa de confirmação antes de concluir a exclusão.
   - A listagem dos artigos deve ser carregada com dados vinculados ao usuário logado e de modo cronológico.

3. **Publicar.aspx:**
   - Para criar novos artigos é necessário: Título, conteúdo e categoria.
   - O botão de publicação é ativado somente após o preenchimento completo dos campos.
   - Deve exibir uma mensagem de sucesso ou erro após tentativa de publicação.
   - A categoria deve ser selecionada de uma lista fornecida pela API.
   - Os dados do autor devem ser fornecidos pela autenticação dele no acesso.
   - As informações de data e hora devem ser preenchidas automaticamente.

### Requisitos Não Funcionais

#### Usabilidade
- O botão de login deve permanecer **desativado** até que os campos obrigatórios estejam preenchidos.
- O **botão de cadastro** deve ser ativado apenas quando todos os campos obrigatórios estiverem preenchidos corretamente.
- As páginas devem **apresentar mensagens de confirmação ou erro** em casos apropriados.

#### Segurança
- **Validação de email** deve ser realizada nos formulários de envio.

#### Performance
- As **páginas** devem carregar os dados de maneira eficiente e rápida, especialmente para **feeds** e listagens de artigos.

#### Integração
- A **categoria** no formulário de publicação deve ser **selecionada de uma lista** fornecida pela **API**.
- O sistema de **autenticação** deve fornecer os dados do autor ao publicar um artigo.

## Histórico de Versões

<font size="3"><p style="text-align: left">**Tabela 1** - Histórico de versões.</p></font>

| Versão |       Descrição       |                     Autor                      |    Data    |                       Revisor                        | Data de revisão |
| :----: | :-------------------: | :--------------------------------------------: | :--------: | :--------------------------------------------------: | :-------------: |
|  1.0   | Requisitos do Sistema | [Carlos Henrique](https://github.com/carlinn1) | 12/01/2025 | [Gabriel Henrique](https://github.com/gabrielhrlima) |   15/01/2025    |
