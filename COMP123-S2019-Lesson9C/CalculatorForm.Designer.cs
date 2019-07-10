namespace COMP123_S2019_Lesson9C
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.CalculatorButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculatorButtonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorButtonTableLayout
            // 
            this.CalculatorButtonTableLayout.ColumnCount = 4;
            this.CalculatorButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayout.Controls.Add(this.ThreeButton, 2, 3);
            this.CalculatorButtonTableLayout.Controls.Add(this.TwoButton, 1, 3);
            this.CalculatorButtonTableLayout.Controls.Add(this.OneButton, 0, 3);
            this.CalculatorButtonTableLayout.Controls.Add(this.SixButton, 2, 2);
            this.CalculatorButtonTableLayout.Controls.Add(this.FiveButton, 1, 2);
            this.CalculatorButtonTableLayout.Controls.Add(this.FourButton, 0, 2);
            this.CalculatorButtonTableLayout.Controls.Add(this.NineButton, 2, 1);
            this.CalculatorButtonTableLayout.Controls.Add(this.EightButton, 1, 1);
            this.CalculatorButtonTableLayout.Controls.Add(this.SevenButton, 0, 1);
            this.CalculatorButtonTableLayout.Controls.Add(this.ResultLabel, 0, 0);
            this.CalculatorButtonTableLayout.Controls.Add(this.DecimalButton, 2, 4);
            this.CalculatorButtonTableLayout.Controls.Add(this.ZeroButton, 0, 4);
            this.CalculatorButtonTableLayout.Controls.Add(this.BackspaceButton, 3, 1);
            this.CalculatorButtonTableLayout.Controls.Add(this.ClearButton, 3, 2);
            this.CalculatorButtonTableLayout.Controls.Add(this.DoneButton, 3, 3);
            this.CalculatorButtonTableLayout.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorButtonTableLayout.Location = new System.Drawing.Point(2, 164);
            this.CalculatorButtonTableLayout.Name = "CalculatorButtonTableLayout";
            this.CalculatorButtonTableLayout.RowCount = 5;
            this.CalculatorButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorButtonTableLayout.Size = new System.Drawing.Size(297, 267);
            this.CalculatorButtonTableLayout.TabIndex = 0;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CalculatorButtonTableLayout.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 215);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(142, 49);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(151, 162);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(68, 47);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(77, 162);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(68, 47);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 162);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(68, 47);
            this.OneButton.TabIndex = 6;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(151, 109);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(68, 47);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(77, 109);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(68, 47);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 109);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(68, 47);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(151, 56);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(68, 47);
            this.NineButton.TabIndex = 2;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(77, 56);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(68, 47);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 56);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(68, 47);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculatorButtonTableLayout.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(291, 53);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DoneButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(225, 162);
            this.DoneButton.Name = "DoneButton";
            this.CalculatorButtonTableLayout.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(69, 102);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.Tag = "Done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.Location = new System.Drawing.Point(151, 215);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(68, 49);
            this.DecimalButton.TabIndex = 13;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackspaceButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BackspaceButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackspaceButton.ForeColor = System.Drawing.Color.White;
            this.BackspaceButton.Image = ((System.Drawing.Image)(resources.GetObject("BackspaceButton.Image")));
            this.BackspaceButton.Location = new System.Drawing.Point(225, 56);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(69, 47);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Tag = "BackSpace";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            this.BackspaceButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(225, 109);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(69, 47);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Tag = "Clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.CalculatorButtonTableLayout);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Form";
            this.CalculatorButtonTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorButtonTableLayout;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

