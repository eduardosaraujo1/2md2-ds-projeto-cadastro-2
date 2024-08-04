using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro2
{
    public class RelatorioPagina
    {
        private int pageNumber;
        private string pageTitle;
        public string PageString { get; private set; } = "";
        public RelatorioPagina(int pageNumber, string pageTitle)
        {
            this.pageNumber = pageNumber;
            this.pageTitle = pageTitle;
        }

    }
    public class RelatorioBuilder
    {
        private List<TableColumn> columns;
        private string relatorioTitle;

        //private bdMainDataSet dataset;
        //private bdMainDataSetTableAdapters.usuarioTableAdapter adapter;
        //private BindingSource bindingSource;
        private DataTable dataTable;
        struct TableColumn
        {
            // propreties
            public string id;
            public string name;
            public int width;
        }
        
        public RelatorioBuilder(string relatorioTitle, bdMainDataSet dataset)
        {
            columns = new List<TableColumn>();
            this.relatorioTitle = relatorioTitle;

            // read database
            bdMainDataSetTableAdapters.usuarioTableAdapter adapter = new bdMainDataSetTableAdapters.usuarioTableAdapter();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataset.usuario; // usuario is the table
            adapter.Fill(dataset.usuario);

            dataTable = bindingSource.DataSource as DataTable;
        }

        public void AddColumn(string columnId, string columnName, int columnWidth)
        {
            TableColumn column = new TableColumn()
            {
                id = columnId,
                name = columnName,
                width = Math.Min(columnWidth, RelatorioPrefs.PAGE_LINE_LENGTH) // anti stupid check
            };
            columns.Add(column);
        }

        /// <summary>
        /// Stringifies a table row by concatenating them side by side
        /// </summary>
        /// <param name="getRowContent">Expression modifies what will be concatenated in the string, could be column name or column data</param>
        /// <returns></returns>
        private string ConcatTableColumns(Func<TableColumn, string> getRowContent)
        {
            string row = string.Empty;
            string data;
            int currentCharPos = 0;
            foreach (TableColumn column in columns)
            {
                bool columnOverflows = currentCharPos + column.width > RelatorioPrefs.PAGE_LINE_LENGTH;
                if (columnOverflows)
                {
                    // break the column into a new line
                    row += '\n';
                    currentCharPos = 0;
                }
                // draw the column and update new line length
                data = getRowContent(column);
                data = string.Concat(data.Take(column.width - 1)); // Cuts the string so it is one shorter than the column width, now it does not overflow
                row += data.PadRight(column.width);
                currentCharPos += column.width;
            }
            return row;
        }
        private string WriteTableHeader()
        {
            return ConcatTableColumns(column => column.name); // expression gets column name and concatenates it with line wrapping
        }

        private string WritePageHeader(int pageNumber)
        {
            string header = "ETEC ADOLPHO BEREZIN\n";
            header += relatorioTitle;
            header += $"Pág: {pageNumber.ToString("D2")}".PadLeft(RelatorioPrefs.PAGE_LINE_LENGTH - relatorioTitle.Length) + '\n'; // PadLeft para alinhar pág a direita
            header += new string('-', RelatorioPrefs.PAGE_LINE_LENGTH) + '\n';
            header += WriteTableHeader() + '\n';
            header += new string('-', RelatorioPrefs.PAGE_LINE_LENGTH) + '\n';
            return header;
        }

        private string WritePageRow(int rowIndex)
        {
            DataRow pageRow = dataTable.Rows[rowIndex];
            return ConcatTableColumns(column => pageRow[column.id].ToString()) + '\n'; // expression gets content in the table cell and concatenates it with line wrapping
        }

        int currentIndex = 0;
        private string WritePage(int pageNumber)
        {
            string page = WritePageHeader(pageNumber);
            string newRow;
            int currentLine = GetStringLineCount(page) + 1;
            while (!ReachedEndOfPage())
            {
                newRow = WritePageRow(currentIndex++);
                
                page += newRow;
                currentLine += GetStringLineCount(newRow);
            }
            
            return page;
            bool ReachedEndOfPage() => currentLine > RelatorioPrefs.PAGE_LINE_COUNT || currentIndex >= dataTable.Rows.Count;
        }

        /// <summary>
        /// Uses the data given to the object to generate a list of strings that can be drawn to a page using Graphics.DrawString
        /// </summary>
        /// <returns>A list of relatorio pages</returns>
        public List<string> Write()
        {
            List<string> pages = new List<string>();
            string page;
            int pageNumber = 1;
            // while not written all the rows in the dataTable...
            do
            {
                page = WritePage(pageNumber++);
                pages.Add(page);
            } while (currentIndex < dataTable.Rows.Count);

            return pages;
        }

        static int GetStringLineCount(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == '\n') count++; 
            }
            return count; 
        }
    }
}
