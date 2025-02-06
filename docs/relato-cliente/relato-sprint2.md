# Relato do Cliente

## Introdução

Este documento apresenta o relato do cliente com base em um formulário elaborado para coletar feedback sobre a implementação do sistema, com base nos critérios de aceitação. O formulário incluiu perguntas acompanhadas de imagens para verificar se os requisitos atendem às expectativas do cliente, identificar melhorias necessárias e avaliar se algo está em falta ou dentro do esperado.

## Relato

### Sprint 2

Nesta sprint, foram entregues ao usuário as seguintes histórias de usuário:

- [US06 - Autenticação (Cadastro)](../user-stories/US06-Cadastro.md)
- [US07 - Autenticação (Acesso)](../user-stories/US07-Acesso.md)
- [US08 - Perfil](../user-stories/US08-Perfil.md)
- [US09 - Publicações de Artigos](../user-stories/US09-Publicacao.md)
- [US10 - Meus Artigos](../user-stories/US10-MeuArtigos.md)
- [US11 - Editar e Apagar Publicação](../user-stories/US11-EditarExcluir.md)

📌 **Link do formulário:** [Formulário de validação, Sprint 2.](https://forms.gle/Ac4FNDqsgRvqtvy47)

### Feedback

Para a sprint 2 o feedback do cliente foi dividido em dois aspectos principais: o produto e o formulário de validação.

#### Produto

Os comentários nesta seção dizem respeito diretamente à experiência do usuário com o sistema.

- [Melhorar o foco da página quando o usuário a acessa ✔](https://github.com/FGA-REQ/2024.2-6EspiasDemais/commit/0a6567bf430009604420bea5ab89853e76c0fead)

- [Adicionar explicação sobre os formulários ✔](https://github.com/FGA-REQ/2024.2-6EspiasDemais/commit/ff45e7f0c5aa6c60420b84d77e9d450778846f47)

- [Trocar a mensagem de erro "Not Found" quando não há artigos disponíveis ✔](https://github.com/FGA-REQ/2024.2-6EspiasDemais/commit/717d923961aa777b15129c2ca8401addfe6b8b66)

- [Adicionar a categoria nos artigos ✔](https://github.com/FGA-REQ/2024.2-6EspiasDemais/commit/4c3e31f58627b26355aa1ccee0fbc8e9525eceb5)

#### Feedback sobre o Formulário

Os feedbacks desta seção dizem respeito à experiência do cliente ao preencher o formulário de validação do sistema:

- As perguntas estavam pouco claras; sugeriu-se o uso de palavras mais objetivas.
- As imagens fornecidas não foram suficientes; o cliente precisou rodar o sistema em seu próprio computador para validar as informações.
- A explicação das perguntas deveria ser melhorada para garantir maior compreensão.
- Foi solicitado remover os cartões das User Stories dos formulários, pois isso não era necessário para o contexto da validação.

## Formulario

As perguntas feitas no formulário têm suas respostas como "Sim" ou "Não". Aqui se encontram apenas as perguntas e suas respostas, onde o foco é apenas na coleta de dados e documentação, com a inferência de um gráfico ao final, apresentando a porcentagem de aceitação pelo usuário.

## Formulário de Cadastro

<font size="3"><p style="text-align: left">**Tabela 1** - Respostas do formulário de cadastro.</p></font>

| Pergunta | Resposta |
|----------|---------|
| O formulário de cadastro está acessível através de um link escrito "Acessar", localizado na parte superior da página, que direciona o usuário para a página de cadastro? | Sim |
| Os campos "Nome", "E-mail" e "Senha" estão presentes e são marcados como obrigatórios? O botão "Cadastrar" permanece desativado até que todos os campos obrigatórios sejam preenchidos corretamente? | Sim |
| O sistema valida se a senha possui os critérios mínimos de 8 caracteres, 1 letra minúscula e 1 letra maiúscula? | Sim |
| Após o envio do formulário, o sistema exibe uma mensagem de sucesso ("Cadastro realizado com sucesso! Você já pode fazer login") ou, em caso de erro, uma mensagem clara e específica (por exemplo, "E-mail já cadastrado")? | Não |
| Observações | Nenhuma |

## Formulário de Acesso

<font size="3"><p style="text-align: left">**Tabela 2** - Respostas do formulário de acesso.</p></font>

| Pergunta | Resposta |
|----------|---------|
| O formulário de acesso está acessível através de um link escrito "Acessar", localizado na parte superior da página, que direciona o usuário para a página de login? | Sim |
| Os campos "E-mail" e "Senha" estão presentes e são marcados como obrigatórios? O botão "Entrar" permanece desativado até que todos os campos obrigatórios sejam preenchidos corretamente? | Sim |
| Ao tentar realizar o login, se algum dos dados estiver incorreto, o sistema exibe a mensagem "E-mail ou senha inválidos"? | Sim |
| Após a realização do login, o usuário é redirecionado para a página de perfil em caso de sucesso? | Sim |
| Observações | Nenhuma |

## Perfil

<font size="3"><p style="text-align: left">**Tabela 3** - Respostas do formulário de perfil.</p></font>

| Pergunta | Resposta |
|----------|---------|
| A tela de perfil está disponível na página "Perfil" e é acessível apenas para usuários que estiverem logados? | Sim |
| O nome do usuário logado é exibido corretamente na tela de perfil? | Sim |
| Caso o usuário já tenha realizado alguma publicação, elas são listadas corretamente, exibindo título, data de publicação e categoria? | Sim |
| Caso o usuário não tenha realizado nenhuma publicação, é exibida a mensagem "Você ainda não publicou nenhum artigo"? | Não |
| O botão "Sair" funciona corretamente, realizando o logout e redirecionando o usuário para a página de login?  | Sim |
| Observações | A mensagem exibida não é exatamente igual à citada, mas a versão atual está aceitável. |

## Publicação de Artigos

<font size="3"><p style="text-align: left">**Tabela 4** - Respostas do formulário de publicação de artigos.</p></font>

| Pergunta | Resposta |
|----------|---------|
| A funcionalidade de publicação está disponível na página "Perfil" e é acessível apenas para usuários logados? | Sim |
| Os campos "Título", "Conteúdo" e "Categoria" estão presentes e são marcados como obrigatórios? O botão "Publicar" permanece desativado até que todos os campos obrigatórios sejam preenchidos corretamente? | Sim |
| Após enviar o formulário, o usuário recebe um retorno sobre a publicação? Se tudo der certo, aparece a mensagem "Artigo publicado com sucesso!". Caso ocorra algum erro, a mensagem exibida é "Erro ao publicar o artigo. Tente novamente mais tarde." | Não |
| Observações | Nenhuma |

## Meus Artigos

<font size="3"><p style="text-align: left">**Tabela 5** - Respostas do formulário de Meus Artigos.</p></font>

| Pergunta | Resposta |
|----------|---------|
| A página Meus Artigos só é disponível para usuários logados? | Sim |
| Se o usuário já publicou artigos, eles são exibidos em ordem cronológica, do mais recente para o mais antigo? | Sim |
| Caso nenhum artigo tenha sido publicado, é mostrada a mensagem "Sem artigos publicados, que tal fazer uma publicação?"? | Sim |
| Em cada artigo listado, são exibidos o título, a categoria e a data de publicação? Além disso, os botões "Excluir" (para remover o artigo) e "Editar" (para modificá-lo) estão disponíveis? | Sim |
| Ao clicar no botão "Excluir" para remover um artigo, é exibida a mensagem "Você tem certeza de que deseja excluir este artigo?" e o artigo só é realmente excluído após a confirmação do usuário? | Não |
| Existe um botão "Publicar" que redireciona o usuário para a página de publicação de artigos? | Sim |
| Observações | Nenhuma |

## Correções da 1ª Sprint

<font size="3"><p style="text-align: left">**Tabela 6** - Respostas sobre as correções da 1ª Sprint.</p></font>

| Pergunta | Resposta |
|----------|---------|
| Durante a criação ou sugestão de um novo artigo, a página exibe uma mensagem clara e intuitiva que orienta o usuário sobre a finalidade de cada formulário? | Sim |
| As mensagens de erro foram aprimoradas em relação à versão anterior? | Sim |

Autor(es): [João Vitor](https://github.com/Jauzimm), 2025.

### Resultado

Com a medição a partir de um gráfico contendo 24 perguntas respondidas, sendo 20 respostas "Sim" e 4 respostas "Não", temos a seguinte estatística de aceitação pelo cliente:

<font size="3"><p style="text-align: left">**Imagem 1** - Gráfico das respostas.</p></font>

![Imagem do grafico](imagens/graficoRelato2.png)

Autor(es): [João Vitor](https://github.com/Jauzimm), 2025.

## Histórico de Versões

<font size="3"><p style="text-align: left">**Tabela 7** - Histórico de versões.</p></font>

| Versão |               Descrição                |   Autor    |    Data    |    Revisor     | Data de revisão |
| :----: | :------------------------------------: | :--------: | :--------: | :------------: | :-------------: |
|  1.0   | Criação do Relato | [João Vitor](https://github.com/Jauzimm) | 06/02/2025 |  |  |



