﻿using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FilmeEditar : Form
    {
        public FilmeEditar()
        {
            InitializeComponent();
        }


        public FilmeEditar(Filme filme)
        {
            InitializeComponent();
            txtNome.Text = filme.Nome;
            txtId.Text = filme.Id.ToString();
            txtAvaliacao.Text = Convert.ToString(filme.Avaliacao);
            txtDuracao.Text = filme.Duracao.ToString("yyyy-MM-dd hh:mm:ss");


            cbCategoria.SelectedItem = filme.Categoria;
            ckbTemSequencia.Checked = filme.TemSequencia;
            if (filme.Curtiu)
            {
                rdbSim.Checked = true;
            }
            else
            {
                rdbNao.Checked = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Id = Convert.ToInt32(txtId.Text);
            filme.Nome = txtId.Text;
            filme.Curtiu = rdbSim.Checked;
            filme.TemSequencia = ckbTemSequencia.Checked;
            filme.Duracao = Convert.ToDateTime(txtDuracao.Text);
            filme.Avaliacao = Convert.ToDecimal(txtAvaliacao.Text);
            filme.Categoria = cbCategoria.SelectedIndex.ToString();
            FilmeRepositorio repositorio = new FilmeRepositorio();
            repositorio.Atualizar(filme);

            MessageBox.Show("Editado com Sucesso");
            Close();
        }
    }
}
