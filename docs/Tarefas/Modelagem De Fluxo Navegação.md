# Modelagem de processos

## Introdução

Este documento descreve o processo de desenvolvimento para uma plataforma digital que permite aos usuários interagirem com artigos, sugestões e seu perfil pessoal. A plataforma é projetada para atender dois tipos principais de usuários: aqueles que possuem login e aqueles que utilizam as funcionalidades básicas sem autenticação. O objetivo é garantir uma experiência amigável e eficiente para todos os tipos de interações, promovendo engajamento e produtividade.

## Metodologia

O processo de desenvolvimento foi baseado em práticas de modelagem visual utilizando diagramas para descrever fluxos de interação dos usuários com o sistema. A seguir estão os passos principais:

1. **Identificação dos Atores**
   - Os atores foram definidos com base nas permissões e ações que podem realizar:
     - **Usuário com login**: Possui acesso ao perfil, pode criar, editar ou excluir artigos.
     - **Usuário sem login**: Pode visualizar artigos e enviar sugestões.

2. **Criação do Diagrama de Atividades**
   - O diagrama foi desenvolvido para mapear as ações e decisões tomadas pelos usuários.
   - Ele está dividido em dois **swimlanes** (pistas de atuação):
     - **Usuário com login**.
     - **Usuário sem login**.

3. **Fluxos Condicionais**
   - Foram definidos pontos de decisão, como "Fazer login?" e "Editar/Excluir artigo?", que direcionam os usuários para caminhos específicos no sistema.

4. **Ações Principais**
   - O sistema suporta diversas ações principais, como:
     - Criar conta.
     - Acessar perfil.
     - Criar, salvar, editar e excluir artigos.
     - Enviar sugestões de pautas ou artigos.

5. **Iteração e Validação**
   - O modelo foi iterado com base no feedback de stakeholders para garantir que todas as possíveis interações foram contempladas.

Com essa metodologia, o desenvolvimento buscou alcançar uma visão clara e detalhada de como os usuários interagem com a plataforma, servindo de base para implementações futuras.

## Processo de diagramação

![Diagrama](Diagramas\DiagramaFluxoDeNavegação.png)

Todo o processo foi modelado atravéz da ferramenta Lucidchart e pode ser acessado clicando [aqui](https://lucid.app/lucidchart/89a9390b-a754-4444-9718-e9f49cc81b75/edit?viewport_loc=-1121%2C-433%2C2994%2C1391%2C0_0&invitationId=inv_f28ae937-745d-424e-868d-34a2f097a5be)

# Fluxo de desenvolvimento do projeto

## Discovery  
O processo inicia com a etapa de **Discovery**, que envolve:  
- Identificar as necessidades e dores do cliente.  
- Mapear os objetivos gerais do sistema.  
- Realizar entrevistas, pesquisas e reuniões com stakeholders para coletar informações relevantes.

---

## Entendimento  
Após a Discovery, a equipe se concentra em compreender as informações coletadas:  
- Análise dos dados e feedback do cliente.  
- Discussão de ideias e soluções viáveis.  
- Definição dos problemas a serem resolvidos e das prioridades iniciais.

---

## Backlog  
Na etapa de backlog, as informações coletadas são transformadas em tarefas organizadas:  
- Criação de **user stories** para descrever os requisitos do usuário.  
- Organização das histórias em backlog, priorizando as mais importantes.  
- Divisão das histórias em entregas incrementais e iterativas.

---

## Decisão: Requisitos Estruturados  
Aqui, o foco é garantir que os requisitos sejam claros e acionáveis:  
- Documentar os requisitos funcionais e não funcionais.  
- Validar se os requisitos estruturados atendem às expectativas do cliente.  
- Obter aprovação dos stakeholders antes de avançar.

---

## Design  
A equipe inicia a criação de soluções visuais e funcionais:  
- Desenvolver wireframes e protótipos de alta fidelidade.  
- Criar fluxos de navegação e interações com base no diagrama.  
- Garantir que o design seja responsivo e acessível.

---

## Decisão: Satisfaz a Necessidade do Cliente?  
Após o design, é necessário decidir se ele atende às expectativas:  
- Revisar o design com o cliente e a equipe.  
- Coletar feedback e ajustar conforme necessário.  
- Obter aprovação antes de iniciar o desenvolvimento.

---

## Develop  
Com o design aprovado, a etapa de desenvolvimento começa:  
- Codificar as funcionalidades descritas no backlog.  
- Seguir boas práticas, como integração contínua e versionamento.  
- Garantir que o código seja modular, escalável e fácil de manter.

---

## Desenvolvimento  
A equipe implementa as soluções aprovadas:  
- Construir a arquitetura do sistema.  
- Desenvolver a interface do usuário, backend e integrações.  
- Realizar testes iniciais para detectar problemas rapidamente.

---

## Test  
Após o desenvolvimento, é realizada a validação:  
- Realizar testes de unidade, integração, aceitação e desempenho.  
- Verificar se os critérios de aceitação estão sendo cumpridos.  
- Documentar e corrigir bugs encontrados.

---

## Decisão: Todos os Critérios de Aceitação Foram Atendidos?  
A equipe revisa os resultados dos testes para determinar:  
- Se todas as funcionalidades estão funcionando conforme o esperado.  
- Se há pendências ou ajustes necessários antes da entrega.  
- Obter aprovação interna para prosseguir.

---

## Verificação Final  
Após todos os critérios serem atendidos, realiza-se a verificação final:  
- Revisão completa do sistema pela equipe técnica.  
- Verificar alinhamento com os objetivos e requisitos iniciais.  
- Preparar o sistema para apresentação ao cliente.

---

## Decisão: A Equipe Aprovou?  
Antes da entrega ao cliente, a equipe avalia:  
- Se o sistema está pronto para uso.  
- Se os objetivos internos foram alcançados.  
- Caso aprovado, preparar para apresentação ao cliente.

---

## Decisão: O Cliente Aprovou?  
Na etapa final, o cliente revisa e avalia o sistema:  
- Apresentar o produto ao cliente.  
- Coletar feedback final e realizar ajustes, se necessário.  
- Confirmar a aprovação e finalizar a entrega.  

- Tendo aprovação multua da equipe de desenvolvimento e do cliente o projeto é entregue e finalizado o seu ciclo de desenvolvimento.