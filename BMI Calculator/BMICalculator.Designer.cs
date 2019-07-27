namespace BMI_Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NumbersTable = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.RadioTable = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResultTable = new System.Windows.Forms.TableLayoutPanel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.KeyPadTable = new System.Windows.Forms.TableLayoutPanel();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.KeyPadAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.ResultMessageLabel = new System.Windows.Forms.Label();
            this.BMIResultTimer = new System.Windows.Forms.Timer(this.components);
            this.NumbersTable.SuspendLayout();
            this.RadioTable.SuspendLayout();
            this.ResultTable.SuspendLayout();
            this.KeyPadTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumbersTable
            // 
            this.NumbersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NumbersTable.AutoSize = true;
            this.NumbersTable.ColumnCount = 3;
            this.NumbersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumbersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.NumbersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumbersTable.Controls.Add(this.HeightLabel, 0, 1);
            this.NumbersTable.Controls.Add(this.WeightUnitLabel, 2, 0);
            this.NumbersTable.Controls.Add(this.WeightTextBox, 1, 0);
            this.NumbersTable.Controls.Add(this.HeightUnitLabel, 2, 1);
            this.NumbersTable.Controls.Add(this.WeightLabel, 0, 0);
            this.NumbersTable.Controls.Add(this.HeightTextBox, 1, 1);
            this.NumbersTable.Location = new System.Drawing.Point(-3, 1);
            this.NumbersTable.Name = "NumbersTable";
            this.NumbersTable.RowCount = 2;
            this.NumbersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumbersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumbersTable.Size = new System.Drawing.Size(310, 110);
            this.NumbersTable.TabIndex = 0;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 55);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(149, 55);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightUnitLabel.BackColor = System.Drawing.Color.Khaki;
            this.WeightUnitLabel.Location = new System.Drawing.Point(251, 0);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(56, 55);
            this.WeightUnitLabel.TabIndex = 3;
            this.WeightUnitLabel.Text = "kg";
            this.WeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(158, 5);
            this.WeightTextBox.MaxLength = 5;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.ReadOnly = true;
            this.WeightTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WeightTextBox.Size = new System.Drawing.Size(87, 45);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.TabStop = false;
            this.WeightTextBox.Text = "0";
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WeightTextBox.Click += new System.EventHandler(this.ActiveTextBox_Click);
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightUnitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeightUnitLabel.Location = new System.Drawing.Point(251, 55);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(56, 55);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "m";
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.Khaki;
            this.WeightLabel.Location = new System.Drawing.Point(3, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(149, 55);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(158, 60);
            this.HeightTextBox.MaxLength = 5;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ReadOnly = true;
            this.HeightTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeightTextBox.Size = new System.Drawing.Size(87, 45);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TabStop = false;
            this.HeightTextBox.Text = "0";
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTextBox.Click += new System.EventHandler(this.ActiveTextBox_Click);
            // 
            // RadioTable
            // 
            this.RadioTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RadioTable.AutoSize = true;
            this.RadioTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RadioTable.ColumnCount = 1;
            this.RadioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RadioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RadioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RadioTable.Controls.Add(this.ImperialRadioButton, 0, 1);
            this.RadioTable.Controls.Add(this.MetricRadioButton, 0, 0);
            this.RadioTable.Location = new System.Drawing.Point(-3, 114);
            this.RadioTable.Name = "RadioTable";
            this.RadioTable.RowCount = 2;
            this.RadioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioTable.Size = new System.Drawing.Size(301, 109);
            this.RadioTable.TabIndex = 1;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.Location = new System.Drawing.Point(74, 57);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(152, 49);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(87, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(127, 48);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.AutoSize = true;
            this.CalculateBMIButton.BackColor = System.Drawing.Color.BurlyWood;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 3);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(292, 60);
            this.CalculateBMIButton.TabIndex = 2;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResultTable
            // 
            this.ResultTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ResultTable.AutoSize = true;
            this.ResultTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResultTable.ColumnCount = 1;
            this.ResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultTable.Controls.Add(this.ResultTextBox, 0, 1);
            this.ResultTable.Controls.Add(this.CalculateBMIButton, 0, 0);
            this.ResultTable.Location = new System.Drawing.Point(4, 226);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowCount = 2;
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ResultTable.Size = new System.Drawing.Size(298, 167);
            this.ResultTable.TabIndex = 3;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.Location = new System.Drawing.Point(3, 94);
            this.ResultTextBox.MaxLength = 5;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResultTextBox.Size = new System.Drawing.Size(292, 45);
            this.ResultTextBox.TabIndex = 6;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeyPadTable
            // 
            this.KeyPadTable.BackColor = System.Drawing.Color.OldLace;
            this.KeyPadTable.ColumnCount = 4;
            this.KeyPadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.Controls.Add(this.DecimalButton, 2, 3);
            this.KeyPadTable.Controls.Add(this.DoneButton, 3, 2);
            this.KeyPadTable.Controls.Add(this.ClearButton, 3, 1);
            this.KeyPadTable.Controls.Add(this.SixButton, 2, 1);
            this.KeyPadTable.Controls.Add(this.FourButton, 0, 1);
            this.KeyPadTable.Controls.Add(this.FiveButton, 1, 1);
            this.KeyPadTable.Controls.Add(this.EightButton, 1, 0);
            this.KeyPadTable.Controls.Add(this.SevenButton, 0, 0);
            this.KeyPadTable.Controls.Add(this.NineButton, 2, 0);
            this.KeyPadTable.Controls.Add(this.TwoButton, 1, 2);
            this.KeyPadTable.Controls.Add(this.ThreeButton, 2, 2);
            this.KeyPadTable.Controls.Add(this.OneButton, 0, 2);
            this.KeyPadTable.Controls.Add(this.ZeroButton, 0, 3);
            this.KeyPadTable.Controls.Add(this.BackspaceButton, 3, 0);
            this.KeyPadTable.Location = new System.Drawing.Point(6, 468);
            this.KeyPadTable.Name = "KeyPadTable";
            this.KeyPadTable.RowCount = 4;
            this.KeyPadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.KeyPadTable.Size = new System.Drawing.Size(295, 284);
            this.KeyPadTable.TabIndex = 4;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DecimalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DecimalButton.Location = new System.Drawing.Point(152, 223);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(60, 50);
            this.DecimalButton.TabIndex = 27;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoneButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.Black;
            this.DoneButton.Location = new System.Drawing.Point(227, 151);
            this.DoneButton.Name = "DoneButton";
            this.KeyPadTable.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(60, 123);
            this.DoneButton.TabIndex = 26;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(227, 81);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(60, 50);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SixButton.Location = new System.Drawing.Point(152, 81);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(60, 50);
            this.SixButton.TabIndex = 20;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FourButton.Location = new System.Drawing.Point(6, 81);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(60, 50);
            this.FourButton.TabIndex = 19;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FiveButton.Location = new System.Drawing.Point(79, 81);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(60, 50);
            this.FiveButton.TabIndex = 18;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EightButton.Location = new System.Drawing.Point(79, 10);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(60, 50);
            this.EightButton.TabIndex = 17;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SevenButton.Location = new System.Drawing.Point(6, 10);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(60, 50);
            this.SevenButton.TabIndex = 16;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NineButton.Location = new System.Drawing.Point(152, 10);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(60, 50);
            this.NineButton.TabIndex = 15;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TwoButton.Location = new System.Drawing.Point(79, 152);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(60, 50);
            this.TwoButton.TabIndex = 21;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ThreeButton.Location = new System.Drawing.Point(152, 152);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(60, 50);
            this.ThreeButton.TabIndex = 22;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OneButton.Location = new System.Drawing.Point(6, 152);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(60, 50);
            this.OneButton.TabIndex = 23;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KeyPadTable.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Location = new System.Drawing.Point(8, 223);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(130, 50);
            this.ZeroButton.TabIndex = 24;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackspaceButton.Image = ((System.Drawing.Image)(resources.GetObject("BackspaceButton.Image")));
            this.BackspaceButton.Location = new System.Drawing.Point(227, 10);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(60, 50);
            this.BackspaceButton.TabIndex = 14;
            this.BackspaceButton.Tag = "back";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.KeyPadButton_Click);
            // 
            // KeyPadAnimationTimer
            // 
            this.KeyPadAnimationTimer.Interval = 16;
            this.KeyPadAnimationTimer.Tick += new System.EventHandler(this.KeyPadAnimationTimer_Tick);
            // 
            // ResultMessageLabel
            // 
            this.ResultMessageLabel.AutoSize = true;
            this.ResultMessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResultMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultMessageLabel.Location = new System.Drawing.Point(77, 208);
            this.ResultMessageLabel.Name = "ResultMessageLabel";
            this.ResultMessageLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultMessageLabel.TabIndex = 5;
            this.ResultMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIResultTimer
            // 
            this.BMIResultTimer.Interval = 3000;
            this.BMIResultTimer.Tick += new System.EventHandler(this.BMIResultTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 753);
            this.Controls.Add(this.ResultMessageLabel);
            this.Controls.Add(this.KeyPadTable);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.RadioTable);
            this.Controls.Add(this.NumbersTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NumbersTable.ResumeLayout(false);
            this.NumbersTable.PerformLayout();
            this.RadioTable.ResumeLayout(false);
            this.RadioTable.PerformLayout();
            this.ResultTable.ResumeLayout(false);
            this.ResultTable.PerformLayout();
            this.KeyPadTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NumbersTable;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.TableLayoutPanel RadioTable;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TableLayoutPanel ResultTable;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TableLayoutPanel KeyPadTable;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Timer KeyPadAnimationTimer;
        private System.Windows.Forms.Label ResultMessageLabel;
        private System.Windows.Forms.Timer BMIResultTimer;
    }
}

