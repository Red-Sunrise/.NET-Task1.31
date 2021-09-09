namespace Task1._31
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TableInput = new System.Windows.Forms.DataGridView();
            this.LabelInput = new System.Windows.Forms.Label();
            this.TableOutput = new System.Windows.Forms.DataGridView();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.TransformButton = new System.Windows.Forms.Button();
            this.InputSize = new System.Windows.Forms.NumericUpDown();
            this.SizeMatrix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputSize)).BeginInit();
            this.SuspendLayout();
            // 
            // TableInput
            // 
            this.TableInput.AllowUserToOrderColumns = true;
            this.TableInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableInput.DefaultCellStyle = dataGridViewCellStyle1;
            this.TableInput.Location = new System.Drawing.Point(12, 50);
            this.TableInput.Name = "TableInput";
            this.TableInput.Size = new System.Drawing.Size(536, 499);
            this.TableInput.TabIndex = 0;
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInput.Location = new System.Drawing.Point(213, 9);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(69, 30);
            this.LabelInput.TabIndex = 1;
            this.LabelInput.Text = "Input";
            // 
            // TableOutput
            // 
            this.TableOutput.AllowUserToOrderColumns = true;
            this.TableOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableOutput.Location = new System.Drawing.Point(719, 50);
            this.TableOutput.Name = "TableOutput";
            this.TableOutput.Size = new System.Drawing.Size(536, 499);
            this.TableOutput.TabIndex = 2;
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOutput.Location = new System.Drawing.Point(957, 9);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(88, 30);
            this.LabelOutput.TabIndex = 3;
            this.LabelOutput.Text = "Output";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(176, 583);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(119, 61);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // TransformButton
            // 
            this.TransformButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransformButton.Location = new System.Drawing.Point(564, 250);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(140, 65);
            this.TransformButton.TabIndex = 5;
            this.TransformButton.Text = "Transform";
            this.TransformButton.UseVisualStyleBackColor = true;
            this.TransformButton.Click += new System.EventHandler(this.transformButton_Click);
            // 
            // InputSize
            // 
            this.InputSize.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSize.Location = new System.Drawing.Point(32, 598);
            this.InputSize.Name = "InputSize";
            this.InputSize.Size = new System.Drawing.Size(120, 36);
            this.InputSize.TabIndex = 6;
            this.InputSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SizeMatrix
            // 
            this.SizeMatrix.AutoSize = true;
            this.SizeMatrix.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeMatrix.Location = new System.Drawing.Point(27, 565);
            this.SizeMatrix.Name = "SizeMatrix";
            this.SizeMatrix.Size = new System.Drawing.Size(129, 30);
            this.SizeMatrix.TabIndex = 7;
            this.SizeMatrix.Text = "Size Matrix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SizeMatrix);
            this.Controls.Add(this.InputSize);
            this.Controls.Add(this.TransformButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.TableOutput);
            this.Controls.Add(this.LabelInput);
            this.Controls.Add(this.TableInput);
            this.Name = "Form1";
            this.Text = "Task1.31";
            ((System.ComponentModel.ISupportInitialize)(this.TableInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableInput;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.DataGridView TableOutput;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button TransformButton;
        private System.Windows.Forms.NumericUpDown InputSize;
        private System.Windows.Forms.Label SizeMatrix;
    }
}

