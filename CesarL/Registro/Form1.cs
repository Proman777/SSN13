using Registro.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Persona>persons;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbproducto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Name
        }
    }
}
