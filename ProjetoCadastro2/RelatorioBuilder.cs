using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro2
{
    public struct RelatorioTableColumn
    {
        // propreties
        public string id;
        public string name;
        public int width;
    }

    public class RelatorioTableColumnList
    {
        public List<RelatorioTableColumn> ColumnList { get; private set; } = new List<RelatorioTableColumn>();

        public void Add(string columnId, string columnName, int columnWidth)
        {
            RelatorioTableColumn column = new RelatorioTableColumn()
            {
                id = columnId,
                name = columnName,
                width = Math.Min(columnWidth, RelatorioPrefs.PAGE_LINE_LENGTH)
            };
            ColumnList.Add(column);
        }
    }
    public class RelatorioBuilder
    {
        public RelatorioTableColumnList ColumnList { get; } = new RelatorioTableColumnList();
        //private readonly List<TableColumn> columns;
        //private readonly BindingSource bindingSource;
        private readonly DataTable dataTable;
        private int currentRowIndex = 0;
        
        public RelatorioBuilder(BindingSource source)
        {
            // database read
            bdMainDataSet dataset = source.DataSource as bdMainDataSet;
            dataTable = dataset.Tables[source.DataMember];
        }


        /// <summary>
        /// Cria uma linha para uma tabela colocando todas as propriedades especificadas nas colunas corretas
        /// </summary>
        /// <param name="rowData">Lista dos valores a colocar em cada coluna. Tamanho desse array deve ser o mesmo que o da lista de colunas (columns)</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>String formatada para ser colocada em uma tabela</returns>
        private string BuildTableRow(string[] rowData)
        {
            if (rowData.Length != ColumnList.ColumnList.Count)
            {
                throw new ArgumentException("Tamanho do array 'rowData' não é igual a quantidade de colunas");
            }

            string row = "";
            string line = "";
            for (int i = 0; i < ColumnList.ColumnList.Count; i++)
            {
                RelatorioTableColumn column = ColumnList.ColumnList[i];

                bool lineWillOverflow = line.Length + column.width > RelatorioPrefs.PAGE_LINE_LENGTH;
                if (lineWillOverflow)
                {
                    row += line + '\n';
                    line = "";
                }

                string col = Truncate(rowData[i], column.width).PadRight(column.width + 1); // +1 para adicionar espaço entre colunas
                line += col;
            }
            row += line;

            return row;
            // 'Truncate' do inglês, em português fica "Truncar" que significa "Cortar". Função pega a string e coloca ela em tamanho definido
            string Truncate(string str, int size) => string.Concat(str.Take(size));
        }

        private string WritePageHeader(string pageTitle, int pageNumber)
        {
            string WriteTableHeader()
            {
                List<string> rowData = new List<string>();

                foreach (RelatorioTableColumn c in ColumnList.ColumnList)
                {
                    rowData.Add(c.name);
                }
                return BuildTableRow(rowData.ToArray());
            }

            string header = "ETEC ADOLPHO BEREZIN\n";
            header += pageTitle;
            header += $"Pág: {pageNumber:D2}".PadLeft(RelatorioPrefs.PAGE_LINE_LENGTH - pageTitle.Length) + '\n'; // PadLeft para alinhar pág a direita
            header += new string('-', RelatorioPrefs.PAGE_LINE_LENGTH) + '\n';
            header += WriteTableHeader() + '\n';
            header += new string('-', RelatorioPrefs.PAGE_LINE_LENGTH) + '\n';
            return header;
        }

        private string WriteRow(int rowIndex)
        {
            DataRow pageRow = dataTable.Rows[rowIndex];
            List<string> rowData = new List<string>();

            foreach (RelatorioTableColumn c in ColumnList.ColumnList)
            {
                rowData.Add(pageRow[c.id].ToString());
            }

            return BuildTableRow(rowData.ToArray()) + '\n';
        }

        private string WritePage(string pageTitle, int pageNumber)
        {
            int GetStringLineCount(string text)
            {
                return text.Split('\n').Length;
            }
            bool ReachedEnd(string paramPage)
            {
                bool paginaCheia = GetStringLineCount(paramPage) > RelatorioPrefs.PAGE_LINE_COUNT;
                bool acabouAsLinhas = currentRowIndex >= dataTable.Rows.Count;
                return paginaCheia || acabouAsLinhas;
            }

            string page = WritePageHeader(pageTitle, pageNumber);
            while (!ReachedEnd(page))
            {
                page += WriteRow(currentRowIndex++);
            }
            
            return page;
        }

        /// <summary>
        /// Uses the data given to the object to generate a list of strings that can be drawn to a page using Graphics.DrawString
        /// </summary>
        /// <returns>Array of relatorio pages, each page a string</returns>
        public string[] Write(string title)
        {
            List<string> pages = new List<string>();
            string page;
            int pageNumber = 1;
            // while not written out all the rows in the dataTable
            while (currentRowIndex < dataTable.Rows.Count)
            {
                page = WritePage(title, pageNumber++);
                pages.Add(page);
            }
            currentRowIndex = 0; // reset para Write poder ser executado novamente caso necessário

            return pages.ToArray();
        }
    }
}
