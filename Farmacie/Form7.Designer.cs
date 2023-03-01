namespace Farmacie
{
    partial class Form7
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
            System.Windows.Forms.Label cod_medicamentLabel;
            System.Windows.Forms.Label stocLabel;
            System.Windows.Forms.Label dulapLabel;
            System.Windows.Forms.Label raftLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Farmacie.PharmacyDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.medicamentTableAdapter = new Farmacie.PharmacyDataSetTableAdapters.MedicamentTableAdapter();
            this.tableAdapterManager = new Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.cod_medicamentTextBox = new System.Windows.Forms.TextBox();
            this.stocTextBox = new System.Windows.Forms.TextBox();
            this.dulapTextBox = new System.Windows.Forms.TextBox();
            this.raftTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            cod_medicamentLabel = new System.Windows.Forms.Label();
            stocLabel = new System.Windows.Forms.Label();
            dulapLabel = new System.Windows.Forms.Label();
            raftLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_medicamentLabel
            // 
            cod_medicamentLabel.AutoSize = true;
            cod_medicamentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cod_medicamentLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_medicamentLabel.Location = new System.Drawing.Point(248, 165);
            cod_medicamentLabel.Name = "cod_medicamentLabel";
            cod_medicamentLabel.Size = new System.Drawing.Size(58, 27);
            cod_medicamentLabel.TabIndex = 4;
            cod_medicamentLabel.Text = "Cod:";
            cod_medicamentLabel.Click += new System.EventHandler(this.cod_medicamentLabel_Click);
            // 
            // stocLabel
            // 
            stocLabel.AutoSize = true;
            stocLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            stocLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stocLabel.Location = new System.Drawing.Point(248, 224);
            stocLabel.Name = "stocLabel";
            stocLabel.Size = new System.Drawing.Size(60, 27);
            stocLabel.TabIndex = 6;
            stocLabel.Text = "Stoc:";
            // 
            // dulapLabel
            // 
            dulapLabel.AutoSize = true;
            dulapLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dulapLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dulapLabel.Location = new System.Drawing.Point(232, 288);
            dulapLabel.Name = "dulapLabel";
            dulapLabel.Size = new System.Drawing.Size(76, 27);
            dulapLabel.TabIndex = 8;
            dulapLabel.Text = "Dulap:";
            // 
            // raftLabel
            // 
            raftLabel.AutoSize = true;
            raftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            raftLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raftLabel.Location = new System.Drawing.Point(248, 355);
            raftLabel.Name = "raftLabel";
            raftLabel.Size = new System.Drawing.Size(60, 27);
            raftLabel.TabIndex = 10;
            raftLabel.Text = "Raft:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem,
            this.detaliiToolStripMenuItem,
            this.confirmareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.inapoiToolStripMenuItem.Text = "Înapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // detaliiToolStripMenuItem
            // 
            this.detaliiToolStripMenuItem.Name = "detaliiToolStripMenuItem";
            this.detaliiToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.detaliiToolStripMenuItem.Text = "Detalii";
            this.detaliiToolStripMenuItem.Click += new System.EventHandler(this.detaliiToolStripMenuItem_Click);
            // 
            // confirmareToolStripMenuItem
            // 
            this.confirmareToolStripMenuItem.Name = "confirmareToolStripMenuItem";
            this.confirmareToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.confirmareToolStripMenuItem.Text = "Confirmare";
            this.confirmareToolStripMenuItem.Click += new System.EventHandler(this.confirmareToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.medicamentBindingSource, "Stoc", true));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "Medicament";
            this.medicamentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicament";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AERIUS 5mg",
            "ASPENTER 100 mg",
            "ASPIRIN 500mg",
            "BRUFEN 400 mg",
            "COLDREX LEMON",
            "COLEBIL",
            "DEBRIDAT 100 mg",
            "EUTHYROX 25mg",
            "FARINGOSEPT FRUCTE DE PADURE",
            "FERVEX RACEALA SI GRIPA 500 mg/4 mg",
            "FLUIMUCIL 300 mg/3 ml",
            "GLUCOZA 200 mg/ml",
            "IBUFEN 200 mg",
            "IBUTIN® 300 mg",
            "MAGNE B6",
            "NO-SPA FORTE 80 mg",
            "NUROFEN 200 mg",
            "NUROFEN GEL",
            "PADUDEN RAPID FORTE 400 mg",
            "PANADOL BABY 120 mg/5 ml",
            "PARACETAMOL 500 mg",
            "PARASINUS",
            "PIAFEN",
            "RANITIDINA 150 mg",
            "REUPROFEN 400 mg",
            "STREPSILS INTENSIV PORTOCALE FARA ZAHAR 8,75 mg",
            "SUPOZITOARE CU GLICERINA PT. ADULTI ",
            "TANTUM VERDE CU AROMA DE MENTA 3 mg",
            "THERAFLU EXTRA RACEALA SI GRIPA 650 mg/20 mg/10 mg",
            "VITAMINA C ARENA 750 mg",
            "VITAMINA E 100 mg",
            "VOLTAREN FORTE 23,2 mg/g"});
            this.comboBox1.Location = new System.Drawing.Point(242, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(405, 34);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // cod_medicamentTextBox
            // 
            this.cod_medicamentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "cod_medicament", true));
            this.cod_medicamentTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_medicamentTextBox.Location = new System.Drawing.Point(324, 165);
            this.cod_medicamentTextBox.Name = "cod_medicamentTextBox";
            this.cod_medicamentTextBox.Size = new System.Drawing.Size(206, 30);
            this.cod_medicamentTextBox.TabIndex = 5;
            this.cod_medicamentTextBox.TextChanged += new System.EventHandler(this.cod_medicamentTextBox_TextChanged);
            // 
            // stocTextBox
            // 
            this.stocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "Stoc", true));
            this.stocTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocTextBox.Location = new System.Drawing.Point(324, 224);
            this.stocTextBox.Name = "stocTextBox";
            this.stocTextBox.Size = new System.Drawing.Size(206, 30);
            this.stocTextBox.TabIndex = 7;
            this.stocTextBox.TextChanged += new System.EventHandler(this.stocTextBox_TextChanged);
            // 
            // dulapTextBox
            // 
            this.dulapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "Dulap", true));
            this.dulapTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dulapTextBox.Location = new System.Drawing.Point(324, 288);
            this.dulapTextBox.Name = "dulapTextBox";
            this.dulapTextBox.Size = new System.Drawing.Size(206, 30);
            this.dulapTextBox.TabIndex = 9;
            this.dulapTextBox.TextChanged += new System.EventHandler(this.dulapTextBox_TextChanged);
            // 
            // raftTextBox
            // 
            this.raftTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentBindingSource, "Raft", true));
            this.raftTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raftTextBox.Location = new System.Drawing.Point(324, 355);
            this.raftTextBox.Name = "raftTextBox";
            this.raftTextBox.Size = new System.Drawing.Size(206, 30);
            this.raftTextBox.TabIndex = 11;
            this.raftTextBox.TextChanged += new System.EventHandler(this.raftTextBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(668, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(668, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(683, 264);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 484);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(raftLabel);
            this.Controls.Add(this.raftTextBox);
            this.Controls.Add(dulapLabel);
            this.Controls.Add(this.dulapTextBox);
            this.Controls.Add(stocLabel);
            this.Controls.Add(this.stocTextBox);
            this.Controls.Add(cod_medicamentLabel);
            this.Controls.Add(this.cod_medicamentTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private PharmacyDataSetTableAdapters.MedicamentTableAdapter medicamentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_medicamentTextBox;
        private System.Windows.Forms.TextBox stocTextBox;
        private System.Windows.Forms.TextBox dulapTextBox;
        private System.Windows.Forms.TextBox raftTextBox;
        private System.Windows.Forms.ToolStripMenuItem confirmareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaliiToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}