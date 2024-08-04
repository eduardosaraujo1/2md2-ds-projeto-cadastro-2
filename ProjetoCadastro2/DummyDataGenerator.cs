using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro2
{
    public class DummyDataGenerator
    {
        public static bool ENABLED = true;
        public static int DUMMY_DATA_COUNT = 100;
        private static Random random = new Random();

        bdMainDataSet dataset;
        bdMainDataSetTableAdapters.usuarioTableAdapter adapter;
        BindingSource bindingSource;
        public DummyDataGenerator()
        {
            dataset = new bdMainDataSet();
            adapter = new bdMainDataSetTableAdapters.usuarioTableAdapter();
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataset.usuario;
            adapter.Fill(dataset.usuario);
        }

        public void GenerateUsuarios()
        {
            for (int i = 0; i < DUMMY_DATA_COUNT; i++)
            {
                bindingSource.AddNew();
                DataRowView rowView = bindingSource.Current as DataRowView;
                rowView["sg_nivel"] = RandomString(1);
                rowView["nm_usuario"] = RandomString(10, 30);
                rowView["nm_login"] = RandomString(5, 15);
                rowView["cd_senha"] = RandomString(8, 24);
                bindingSource.EndEdit();
                adapter.Update(dataset.usuario);
            }
        }

        public void GenerateAll()
        {
            GenerateUsuarios();
        }

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private string RandomString(int length)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string RandomString(int minLength, int maxLength)
        {
            minLength = Math.Max(minLength, 1);
            maxLength = Math.Max(maxLength, 1);
            int length = random.Next(minLength, maxLength);
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
