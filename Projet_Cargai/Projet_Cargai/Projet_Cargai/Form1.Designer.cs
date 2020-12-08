
namespace Projet_Cargai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnAddCargaison = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnAddMarchandise = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMarchandise = new System.Windows.Forms.DataGridView();
            this.listViewCargaison = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarchandise)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewCargaison);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddCargaison);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.txtDistance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargaison";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMarchandise);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAddMarchandise);
            this.groupBox2.Controls.Add(this.txtVolume);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPoids);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(413, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 416);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marchandise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(106, 50);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(269, 26);
            this.txtDistance.TabIndex = 2;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "AERIENNE",
            "ROUTIERE"});
            this.cboType.Location = new System.Drawing.Point(106, 106);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(157, 28);
            this.cboType.TabIndex = 3;
            // 
            // btnAddCargaison
            // 
            this.btnAddCargaison.Location = new System.Drawing.Point(293, 160);
            this.btnAddCargaison.Name = "btnAddCargaison";
            this.btnAddCargaison.Size = new System.Drawing.Size(75, 28);
            this.btnAddCargaison.TabIndex = 4;
            this.btnAddCargaison.Text = "Add";
            this.btnAddCargaison.UseVisualStyleBackColor = true;
            this.btnAddCargaison.Click += new System.EventHandler(this.btnAddCargaison_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste Des Cargaisons";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Poids";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(82, 47);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(104, 26);
            this.txtPoids.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Volume";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(282, 47);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(93, 26);
            this.txtVolume.TabIndex = 10;
            // 
            // btnAddMarchandise
            // 
            this.btnAddMarchandise.Location = new System.Drawing.Point(300, 92);
            this.btnAddMarchandise.Name = "btnAddMarchandise";
            this.btnAddMarchandise.Size = new System.Drawing.Size(75, 28);
            this.btnAddMarchandise.TabIndex = 8;
            this.btnAddMarchandise.Text = "Add";
            this.btnAddMarchandise.UseVisualStyleBackColor = true;
            this.btnAddMarchandise.Click += new System.EventHandler(this.btnAddMarchandise_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Liste Des Marchandises";
            // 
            // dgvMarchandise
            // 
            this.dgvMarchandise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarchandise.Location = new System.Drawing.Point(13, 160);
            this.dgvMarchandise.Name = "dgvMarchandise";
            this.dgvMarchandise.Size = new System.Drawing.Size(373, 250);
            this.dgvMarchandise.TabIndex = 11;
            // 
            // listViewCargaison
            // 
            this.listViewCargaison.FormattingEnabled = true;
            this.listViewCargaison.ItemHeight = 20;
            this.listViewCargaison.Location = new System.Drawing.Point(15, 225);
            this.listViewCargaison.Name = "listViewCargaison";
            this.listViewCargaison.Size = new System.Drawing.Size(360, 184);
            this.listViewCargaison.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarchandise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCargaison;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMarchandise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddMarchandise;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listViewCargaison;
    }
}

