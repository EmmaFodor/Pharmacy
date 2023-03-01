namespace Farmacie
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cod_retetaLabel;
            System.Windows.Forms.Label cod_medicamentLabel;
            System.Windows.Forms.Label id_doctorLabel;
            System.Windows.Forms.Label data_emisaLabel;
            System.Windows.Forms.Label data_expLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacyDataSet = new Farmacie.PharmacyDataSet();
            this.retetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retetaTableAdapter = new Farmacie.PharmacyDataSetTableAdapters.RetetaTableAdapter();
            this.tableAdapterManager = new Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.retetaTextBox = new System.Windows.Forms.TextBox();
            this.cod_medicamentTextBox = new System.Windows.Forms.TextBox();
            this.id_doctorTextBox = new System.Windows.Forms.TextBox();
            this.data_emisaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_expDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            cod_retetaLabel = new System.Windows.Forms.Label();
            cod_medicamentLabel = new System.Windows.Forms.Label();
            id_doctorLabel = new System.Windows.Forms.Label();
            data_emisaLabel = new System.Windows.Forms.Label();
            data_expLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_retetaLabel
            // 
            cod_retetaLabel.AutoSize = true;
            cod_retetaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cod_retetaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_retetaLabel.Location = new System.Drawing.Point(80, 90);
            cod_retetaLabel.Name = "cod_retetaLabel";
            cod_retetaLabel.Size = new System.Drawing.Size(119, 27);
            cod_retetaLabel.TabIndex = 2;
            cod_retetaLabel.Text = "Cod rețetă:";
            cod_retetaLabel.Click += new System.EventHandler(this.cod_retetaLabel_Click);
            // 
            // cod_medicamentLabel
            // 
            cod_medicamentLabel.AutoSize = true;
            cod_medicamentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cod_medicamentLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_medicamentLabel.Location = new System.Drawing.Point(166, 188);
            cod_medicamentLabel.Name = "cod_medicamentLabel";
            cod_medicamentLabel.Size = new System.Drawing.Size(181, 27);
            cod_medicamentLabel.TabIndex = 6;
            cod_medicamentLabel.Text = "Cod medicament:";
            // 
            // id_doctorLabel
            // 
            id_doctorLabel.AutoSize = true;
            id_doctorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            id_doctorLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_doctorLabel.Location = new System.Drawing.Point(241, 247);
            id_doctorLabel.Name = "id_doctorLabel";
            id_doctorLabel.Size = new System.Drawing.Size(111, 27);
            id_doctorLabel.TabIndex = 7;
            id_doctorLabel.Text = "ID doctor:";
            // 
            // data_emisaLabel
            // 
            data_emisaLabel.AutoSize = true;
            data_emisaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            data_emisaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_emisaLabel.Location = new System.Drawing.Point(222, 313);
            data_emisaLabel.Name = "data_emisaLabel";
            data_emisaLabel.Size = new System.Drawing.Size(125, 27);
            data_emisaLabel.TabIndex = 8;
            data_emisaLabel.Text = "Data emisă:";
            data_emisaLabel.Click += new System.EventHandler(this.data_emisaLabel_Click);
            // 
            // data_expLabel
            // 
            data_expLabel.AutoSize = true;
            data_expLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            data_expLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_expLabel.Location = new System.Drawing.Point(241, 381);
            data_expLabel.Name = "data_expLabel";
            data_expLabel.Size = new System.Drawing.Size(105, 27);
            data_expLabel.TabIndex = 10;
            data_expLabel.Text = "Data exp:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.medicamentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.backToolStripMenuItem.Text = "Înapoi";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // medicamentToolStripMenuItem
            // 
            this.medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            this.medicamentToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.medicamentToolStripMenuItem.Text = "Medicament";
            this.medicamentToolStripMenuItem.Click += new System.EventHandler(this.medicamentToolStripMenuItem_Click);
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retetaBindingSource
            // 
            this.retetaBindingSource.DataMember = "Reteta";
            this.retetaBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // retetaTableAdapter
            // 
            this.retetaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IstoricTableAdapter = null;
            this.tableAdapterManager.MedicamentTableAdapter = null;
            this.tableAdapterManager.PacientTableAdapter = null;
            this.tableAdapterManager.RetetaTableAdapter = this.retetaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValabilitateTableAdapter = null;
            // 
            // retetaTextBox
            // 
            this.retetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.retetaBindingSource, "cod_reteta", true));
            this.retetaTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retetaTextBox.Location = new System.Drawing.Point(223, 87);
            this.retetaTextBox.Name = "retetaTextBox";
            this.retetaTextBox.Size = new System.Drawing.Size(199, 34);
            this.retetaTextBox.TabIndex = 3;
            this.retetaTextBox.TextChanged += new System.EventHandler(this.retetaTextBox_TextChanged);
            // 
            // cod_medicamentTextBox
            // 
            this.cod_medicamentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.retetaBindingSource, "cod_medicament", true));
            this.cod_medicamentTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_medicamentTextBox.Location = new System.Drawing.Point(365, 185);
            this.cod_medicamentTextBox.Name = "cod_medicamentTextBox";
            this.cod_medicamentTextBox.Size = new System.Drawing.Size(195, 34);
            this.cod_medicamentTextBox.TabIndex = 7;
            this.cod_medicamentTextBox.TextChanged += new System.EventHandler(this.cod_medicamentTextBox_TextChanged);
            // 
            // id_doctorTextBox
            // 
            this.id_doctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.retetaBindingSource, "id_doctor", true));
            this.id_doctorTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_doctorTextBox.Location = new System.Drawing.Point(366, 244);
            this.id_doctorTextBox.Name = "id_doctorTextBox";
            this.id_doctorTextBox.Size = new System.Drawing.Size(194, 34);
            this.id_doctorTextBox.TabIndex = 8;
            this.id_doctorTextBox.TextChanged += new System.EventHandler(this.id_doctorTextBox_TextChanged);
            // 
            // data_emisaDateTimePicker
            // 
            this.data_emisaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.retetaBindingSource, "data_emisa", true));
            this.data_emisaDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_emisaDateTimePicker.Location = new System.Drawing.Point(365, 307);
            this.data_emisaDateTimePicker.Name = "data_emisaDateTimePicker";
            this.data_emisaDateTimePicker.Size = new System.Drawing.Size(379, 34);
            this.data_emisaDateTimePicker.TabIndex = 9;
            this.data_emisaDateTimePicker.ValueChanged += new System.EventHandler(this.data_emisaDateTimePicker_ValueChanged);
            // 
            // data_expDateTimePicker
            // 
            this.data_expDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.retetaBindingSource, "data_exp", true));
            this.data_expDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_expDateTimePicker.Location = new System.Drawing.Point(366, 375);
            this.data_expDateTimePicker.Name = "data_expDateTimePicker";
            this.data_expDateTimePicker.Size = new System.Drawing.Size(379, 34);
            this.data_expDateTimePicker.TabIndex = 11;
            this.data_expDateTimePicker.ValueChanged += new System.EventHandler(this.data_expDateTimePicker_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(446, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Caută";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 484);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(data_expLabel);
            this.Controls.Add(this.data_expDateTimePicker);
            this.Controls.Add(data_emisaLabel);
            this.Controls.Add(this.data_emisaDateTimePicker);
            this.Controls.Add(id_doctorLabel);
            this.Controls.Add(this.id_doctorTextBox);
            this.Controls.Add(cod_medicamentLabel);
            this.Controls.Add(this.cod_medicamentTextBox);
            this.Controls.Add(cod_retetaLabel);
            this.Controls.Add(this.retetaTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentToolStripMenuItem;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource retetaBindingSource;
        private PharmacyDataSetTableAdapters.RetetaTableAdapter retetaTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox retetaTextBox;
        private System.Windows.Forms.TextBox cod_medicamentTextBox;
        private System.Windows.Forms.TextBox id_doctorTextBox;
        private System.Windows.Forms.DateTimePicker data_emisaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_expDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}