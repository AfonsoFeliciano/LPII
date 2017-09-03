namespace IMC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calcularIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masculinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femininoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularIMCToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calcularIMCToolStripMenuItem
            // 
            this.calcularIMCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masculinoToolStripMenuItem,
            this.femininoToolStripMenuItem});
            this.calcularIMCToolStripMenuItem.Image = global::IMC.Properties.Resources.cal;
            this.calcularIMCToolStripMenuItem.Name = "calcularIMCToolStripMenuItem";
            this.calcularIMCToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.calcularIMCToolStripMenuItem.Text = "Calcular IMC";
            this.calcularIMCToolStripMenuItem.Click += new System.EventHandler(this.calcularIMCToolStripMenuItem_Click);
            // 
            // masculinoToolStripMenuItem
            // 
            this.masculinoToolStripMenuItem.Image = global::IMC.Properties.Resources.male;
            this.masculinoToolStripMenuItem.Name = "masculinoToolStripMenuItem";
            this.masculinoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.masculinoToolStripMenuItem.Text = "Masculino";
            // 
            // femininoToolStripMenuItem
            // 
            this.femininoToolStripMenuItem.Image = global::IMC.Properties.Resources.female;
            this.femininoToolStripMenuItem.Name = "femininoToolStripMenuItem";
            this.femininoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.femininoToolStripMenuItem.Text = "Feminino";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaIMCToolStripMenuItem,
            this.desenvolvedorToolStripMenuItem});
            this.opçõesToolStripMenuItem.Image = global::IMC.Properties.Resources.ope;
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // tabelaIMCToolStripMenuItem
            // 
            this.tabelaIMCToolStripMenuItem.Image = global::IMC.Properties.Resources.table;
            this.tabelaIMCToolStripMenuItem.Name = "tabelaIMCToolStripMenuItem";
            this.tabelaIMCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tabelaIMCToolStripMenuItem.Text = "Tabela IMC";
            // 
            // desenvolvedorToolStripMenuItem
            // 
            this.desenvolvedorToolStripMenuItem.Image = global::IMC.Properties.Resources.developer;
            this.desenvolvedorToolStripMenuItem.Name = "desenvolvedorToolStripMenuItem";
            this.desenvolvedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desenvolvedorToolStripMenuItem.Text = "Desenvolvedor";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::IMC.Properties.Resources.exit;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo IMC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calcularIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masculinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femininoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorToolStripMenuItem;
    }
}

