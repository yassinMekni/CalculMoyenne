namespace CalculMoyenne
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NomPrenom = new System.Windows.Forms.TextBox();
            this.btn_Calculer = new System.Windows.Forms.Button();
            this.lst_Moyenne = new System.Windows.Forms.ListBox();
            this.txt_NoteTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NoteExamen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NoteDS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Moyenne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 136);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Et Prénom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_NomPrenom
            // 
            this.txt_NomPrenom.Location = new System.Drawing.Point(215, 133);
            this.txt_NomPrenom.Name = "txt_NomPrenom";
            this.txt_NomPrenom.Size = new System.Drawing.Size(211, 22);
            this.txt_NomPrenom.TabIndex = 1;
            this.txt_NomPrenom.TextChanged += new System.EventHandler(this.txt_NomPrenom_TextChanged);
            // 
            // btn_Calculer
            // 
            this.btn_Calculer.Enabled = false;
            this.btn_Calculer.Location = new System.Drawing.Point(216, 417);
            this.btn_Calculer.Name = "btn_Calculer";
            this.btn_Calculer.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculer.TabIndex = 2;
            this.btn_Calculer.Text = "Calculer";
            this.btn_Calculer.UseVisualStyleBackColor = true;
            this.btn_Calculer.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_Moyenne
            // 
            this.lst_Moyenne.FormattingEnabled = true;
            this.lst_Moyenne.ItemHeight = 16;
            this.lst_Moyenne.Location = new System.Drawing.Point(466, 103);
            this.lst_Moyenne.Name = "lst_Moyenne";
            this.lst_Moyenne.Size = new System.Drawing.Size(447, 260);
            this.lst_Moyenne.TabIndex = 3;
            this.lst_Moyenne.SelectedIndexChanged += new System.EventHandler(this.lst_Moyenne_SelectedIndexChanged);
            // 
            // txt_NoteTP
            // 
            this.txt_NoteTP.Location = new System.Drawing.Point(216, 295);
            this.txt_NoteTP.Name = "txt_NoteTP";
            this.txt_NoteTP.Size = new System.Drawing.Size(211, 22);
            this.txt_NoteTP.TabIndex = 5;
            this.txt_NoteTP.TextChanged += new System.EventHandler(this.txt_NoteTP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 295);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note TP";
            // 
            // txt_NoteExamen
            // 
            this.txt_NoteExamen.Location = new System.Drawing.Point(216, 238);
            this.txt_NoteExamen.Name = "txt_NoteExamen";
            this.txt_NoteExamen.Size = new System.Drawing.Size(211, 22);
            this.txt_NoteExamen.TabIndex = 7;
            this.txt_NoteExamen.TextChanged += new System.EventHandler(this.txt_NoteExamen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 244);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note Examen";
            // 
            // txt_NoteDS
            // 
            this.txt_NoteDS.Location = new System.Drawing.Point(215, 188);
            this.txt_NoteDS.Name = "txt_NoteDS";
            this.txt_NoteDS.Size = new System.Drawing.Size(211, 22);
            this.txt_NoteDS.TabIndex = 9;
            this.txt_NoteDS.TextChanged += new System.EventHandler(this.txt_NoteDS_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 191);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note Ds";
            // 
            // txt_Moyenne
            // 
            this.txt_Moyenne.Location = new System.Drawing.Point(216, 341);
            this.txt_Moyenne.Name = "txt_Moyenne";
            this.txt_Moyenne.ReadOnly = true;
            this.txt_Moyenne.Size = new System.Drawing.Size(211, 22);
            this.txt_Moyenne.TabIndex = 11;
            this.txt_Moyenne.TextChanged += new System.EventHandler(this.txt_Moyenne_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 341);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Moyenne";
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Enabled = false;
            this.btn_Supprimer.Location = new System.Drawing.Point(712, 417);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 12;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Enabled = false;
            this.btn_Ajouter.Location = new System.Drawing.Point(466, 417);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 13;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 540);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.txt_Moyenne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NoteDS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NoteExamen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NoteTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_Moyenne);
            this.Controls.Add(this.btn_Calculer);
            this.Controls.Add(this.txt_NomPrenom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomPrenom;
        private System.Windows.Forms.Button btn_Calculer;
        private System.Windows.Forms.ListBox lst_Moyenne;
        private System.Windows.Forms.TextBox txt_NoteTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NoteExamen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NoteDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Moyenne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Ajouter;
    }
}

