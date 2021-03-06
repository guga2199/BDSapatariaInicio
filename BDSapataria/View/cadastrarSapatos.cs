﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDSapataria.Control;
using BDSapataria.Model;

namespace BDSapataria.View
{
    public partial class cadastrarSapatos : Form
    {
        public cadastrarSapatos()
        {
            InitializeComponent();
        }

        private void buttonCadastrarSapato_Click(object sender, EventArgs e) 
        {
            Sapatos.Modelo = textBoxCadastraMarca.Text;
            Sapatos.Tamanho = textBoxCadastrarTamanho.Text;
            Sapatos.Genero = textBoxCadastraGenero.Text;
            Sapatos.Marca = textBoxCadastraMarca.Text;
            SapatosPreco = (float)(textBoxCadastraPreco.Text);

            ManipulaSapato manipulaSapato = new ManipularSapato();
            manipularSapato.cadastrarSapatos();

        }
    }
}
