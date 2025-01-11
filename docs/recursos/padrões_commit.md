# Padronização dos Commits e Branches

## Introdução

Este documento define as diretrizes para padronização dos commits e organização das branches no repositório do projeto. O objetivo é facilitar a colaboração entre os membros do time, garantir rastreabilidade e manter a consistência no fluxo de trabalho.

## Commits

Conforme as diretrizes do [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/), utilizaremos commits semânticos para garantir a compreensão clara das mudanças no histórico do projeto. Essa convenção facilita a rastreabilidade e a padronização.

### Tipo e Descrição

Os tipos de commit utilizados no projeto são:

- **feat:** Adição de um novo recurso (MINOR).
- **fix:** Correção de um bug (PATCH).
- **docs:** Alterações na documentação.
- **test:** Modificações em testes.
- **build:** Alterações em arquivos de build e dependências.
- **perf:** Ajustes de performance.
- **style:** Alterações de formatação, sem impacto no código.
- **refactor:** Refatorações que não mudam a funcionalidade.
- **chore:** Tarefas de configuração e manutenção.
- **ci:** Mudanças relacionadas à integração contínua.
- **raw:** Arquivos de configuração e parâmetros.
- **cleanup:** Remoção de código desnecessário e ajustes de legibilidade.
- **remove:** Exclusão de arquivos ou funcionalidades obsoletas.

### Recomendação de commit:

- Comece o commit colocando o seu tipo, seguido de ":" e uma breve descrição do que foi feito.
- Escreva na terceira pessoa.
- Inicie a descrição com letra maiúscula e finalize com um ponto final.
- (Opcional) Detalhe mais a fundo o que foi feito na descrição do commit.

**Exemplo:** `git commit -m "docs: Revisão da metodologia."`

## Branches

### Branches principais

- **main**: Contém o código estável. Somente alterações revisadas e aprovadas que passaram pela develop devem ser mescladas nesta branch. _**Nenhuma alteração deve ser feita diretamente aqui.**_

- **gh-pages**: Utilizada para hospedar a versão estática do site do projeto. Atualizada automaticamente com base nas mudanças na branch **docs**.

- **docs**: Dedicada à documentação do projeto. Após revisão, todas as atualizações devem ser mescladas nesta branch.

- **develop**: Contém o código em desenvolvimento. Todas as branches relacionadas ao desenvolvimento de funcionalidades ou correções de código devem partir desta branch.

### Branches Secundárias

As branches secundárias são criadas temporariamente para atender demandas específicas, como o desenvolvimento de funcionalidades, correção de bugs ou atualização de documentação. Elas devem ser removidas após a conclusão da tarefa e o merge, garantindo a organização do repositório.

#### 1. Desenvolvimento de Código

- **Origem**: Branches de código devem ser criadas a partir da branch **develop**.
- **Nome**: Devem começar com o prefixo `dev:` seguido de uma descrição clara e objetiva da tarefa.  
  **Exemplos**:  
  - `dev:feature-pomodoro`  
  - `dev:fix-login-bug`

#### 2. Atualização de Documentação
- **Origem**: Branches relacionadas à documentação devem ser criadas a partir da branch **docs**.
- **Nome**: Devem começar com o prefixo `doc:` seguido de uma descrição clara da tarefa.  
  **Exemplos**:  
  - `doc:update-readme`  
  - `doc:guide-setup`

### Decisão de Padronização

Durante a reunião da equipe, ficou definido que branches de código devem ser criadas a partir da branch **develop** com o prefixo `dev:`, e branches de documentação devem se basear na branch **docs** com o prefixo `doc:`. Essa padronização ajuda a identificar o propósito de cada branch, mantém o fluxo de trabalho organizado e reduz erros na integração.

## Bibliografia

> https://www.conventionalcommits.org/en/v1.0.0/#specification. Acesso em: 07/01/2025.

## Histórico de Versão

<font size="3"><p style="text-align: left">**Tabela 1** - Histórico de versões.</p></font>

| Versão | Descrição | Autor(es) | Data | Revisor(es) | Data de Revisão |
| :---: | :---: | :---: | :---: | :---: | :---: |
| 1.0 | Criação do documento de padronização de commits e branches | [João Vitor](https://github.com/Jauzimm) | 07/01/2025 |  |  |
| 1.1 | Alteração e adição de informações em branches | [João Vitor](https://github.com/Jauzimm) | 11/01/2025 |  |  |