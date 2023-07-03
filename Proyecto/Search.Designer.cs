namespace Proyecto
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.searchItem = new System.Windows.Forms.Button();
            this.textBoxNombreZapato = new System.Windows.Forms.TextBox();
            this.dataGridViewZapatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.regresarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZapatos)).BeginInit();
            this.SuspendLayout();
            // 
            // searchItem
            // 
            this.searchItem.Location = new System.Drawing.Point(30, 108);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(119, 23);
            this.searchItem.TabIndex = 0;
            this.searchItem.Text = "Buscar";
            this.searchItem.UseVisualStyleBackColor = true;
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // textBoxNombreZapato
            // 
            this.textBoxNombreZapato.Location = new System.Drawing.Point(30, 82);
            this.textBoxNombreZapato.Name = "textBoxNombreZapato";
            this.textBoxNombreZapato.Size = new System.Drawing.Size(119, 20);
            this.textBoxNombreZapato.TabIndex = 1;
            // 
            // dataGridViewZapatos
            // 
            this.dataGridViewZapatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZapatos.Location = new System.Drawing.Point(164, 21);
            this.dataGridViewZapatos.Name = "dataGridViewZapatos";
            this.dataGridViewZapatos.Size = new System.Drawing.Size(535, 161);
            this.dataGridViewZapatos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el tipo de calzado:";
            // 
            // regresarBtn
            // 
            this.regresarBtn.Location = new System.Drawing.Point(30, 145);
            this.regresarBtn.Name = "regresarBtn";
            this.regresarBtn.Size = new System.Drawing.Size(119, 23);
            this.regresarBtn.TabIndex = 4;
            this.regresarBtn.Text = "Regresar";
            this.regresarBtn.UseVisualStyleBackColor = true;
            this.regresarBtn.Click += new System.EventHandler(this.regresarBtn_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 201);
            this.ControlBox = false;
            this.Controls.Add(this.regresarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewZapatos);
            this.Controls.Add(this.textBoxNombreZapato);
            this.Controls.Add(this.searchItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.Text = "SEARCH";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZapatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchItem;
        private System.Windows.Forms.TextBox textBoxNombreZapato;
        private System.Windows.Forms.DataGridView dataGridViewZapatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regresarBtn;
    }
}