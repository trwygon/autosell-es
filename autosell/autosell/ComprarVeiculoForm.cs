﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autosell
{
    public partial class ComprarVeiculoForm : Form
    {
        public ComprarVeiculoForm()
        {
            InitializeComponent();

            cmbClientes.DataSource = Enum.GetValues(typeof(TipoTransacao));
        }
    }
}