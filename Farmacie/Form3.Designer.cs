namespace Farmacie
{
    partial class Form3
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
            System.Windows.Forms.Label cnpLabel;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label orasLabel;
            System.Windows.Forms.Label cod_retetaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faraRetetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaPaginaPrincipalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Farmacie.PharmacyDataSet();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.orasTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cod_retetaTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pacientTableAdapter = new Farmacie.PharmacyDataSetTableAdapters.PacientTableAdapter();
            this.tableAdapterManager = new Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager();
            cnpLabel = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            orasLabel = new System.Windows.Forms.Label();
            cod_retetaLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cnpLabel
            // 
            cnpLabel.AutoSize = true;
            cnpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cnpLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cnpLabel.Location = new System.Drawing.Point(72, 90);
            cnpLabel.Name = "cnpLabel";
            cnpLabel.Size = new System.Drawing.Size(65, 27);
            cnpLabel.TabIndex = 2;
            cnpLabel.Text = "CNP:";
            cnpLabel.Click += new System.EventHandler(this.cnpLabel_Click);
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            numeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeLabel.Location = new System.Drawing.Point(232, 155);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(76, 27);
            numeLabel.TabIndex = 4;
            numeLabel.Text = "Nume:";
            numeLabel.Click += new System.EventHandler(this.numeLabel_Click);
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            prenumeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenumeLabel.Location = new System.Drawing.Point(204, 207);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(104, 27);
            prenumeLabel.TabIndex = 6;
            prenumeLabel.Text = "Prenume:";
            prenumeLabel.Click += new System.EventHandler(this.prenumeLabel_Click);
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            telefonLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonLabel.Location = new System.Drawing.Point(218, 264);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(90, 27);
            telefonLabel.TabIndex = 8;
            telefonLabel.Text = "Telefon:";
            telefonLabel.Click += new System.EventHandler(this.telefonLabel_Click);
            // 
            // orasLabel
            // 
            orasLabel.AutoSize = true;
            orasLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            orasLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orasLabel.Location = new System.Drawing.Point(245, 315);
            orasLabel.Name = "orasLabel";
            orasLabel.Size = new System.Drawing.Size(63, 27);
            orasLabel.TabIndex = 10;
            orasLabel.Text = "Oraș:";
            orasLabel.Click += new System.EventHandler(this.orasLabel_Click);
            // 
            // cod_retetaLabel
            // 
            cod_retetaLabel.AutoSize = true;
            cod_retetaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            cod_retetaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_retetaLabel.Location = new System.Drawing.Point(227, 363);
            cod_retetaLabel.Name = "cod_retetaLabel";
            cod_retetaLabel.Size = new System.Drawing.Size(81, 27);
            cod_retetaLabel.TabIndex = 12;
            cod_retetaLabel.Text = "Rețetă:";
            cod_retetaLabel.Click += new System.EventHandler(this.cod_retetaLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientToolStripMenuItem,
            this.faraRetetaToolStripMenuItem,
            this.istoricToolStripMenuItem,
            this.stocToolStripMenuItem,
            this.inapoiLaPaginaPrincipalaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pacientToolStripMenuItem
            // 
            this.pacientToolStripMenuItem.Name = "pacientToolStripMenuItem";
            this.pacientToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.pacientToolStripMenuItem.Text = "Rețetă";
            this.pacientToolStripMenuItem.Click += new System.EventHandler(this.pacientToolStripMenuItem_Click);
            // 
            // faraRetetaToolStripMenuItem
            // 
            this.faraRetetaToolStripMenuItem.Name = "faraRetetaToolStripMenuItem";
            this.faraRetetaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.faraRetetaToolStripMenuItem.Text = "Fără rețetă";
            this.faraRetetaToolStripMenuItem.Click += new System.EventHandler(this.faraRetetaToolStripMenuItem_Click);
            // 
            // istoricToolStripMenuItem
            // 
            this.istoricToolStripMenuItem.Name = "istoricToolStripMenuItem";
            this.istoricToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.istoricToolStripMenuItem.Text = "Istoric";
            this.istoricToolStripMenuItem.Click += new System.EventHandler(this.istoricToolStripMenuItem_Click);
            // 
            // stocToolStripMenuItem
            // 
            this.stocToolStripMenuItem.Name = "stocToolStripMenuItem";
            this.stocToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.stocToolStripMenuItem.Text = "Stoc";
            this.stocToolStripMenuItem.Click += new System.EventHandler(this.stocToolStripMenuItem_Click);
            // 
            // inapoiLaPaginaPrincipalaToolStripMenuItem
            // 
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Name = "inapoiLaPaginaPrincipalaToolStripMenuItem";
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Text = "Înapoi la pagina principală";
            this.inapoiLaPaginaPrincipalaToolStripMenuItem.Click += new System.EventHandler(this.inapoiLaPaginaPrincipalaToolStripMenuItem_Click);
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "cnp", true));
            this.cnpTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpTextBox.Location = new System.Drawing.Point(158, 87);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(303, 34);
            this.cnpTextBox.TabIndex = 3;
            this.cnpTextBox.TextChanged += new System.EventHandler(this.cnpTextBox_TextChanged);
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataMember = "Pacient";
            this.pacientBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numeTextBox
            // 
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "nume", true));
            this.numeTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeTextBox.Location = new System.Drawing.Point(320, 152);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(242, 34);
            this.numeTextBox.TabIndex = 5;
            this.numeTextBox.TextChanged += new System.EventHandler(this.numeTextBox_TextChanged);
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "prenume", true));
            this.prenumeTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenumeTextBox.Location = new System.Drawing.Point(320, 204);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(242, 34);
            this.prenumeTextBox.TabIndex = 7;
            this.prenumeTextBox.TextChanged += new System.EventHandler(this.prenumeTextBox_TextChanged);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "telefon", true));
            this.telefonTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonTextBox.Location = new System.Drawing.Point(320, 261);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(242, 34);
            this.telefonTextBox.TabIndex = 9;
            this.telefonTextBox.TextChanged += new System.EventHandler(this.telefonTextBox_TextChanged);
            // 
            // orasTextBox
            // 
            this.orasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "oras", true));
            this.orasTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orasTextBox.Location = new System.Drawing.Point(320, 315);
            this.orasTextBox.Name = "orasTextBox";
            this.orasTextBox.Size = new System.Drawing.Size(242, 30);
            this.orasTextBox.TabIndex = 11;
            this.orasTextBox.TextChanged += new System.EventHandler(this.orasTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(487, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Caută";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cod_retetaTextBox
            // 
            this.cod_retetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientBindingSource, "cod_reteta", true));
            this.cod_retetaTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_retetaTextBox.Location = new System.Drawing.Point(320, 363);
            this.cod_retetaTextBox.Name = "cod_retetaTextBox";
            this.cod_retetaTextBox.Size = new System.Drawing.Size(242, 30);
            this.cod_retetaTextBox.TabIndex = 13;
            this.cod_retetaTextBox.TextChanged += new System.EventHandler(this.cod_retetaTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(669, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Șterge";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(735, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 30);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "5";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Transparent;
            this.textBox2.Location = new System.Drawing.Point(735, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 30);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pacientTableAdapter
            // 
            this.pacientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IstoricTableAdapter = null;
            this.tableAdapterManager.MedicamentTableAdapter = null;
            this.tableAdapterManager.PacientTableAdapter = this.pacientTableAdapter;
            this.tableAdapterManager.RetetaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValabilitateTableAdapter = null;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 484);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(cod_retetaLabel);
            this.Controls.Add(this.cod_retetaTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(orasLabel);
            this.Controls.Add(this.orasTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(prenumeLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(cnpLabel);
            this.Controls.Add(this.cnpTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaPaginaPrincipalaToolStripMenuItem;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private PharmacyDataSetTableAdapters.PacientTableAdapter pacientTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox orasTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cod_retetaTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem faraRetetaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem stocToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}