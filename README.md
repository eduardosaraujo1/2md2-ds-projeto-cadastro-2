# Informações

Aluno: Eduardo Soares e Araújo <br>
Curso: 2MD2<br>
Orientadores: Oswaldo Luiz e Joelma Lucia Sartori<br>

# Mudanças da V2

Versão 2: O código foi reescrito devído a desorganização do uso de orientação a objeto do projeto anterior, que utilizava o objeto de classe `LogicaCadastro` para gerenciar as telas. No lugar, a utilização de duas classes deveria ter sido utilizado: gerenciar todos os dados cadastrados (Storage) e gerenciar o registro atual (posição, alterações e exclusões). Essa preocupação não estará presente no novo sistema, pois essa já utiliza essas classes na forma de DataSets e BindingSources.

# Aspectos do sistema

## Telas de cadastro

O sistema possui telas de cadastro para **Usuários**, **Clientes**, **Fornecedores**, que exibe todos os campos de cada registro além de possuir os seguintes botões:

- Próximo e Anterior: Navega entre os registros sendo visualizados
- Novo: Cria um novo registro e libera os campos de texto para escrita, com exceção do Código que é definido automaticamente
- Alterar: Altera o registro selecionado, liberando os texto para escrita, com exceção do Código que é definido automaticamente
- Excluir: Apaga todos os dados do registro atual e não o permite mais aparecer na navegação. O código do cadastro apagado nunca será utilizado novamente
- Salvar: Apenas liberado quando está alterando ou criando um novo registro, o botão valida todos os dados no campo e se estiverem válidos os escrevem no banco de dados
- Cancelar: Cancela o cadastro ou alteração dos dados, anulando as ações do "Novo" e "Alterar"
- Pesquisar: Abre um popup com uma barra de pesquisa que permite a pesquisa de um registro por nome. Se a pesquisa encontrar um resultado o registro será visualizado
- Imprimir: Gera uma página para impressão com os dados do cliente selecionado
- Sair: Fecha a tela

## Relatórios

Existe a funcionalidade de gerar um relatório para impressão: uma tabela feita com texto de todos os registros feitos, com funcionalidade de multiplas páginas e um header.
- Fonte Courier New, 10pt 
- Folha A4, comportando 68 linhas cada linha com 84 caracteres
- Margens de 50 pixels de distancia da ponta superior esquerda
Estilo do Header:
```
ETEC ADOLPHO BEREZIN
Relatório de <TITULO>                                                        Pág: 00
------------------------------------------------------------------------------------
COLUNA1            COLUNA2              COLUNA3           COLUNA4        
COLUNA5       COLUNA6       ...
------------------------------------------------------------------------------------
```
- O form comporta multiplas colunas mas é possível ter apenas uma também (calculo é feito automaticamente pelo RelatorioBuilder)
- Os dados são colocados um em baixo do outro seguindo o padrão de colunas especificado no header.