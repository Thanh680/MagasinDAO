
namespace ADO
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
            this.txtBox_num = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_localite = new System.Windows.Forms.TextBox();
            this.txtBox_gerant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_gerant = new System.Windows.Forms.Label();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_num
            // 
            this.txtBox_num.Location = new System.Drawing.Point(128, 52);
            this.txtBox_num.Name = "txtBox_num";
            this.txtBox_num.Size = new System.Drawing.Size(100, 20);
            this.txtBox_num.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(261, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Recherche";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero";
            // 
            // txtBox_localite
            // 
            this.txtBox_localite.Location = new System.Drawing.Point(169, 167);
            this.txtBox_localite.Name = "txtBox_localite";
            this.txtBox_localite.Size = new System.Drawing.Size(157, 20);
            this.txtBox_localite.TabIndex = 3;
            // 
            // txtBox_gerant
            // 
            this.txtBox_gerant.Location = new System.Drawing.Point(169, 193);
            this.txtBox_gerant.Name = "txtBox_gerant";
            this.txtBox_gerant.Size = new System.Drawing.Size(157, 20);
            this.txtBox_gerant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localite";
            // 
            // label_gerant
            // 
            this.label_gerant.AutoSize = true;
            this.label_gerant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gerant.Location = new System.Drawing.Point(78, 193);
            this.label_gerant.Name = "label_gerant";
            this.label_gerant.Size = new System.Drawing.Size(48, 16);
            this.label_gerant.TabIndex = 6;
            this.label_gerant.Text = "Gérant";
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(450, 72);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(111, 23);
            this.btn_list.TabIndex = 7;
            this.btn_list.Text = "Liste des magasins";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(450, 116);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(111, 23);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Créer";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(450, 145);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(111, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Mettre à jour";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(450, 193);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(111, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.label_gerant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_gerant);
            this.Controls.Add(this.txtBox_localite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtBox_num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_num;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_localite;
        private System.Windows.Forms.TextBox txtBox_gerant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_gerant;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}

