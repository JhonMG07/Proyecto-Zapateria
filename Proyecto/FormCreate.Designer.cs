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
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.dataGridViewCreate = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGeneroCreate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxDescripcionCreate = new System.Windows.Forms.RichTextBox();
            this.textBoxPrecioCreate = new System.Windows.Forms.TextBox();
            this.textBoxTallaCreate = new System.Windows.Forms.TextBox();
            this.textBoxTipoCreate = new System.Windows.Forms.TextBox();
            this.textBoxIDCreate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(26, 310);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(167, 310);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 1;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // dataGridViewCreate
            // 
            this.dataGridViewCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCreate.Location = new System.Drawing.Point(266, 12);
            this.dataGridViewCreate.Name = "dataGridViewCreate";
            this.dataGridViewCreate.Size = new System.Drawing.Size(522, 343);
            this.dataGridViewCreate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGeneroCreate);
            this.groupBox1.Controls.Add(this.label6);
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
            this.groupBox1.Size = new System.Drawing.Size(248, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Zapato";
            // 
            // textBoxGeneroCreate
            // 
            this.textBoxGeneroCreate.Location = new System.Drawing.Point(80, 243);
            this.textBoxGeneroCreate.Name = "textBoxGeneroCreate";
            this.textBoxGeneroCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxGeneroCreate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Género";
            // 
            // richTextBoxDescripcionCreate
            // 
            this.richTextBoxDescripcionCreate.Location = new System.Drawing.Point(80, 128);
            this.richTextBoxDescripcionCreate.Name = "richTextBoxDescripcionCreate";
            this.richTextBoxDescripcionCreate.Size = new System.Drawing.Size(162, 95);
            this.richTextBoxDescripcionCreate.TabIndex = 9;
            this.richTextBoxDescripcionCreate.Text = "";
            // 
            // textBoxPrecioCreate
            // 
            this.textBoxPrecioCreate.Location = new System.Drawing.Point(80, 101);
            this.textBoxPrecioCreate.Name = "textBoxPrecioCreate";
            this.textBoxPrecioCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxPrecioCreate.TabIndex = 8;
            // 
            // textBoxTallaCreate
            // 
            this.textBoxTallaCreate.Location = new System.Drawing.Point(80, 74);
            this.textBoxTallaCreate.Name = "textBoxTallaCreate";
            this.textBoxTallaCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxTallaCreate.TabIndex = 7;
            // 
            // textBoxTipoCreate
            // 
            this.textBoxTipoCreate.Location = new System.Drawing.Point(80, 47);
            this.textBoxTipoCreate.Name = "textBoxTipoCreate";
            this.textBoxTipoCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxTipoCreate.TabIndex = 6;
            // 
            // textBoxIDCreate
            // 
            this.textBoxIDCreate.Location = new System.Drawing.Point(80, 20);
            this.textBoxIDCreate.Name = "textBoxIDCreate";
            this.textBoxIDCreate.Size = new System.Drawing.Size(162, 20);
            this.textBoxIDCreate.TabIndex = 5;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
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
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCreate);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "FormCreate";
            this.Text = "CREATE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCreate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.DataGridView dataGridViewCreate;
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
        private System.Windows.Forms.TextBox textBoxGeneroCreate;
        private System.Windows.Forms.Label label6;
    }
}