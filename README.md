Teste Prático DeMaria
-----------------------
🔧 Tecnologias utilizadas
- Interface: Biblioteca MaterialSkin.2 para estilização dos Forms, baseada em Material Design.
- Banco de dados: PostgreSQL 18.1 on x86_64-windows, compiled by msvc-19.44.35221, 64-bit.
- Microsoft ReportingServices ReportViewerControl (Controle Visualizador de Relatórios da Microsoft para aplicações .NET Windows Forms.)

🗄️ Banco de Dados
- Todos os scripts de criação de banco, tabelas, views e usuários de acesso estão na pasta Scripts.
- O diagrama do banco de dados está disponível na documentação do proje

📂 Estrutura de Pastas
- Classes → Armazena os objetos principais.
  - Base de Dasos → Lógica de conexão e comunicação com o banco.
  - Utils → Classes auxiliares (validação CPF, preenchimento CEP...).
- Forms → Todos os formulários do projeto.
- Relatórios → Arquivos base para relatórios do Report Reviewer.
- Scripts → Scripts SQL de criação de banco, tabelas, usuários e views.

🖥️ Visão geral das telas

Toda a parte de troca de telas é feita por um controle presente no canto esquerdo da aplicação:
<img width="1596" height="835" alt="image" src="https://github.com/user-attachments/assets/aade8967-4a50-4d74-b19a-5f54d61694b0" />

Tela Home
Funcionalidades:
- Traz dados importantes presentes nas bases(Total de Vendas, Qtd. estoque, Qtd. de clientes ativos, Qtd de items vendidos)
<img width="1602" height="841" alt="image" src="https://github.com/user-attachments/assets/3f40b77b-1041-4d96-ab68-18fd4bac2693" />

Tela de Cadastro de Clientes
Funcionalidades:
- Operações CRUD.
- Busca por CPF.
- Validação automática de CPF.
- Máscaras automáticas para CPF, Celular e CEP.
- Pesquisa de CEP via API para preenchimento rápido de endereço.
- Preview da lista de cadastros com atualização automatica a cada inclusão.

  <img width="1587" height="829" alt="image" src="https://github.com/user-attachments/assets/2a5e5041-4eba-4768-9706-ffb013c14516" />


Tela de Cadastro de Produtos
Funcionalidades:
- Operações CRUD.
- Busca de produto por nome.
- Preview da lista de cadastros com atualização automatica a cada inclusão.

  <img width="1599" height="836" alt="image" src="https://github.com/user-attachments/assets/7c82fbba-881e-445b-9864-86f1cd88b633" />

Tela de Vendas
Funcionalidades:
- Operações CRUD.
- Lançamento de produtos e atualização em tempo real.
- Resumo do pedido (valor total,detalhes e estoque do item selecionado) atualizado dinamicamente.
- Atualização automática do estoque ao finalizar a venda.

  <img width="1602" height="834" alt="image" src="https://github.com/user-attachments/assets/ece5c0d4-6493-4d37-aaa9-cc21fa458702" />

Tela de Relatórios
Funcionalidades:
- Relatórios de estoque.
- Relatórios de clientes cadastrados.
- Relatórios de vendas realizadas por período.

  <img width="1601" height="836" alt="image" src="https://github.com/user-attachments/assets/4e6b1c48-b82c-4912-bb2b-19b0f1b19f16" />

Tela de Configuração do banco de dados
Funcionalidades:
- Salva informações para conexão com Postgre.
- Testa conexão.
  
<img width="1598" height="835" alt="image" src="https://github.com/user-attachments/assets/2196fd0b-588b-45c0-8091-ba47b648d77c" />
