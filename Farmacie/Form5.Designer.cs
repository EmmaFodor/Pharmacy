namespace Farmacie
{
    partial class Form5
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
            System.Windows.Forms.Label denumire_comercialaLabel;
            System.Windows.Forms.Label stocLabel;
            System.Windows.Forms.Label dulapLabel;
            System.Windows.Forms.Label raftLabel;
            System.Windows.Forms.Label cod_medicamentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pharmacyDataSet = new Farmacie.PharmacyDataSet();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentTableAdapter = new Farmacie.PharmacyDataSetTableAdapters.MedicamentTableAdapter();
            this.tableAdapterManager = new Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.denumire_comercialaTextBox = new System.Windows.Forms.TextBox();
            this.stocTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dulapTextBox = new System.Windows.Forms.TextBox();
            this.raftTextBox = new System.Windows.Forms.TextBox();
            this.cod_medicamentTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            denumire_comercialaLabel = new System.Windows.Forms.Label();
            stocLabel = new System.Windows.Forms.Label();
            dulapLabel = new System.Windows.Forms.Label();
            raftLabel = new System.Windows.Forms.Label();
            cod_medicamentLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // denumire_comercialaLabel
            // 
            denumire_comercialaLabel.AutoSize = true;
            denumire_comercialaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            denumire_comercialaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            denumire_comercialaLabel.Location = new System.Drawing.Point(33, 159);
            denumire_comercialaLabel.Name = "denumire_comercialaLabel";
            denumire_comercialaLabel.Size = new System.Drawing.Size(224, 27);
            denumire_comercialaLabel.TabIndex = 2;
            denumire_comercialaLabel.Text = "Denumire comercială:";
            // 
            // stocLabel
            // 
            stocLabel.AutoSize = true;
            stocLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stocLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stocLabel.Location = new System.Drawing.Point(194, 233);
            stocLabel.Name = "stocLabel";
            stocLabel.Size = new System.Drawing.Size(60, 27);
            stocLabel.TabIndex = 9;
            stocLabel.Text = "Stoc:";
            // 
            // dulapLabel
            // 
            dulapLabel.AutoSize = true;
            dulapLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dulapLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dulapLabel.Location = new System.Drawing.Point(181, 305);
            dulapLabel.Name = "dulapLabel";
            dulapLabel.Size = new System.Drawing.Size(76, 27);
            dulapLabel.TabIndex = 12;
            dulapLabel.Text = "Dulap:";
            // 
            // raftLabel
            // 
            raftLabel.AutoSize = true;
            raftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            raftLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raftLabel.Location = new System.Drawing.Point(194, 369);
            raftLabel.Name = "raftLabel";
            raftLabel.Size = new System.Drawing.Size(60, 27);
            raftLabel.TabIndex = 14;
            raftLabel.Text = "Raft:";
            // 
            // cod_medicamentLabel
            // 
            cod_medicamentLabel.AutoSize = true;
            cod_medicamentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cod_medicamentLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_medicamentLabel.Location = new System.Drawing.Point(56, 82);
            cod_medicamentLabel.Name = "cod_medicamentLabel";
            cod_medicamentLabel.Size = new System.Drawing.Size(181, 27);
            cod_medicamentLabel.TabIndex = 16;
            cod_medicamentLabel.Text = "Cod medicament:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.detaliiToolStripMenuItem,
            this.finalizareToolStripMenuItem});
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
            // detaliiToolStripMenuItem
            // 
            this.detaliiToolStripMenuItem.Name = "detaliiToolStripMenuItem";
            this.detaliiToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.detaliiToolStripMenuItem.Text = "Detalii medicament";
            this.detaliiToolStripMenuItem.Click += new System.EventHandler(this.detaliiToolStripMenuItem_Click);
            // 
            // finalizareToolStripMenuItem
            // 
            this.finalizareToolStripMenuItem.Name = "finalizareToolStripMenuItem";
            this.finalizareToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.finalizareToolStripMenuItem.Text = "Confirmare rețetă";
            this.finalizareToolStripMenuItem.Click += new System.EventHandler(this.finalizareToolStripMenuItem_Click);
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "Medicament";
            this.medicamentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IstoricTableAdapter = null;
            this.tableAdapterManager.MedicamentTableAdapter = this.medicamentTableAdapter;
            this.tableAdapterManager.PacientTableAdapter = null;
            this.tableAdapterManager.RetetaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValabilitateTableAdapter = null;
            // 
            // denumire_comercialaTextBox
            // 
            this.denumire_comercialaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "Denumire_comerciala", true));
            this.denumire_comercialaTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumire_comercialaTextBox.Location = new System.Drawing.Point(271, 159);
            this.denumire_comercialaTextBox.Name = "denumire_comercialaTextBox";
            this.denumire_comercialaTextBox.Size = new System.Drawing.Size(570, 30);
            this.denumire_comercialaTextBox.TabIndex = 3;
            this.denumire_comercialaTextBox.TextChanged += new System.EventHandler(this.denumire_comercialaTextBox_TextChanged);
            // 
            // stocTextBox
            // 
            this.stocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "Stoc", true));
            this.stocTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocTextBox.Location = new System.Drawing.Point(271, 233);
            this.stocTextBox.Name = "stocTextBox";
            this.stocTextBox.Size = new System.Drawing.Size(170, 30);
            this.stocTextBox.TabIndex = 10;
            this.stocTextBox.TextChanged += new System.EventHandler(this.stocTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.medicamentBindingSource, "cod_medicament", true));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dulapTextBox
            // 
            this.dulapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "Dulap", true));
            this.dulapTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dulapTextBox.Location = new System.Drawing.Point(271, 305);
            this.dulapTextBox.Name = "dulapTextBox";
            this.dulapTextBox.Size = new System.Drawing.Size(170, 30);
            this.dulapTextBox.TabIndex = 13;
            this.dulapTextBox.TextChanged += new System.EventHandler(this.dulapTextBox_TextChanged);
            // 
            // raftTextBox
            // 
            this.raftTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "Raft", true));
            this.raftTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raftTextBox.Location = new System.Drawing.Point(271, 369);
            this.raftTextBox.Name = "raftTextBox";
            this.raftTextBox.Size = new System.Drawing.Size(170, 30);
            this.raftTextBox.TabIndex = 15;
            this.raftTextBox.TextChanged += new System.EventHandler(this.raftTextBox_TextChanged);
            // 
            // cod_medicamentTextBox
            // 
            this.cod_medicamentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "cod_medicament", true));
            this.cod_medicamentTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_medicamentTextBox.Location = new System.Drawing.Point(252, 79);
            this.cod_medicamentTextBox.Name = "cod_medicamentTextBox";
            this.cod_medicamentTextBox.Size = new System.Drawing.Size(238, 34);
            this.cod_medicamentTextBox.TabIndex = 17;
            this.cod_medicamentTextBox.TextChanged += new System.EventHandler(this.cod_medicamentTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Caută";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(633, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(633, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(633, 369);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 484);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(cod_medicamentLabel);
            this.Controls.Add(this.cod_medicamentTextBox);
            this.Controls.Add(raftLabel);
            this.Controls.Add(this.raftTextBox);
            this.Controls.Add(dulapLabel);
            this.Controls.Add(this.dulapTextBox);
            this.Controls.Add(stocLabel);
            this.Controls.Add(this.stocTextBox);
            this.Controls.Add(denumire_comercialaLabel);
            this.Controls.Add(this.denumire_comercialaTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private PharmacyDataSetTableAdapters.MedicamentTableAdapter medicamentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox denumire_comercialaTextBox;
        private System.Windows.Forms.TextBox stocTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox dulapTextBox;
        private System.Windows.Forms.TextBox raftTextBox;
        private System.Windows.Forms.TextBox cod_medicamentTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem detaliiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizareToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}