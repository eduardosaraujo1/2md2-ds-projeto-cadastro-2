# Informações

Aluno: Eduardo Soares e Araújo
Curso: 2MD2
Orientadores: Oswaldo Luiz e Joelma Lucia Sartori

# Sobre o projeto

O projeto é uma continuação do sistema de cadastros, na qual utilizamos conexão ao banco de dados Microsoft SQL Server, em um arquivo local.

O código foi reescrito para gerenciar a desorganização do uso de orientação a objeto do projeto anterior, que utilizava o objeto de classe `LogicaCadastro` para gerenciar as telas. No lugar, a utilização de duas classes deveria ser utilizado: gerenciar todos os dados cadastrados (Storage) e gerenciar o registro atual (posição, alterações e exclusões). Essa preocupação não estará presente no novo sistema, pois essa já utiliza essas classes na forma de DataSet, BindingSource e TableAdapter

# Requisitos do sistema

O sistema deve prover uma maneira facil de gerenciar os dados dos cadastros de **Usuários**, **Clientes** e **Fornecedores**.
