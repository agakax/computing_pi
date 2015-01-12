namespace Pi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelComputing = new System.Windows.Forms.Label();
            this.pictureFormula = new System.Windows.Forms.PictureBox();
            this.numericUpDownP = new System.Windows.Forms.NumericUpDown();
            this.labelP = new System.Windows.Forms.Label();
            this.numericUpDownThreads = new System.Windows.Forms.NumericUpDown();
            this.labelThreads = new System.Windows.Forms.Label();
            this.buttonAsm = new System.Windows.Forms.Button();
            this.labelTimeAsm = new System.Windows.Forms.Label();
            this.textBoxTimeAsm = new System.Windows.Forms.TextBox();
            this.buttonCpp = new System.Windows.Forms.Button();
            this.labelTimeCpp = new System.Windows.Forms.Label();
            this.textBoxTimeCpp = new System.Windows.Forms.TextBox();
            this.labelPi = new System.Windows.Forms.Label();
            this.richTextBoxPi = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialogPi = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // labelComputing
            // 
            this.labelComputing.AutoSize = true;
            this.labelComputing.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputing.Location = new System.Drawing.Point(45, 26);
            this.labelComputing.Name = "labelComputing";
            this.labelComputing.Size = new System.Drawing.Size(346, 26);
            this.labelComputing.TabIndex = 16;
            this.labelComputing.Text = "Obliczanie π za pomocą wzoru Leibniza";
            this.labelComputing.Click += new System.EventHandler(this.labelComputing_Click);
            // 
            // pictureFormula
            // 
            this.pictureFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureFormula.Image")));
            this.pictureFormula.Location = new System.Drawing.Point(51, 62);
            this.pictureFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureFormula.Name = "pictureFormula";
            this.pictureFormula.Size = new System.Drawing.Size(188, 71);
            this.pictureFormula.TabIndex = 17;
            this.pictureFormula.TabStop = false;
            this.pictureFormula.Click += new System.EventHandler(this.pictureFormula_Click);
            // 
            // numericUpDownP
            // 
            this.numericUpDownP.Location = new System.Drawing.Point(51, 140);
            this.numericUpDownP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownP.Name = "numericUpDownP";
            this.numericUpDownP.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownP.TabIndex = 18;
            this.numericUpDownP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownP.ValueChanged += new System.EventHandler(this.numericUpDownP_ValueChanged);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.Location = new System.Drawing.Point(197, 139);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(69, 18);
            this.labelP.TabIndex = 19;
            this.labelP.Text = "Wartość p";
            this.labelP.Click += new System.EventHandler(this.labelP_Click);
            // 
            // numericUpDownThreads
            // 
            this.numericUpDownThreads.Location = new System.Drawing.Point(51, 172);
            this.numericUpDownThreads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownThreads.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreads.Name = "numericUpDownThreads";
            this.numericUpDownThreads.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownThreads.TabIndex = 20;
            this.numericUpDownThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownThreads.ValueChanged += new System.EventHandler(this.numericUpDownThreads_ValueChanged);
            // 
            // labelThreads
            // 
            this.labelThreads.AutoSize = true;
            this.labelThreads.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThreads.Location = new System.Drawing.Point(197, 171);
            this.labelThreads.Name = "labelThreads";
            this.labelThreads.Size = new System.Drawing.Size(101, 18);
            this.labelThreads.TabIndex = 21;
            this.labelThreads.Text = "Liczba wątków";
            this.labelThreads.Click += new System.EventHandler(this.labelThreads_Click);
            // 
            // buttonAsm
            // 
            this.buttonAsm.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsm.Location = new System.Drawing.Point(50, 204);
            this.buttonAsm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAsm.Name = "buttonAsm";
            this.buttonAsm.Size = new System.Drawing.Size(87, 41);
            this.buttonAsm.TabIndex = 22;
            this.buttonAsm.Text = "Asm";
            this.buttonAsm.UseVisualStyleBackColor = true;
            this.buttonAsm.Click += new System.EventHandler(this.buttonAsm_Click);
            // 
            // labelTimeAsm
            // 
            this.labelTimeAsm.AutoSize = true;
            this.labelTimeAsm.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeAsm.Location = new System.Drawing.Point(149, 215);
            this.labelTimeAsm.Name = "labelTimeAsm";
            this.labelTimeAsm.Size = new System.Drawing.Size(40, 18);
            this.labelTimeAsm.TabIndex = 23;
            this.labelTimeAsm.Text = "Czas:";
            this.labelTimeAsm.Click += new System.EventHandler(this.labelTimeAsm_Click);
            // 
            // textBoxTimeAsm
            // 
            this.textBoxTimeAsm.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTimeAsm.Enabled = false;
            this.textBoxTimeAsm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxTimeAsm.Location = new System.Drawing.Point(201, 213);
            this.textBoxTimeAsm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTimeAsm.Name = "textBoxTimeAsm";
            this.textBoxTimeAsm.Size = new System.Drawing.Size(116, 22);
            this.textBoxTimeAsm.TabIndex = 24;
            this.textBoxTimeAsm.TextChanged += new System.EventHandler(this.textBoxTimeAsm_TextChanged);
            // 
            // buttonCpp
            // 
            this.buttonCpp.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCpp.Location = new System.Drawing.Point(50, 252);
            this.buttonCpp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCpp.Name = "buttonCpp";
            this.buttonCpp.Size = new System.Drawing.Size(87, 38);
            this.buttonCpp.TabIndex = 25;
            this.buttonCpp.Text = "Cpp";
            this.buttonCpp.UseVisualStyleBackColor = true;
            this.buttonCpp.Click += new System.EventHandler(this.buttonCpp_Click);
            // 
            // labelTimeCpp
            // 
            this.labelTimeCpp.AutoSize = true;
            this.labelTimeCpp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeCpp.Location = new System.Drawing.Point(149, 262);
            this.labelTimeCpp.Name = "labelTimeCpp";
            this.labelTimeCpp.Size = new System.Drawing.Size(40, 18);
            this.labelTimeCpp.TabIndex = 26;
            this.labelTimeCpp.Text = "Czas:";
            this.labelTimeCpp.Click += new System.EventHandler(this.labelTimeCpp_Click);
            // 
            // textBoxTimeCpp
            // 
            this.textBoxTimeCpp.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTimeCpp.Enabled = false;
            this.textBoxTimeCpp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxTimeCpp.Location = new System.Drawing.Point(201, 260);
            this.textBoxTimeCpp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTimeCpp.Name = "textBoxTimeCpp";
            this.textBoxTimeCpp.Size = new System.Drawing.Size(116, 22);
            this.textBoxTimeCpp.TabIndex = 27;
            this.textBoxTimeCpp.TextChanged += new System.EventHandler(this.textBoxTimeCpp_TextChanged);
            // 
            // labelPi
            // 
            this.labelPi.AutoSize = true;
            this.labelPi.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPi.Location = new System.Drawing.Point(48, 294);
            this.labelPi.Name = "labelPi";
            this.labelPi.Size = new System.Drawing.Size(23, 18);
            this.labelPi.TabIndex = 28;
            this.labelPi.Text = "Pi:";
            this.labelPi.Click += new System.EventHandler(this.labelPi_Click);
            // 
            // richTextBoxPi
            // 
            this.richTextBoxPi.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxPi.Enabled = false;
            this.richTextBoxPi.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPi.Location = new System.Drawing.Point(51, 320);
            this.richTextBoxPi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxPi.Name = "richTextBoxPi";
            this.richTextBoxPi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxPi.Size = new System.Drawing.Size(409, 164);
            this.richTextBoxPi.TabIndex = 29;
            this.richTextBoxPi.Text = "";
            this.richTextBoxPi.TextChanged += new System.EventHandler(this.richTextBoxPi_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(296, 492);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 41);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Zapisz π do pliku";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveFileDialogPi
            // 
            this.saveFileDialogPi.FileName = "pi.txt";
            this.saveFileDialogPi.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogPi_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 574);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxPi);
            this.Controls.Add(this.labelPi);
            this.Controls.Add(this.textBoxTimeCpp);
            this.Controls.Add(this.labelTimeCpp);
            this.Controls.Add(this.buttonCpp);
            this.Controls.Add(this.textBoxTimeAsm);
            this.Controls.Add(this.labelTimeAsm);
            this.Controls.Add(this.buttonAsm);
            this.Controls.Add(this.labelThreads);
            this.Controls.Add(this.numericUpDownThreads);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.numericUpDownP);
            this.Controls.Add(this.pictureFormula);
            this.Controls.Add(this.labelComputing);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Obliczanie π";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComputing;
        private System.Windows.Forms.PictureBox pictureFormula;
        private System.Windows.Forms.NumericUpDown numericUpDownP;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.NumericUpDown numericUpDownThreads;
        private System.Windows.Forms.Label labelThreads;
        private System.Windows.Forms.Button buttonAsm;
        private System.Windows.Forms.Label labelTimeAsm;
        private System.Windows.Forms.TextBox textBoxTimeAsm;
        private System.Windows.Forms.Button buttonCpp;
        private System.Windows.Forms.Label labelTimeCpp;
        private System.Windows.Forms.TextBox textBoxTimeCpp;
        private System.Windows.Forms.Label labelPi;
        private System.Windows.Forms.RichTextBox richTextBoxPi;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPi;
    }
}

