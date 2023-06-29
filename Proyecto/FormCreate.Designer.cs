namespace Proyecto
{
    partial class FormCreate
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDCreate = new System.Windows.Forms.TextBox();
            this.textBoxTipoCreate = new System.Windows.Forms.TextBox();
            this.textBoxTallaCreate = new System.Windows.Forms.TextBox();
            this.textBoxPrecioCreate = new System.Windows.Forms.TextBox();
            this.richTextBoxDescripcionCreate = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(26, 329);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(167, 329);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxDescripcionCreate);
            this.groupBox1.Controls.Add(this.textBoxPrecioCreate);
            this.groupBox1.Controls.Add(this.textBoxTallaCreate);
            this.groupBox1.Controls.Add(this.textBoxTipoCreate);
            this.groupBox1.Controls.Add(this.textBoxIDCreate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 229);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Talla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción";
            // 
            // textBoxIDCreate
            // 
            this.textBoxIDCreate.Location = new System.Drawing.Point(80, 20);
            this.textBoxIDCreate.Name = "textBoxIDCreate";
            this.textBoxIDCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxIDCreate.TabIndex = 5;
            // 
            // textBoxTipoCreate
            // 
            this.textBoxTipoCreate.Location = new System.Drawing.Point(80, 47);
            this.textBoxTipoCreate.Name = "textBoxTipoCreate";
            this.textBoxTipoCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxTipoCreate.TabIndex = 6;
            // 
            // textBoxTallaCreate
            // 
            this.textBoxTallaCreate.Location = new System.Drawing.Point(80, 74);
            this.textBoxTallaCreate.Name = "textBoxTallaCreate";
            this.textBoxTallaCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxTallaCreate.TabIndex = 7;
            // 
            // textBoxPrecioCreate
            // 
            this.textBoxPrecioCreate.Location = new System.Drawing.Point(80, 101);
            this.textBoxPrecioCreate.Name = "textBoxPrecioCreate";
            this.textBoxPrecioCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxPrecioCreate.TabIndex = 8;
            // 
            // richTextBoxDescripcionCreate
            // 
            this.richTextBoxDescripcionCreate.Location = new System.Drawing.Point(80, 128);
            this.richTextBoxDescripcionCreate.Name = "richTextBoxDescripcionCreate";
            this.richTextBoxDescripcionCreate.Size = new System.Drawing.Size(162, 95);
            this.richTextBoxDescripcionCreate.TabIndex = 9;
            this.richTextBoxDescripcionCreate.Text = "";
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "FormCreate";
            this.Text = "FormCreate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPrecioCreate;
        private System.Windows.Forms.TextBox textBoxTallaCreate;
        private System.Windows.Forms.TextBox textBoxTipoCreate;
        private System.Windows.Forms.TextBox textBoxIDCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcionCreate;
    }
}