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
        bdMainDataSet dataset;
        bdMainDataSetTableAdapters.usuarioTableAdapter adapter;
        BindingSource bindingSource;
        private static Random random = new Random();
        private int count;
        public DummyDataGenerator(int count)
        {
            dataset = new bdMainDataSet();
            adapter = new bdMainDataSetTableAdapters.usuarioTableAdapter();
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataset.usuario;
            adapter.Fill(dataset.usuario);
            this.count = count;
        }

        public void GenerateUsuarios()
        {
            for (int i = 0; i < count; i++)
            {
                bindingSource.AddNew();
                DataRowView rowView = bindingSource.Current as DataRowView;
                rowView["sg_nivel"] = RandomString(1);
                rowView["nm_usuario"] = RandomString(30, 15);
                rowView["nm_login"] = RandomString(15, 20);
                rowView["cd_senha"] = RandomString(12, 4);
                bindingSource.EndEdit();
                adapter.Update(dataset.usuario);
            }
        }

        public void GenerateAll()
        {
            GenerateUsuarios();
        }

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string RandomString(int length, int noise)
        {
            length = random.Next(Math.Max(length - noise, 1), length + noise);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
