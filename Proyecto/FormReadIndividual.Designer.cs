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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIndividual
            // 
            this.dataGridViewIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndividual.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewIndividual.Name = "dataGridViewIndividual";
            this.dataGridViewIndividual.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewIndividual.TabIndex = 0;
            // 
            // FormReadIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewIndividual);
            this.IsMdiContainer = true;
            this.Name = "FormReadIndividual";
            this.Text = "FormReadIndividual";
            this.Load += new System.EventHandler(this.FormReadIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIndividual;
    }
}