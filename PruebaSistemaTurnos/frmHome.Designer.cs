
namespace PruebaSistemaTurnos
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPagePacientes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnAgregarPaciente = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnEditarPaciente = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminarPaciente = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnAgregarPaciente,
            this.btnEditarPaciente,
            this.btnEliminarPaciente});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPagePacientes});
            this.ribbon.Size = new System.Drawing.Size(771, 177);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPagePacientes
            // 
            this.ribbonPagePacientes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPagePacientes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPagePacientes.Name = "ribbonPagePacientes";
            this.ribbonPagePacientes.Text = "Pacientes";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAgregarPaciente);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditarPaciente);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEliminarPaciente);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 503);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(771, 24);
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.Caption = "Agregar Paciente";
            this.btnAgregarPaciente.Id = 2;
            this.btnAgregarPaciente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPaciente.ImageOptions.Image")));
            this.btnAgregarPaciente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPaciente.ImageOptions.LargeImage")));
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgregarPaciente_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Caption = "Editar Paciente";
            this.btnEditarPaciente.Id = 4;
            this.btnEditarPaciente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPaciente.ImageOptions.Image")));
            this.btnEditarPaciente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditarPaciente.ImageOptions.LargeImage")));
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Caption = "Eliminar Paciente";
            this.btnEliminarPaciente.Id = 5;
            this.btnEliminarPaciente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPaciente.ImageOptions.Image")));
            this.btnEliminarPaciente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPaciente.ImageOptions.LargeImage")));
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 527);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmHome";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPagePacientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAgregarPaciente;
        private DevExpress.XtraBars.BarButtonItem btnEditarPaciente;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnEliminarPaciente;
    }
}