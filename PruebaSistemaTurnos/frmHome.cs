using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSistemaTurnos
{
    public partial class frmHome : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarPaciente_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPacientes oFormPacientes = new frmPacientes();
            oFormPacientes.MdiParent = this;
            oFormPacientes.Show();
        }
    }
}