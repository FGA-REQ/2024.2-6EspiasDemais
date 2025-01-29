# Regras de Negócio

## Banco de Dados

### **Categorias**
1. **Regras de Restrição**  
   - Cada categoria deve possuir um nome único e descritivo.
   - Categorias não podem ser removidas se estiverem associadas a algum artigo, formulário de artigo ou tema.

### **Formulário Tema**
1. **Regras de Restrição**  
   - Os campos nome, email e tema são obrigatórios para cada sugestão.
   - O id_categoria deve referenciar uma categoria existente.

### **Formulário Artigo**
1. **Regras de Restrição**  
   - Os campos nome, email, título e conteúdo são obrigatórios.
   - O id_categoria deve referenciar uma categoria existente.

### **Artigos**
1. **Regras de Restrição**  
   - Cada artigo deve ter um título único e conteúdo associado a um autor identificado pelo id_usuario.
   - Apenas usuários cadastrados podem submeter artigos.

### **Usuários**
1. **Regras de Restrição**  
   - O email dos usuários deve ser único no banco de dados.
2. **Regras de Restrição**  
   - A senha deve ser armazenada de forma segura, utilizando técnicas de hash e sal.

## API

### **Categorias**
1. **Regras de Cálculo**  
   - **Listar Categorias**: Todas as categorias cadastradas devem ser retornadas, ordenadas por nome em ordem alfabética.

### **Feed (Artigos)**
1. **Regras de Restrição**  
   - **Adicionar Artigo**: O título e o conteúdo do artigo são obrigatórios e devem conter no mínimo 10 caracteres.

### **Formulários (Sugestões)**
1. **Regras de Restrição**  
   - **Adicionar Tema**: O nome, e-mail e descrição do tema são obrigatórios.

### **Login e Cadastro**
1. **Regras de Causa e Efeito**  
   - **Realizar Login**: O sistema deve validar e-mails e senhas em conformidade com a autenticação segura.

## WebForms

### **Páginas Públicas**
1. **Regras de Diretriz**  
   - **About.aspx**: Exibe informações institucionais do blog.
   - **Default.aspx**: Apresenta um feed de artigos publicados, organizados por ordem cronológica.

### **Páginas Logadas**
1. **Regras de Diretriz**  
   - **Profile.aspx**: Exibe as informações do usuário logado e suas publicações pessoais.
   - **MeusArtigos.aspx**: Usuários podem criar novos artigos, editar ou excluir artigos existentes.

### **Validações Gerais**
1. **Regras de Restrição**  
   - Todos os formulários devem apresentar validações client-side e server-side para garantir consistência e segurança.

### **Interação com a API**
1. **Regras de Restrição**  
   - Toda manipulação de dados deve ser feita por meio de chamadas à API Conecta Ciência.

## Histórico de Versões

<font size="3"><p style="text-align: left">**Tabela 1** - Histórico de versões.</p></font>

| Versão |     Descrição     |                     Autor                      |    Data    |                       Revisor                        | Data de revisão |
| :----: | :---------------: | :--------------------------------------------: | :--------: | :--------------------------------------------------: | :-------------: |
|  1.0   | Regras de Negócio | [Carlos Henrique](https://github.com/carlinn1) | 12/01/2025 | [Gabriel Henrique](https://github.com/gabrielhrlima) |   15/01/2025    |
|  2.0   | Separação entre Requisitos funcionais e não funcionais | [Pedro Gustavo](https://github.com/PedroGusta) | 24/01/2025 |  |    |
