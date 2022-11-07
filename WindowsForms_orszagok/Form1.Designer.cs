namespace WindowsForms_orszagok
{
    partial class Form_Országok
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
            this.listBox_Orszagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5_allamforma = new System.Windows.Forms.TextBox();
            this.textBox4_nepesseg = new System.Windows.Forms.TextBox();
            this.textBox3_terulet = new System.Windows.Forms.TextBox();
            this.textBox2_fovaros = new System.Windows.Forms.TextBox();
            this.textBox1_orszagneve = new System.Windows.Forms.TextBox();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Orszagok
            // 
            this.listBox_Orszagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Orszagok.FormattingEnabled = true;
            this.listBox_Orszagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Orszagok.Name = "listBox_Orszagok";
            this.listBox_Orszagok.Size = new System.Drawing.Size(198, 422);
            this.listBox_Orszagok.TabIndex = 0;
            this.listBox_Orszagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Orszagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5_allamforma);
            this.groupBox1.Controls.Add(this.textBox4_nepesseg);
            this.groupBox1.Controls.Add(this.textBox3_terulet);
            this.groupBox1.Controls.Add(this.textBox2_fovaros);
            this.groupBox1.Controls.Add(this.textBox1_orszagneve);
            this.groupBox1.Controls.Add(this.textBox1_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(198, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott országok adatai";
            // 
            // textBox5_allamforma
            // 
            this.textBox5_allamforma.Location = new System.Drawing.Point(114, 370);
            this.textBox5_allamforma.Name = "textBox5_allamforma";
            this.textBox5_allamforma.Size = new System.Drawing.Size(177, 20);
            this.textBox5_allamforma.TabIndex = 11;
            // 
            // textBox4_nepesseg
            // 
            this.textBox4_nepesseg.Location = new System.Drawing.Point(114, 306);
            this.textBox4_nepesseg.Name = "textBox4_nepesseg";
            this.textBox4_nepesseg.Size = new System.Drawing.Size(177, 20);
            this.textBox4_nepesseg.TabIndex = 10;
            // 
            // textBox3_terulet
            // 
            this.textBox3_terulet.Location = new System.Drawing.Point(114, 233);
            this.textBox3_terulet.Name = "textBox3_terulet";
            this.textBox3_terulet.Size = new System.Drawing.Size(177, 20);
            this.textBox3_terulet.TabIndex = 9;
            // 
            // textBox2_fovaros
            // 
            this.textBox2_fovaros.Location = new System.Drawing.Point(114, 164);
            this.textBox2_fovaros.Name = "textBox2_fovaros";
            this.textBox2_fovaros.Size = new System.Drawing.Size(177, 20);
            this.textBox2_fovaros.TabIndex = 8;
            // 
            // textBox1_orszagneve
            // 
            this.textBox1_orszagneve.Location = new System.Drawing.Point(114, 92);
            this.textBox1_orszagneve.Name = "textBox1_orszagneve";
            this.textBox1_orszagneve.Size = new System.Drawing.Size(177, 20);
            this.textBox1_orszagneve.TabIndex = 7;
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(114, 37);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(100, 20);
            this.textBox1_id.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(23, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Népesség:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(15, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Államforma:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(46, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terület:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(38, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Főváros:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ország neve:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Országok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Orszagok);
            this.Name = "Form_Országok";
            this.Text = "A Föld orzágai";
            this.Load += new System.EventHandler(this.Form_Országok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Orszagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox5_allamforma;
        private System.Windows.Forms.TextBox textBox4_nepesseg;
        private System.Windows.Forms.TextBox textBox3_terulet;
        private System.Windows.Forms.TextBox textBox2_fovaros;
        private System.Windows.Forms.TextBox textBox1_orszagneve;
    }
}

