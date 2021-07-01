
namespace GestionReservation.UC
{
    partial class ucHotel
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ucRoom9 = new GestionReservation.UC.ucRoom();
            this.ucRoom6 = new GestionReservation.UC.ucRoom();
            this.ucRoom2 = new GestionReservation.UC.ucRoom();
            this.ucRoom8 = new GestionReservation.UC.ucRoom();
            this.ucRoom7 = new GestionReservation.UC.ucRoom();
            this.ucRoom4 = new GestionReservation.UC.ucRoom();
            this.ucRoom3 = new GestionReservation.UC.ucRoom();
            this.ucRoom1 = new GestionReservation.UC.ucRoom();
            this.ucRoom5 = new GestionReservation.UC.ucRoom();
            this.levels.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date de réservation";
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(176, 245);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(246, 24);
            this.dtPicker.TabIndex = 4;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Levels :";
            // 
            // levels
            // 
            this.levels.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.levels.Controls.Add(this.button11);
            this.levels.Controls.Add(this.button10);
            this.levels.Controls.Add(this.button9);
            this.levels.Controls.Add(this.button8);
            this.levels.Controls.Add(this.button7);
            this.levels.Controls.Add(this.button6);
            this.levels.Controls.Add(this.button5);
            this.levels.Controls.Add(this.button4);
            this.levels.Controls.Add(this.button3);
            this.levels.Controls.Add(this.button2);
            this.levels.Controls.Add(this.button1);
            this.levels.Location = new System.Drawing.Point(125, 21);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(326, 25);
            this.levels.TabIndex = 6;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(293, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 20);
            this.button11.TabIndex = 10;
            this.button11.Text = "10";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(264, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(23, 20);
            this.button10.TabIndex = 9;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(235, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 20);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(61, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 20);
            this.button8.TabIndex = 7;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(206, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 20);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(90, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 20);
            this.button6.TabIndex = 5;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 20);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 20);
            this.button4.TabIndex = 3;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "5";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "6";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // ucRoom9
            // 
            this.ucRoom9.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom9.Location = new System.Drawing.Point(356, 58);
            this.ucRoom9.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom9.Name = "ucRoom9";
            this.ucRoom9.Num = 9;
            this.ucRoom9.Size = new System.Drawing.Size(171, 55);
            this.ucRoom9.TabIndex = 2;
            // 
            // ucRoom6
            // 
            this.ucRoom6.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom6.Location = new System.Drawing.Point(356, 116);
            this.ucRoom6.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom6.Name = "ucRoom6";
            this.ucRoom6.Num = 6;
            this.ucRoom6.Size = new System.Drawing.Size(171, 55);
            this.ucRoom6.TabIndex = 2;
            // 
            // ucRoom2
            // 
            this.ucRoom2.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom2.Location = new System.Drawing.Point(356, 174);
            this.ucRoom2.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom2.Name = "ucRoom2";
            this.ucRoom2.Num = 3;
            this.ucRoom2.Size = new System.Drawing.Size(171, 55);
            this.ucRoom2.TabIndex = 2;
            // 
            // ucRoom8
            // 
            this.ucRoom8.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom8.Location = new System.Drawing.Point(182, 58);
            this.ucRoom8.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom8.Name = "ucRoom8";
            this.ucRoom8.Num = 8;
            this.ucRoom8.Size = new System.Drawing.Size(171, 55);
            this.ucRoom8.TabIndex = 2;
            // 
            // ucRoom7
            // 
            this.ucRoom7.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom7.Location = new System.Drawing.Point(8, 58);
            this.ucRoom7.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom7.Name = "ucRoom7";
            this.ucRoom7.Num = 7;
            this.ucRoom7.Size = new System.Drawing.Size(171, 55);
            this.ucRoom7.TabIndex = 2;
            // 
            // ucRoom4
            // 
            this.ucRoom4.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom4.Location = new System.Drawing.Point(182, 116);
            this.ucRoom4.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom4.Name = "ucRoom4";
            this.ucRoom4.Num = 5;
            this.ucRoom4.Size = new System.Drawing.Size(171, 55);
            this.ucRoom4.TabIndex = 2;
            // 
            // ucRoom3
            // 
            this.ucRoom3.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom3.Location = new System.Drawing.Point(8, 116);
            this.ucRoom3.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom3.Name = "ucRoom3";
            this.ucRoom3.Num = 4;
            this.ucRoom3.Size = new System.Drawing.Size(171, 55);
            this.ucRoom3.TabIndex = 2;
            // 
            // ucRoom1
            // 
            this.ucRoom1.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom1.Location = new System.Drawing.Point(182, 174);
            this.ucRoom1.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom1.Name = "ucRoom1";
            this.ucRoom1.Num = 2;
            this.ucRoom1.Size = new System.Drawing.Size(171, 55);
            this.ucRoom1.TabIndex = 2;
            // 
            // ucRoom5
            // 
            this.ucRoom5.BackColor = System.Drawing.Color.DarkGray;
            this.ucRoom5.Location = new System.Drawing.Point(8, 174);
            this.ucRoom5.Margin = new System.Windows.Forms.Padding(1);
            this.ucRoom5.Name = "ucRoom5";
            this.ucRoom5.Num = 1;
            this.ucRoom5.Size = new System.Drawing.Size(171, 55);
            this.ucRoom5.TabIndex = 2;
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.levels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucRoom9);
            this.Controls.Add(this.ucRoom6);
            this.Controls.Add(this.ucRoom2);
            this.Controls.Add(this.ucRoom8);
            this.Controls.Add(this.ucRoom7);
            this.Controls.Add(this.ucRoom4);
            this.Controls.Add(this.ucRoom3);
            this.Controls.Add(this.ucRoom1);
            this.Controls.Add(this.ucRoom5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(537, 296);
            this.Load += new System.EventHandler(this.ucHotel_Load);
            this.levels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucRoom ucRoom5;
        private ucRoom ucRoom1;
        private ucRoom ucRoom2;
        private ucRoom ucRoom3;
        private ucRoom ucRoom4;
        private ucRoom ucRoom6;
        private ucRoom ucRoom7;
        private ucRoom ucRoom8;
        private ucRoom ucRoom9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel levels;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
