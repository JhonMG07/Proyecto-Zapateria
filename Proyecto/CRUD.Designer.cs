﻿namespace Proyecto
{
    partial class CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalReadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualReadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createItem,
            this.readItem,
            this.updateItem,
            this.deleteItem,
            this.searchItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createItem
            // 
            this.createItem.Name = "createItem";
            this.createItem.Size = new System.Drawing.Size(59, 20);
            this.createItem.Text = "CREATE";
            this.createItem.Click += new System.EventHandler(this.createItem_Click);
            // 
            // readItem
            // 
            this.readItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalReadItem,
            this.individualReadItem});
            this.readItem.Name = "readItem";
            this.readItem.Size = new System.Drawing.Size(48, 20);
            this.readItem.Text = "READ";
            // 
            // generalReadItem
            // 
            this.generalReadItem.Name = "generalReadItem";
            this.generalReadItem.Size = new System.Drawing.Size(137, 22);
            this.generalReadItem.Text = "GENERAL";
            this.generalReadItem.Click += new System.EventHandler(this.generalReadItem_Click);
            // 
            // individualReadItem
            // 
            this.individualReadItem.Name = "individualReadItem";
            this.individualReadItem.Size = new System.Drawing.Size(137, 22);
            this.individualReadItem.Text = "INDIVIDUAL";
            this.individualReadItem.Click += new System.EventHandler(this.individualReadItem_Click);
            // 
            // updateItem
            // 
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(61, 20);
            this.updateItem.Text = "UPDATE";
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(57, 20);
            this.deleteItem.Text = "DELETE";
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // searchItem
            // 
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(63, 20);
            this.searchItem.Text = "SEARCH";
            this.searchItem.Click += new System.EventHandler(this.searchItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(346, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRUD";
            this.Text = "MENÚ PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createItem;
        private System.Windows.Forms.ToolStripMenuItem readItem;
        private System.Windows.Forms.ToolStripMenuItem generalReadItem;
        private System.Windows.Forms.ToolStripMenuItem updateItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private System.Windows.Forms.ToolStripMenuItem searchItem;
        private System.Windows.Forms.ToolStripMenuItem individualReadItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}