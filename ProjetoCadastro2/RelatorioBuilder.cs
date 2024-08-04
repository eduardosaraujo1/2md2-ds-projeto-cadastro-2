using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        struct TableColumn
        {
            // propreties
            public string id;
            public string name;
            public int width;
        }
        
        public RelatorioBuilder(string relatorioTitle)
        {
            columns = new List<TableColumn>();
            this.relatorioTitle = relatorioTitle;
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

        private string WriteTableHeader()
        {
            string tableHeader = string.Empty;
            int currentCharPos = 0;
            foreach (TableColumn column in columns)
            {
                bool columnOverflows = currentCharPos + column.width > RelatorioPrefs.PAGE_LINE_LENGTH;
                if (columnOverflows)
                {
                    tableHeader += '\n';
                    currentCharPos = 0;
                }
                currentCharPos += column.width;
                tableHeader += column.name.PadRight(column.width);
            }
            return tableHeader;
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

        /// <summary>
        /// Generates a string composing a single page of Relatorio.
        /// </summary>
        /// <param name="pageNumber">Page number to display in page header</param>
        /// <returns></returns>
        private string WritePage(int pageNumber)
        {
            string page = WritePageHeader(pageNumber);
            return page;
        }

        /// <summary>
        /// Uses the data given to the object to generate a list of strings that can be drawn to a page using Graphics.DrawString
        /// </summary>
        /// <returns>A list of relatorio pages</returns>
        public List<string> Write()
        {
            List<string> pages = new List<string>();
            pages.Add(WritePage(0));
            return pages;
        }
    }
}
