# Modelagem de processos

## Introdução

O processo de modelagem de tarefas é um metodo que estrutura a ordem que tarefas devem ser realizadas podendo ser utilizadas para diversas finalidades como definir o fluxo de tarefas a ser realizado para atingir um objetivo, dividir uma tarefa complexa em sub-tarefas para facilitar o desenvolvimento ou descrever sub-tarefas que compõem uma tarefa.

## Metodologia

A notação utilizada para o desenvolvimento do diagrama foi a BPMN (Business Process Model and Notation), sendo esta uma notação gráfica padrão para representar processos de negócio. Ela faz uso de simbolos e regras para a criação de diagramas que facilitam a compreensão e comunicação dos processos.

## Diagramação

### Diagrama de processo de desenvolvimento

![Diagrama](..\Img\DiagramaDesenvolvimento.png)

Todo o processo foi modelado através da ferramenta Lucidchart e pode ser acessado clicando [aqui](https://lucid.app/lucidchart/f7bd59ad-0d0f-451a-a6d2-42be2ba335e5/edit?viewport_loc=-733%2C1349%2C1739%2C1131%2C0_0&invitationId=inv_ea9e97ce-b396-44cc-aaa2-8b2d5d9243ac)

### Diagrama de fluxo de navegação

![Diagrama](..\Img\DiagramaFluxoDeNavegação.png)

Todo o processo foi modelado através da ferramenta Lucidchart e pode ser acessado clicando [aqui](https://lucid.app/lucidchart/89a9390b-a754-4444-9718-e9f49cc81b75/edit?viewport_loc=-1311%2C-1057%2C3272%2C2548%2C0_0&invitationId=inv_f28ae937-745d-424e-868d-34a2f097a5be)

## Descrição

### Diagrama de fluxo de navegação

#### **Início do Fluxo**

- O fluxo começa com o **acesso à plataforma**.
- Decisão: O usuário deve decidir se deseja fazer login.
    - **Sim**: O fluxo segue para o caminho de **Usuário com login**.
    - **Não**: O fluxo segue para o caminho de **Usuário sem login**.

#### **Usuário com Login**

1. **Acessar o Perfil**

    - Após o login, o usuário tem acesso ao perfil, onde pode realizar várias ações:

2. **Visualizar Feed de Artigos**

    - O usuário pode navegar pelo feed de artigos disponíveis na plataforma.

3. **Enviar Sugestões**

    - O usuário pode enviar sugestões de dois tipos:
        1. **Sugestões de Pauta**: Após o envio, o fluxo é concluído.
        2. **Sugestões de Artigos**: Após o envio, o fluxo é concluído.

4. **Visualizar Meus Artigos**

    - O usuário pode gerenciar os artigos que já escreveu:

  - **Escrever um Artigo**: O usuário pode criar e salvar um novo artigo.

  - **Visualizar Próprios Artigos**:
    - Decisão: O usuário pode optar por **editar** ou **excluir** um artigo.
        1. **Salvar Edições Realizadas**: As alterações são salvas, e o fluxo é concluído.
        2. **Descartar Edições Realizadas**: As alterações são descartadas, e o fluxo é concluído.

#### **Usuário sem Login**

1. **Visualizar Feed de Artigos**

    - O usuário pode navegar pelo feed de artigos disponíveis, mas sem a necessidade de login.

2. **Enviar Sugestões**

    - O usuário pode enviar sugestões de dois tipos:
        1. **Sugestões de Pauta**: Após o envio, o fluxo é concluído.
        2. **Sugestões de Artigos**: Após o envio, o fluxo é concluído.

3. **Criar Cadastro**

    - O usuário pode criar um cadastro na plataforma.
        1. Após o cadastro, o usuário é redirecionado para **acessar o perfil**, iniciando o fluxo de **Usuário com login**.

#### **Usuário sem Login**

1. **Visualizar Feed de Artigos**

    - O usuário pode navegar pelo feed de artigos disponíveis, acessando informações públicas sem necessidade de login.

2. **Enviar Sugestões**

    - O usuário pode contribuir com sugestões mesmo sem estar logado:

        1. **Sugestões de Pauta**: O usuário propõe ideias para novas pautas. Após o envio, o fluxo é concluído.
        2. **Sugestões de Artigos**: O usuário sugere temas ou conteúdos para artigos. Após o envio, o fluxo é concluído.

3. **Criar Cadastro**

    - O usuário pode optar por criar um cadastro na plataforma:
        1. Após o cadastro, o usuário é redirecionado para **acessar o perfil**, iniciando o fluxo de **Usuário com login**.

### Diagrama de processo de desenvolvimento

#### Discovery

Etapa incial do projeto, onde se tem as primeiras conversas entre o cliente e a equipe e surgem as primeiras ideias para a definição de requisitos e criação de histórias de usuários.

1. **Entendimento**

    - Onde ocorrem as primeiras conversas entre a equipe de desenvolvimento e o cliente, entendendo as necessidades do usuário para a formulação de requisitos.
    - Entradas: conversas com o cliente e entre a equipe.
    - Saídas: elicitação e descoberta de requisitos.

2. **Backlog**

    - Onde os requisitos levantados nas conversas com o cliente vão ser analizados e transformados em User Stories.
    - Entradas: elicitação e descoberta de requisitos.
    - Saídas: User stories criadas, com título, cartão e critérios de aceitação.

3. **Decisão: Requisitos estruturados?**

    - Após a realização das etapas anteriores o time deve se questionar se os requisitos estão bem estruturados para dar prosseguimento ao projeto.
    - Caso a resposta seja não, a equipe de desenvolvimento deve retornar a tarefa de entendimento, a fim de estruturar melhor os requisitos para o sistema.
    - Caso a resposta seja sim, a equipe deve seguir adiante para a etapa de Design.

#### Design

Segunda etapa do projeto, quando será feita a prototipação de alta fidelidade para cada história de usuário.

1. **Design**

    - Nesta tarefa, a equipe deve utilizar as histórias de usuários desenvolvidas anteriormente para o desenvolvimento de protótipos a serem utilizados em suas respectivas histórias.
    - Entradas: User stories criadas, ideia e criterios de aceitação iniciais.
    - Saída: Protótipos de alta fidelidade para cada user storie.

2. **Decisão: Satisfaz a necessidade do cliente?**

    - Neste momento o entendimento sobre as necessidades do cliente tem que estar claro a fim de prosseguir com o desenvolvimento de forma correta.
    - Caso a resposta seja sim, o desenvolvimento avança para a etapa de desenvolvimento.
    - Caso a resposta seja não, outros dois questionamentos devem ser feitos.

1. **Decisão: É um problema na interface?**

    - Seguindo por esse caminho o desenvolvimento deve retornar a tarefa de design, visando a melhoria e criação de interfaces que atendam melhor as necessidades do cliente.

2. **Decisão: É um problema de requisito funcional?**

    - Neste caminho o desenvolvimento retona a tarefa de entendimento na etapa anterior, a fim de definir de maneira mais precisa os requisitos que expressem melhor os desejos do cliente.

#### Develop

Terceira etapa do desenvolvimento, onde serão feitas as implementações com base em todo o material produzido nas tarefas e etapas anteriores.

1. **Desenvolvimento**

    - Tarefa de implementação, onde as user stories validadas pelo cliente serão desenvolvidas com base nos critérios preestabelecidos e protótipos criados.
    - Entradas: Protótipos de alta fidelidade e user stories validadas pelo cliente.
    - Saída: Implementação correspondente a cada história de usuário.

#### Test

Etapa final do desenvolvimento, ocorrendo a validação das implementações criadas na etapa anterior e validação final do cliente.

1. **Teste**

    - Tarefa de validação das implementações, verificando atravéz de um checklist se os critérios de aceitação foram atingidos.
    - Entradas: Implementação correspondente a cada história de usuário.
    - Saída: checklist preenchido dos critérios de aceitação de cada user storie.

2. **Decisão: Todos os critérios de aceitação foram atendidos?**

    - Tarefa de verificação do checklist gerado pela tarefa anterior.
    - Caso a resposta seja sim, o desenvolvimento avança para a tarefa de verificação final.
    - Caso a resposta seja não, o desenvolvimento retorna para a tarefa de desenvolvimento na etapa anterior, com o intuito de resolver as falhas de desenvolvimento para que a implementação cumpra todos os critérios.

3. **Verificação final**

    - Nesta tarefa ocorre a validação final pela equipe e pelo cliente para acontecer a entrega do projeto e fim do ciclo de desenvolvimento.

  1. **Decisão: A equipe aprovou?**

    - Caso a resposta seja não, o projeto retorna a tarefa de desenvolvimento para sanar os problemas encontrados pela equipe.

  2. **Decisão: O cliente aprovou?**

    - Caso a resposta seja não, o projeto retorna a tarefa de desenvolvimento para solucionar os problemas encontrados pelo cliente.

    - Tendo aprovação mútua da equipe de desenvolvimento e do cliente o projeto é entregue e finalizado o seu ciclo de desenvolvimento.

## Histórico de Versões

<font size="3"><p style="text-align: left">**Tabela 1** - Histórico de versões.</p></font>

| Versão |       Descrição        |                                             Autor(es)                                             |    Data    |                                           Revisor                                            | Data de revisão |
| :----: | :--------------------: | :-----------------------------------------------------------------------------------------------: | :--------: | :------------------------------------------------------------------------------------------: | :-------------: |
|  1.0   | Modelagem de Processos | [Carlos Henrique](https://github.com/carlinn1), [Ruan Carvalho](https://github.com/Ruan-Carvalho), [Jesse Eveline](https://github.com/xzxjesse) | 15/01/2025 | [Pedro Gustavo](https://github.com/PedroGusta) |   15/01/2025    |
