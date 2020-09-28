using System;

namespace games_db
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namebox = new System.Windows.Forms.TextBox();
            this.editorbox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.platformbox = new System.Windows.Forms.ComboBox();
            this.typebox = new System.Windows.Forms.ComboBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamegrid = new System.Windows.Forms.DataGridView();
            this.enamebox = new System.Windows.Forms.TextBox();
            this.edatebox = new System.Windows.Forms.TextBox();
            this.eplatformbox = new System.Windows.Forms.ComboBox();
            this.etypebox = new System.Windows.Forms.ComboBox();
            this.eeditorbox = new System.Windows.Forms.TextBox();
            this.editbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(47, 24);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(200, 23);
            this.namebox.TabIndex = 1;
            // 
            // editorbox
            // 
            this.editorbox.Location = new System.Drawing.Point(47, 140);
            this.editorbox.Name = "editorbox";
            this.editorbox.Size = new System.Drawing.Size(200, 23);
            this.editorbox.TabIndex = 1;
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(47, 111);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(200, 23);
            this.datebox.TabIndex = 2;
            // 
            // platformbox
            // 
            this.platformbox.FormattingEnabled = true;
            this.platformbox.Items.AddRange(new object[] {
            "PC",
            "Xbox",
            "PS4",
            "Nintendo Switch"});
            this.platformbox.Location = new System.Drawing.Point(47, 53);
            this.platformbox.Name = "platformbox";
            this.platformbox.Size = new System.Drawing.Size(200, 23);
            this.platformbox.TabIndex = 3;
            // 
            // typebox
            // 
            this.typebox.FormattingEnabled = true;
            this.typebox.Items.AddRange(new object[] {
            "FPS",
            "TPS",
            "RPG",
            "MMORPG",
            "Simulateur"});
            this.typebox.Location = new System.Drawing.Point(47, 82);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(200, 23);
            this.typebox.TabIndex = 4;
            this.typebox.SelectedIndexChanged += new System.EventHandler(this.typebox_SelectedIndexChanged);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(47, 169);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(200, 23);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GName
            // 
            this.GName.HeaderText = "GName";
            this.GName.Name = "GName";
            this.GName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GameDate
            // 
            this.GameDate.HeaderText = "GameDate";
            this.GameDate.Name = "GameDate";
            this.GameDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Editor
            // 
            this.Editor.HeaderText = "Editor";
            this.Editor.Name = "Editor";
            this.Editor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gamegrid
            // 
            this.gamegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.GName,
            this.Platform,
            this.Type,
            this.GameDate,
            this.Editor});
            this.gamegrid.Location = new System.Drawing.Point(253, 24);
            this.gamegrid.Name = "gamegrid";
            this.gamegrid.Size = new System.Drawing.Size(650, 460);
            this.gamegrid.TabIndex = 0;
            this.gamegrid.Text = "dataGridView1";
            this.gamegrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gamegrid_CellClick);
            // 
            // enamebox
            // 
            this.enamebox.Location = new System.Drawing.Point(47, 221);
            this.enamebox.Name = "enamebox";
            this.enamebox.Size = new System.Drawing.Size(200, 23);
            this.enamebox.TabIndex = 1;
            // 
            // edatebox
            // 
            this.edatebox.Location = new System.Drawing.Point(47, 308);
            this.edatebox.Name = "edatebox";
            this.edatebox.Size = new System.Drawing.Size(200, 23);
            this.edatebox.TabIndex = 1;
            // 
            // eplatformbox
            // 
            this.eplatformbox.FormattingEnabled = true;
            this.eplatformbox.Items.AddRange(new object[] {
            "PC",
            "Xbox",
            "PS4",
            "Nintendo Switch"});
            this.eplatformbox.Location = new System.Drawing.Point(47, 250);
            this.eplatformbox.Name = "eplatformbox";
            this.eplatformbox.Size = new System.Drawing.Size(200, 23);
            this.eplatformbox.TabIndex = 3;
            // 
            // etypebox
            // 
            this.etypebox.FormattingEnabled = true;
            this.etypebox.Items.AddRange(new object[] {
            "FPS",
            "TPS",
            "RPG",
            "MMORPG",
            "Simulateur"});
            this.etypebox.Location = new System.Drawing.Point(47, 279);
            this.etypebox.Name = "etypebox";
            this.etypebox.Size = new System.Drawing.Size(200, 23);
            this.etypebox.TabIndex = 3;
            // 
            // eeditorbox
            // 
            this.eeditorbox.Location = new System.Drawing.Point(47, 337);
            this.eeditorbox.Name = "eeditorbox";
            this.eeditorbox.Size = new System.Drawing.Size(200, 23);
            this.eeditorbox.TabIndex = 1;
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(47, 366);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(200, 23);
            this.editbutton.TabIndex = 5;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 496);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.eeditorbox);
            this.Controls.Add(this.etypebox);
            this.Controls.Add(this.eplatformbox);
            this.Controls.Add(this.edatebox);
            this.Controls.Add(this.enamebox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.platformbox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.editorbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.gamegrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamegrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gamegrid;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox editorbox;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.ComboBox platformbox;
        private System.Windows.Forms.ComboBox typebox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editor;
        private System.Windows.Forms.TextBox enamebox;
        private System.Windows.Forms.TextBox edatebox;
        private System.Windows.Forms.ComboBox eplatformbox;
        private System.Windows.Forms.ComboBox etypebox;
        private System.Windows.Forms.TextBox eeditorbox;
        private System.Windows.Forms.Button editbutton;
    }
}

