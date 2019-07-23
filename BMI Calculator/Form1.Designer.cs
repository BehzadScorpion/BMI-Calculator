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
            this.NumbersTable = new System.Windows.Forms.TableLayoutPanel();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.RadioTable = new System.Windows.Forms.TableLayoutPanel();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultTable = new System.Windows.Forms.TableLayoutPanel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.NumbersTable.SuspendLayout();
            this.RadioTable.SuspendLayout();
            this.ResultTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumbersTable
            // 
            this.NumbersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumbersTable.AutoSize = true;
            this.NumbersTable.ColumnCount = 3;
            this.NumbersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumbersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.NumbersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumbersTable.Controls.Add(this.HeightBox, 1, 1);
            this.NumbersTable.Controls.Add(this.HeightLabel, 0, 1);
            this.NumbersTable.Controls.Add(this.WeightUnitLabel, 2, 0);
            this.NumbersTable.Controls.Add(this.WeightLabel, 0, 0);
            this.NumbersTable.Controls.Add(this.WeightBox, 1, 0);
            this.NumbersTable.Controls.Add(this.HeightUnitLabel, 2, 1);
            this.NumbersTable.Location = new System.Drawing.Point(0, 27);
            this.NumbersTable.Name = "NumbersTable";
            this.NumbersTable.RowCount = 2;
            this.NumbersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumbersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NumbersTable.Size = new System.Drawing.Size(301, 109);
            this.NumbersTable.TabIndex = 0;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.Beige;
            this.WeightLabel.Location = new System.Drawing.Point(3, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(144, 54);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 54);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(144, 55);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightBox
            // 
            this.WeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightBox.Location = new System.Drawing.Point(153, 3);
            this.WeightBox.MaxLength = 5;
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WeightBox.Size = new System.Drawing.Size(84, 45);
            this.WeightBox.TabIndex = 2;
            this.WeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightUnitLabel.BackColor = System.Drawing.Color.Beige;
            this.WeightUnitLabel.Location = new System.Drawing.Point(243, 0);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(55, 54);
            this.WeightUnitLabel.TabIndex = 3;
            this.WeightUnitLabel.Text = "kg";
            this.WeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightUnitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HeightUnitLabel.Location = new System.Drawing.Point(243, 54);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(55, 55);
            this.HeightUnitLabel.TabIndex = 4;
            this.HeightUnitLabel.Text = "m";
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightBox
            // 
            this.HeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightBox.Location = new System.Drawing.Point(153, 57);
            this.HeightBox.MaxLength = 5;
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeightBox.Size = new System.Drawing.Size(84, 45);
            this.HeightBox.TabIndex = 5;
            this.HeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RadioTable
            // 
            this.RadioTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioTable.AutoSize = true;
            this.RadioTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RadioTable.ColumnCount = 1;
            this.RadioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RadioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RadioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RadioTable.Controls.Add(this.ImperialRadioButton, 0, 1);
            this.RadioTable.Controls.Add(this.MetricRadioButton, 0, 0);
            this.RadioTable.Location = new System.Drawing.Point(0, 139);
            this.RadioTable.Name = "RadioTable";
            this.RadioTable.RowCount = 2;
            this.RadioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioTable.Size = new System.Drawing.Size(301, 109);
            this.RadioTable.TabIndex = 1;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(85, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(130, 48);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.Location = new System.Drawing.Point(70, 57);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(160, 49);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.AutoSize = true;
            this.CalculateButton.BackColor = System.Drawing.Color.BurlyWood;
            this.CalculateButton.Location = new System.Drawing.Point(3, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(292, 60);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
            // 
            // ResultTable
            // 
            this.ResultTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResultTable.ColumnCount = 1;
            this.ResultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ResultTable.Controls.Add(this.CalculateButton, 0, 0);
            this.ResultTable.Controls.Add(this.ResultLabel, 0, 1);
            this.ResultTable.Location = new System.Drawing.Point(0, 254);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.RowCount = 2;
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ResultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ResultTable.Size = new System.Drawing.Size(298, 167);
            this.ResultTable.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(49, 91);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(200, 50);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.RadioTable);
            this.Controls.Add(this.NumbersTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.NumbersTable.ResumeLayout(false);
            this.NumbersTable.PerformLayout();
            this.RadioTable.ResumeLayout(false);
            this.RadioTable.PerformLayout();
            this.ResultTable.ResumeLayout(false);
            this.ResultTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NumbersTable;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.TableLayoutPanel RadioTable;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TableLayoutPanel ResultTable;
        private System.Windows.Forms.Label ResultLabel;
    }
}

