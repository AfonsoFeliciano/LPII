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
            this.calcularImcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masculinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femininoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularImcToolStripMenuItem,
            this.menu3ToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 61);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calcularImcToolStripMenuItem
            // 
            this.calcularImcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masculinoToolStripMenuItem,
            this.femininoToolStripMenuItem});
            this.calcularImcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularImcToolStripMenuItem.Image = global::IMC.Properties.Resources.calcular;
            this.calcularImcToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.calcularImcToolStripMenuItem.Name = "calcularImcToolStripMenuItem";
            this.calcularImcToolStripMenuItem.Size = new System.Drawing.Size(118, 57);
            this.calcularImcToolStripMenuItem.Text = "Calcular IMC";
            this.calcularImcToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // masculinoToolStripMenuItem
            // 
            this.masculinoToolStripMenuItem.Image = global::IMC.Properties.Resources.masculino;
            this.masculinoToolStripMenuItem.Name = "masculinoToolStripMenuItem";
            this.masculinoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.masculinoToolStripMenuItem.Text = "Masculino";
            this.masculinoToolStripMenuItem.Click += new System.EventHandler(this.masculinoToolStripMenuItem_Click);
            // 
            // femininoToolStripMenuItem
            // 
            this.femininoToolStripMenuItem.Image = global::IMC.Properties.Resources.feminino;
            this.femininoToolStripMenuItem.Name = "femininoToolStripMenuItem";
            this.femininoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.femininoToolStripMenuItem.Text = "Feminino";
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaIMCToolStripMenuItem,
            this.resultadosStripMenuItem1,
            this.sobreToolStripMenuItem});
            this.menu3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3ToolStripMenuItem.Image = global::IMC.Properties.Resources.opcoes;
            this.menu3ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(78, 57);
            this.menu3ToolStripMenuItem.Text = "Opções";
            this.menu3ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabelaIMCToolStripMenuItem
            // 
            this.tabelaIMCToolStripMenuItem.Image = global::IMC.Properties.Resources.tabela;
            this.tabelaIMCToolStripMenuItem.Name = "tabelaIMCToolStripMenuItem";
            this.tabelaIMCToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.tabelaIMCToolStripMenuItem.Text = "Tabela IMC";
            // 
            // resultadosStripMenuItem1
            // 
            this.resultadosStripMenuItem1.Image = global::IMC.Properties.Resources.tabela;
            this.resultadosStripMenuItem1.Name = "resultadosStripMenuItem1";
            this.resultadosStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.resultadosStripMenuItem1.Text = "Resultados";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::IMC.Properties.Resources.about;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem1.Image = global::IMC.Properties.Resources.exit;
            this.sairToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(51, 57);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 403);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de IMC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calcularImcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masculinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femininoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resultadosStripMenuItem1;
    }
}

