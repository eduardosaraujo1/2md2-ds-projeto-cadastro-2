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
    public class RelatorioBuilder
    {
        private readonly List<TableColumn> columns;
        //private readonly BindingSource bindingSource;

        private readonly DataTable dataTable;
        struct TableColumn
        {
            // propreties
            public string id;
            public string name;
            public int width;
        }
        
        public RelatorioBuilder(BindingSource source)
        {
            columns = new List<TableColumn>();

            // database
            bdMainDataSet dataset = source.DataSource as bdMainDataSet;
            dataTable = dataset.Tables[source.DataMember];
        }

        public void AddColumn(string columnId, string columnName, int columnWidth)
        {
            TableColumn column = new TableColumn()
            {
                id = columnId,
                name = columnName,
                width = Math.Min(columnWidth, RelatorioPrefs.PAGE_LINE_LENGTH)
            };
            columns.Add(column);
        }

        /// <summary>
        /// Stringifies a table row by concatenating them side by side
        /// </summary>
        /// <param name="GetColumnContent">Expression modifies what will be concatenated in the string, could be column name or column data</param>
        /// <returns></returns>
        private string ConcatTableColumns(Func<TableColumn, string> GetColumnContent)
        {
            string row = string.Empty;
            string col;
            int currentLineLength = 0;
            foreach (TableColumn column in columns)
            {
                bool columnWillOverflow = currentLineLength + column.width > RelatorioPrefs.PAGE_LINE_LENGTH;
                if (columnWillOverflow)
                {
                    // break the column into a new line
                    row += '\n';
                    currentLineLength = 0;
                }

                // draw the column and update new line length
                col = GetColumnContent(column);
                col = Truncate(col, column.width - 1).PadRight(column.width); // -1 adds the column separator
                row += col;
                currentLineLength += col.Length; // track how long the current line is
            }
            return row;
            string Truncate(string str, int size) => string.Concat(str.Take(size));
        }
        private string WriteTableHeader()
        {
            return ConcatTableColumns(column => column.name); // expression gets column name and concatenates it with line wrapping
        }

        private string WritePageHeader(string pageTitle, int pageNumber)
        {
            string header = "ETEC ADOLPHO BEREZIN\n";
            header += pageTitle;
            header += $"Pág: {pageNumber:D2}".PadLeft(RelatorioPrefs.PAGE_LINE_LENGTH - pageTitle.Length) + '\n'; // PadLeft para alinhar pág a direita
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
        private string WritePage(string pageTitle, int pageNumber)
        {
            string page = WritePageHeader(pageTitle, pageNumber);
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
        /// <returns>Array of relatorio pages, each page a string</returns>
        public string[] Write(string title)
        {
            List<string> pages = new List<string>();
            string page;
            int pageNumber = 1;
            // do while not written all the rows in the dataTable
            while (currentIndex < dataTable.Rows.Count)
            {
                page = WritePage(title, pageNumber++);
                pages.Add(page);
            }

            return pages.ToArray();
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
