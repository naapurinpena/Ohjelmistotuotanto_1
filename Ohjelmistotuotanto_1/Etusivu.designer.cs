
namespace Ohejlmistotuotanto_R18
{
    partial class Etusivu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.etusivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsiakas = new System.Windows.Forms.Button();
            this.btnPalvelu = new System.Windows.Forms.Button();
            this.btnToiminta = new System.Windows.Forms.Button();
            this.btnLasku = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etusivuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 28);
            // 
            // etusivuToolStripMenuItem
            // 
            this.etusivuToolStripMenuItem.Name = "etusivuToolStripMenuItem";
            this.etusivuToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.etusivuToolStripMenuItem.Text = "Etusivu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1057, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(368, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Village Newbies Oy";
            // 
            // btnAsiakas
            // 
            this.btnAsiakas.Location = new System.Drawing.Point(368, 180);
            this.btnAsiakas.Name = "btnAsiakas";
            this.btnAsiakas.Size = new System.Drawing.Size(131, 50);
            this.btnAsiakas.TabIndex = 4;
            this.btnAsiakas.Text = "Asiakashallinta";
            this.btnAsiakas.UseVisualStyleBackColor = true;
            this.btnAsiakas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPalvelu
            // 
            this.btnPalvelu.Location = new System.Drawing.Point(531, 180);
            this.btnPalvelu.Name = "btnPalvelu";
            this.btnPalvelu.Size = new System.Drawing.Size(131, 50);
            this.btnPalvelu.TabIndex = 5;
            this.btnPalvelu.Text = "Palveluiden hallinta";
            this.btnPalvelu.UseVisualStyleBackColor = true;
            // 
            // btnToiminta
            // 
            this.btnToiminta.Location = new System.Drawing.Point(201, 180);
            this.btnToiminta.Name = "btnToiminta";
            this.btnToiminta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnToiminta.Size = new System.Drawing.Size(131, 50);
            this.btnToiminta.TabIndex = 6;
            this.btnToiminta.Text = "Toiminta-alueiden hallinta";
            this.btnToiminta.UseVisualStyleBackColor = true;
            // 
            // btnLasku
            // 
            this.btnLasku.Location = new System.Drawing.Point(700, 180);
            this.btnLasku.Name = "btnLasku";
            this.btnLasku.Size = new System.Drawing.Size(131, 50);
            this.btnLasku.TabIndex = 7;
            this.btnLasku.Text = "Laskujen hallinta";
            this.btnLasku.UseVisualStyleBackColor = true;
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1057, 658);
            this.Controls.Add(this.btnLasku);
            this.Controls.Add(this.btnToiminta);
            this.Controls.Add(this.btnPalvelu);
            this.Controls.Add(this.btnAsiakas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Etusivu";
            this.Text = "Etusivu";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem etusivuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsiakas;
        private System.Windows.Forms.Button btnPalvelu;
        private System.Windows.Forms.Button btnToiminta;
        private System.Windows.Forms.Button btnLasku;
    }
}