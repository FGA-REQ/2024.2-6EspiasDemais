# Registro da Gravação de Validação com Cliente

## Informações Gerais

- **Data:** 07/02/2025
- **Hora:** Início 21:00, término 21:20

### Membros da Equipe

| Membro         | Responsabilidade                                       |
|-----------------|-------------------------------------------------------|
| Pedro           | Realizar a introdução da reunião                      |
| Carlos          | Explicar o diagrama de fluxos de navegação do usuário não logado |
| Ruan            | Explicar o diagrama de fluxos de navegação do usuário logado   |
| João Vitor      | Verificar a navegabilidade da entrega e realizar a gravação da reunião              |
| Jéssica         | Verificar os pontos positivos e negativos da entrega  |
| Gabriel         | Elaborar a ata da reunião                             |

### Dados do Cliente:

| Dado             | Informação                              |
|-------------------|----------------------------------------|
| Nome             | Letícia Gabriela Saraiva Araújo        |
| Organização      | Universidade de Brasília - UnB         |
| Papel/Setor      | Estudante do 4° semestre de Letras Inglês |

## Preparação

### Sistema Funcional

| Verificação Realizada | Status |
|------------------------|--------|
| Verificação Completa   | Sim    |

### Organização do Ambiente

| Item                               | Status |
|------------------------------------|--------|
| Dispositivos configurados          | Sim    |
| Credenciais e dados de teste disponíveis | Sim |

### Introdução

| Item                                | Status |
|-------------------------------------|--------|
| Cada membro se apresentou?          | Sim    |
| Propósito da reunião explicado      | Sim    |
| Propósitos do sistema reforçados    | Sim    |
| Retrospectiva apresentada           | Sim    |
| Importância do feedback destacada   | Sim    |

## Demonstração do Sistema

### Fluxos Testados

#### Fluxo: Feed com Filtros  

| Item                 | Detalhes                                                                                     |
|----------------------|---------------------------------------------------------------------------------------------|
| **Objetivo**         | Verificar se o feed exibe corretamente os artigos publicados e permite o uso de filtros.     |
| **Condições Iniciais** | - O usuário deve acessar a página _Feed_.<br>- O sistema deve estar online e possuir artigos publicados. |
| **Passos**           | **Exibição do Feed:**<br>1. O usuário acessa a página _ConectaCiÊncia_.<br>2. O feed exibe uma listagem de artigos organizados em ordem cronológica (mais recente para o mais antigo), com as informações: Título, Conteúdo, Data de Publicação, Nome do Autor e Categoria.<br><br>**Aplicação de Filtros:**<br>3. O usuário seleciona um ou mais filtros disponíveis:<br>   - **Filtro por Categoria:** O usuário escolhe uma categoria no dropdown. O feed exibe apenas os artigos correspondentes.<br>   - **Filtro por Palavras-chave:** O usuário insere uma palavra-chave na barra de busca. O feed exibe os artigos que contenham a palavra-chave no título ou no conteúdo.<br>   - **Filtro por Data de Publicação:** O usuário seleciona uma data específica ou um intervalo de datas. O feed exibe os artigos publicados nesse período.<br>4. O feed atualiza os resultados de acordo com os filtros selecionados. |
| **Resultado Esperado**| O feed exibe corretamente os artigos de acordo com os filtros aplicados. O usuário consegue visualizar as informações detalhadas de cada artigo listado. |

#### Fluxo: Formulário de Sugestão de Artigo  

| Item                 | Detalhes                                                                                     |
|----------------------|---------------------------------------------------------------------------------------------|
| **Objetivo**         | Verificar se o usuário consegue enviar uma sugestão de artigo.                              |
| **Condições Iniciais** | - O usuário deve acessar a página _Sua Voz na Ciência_.<br>- O sistema deve estar online.  |
| **Passos**           | 1. O usuário acessa a página _Sua Voz na Ciência_.<br>2. O usuário preenche os campos obrigatórios: Nome, E-mail, Categoria, Título do Artigo e Conteúdo do Artigo.<br>3. O usuário clica no botão "Enviar".<br>4. O sistema valida os dados e exibe uma mensagem de sucesso. |
| **Resultado Esperado**| A sugestão do artigo é enviada para o banco de dados configurado no sistema, onde será avaliada.    |

#### Fluxo: Formulário de Sugestão de Tema  

| Item                 | Detalhes                                                                                     |
|----------------------|---------------------------------------------------------------------------------------------|
| **Objetivo**         | Verificar se o usuário consegue enviar uma sugestão de tema.                                |
| **Condições Iniciais** | - O usuário deve acessar a página _Sua Voz na Ciência_.<br>- O sistema deve estar online.  |
| **Passos**           | 1. O usuário acessa a página _Sua Voz na Ciência_.<br>2. O usuário preenche os campos obrigatórios: Nome, E-mail, Categoria e Descrição do Tema.<br>3. O usuário clica no botão "Enviar".<br>4. O sistema valida os dados e exibe uma mensagem de sucesso. |
| **Resultado Esperado**| A sugestão do tema é enviada para o banco de dados configurado no sistema, onde será avaliada.      |

#### Fluxo: Cadastro

| Item                 | Detalhes                                                                                     |
|----------------------|---------------------------------------------------------------------------------------------|
| **Objetivo**         | Verificar se o usuário consegue realizar o cadastro no sistema.                             |
| **Condições Iniciais** | - O usuário deve acessar a página _Cadastro_.<br>- O sistema deve estar online.           |
| **Passos**           | 1. O usuário acessa a página _Acesso_ e clica no link "Cadastre-se aqui".<br>2. O usuário preenche os campos obrigatórios.<br>3. O usuário clica no botão "Cadastrar".<br>4. O sistema valida os dados e exibe uma mensagem de sucesso. |
| **Resultado Esperado**| O usuário é cadastrado com sucesso e é redirecionado para a página _Perfil_.               |

### Fluxo: Acesso  

| Item                 | Detalhes                                                                                     |
|----------------------|---------------------------------------------------------------------------------------------|
| **Objetivo**         | Verificar se o usuário consegue acessar o sistema com credenciais válidas.                  |
| **Condições Iniciais** | - O usuário deve acessar a página _Acesso_.<br>- O sistema deve estar online.<br>- O usuário deve possuir cadastro ativo. |
| **Passos**           | 1. O usuário acessa a página _Acesso_.<br>2. O usuário insere o email e a senha cadastrados.<br>3. O usuário clica no botão "Entrar".<br>4. O sistema valida os dados e redireciona o usuário para a página _Perfil_. |
| **Resultado Esperado**| O usuário acessa o sistema com sucesso e é redirecionado para a página _Perfil_.            |
#### Fluxo: Publicação de Artigos

| Item                 | Detalhes                                                                                     |
|----------------------|---------------------------------------------------------------------------------------------|
| **Objetivo**         | Verificar se o usuário consegue publicar artigos.                                           |
| **Condições Iniciais** | - O usuário deve acessar a página _Meus Artigos_.<br>- O usuário deve estar logado.       |
| **Passos**           | 1. A partir da página _Perfil_, o usuário acessa a página _Meus Artigos_ e clica no botão "Publicar".<br>2. O usuário preenche os campos obrigatórios.<br>3. O usuário clica no botão "Publicar".<br>4. O sistema valida os dados e exibe uma mensagem de sucesso. |
| **Resultado Esperado**| - O artigo é publicado na página _Meus Artigos_, com as opções de editar e excluir artigo.<br>- O artigo é publicado no Feed, sem as opções de editar e excluir artigo. |

#### Fluxo: Editar ou Excluir Artigo

| Item                 | Detalhes                                                                                     |
|----------------------|---------------------------------------------------------------------------------------------|
| **Objetivo**         | Verificar se o usuário consegue realizar modificações ou excluir um artigo.                 |
| **Condições Iniciais** | - O usuário deve acessar a página _Meus Artigos_.<br>- O usuário deve estar logado.       |
| **Passos**           | 1. O usuário clica nos botões "Editar" ou "Excluir" presentes nos artigos publicados.<br>2. O usuário seleciona a operação desejada:<br>&nbsp;&nbsp;- **Editar:** O usuário clica em "Editar", realiza as modificações e clica em "Salvar".<br>&nbsp;&nbsp;- **Excluir:** O usuário clica em "Excluir" e confirma a operação.<br>3. O sistema valida os resultados e exibe uma mensagem de confirmação. |
| **Resultado Esperado**| - O artigo é modificado e as alterações refletem tanto na página _Meus Artigos_ quanto no Feed.<br>- O artigo é removido tanto da página _Meus Artigos_ quanto do Feed. |

### Interação do Cliente

| Item                                  | Detalhes                                                                                          |
|---------------------------------------|--------------------------------------------------------------------------------------------------|
| O cliente interagiu com o sistema?    | Sim                                                                                              |
| **Dificuldades identificadas**        | A cliente demonstrou uma pequena confusão ao sugerir um tema, sem entender se deveria colocar o próprio nome ou o nome da sugestão. |

### Cenários Práticos Apresentados

| Item                                  | Detalhes                                                                                          |
|---------------------------------------|--------------------------------------------------------------------------------------------------|
| A cliente navegou por todas as páginas? | Sim                                                                                              |
| Ações implementadas realizadas        | A cliente realizou todas as ações implementadas, confirmando se cada parte aconteceu como esperado. |

## Coleta de Feedback

### Navegabilidade

| Pergunta                                                      | Resposta                                                                                          |
|---------------------------------------------------------------|---------------------------------------------------------------------------------------------------|
| **1. Você conseguiu encontrar facilmente as funcionalidades que procurava?** | Sim, elas estão bem claras e onde eu esperaria que elas estivessem.                               |
| **2. O sistema é intuitivo ao navegar pelas telas e menus?**   | Sim, elas estão exatamente onde eu espero e os nomes também estão bem explicativos.             |
| **3. Há algum fluxo que pareceu longo ou complicado?**         | Não, tudo está bem objetivo.                                                                     |
| **4. As mensagens ou botões fornecem informações suficientes?**| Sim, como, por exemplo, quando vou enviar um artigo e ele está sendo enviado.                    |
| **5. O sistema funcionou como esperado em tarefas comuns?**   | Sim, tudo funcionou como eu esperava que funcionaria.                                              |

### Pontos Positivos e Negativos

| Item                                                       | Detalhes                                                                                                    |
|------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------|
| **1. Aspectos positivos destacados:**                      | A cliente destacou que gostou bastante da página _Sua Voz na Ciência_, especialmente da opção de sugerir um tema sem necessariamente precisar escrever um artigo sobre o assunto. |
| **2. Obstáculos ou frustrações:**                          | A cliente teve uma pequena confusão ao sugerir um tema, não entendendo se deveria colocar seu próprio nome ou o nome da sugestão. Além disso, mencionou que, ao utilizar os filtros, o sistema considera os acentos nas palavras, o que difere de outros sistemas onde geralmente não é necessário acentuar ao realizar uma busca. |
| **3. Erros ou comportamentos inesperados:**                | Não foi relatado nenhum comportamento inesperado.                                                           |
| **4. Funcionalidades mais valiosas:**                      | A cliente relatou que a funcionalidade de publicar artigos foi a mais valiosa. Quando realizou a matéria em que havia essa necessidade, não existia um meio eficiente para a publicação individual de artigos. |
| **5. Mudanças prioritárias sugeridas:**                    | Não foi relatada nenhuma mudança a ser feita.                                                               |

## Link de Gravação

<iframe width="560" height="315" src="https://www.youtube.com/embed/wXhjrGj6bVA?si=ECmZG9NszeHi3FIT" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

## Histórico de Versões

<font size="3"><p style="text-align: left">**Tabela 5** - Histórico de versões.</p></font>

| Versão |             Descrição              |                        Autor                         |    Data    | Revisor | Data de revisão |
| :----: | :--------------------------------: | :--------------------------------------------------: | :--------: | :-----: | :-------------: |
|  1.0   | Relatório da reunião com o cliente | [Gabriel Henrique](https://github.com/gabrielhrlima) | 08/02/2025 | [Ruan Carvalho](https://github.com/Ruan-Carvalho), [Jéssica Eveline](https://github.com/xzxjesse) | 08/02/2025, 09/02/2025 |
