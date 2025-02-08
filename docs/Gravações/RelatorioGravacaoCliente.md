# Registro da Gravação de Validação com Cliente

### Informações Gerais

- **Data:** 07/02/2025
- **Hora:** Início-21:00, término-21:20
- **Membros da Equipe Presentes:**
  - Carlos, responsável por explicar o diagrama de fluxos de navegação do usuário não logado;
  - Gabriel, responsável pela ata da reunião;
  - Jéssica, responsável por verificar os pontos positivos e negativos da entrega;
  - João Vitor, responsável por verificar a navegabilidade da entrega;
  - Pedro, responsável pela introdução da reunião;
  - Ruan, responsável por explicar o diagrama de fluxos de navegação do usuário logado.
- **Dados do Cliente:**
  - Nome: Letícia Gabriela Saraiva Araújo
  - Organização: Universidade de Brasília-UnB
  - Papel/Setor: Estudante do 4° semestre

### Preparação Prévia

- **Sistema Funcional:**

  - Verificação completa realizada: Sim
  - **Fluxos testados:**
  - **Fluxo:** Sugestão de Tema e Artigo

    - **Objetivo**
      - Verificar se o usuário consegue realizar sugestões de novos temas ou novos artigos.
    - **Condições Iniciais**
      - O usuário deve acessar a página _Sua voz na Ciência_.
      - O sistema deve estar online.
    - **Passos**
      1.  O usuário acessa a página _Sua voz na Ciência_.
      2.  O usuário deve preencher os campos obrigatórios dos formulários "Sugerir Tema" ou "Sugerir Artigo".
      3.  O usuário clica no botão "Enviar".
      4.  O sistema valida os dados e exibe uma mensagem de sucesso.
    - **Resultado Esperado**
      - A sugestão do usuário deve ser enviada para um email onde será avaliada.

  - **Fluxo:** Cadastro

    - **Objetivo**
      - Verificar se o usuário consegue realizar o cadastro no sistema.
    - **Condições Iniciais**
      - O usuário deve acessar a página _Cadastro_.
      - O sistema deve estar online.
    - **Passos**
      1.  O usuário acessa a página _Acesso_ e clicar no link "Cadastre-se aqui".
      2.  O usuário deve e preenche os campos obrigatórios .
      3.  O usuário clica no botão "Cadastrar".
      4.  O sistema valida os dados e exibe uma mensagem de sucesso.
    - **Resultado Esperado**

      - O usuário é cadastrado com sucesso e é redirecionado para a página _Perfil_.

  - **Fluxo:** Publicação de Artigos

    - **Objetivo**
      - Verificar se o usuário consegue publicar artigos.
    - **Condições Iniciais**
      - O usuário deve acessar a página _Meus Artigos_.
      - O usuário deve estar logado.
    - **Passos**
      1.  A partir da página _Perfil_ o usuário deve acessar a página _Meus Artigos_ e clicar no botão "Publicar".
      2.  O usuário deve e preenche os campos obrigatórios .
      3.  O usuário clica no botão "Publicar".
      4.  O sistema valida os dados e exibe uma mensagem de sucesso.
    - **Resultado Esperado**
      - O artigo é publicado na página _Meus artigos_, com as opções de editar e excluir artigo.
      - O artigo é publicado no Feed, sem as opções de editar e excluir artigo."

  - **Fluxo:** Editar ou Excluir Artigo
    - **Objetivo**
      - Verificar se o usuário consegue realizar modificações ou excluir um artigo.
    - **Condições Iniciais**
      - O usuário deve acessar a página _Meus Artigos_.
      - O usuário deve estar logado.
    - **Passos**
      1.  O usuário deve clicar nos botões "Editar" ou "Excluir" presentes em todos os artigos publicados pelo usuário.
      2.  O usuário deve clicar no botão com a operação que deseja realizar.
          - Se o usuário desejar realizar uma modificação, ele deve clicar no botão "Editar", realizar as modificações e clicar em "Salvar".
          - Se o usuário desejar realizar a remoção, ele deve clicar no botão "Excluir" e confirmar a remoção clicando em "Excluir".
      3.  O sistema valida os resultados e exibe uma mensagem de confirmação.
    - **Resultado Esperado**
      - O artigo é modificado, e as modificação são realizadas tanto na página _Meus Artigos_ quanto do Feed.
      - O artigo é removido tanto da página _Meus Artigos_ quanto do Feed.

- **Organização do Ambiente:**
  - Dispositivos configurados: Sim/Não
  - Credenciais e dados de teste disponíveis: Sim/Não
- **Revisão de Feedbacks Anteriores:**
  - Feedbacks identificados: [Resumir principais pontos]

### Introdução

- **Apresentação da Equipe:**
  - Cada membro se apresentou? Sim
- **Propósito da Reunião Explicado:** Sim
- **Propósitos do Sistema Reforçados:** Sim
- **Retrospectiva Apresentada:** Sim
- **Importância do Feedback Destacada:** Sim

### Demonstração do Sistema

- **Fluxos Apresentados:**
  - Fluxo de Cadastro;
  - Fluxo de Sugestão de Tema e Artigo;
  - Fluxo de Publicação;
  - Fluxo de Editar e Excluir Artigo.
- **Interação do Cliente:**
  - O cliente interagiu com o sistema? Sim
  - Dificuldades identificadas:
    - A cliente demostrou uma pequena confusão ao sugerir um tema, ela não entendeu bem se deveria para colocar o próprio nome ou o nome da sugestão.
- **Cenários Práticos Apresentados:**
  - A cliente navegou por todas as páginas criadas e realizou todos as ações implementadas, confirmando se cada parte aconteceu como esperado.

### Coleta de Feedback

#### Navegabilidade

1. **Você conseguiu encontrar facilmente as funcionalidades que procurava?**
   - Resposta: "Sim, elas estão bem claras e onde eu esperaria que elas estivessem."
2. **O sistema é intuitivo ao navegar pelas telas e menus?**
   - Resposta: "Sim, elas estão exatamente onde eu espero e os nomes também estão bem explicativos."
3. **Há algum fluxo que pareceu longo ou complicado?**
   - Resposta: "Não, tudo está bem objetivo."
4. **As mensagens ou botões fornecem informações suficientes?**
   - Resposta: "Sim, como, por exemplo, quando vou enviar um artigo e ele está sendo enviado."
5. **O sistema funcionou como esperado em tarefas comuns?**
   - Resposta: "Sim, tudo funcionou como eu esperava que funcionaria."

#### Pontos Positivos e Negativos

1. **Aspectos positivos destacados:**
   - A cliente destacou que gostou bastante da página _Sua Voz na Ciência_, especialmente da opção de sugerir um tema sem necessariamente precisar escrever um artigo sobre o assunto.
2. **Obstáculos ou frustrações:**
   - A cliente destacou que teve uma pequena confusão ao sugerir um tema, pois não entendeu bem se deveria colocar seu próprio nome ou o nome da sugestão. Além disso, mencionou que, ao utilizar os filtros, o sistema considera os acentos nas palavras, o que difere de outros sistemas onde geralmente não é necessário acentuar ao realizar uma busca.
3. **Erros ou comportamentos inesperados:**
   - Não foi relatado nenhum comportamento inesperado.
4. **Funcionalidades mais valiosas:**
   - A cliente relatou que a funcionalidade de publicar artigos foi a mais valiosa. Quando realizou a matéria em que havia essa necessidade, não existia um meio eficiente para a publicação individual de artigos.
5. **Mudanças prioritárias sugeridas:**
   - Não foi relatada nenhuma mudança a ser feita.

### Link de Gravação

- **URL da gravação:**

<iframe width="560" height="315" src="https://www.youtube.com/embed/wXhjrGj6bVA?si=ECmZG9NszeHi3FIT" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

## Histórico de Versões

<font size="3"><p style="text-align: left">**Tabela 5** - Histórico de versões.</p></font>

| Versão |             Descrição              |                        Autor                         |    Data    | Revisor | Data de revisão |
| :----: | :--------------------------------: | :--------------------------------------------------: | :--------: | :-----: | :-------------: |
|  1.0   | Relatório da reunião com o cliente | [Gabriel Henrique](https://github.com/gabrielhrlima) | 08/02/2025 |         |                 |
