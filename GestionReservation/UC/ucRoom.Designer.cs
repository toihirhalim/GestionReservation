
namespace GestionReservation.UC
{
    partial class ucRoom
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbNum = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.libérerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réserverMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.BackColor = System.Drawing.Color.Navy;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.ForeColor = System.Drawing.Color.White;
            this.lbNum.Location = new System.Drawing.Point(1, 68);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(36, 37);
            this.lbNum.TabIndex = 0;
            this.lbNum.Text = "0";
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libérerMenuItem,
            this.réserverMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(181, 80);
            // 
            // libérerMenuItem
            // 
            this.libérerMenuItem.Name = "libérerMenuItem";
            this.libérerMenuItem.Size = new System.Drawing.Size(180, 38);
            this.libérerMenuItem.Text = "Libérer";
            // 
            // réserverMenuItem
            // 
            this.réserverMenuItem.Name = "réserverMenuItem";
            this.réserverMenuItem.Size = new System.Drawing.Size(180, 38);
            this.réserverMenuItem.Text = "Réserver";
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.lbNum);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(342, 106);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem libérerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réserverMenuItem;
    }
}
