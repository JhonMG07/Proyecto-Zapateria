using System;

namespace Proyecto
{
    partial class FormUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGeneroUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.richTextBoxDescripcionUpdate = new System.Windows.Forms.RichTextBox();
            this.textBoxPrecioUpdate = new System.Windows.Forms.TextBox();
            this.textBoxTallaUpdate = new System.Windows.Forms.TextBox();
            this.textBoxTipoUpdate = new System.Windows.Forms.TextBox();
            this.textBoxIDUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGeneroUpdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.richTextBoxDescripcionUpdate);
            this.groupBox1.Controls.Add(this.textBoxPrecioUpdate);
            this.groupBox1.Controls.Add(this.textBoxTallaUpdate);
            this.groupBox1.Controls.Add(this.textBoxTipoUpdate);
            this.groupBox1.Controls.Add(this.textBoxIDUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 305);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Zapato";
            // 
            // textBoxGeneroUpdate
            // 
            this.textBoxGeneroUpdate.Location = new System.Drawing.Point(80, 278);
            this.textBoxGeneroUpdate.Name = "textBoxGeneroUpdate";
            this.textBoxGeneroUpdate.Size = new System.Drawing.Size(162, 20);
            this.textBoxGeneroUpdate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Género";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(155, 56);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // richTextBoxDescripcionUpdate
            // 
            this.richTextBoxDescripcionUpdate.Location = new System.Drawing.Point(80, 176);
            this.richTextBoxDescripcionUpdate.Name = "richTextBoxDescripcionUpdate";
            this.richTextBoxDescripcionUpdate.Size = new System.Drawing.Size(162, 95);
            this.richTextBoxDescripcionUpdate.TabIndex = 9;
            this.richTextBoxDescripcionUpdate.Text = "";
            // 
            // textBoxPrecioUpdate
            // 
            this.textBoxPrecioUpdate.Location = new System.Drawing.Point(80, 149);
            this.textBoxPrecioUpdate.Name = "textBoxPrecioUpdate";
            this.textBoxPrecioUpdate.Size = new System.Drawing.Size(162, 20);
            this.textBoxPrecioUpdate.TabIndex = 8;
            // 
            // textBoxTallaUpdate
            // 
            this.textBoxTallaUpdate.Location = new System.Drawing.Point(80, 122);
            this.textBoxTallaUpdate.Name = "textBoxTallaUpdate";
            this.textBoxTallaUpdate.Size = new System.Drawing.Size(162, 20);
            this.textBoxTallaUpdate.TabIndex = 7;
            // 
            // textBoxTipoUpdate
            // 
            this.textBoxTipoUpdate.Location = new System.Drawing.Point(80, 95);
            this.textBoxTipoUpdate.Name = "textBoxTipoUpdate";
            this.textBoxTipoUpdate.Size = new System.Drawing.Size(162, 20);
            this.textBoxTipoUpdate.TabIndex = 6;
            // 
            // textBoxIDUpdate
            // 
            this.textBoxIDUpdate.Location = new System.Drawing.Point(80, 20);
            this.textBoxIDUpdate.Name = "textBoxIDUpdate";
            this.textBoxIDUpdate.Size = new System.Drawing.Size(162, 20);
            this.textBoxIDUpdate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Talla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
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
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Location = new System.Drawing.Point(266, 12);
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.Size = new System.Drawing.Size(522, 343);
            this.dataGridViewUpdate.TabIndex = 6;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(167, 332);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 5;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(26, 332);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 4;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewUpdate);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonActualizar);
            this.Name = "FormUpdate";
            this.Text = "UPDATE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
            this.ResumeLayout(false);

        }
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            CRUD backCrud = new CRUD();
            backCrud.Show();
            this.Close();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcionUpdate;
        private System.Windows.Forms.TextBox textBoxPrecioUpdate;
        private System.Windows.Forms.TextBox textBoxTallaUpdate;
        private System.Windows.Forms.TextBox textBoxTipoUpdate;
        private System.Windows.Forms.TextBox textBoxIDUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUpdate;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxGeneroUpdate;
        private System.Windows.Forms.Label label6;
    }
}