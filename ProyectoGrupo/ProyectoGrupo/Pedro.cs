using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo
{
    public partial class Pedro : Form
    {
        public Pedro()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwind_2007DataSet1);

        }

        private void Pedro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwind_2007DataSet1.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.northwind_2007DataSet1.Proveedores);

        }
    }
}
