﻿namespace CelluleMutante
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_cell = new System.Windows.Forms.Panel();
            this.btn_simulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_cell
            // 
            this.pnl_cell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_cell.Location = new System.Drawing.Point(193, 47);
            this.pnl_cell.Name = "pnl_cell";
            this.pnl_cell.Size = new System.Drawing.Size(423, 354);
            this.pnl_cell.TabIndex = 0;
            this.pnl_cell.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cell_Paint);
            // 
            // btn_simulation
            // 
            this.btn_simulation.Location = new System.Drawing.Point(193, 407);
            this.btn_simulation.Name = "btn_simulation";
            this.btn_simulation.Size = new System.Drawing.Size(423, 31);
            this.btn_simulation.TabIndex = 0;
            this.btn_simulation.Text = "Simulation";
            this.btn_simulation.UseVisualStyleBackColor = true;
            this.btn_simulation.Click += new System.EventHandler(this.btn_simulation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_simulation);
            this.Controls.Add(this.pnl_cell);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cell;
        private System.Windows.Forms.Button btn_simulation;
    }
}

