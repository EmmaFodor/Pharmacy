namespace Farmacie
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.asistentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Farmacie.PharmacyDataSet();
            this.asistentTableAdapter = new Farmacie.PharmacyDataSetTableAdapters.AsistentTableAdapter();
            this.tableAdapterManager = new Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.nume_utilizatorTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.circularButton3 = new Farmacie.CircularButton();
            this.circularButton2 = new Farmacie.CircularButton();
            this.circularButton1 = new Farmacie.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(719, 550);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accesează";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.asistentBindingSource, "nume_utilizator", true));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1330, 756);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // asistentBindingSource
            // 
            this.asistentBindingSource.DataMember = "Asistent";
            this.asistentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistentTableAdapter
            // 
            this.asistentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistentTableAdapter = this.asistentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.IstoricTableAdapter = null;
            this.tableAdapterManager.MedicamentTableAdapter = null;
            this.tableAdapterManager.PacientTableAdapter = null;
            this.tableAdapterManager.RetetaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Farmacie.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ValabilitateTableAdapter = null;
            // 
            // nume_utilizatorTextBox
            // 
            this.nume_utilizatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asistentBindingSource, "nume_utilizator", true));
            this.nume_utilizatorTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume_utilizatorTextBox.Location = new System.Drawing.Point(458, 284);
            this.nume_utilizatorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nume_utilizatorTextBox.Name = "nume_utilizatorTextBox";
            this.nume_utilizatorTextBox.Size = new System.Drawing.Size(428, 50);
            this.nume_utilizatorTextBox.TabIndex = 6;
            this.nume_utilizatorTextBox.TextChanged += new System.EventHandler(this.nume_utilizatorTextBox_TextChanged);
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asistentBindingSource, "Parola", true));
            this.parolaTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaTextBox.Location = new System.Drawing.Point(458, 412);
            this.parolaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(436, 50);
            this.parolaTextBox.TabIndex = 8;
            this.parolaTextBox.TextChanged += new System.EventHandler(this.parolaTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nume:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parola:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(156, 550);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(399, 95);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // circularButton3
            // 
            this.circularButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circularButton3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton3.Location = new System.Drawing.Point(180, 175);
            this.circularButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(268, 262);
            this.circularButton3.TabIndex = 4;
            this.circularButton3.Text = "Angajat";
            this.circularButton3.UseVisualStyleBackColor = false;
            this.circularButton3.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.circularButton2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton2.Location = new System.Drawing.Point(897, 175);
            this.circularButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(268, 262);
            this.circularButton2.TabIndex = 3;
            this.circularButton2.Text = "Director";
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // circularButton1
            // 
            this.circularButton1.Location = new System.Drawing.Point(-28, -30);
            this.circularButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(112, 36);
            this.circularButton1.TabIndex = 2;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 756);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.nume_utilizatorTextBox);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton circularButton1;
        private CircularButton circularButton2;
        private CircularButton circularButton3;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource asistentBindingSource;
        private PharmacyDataSetTableAdapters.AsistentTableAdapter asistentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nume_utilizatorTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}