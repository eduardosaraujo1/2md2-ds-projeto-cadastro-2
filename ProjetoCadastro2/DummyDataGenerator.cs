using ProjetoCadastro2.bdMainDataSetTableAdapters;
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
        BindingSource usuarioSource;
        BindingSource clienteSource;
        BindingSource fornecedorSource;
        usuarioTableAdapter usuarioTableAdapter;
        clienteTableAdapter clienteTableAdapter;
        fornecedorTableAdapter fornecedorTableAdapter;
        public DummyDataGenerator()
        {
            dataset = new bdMainDataSet();
            usuarioSource = new BindingSource();
            clienteSource = new BindingSource();
            fornecedorSource = new BindingSource();
            usuarioTableAdapter = new usuarioTableAdapter();
            clienteTableAdapter = new clienteTableAdapter();
            fornecedorTableAdapter = new fornecedorTableAdapter();

            usuarioSource.DataSource = dataset.usuario;
            clienteSource.DataSource = dataset.cliente;
            fornecedorSource.DataSource = dataset.fornecedor;

            usuarioTableAdapter.Fill(dataset.usuario);
            clienteTableAdapter.Fill(dataset.cliente);
            fornecedorTableAdapter.Fill(dataset.fornecedor);
        }

        public void GenerateUsuarios()
        {
            for (int i = 0; i < DUMMY_DATA_COUNT; i++)
            {
                usuarioSource.AddNew();
                DataRowView rowView = usuarioSource.Current as DataRowView;
                rowView["sg_nivel"] = RandomString(1);
                rowView["nm_usuario"] = RandomString(10, 30);
                rowView["nm_login"] = RandomString(5, 15);
                rowView["cd_senha"] = RandomString(8, 24);
                usuarioSource.EndEdit();
                usuarioTableAdapter.Update(dataset.usuario);
            }
        }

        public void GenerateClientes()
        {
            for (int i = 0; i < DUMMY_DATA_COUNT; i++)
            {
                clienteSource.AddNew();
                DataRowView rowView = clienteSource.Current as DataRowView;

                rowView["nm_cliente"] = RandomString(10, 30);
                rowView["ds_endereco"] = RandomString(10, 30);
                rowView["nm_bairro"] = RandomString(10, 30);
                rowView["nm_cidade"] = RandomString(10, 30);
                rowView["sg_estado"] = RandomString(2, chars_letters);
                rowView["cd_cep"] = RandomString(9, chars_numbers);
                rowView["cd_cpf"] = RandomString(14, chars_numbers);
                rowView["cd_rg"] = RandomString(15, chars_numbers);
                rowView["nr_telefone"] = RandomString(13, chars_numbers);
                rowView["email"] = RandomString(10, 40);

                clienteSource.EndEdit();
                clienteTableAdapter.Update(dataset.cliente);
            }
        }

        public void GenerateFornecedores()
        {
            for (int i = 0; i < DUMMY_DATA_COUNT; i++)
            {
                fornecedorSource.AddNew();
                DataRowView rowView = fornecedorSource.Current as DataRowView;

                rowView["nm_fornecedor"] = RandomString(10, 30);
                rowView["ds_endereco"] = RandomString(10, 30);
                rowView["nm_bairro"] = RandomString(10, 30);
                rowView["nm_cidade"] = RandomString(10, 30);
                rowView["sg_estado"] = RandomString(2, chars_letters);
                rowView["cd_cep"] = RandomString(9, chars_numbers);
                rowView["cd_cnpj"] = RandomString(18, chars_numbers);
                rowView["cd_inscr_estadual"] = RandomString(15, chars_numbers);

                fornecedorSource.EndEdit();
                fornecedorTableAdapter.Update(dataset.fornecedor);
            }
        }

        public void GenerateAll()
        {
            GenerateUsuarios();
            GenerateClientes();
            //GenerateFornecedores();
        }

        const string chars_alphanumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const string chars_letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string chars_numbers = "1234567890";
        private string RandomString(int length, string chars=chars_alphanumeric)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string RandomString(int minLength, int maxLength, string chars=chars_alphanumeric)
        {
            minLength = Math.Max(minLength, 1);
            maxLength = Math.Max(maxLength, 1);
            int length = random.Next(minLength, maxLength);
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
