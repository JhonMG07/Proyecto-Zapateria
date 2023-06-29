namespace Proyecto
{
    partial class FormReadIndividual
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
            this.dataGridViewIndividual = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIndividual
            // 
            this.dataGridViewIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndividual.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewIndividual.Name = "dataGridViewIndividual";
            this.dataGridViewIndividual.Size = new System.Drawing.Size(935, 74);
            this.dataGridViewIndividual.TabIndex = 0;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(347, 92);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(429, 92);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 2;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(511, 92);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FormReadIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 129);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dataGridViewIndividual);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReadIndividual";
            this.Text = "FormReadIndividual";
            this.Load += new System.EventHandler(this.FormReadIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIndividual;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSiguiente;
    }
}