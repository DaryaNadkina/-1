namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_5textBox = new System.Windows.Forms.TextBox();
            this.x_4textBox = new System.Windows.Forms.TextBox();
            this.x_5label = new System.Windows.Forms.Label();
            this.x_3textBox = new System.Windows.Forms.TextBox();
            this.x_4label = new System.Windows.Forms.Label();
            this.x_2textBox = new System.Windows.Forms.TextBox();
            this.x_3label = new System.Windows.Forms.Label();
            this.x_1textBox = new System.Windows.Forms.TextBox();
            this.x_2label = new System.Windows.Forms.Label();
            this.x_0textBox = new System.Windows.Forms.TextBox();
            this.x_1label = new System.Windows.Forms.Label();
            this.x_0label = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(215, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Порядок уравнения";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(358, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(34, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(211, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Решим уравнение вида:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(49, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "f(x) =";
            // 
            // x_5textBox
            // 
            this.x_5textBox.Location = new System.Drawing.Point(3, 8);
            this.x_5textBox.Name = "x_5textBox";
            this.x_5textBox.Size = new System.Drawing.Size(26, 23);
            this.x_5textBox.TabIndex = 4;
            // 
            // x_4textBox
            // 
            this.x_4textBox.Location = new System.Drawing.Point(8, 8);
            this.x_4textBox.Name = "x_4textBox";
            this.x_4textBox.Size = new System.Drawing.Size(26, 23);
            this.x_4textBox.TabIndex = 6;
            // 
            // x_5label
            // 
            this.x_5label.AutoSize = true;
            this.x_5label.Location = new System.Drawing.Point(35, 13);
            this.x_5label.Name = "x_5label";
            this.x_5label.Size = new System.Drawing.Size(37, 17);
            this.x_5label.TabIndex = 5;
            this.x_5label.Text = "x^5+";
            // 
            // x_3textBox
            // 
            this.x_3textBox.Location = new System.Drawing.Point(6, 8);
            this.x_3textBox.Name = "x_3textBox";
            this.x_3textBox.Size = new System.Drawing.Size(26, 23);
            this.x_3textBox.TabIndex = 8;
            // 
            // x_4label
            // 
            this.x_4label.AutoSize = true;
            this.x_4label.Location = new System.Drawing.Point(40, 13);
            this.x_4label.Name = "x_4label";
            this.x_4label.Size = new System.Drawing.Size(37, 17);
            this.x_4label.TabIndex = 7;
            this.x_4label.Text = "x^4+";
            // 
            // x_2textBox
            // 
            this.x_2textBox.Location = new System.Drawing.Point(4, 8);
            this.x_2textBox.Name = "x_2textBox";
            this.x_2textBox.Size = new System.Drawing.Size(26, 23);
            this.x_2textBox.TabIndex = 10;
            // 
            // x_3label
            // 
            this.x_3label.AutoSize = true;
            this.x_3label.Location = new System.Drawing.Point(33, 11);
            this.x_3label.Name = "x_3label";
            this.x_3label.Size = new System.Drawing.Size(37, 17);
            this.x_3label.TabIndex = 9;
            this.x_3label.Text = "x^3+";
            // 
            // x_1textBox
            // 
            this.x_1textBox.Location = new System.Drawing.Point(3, 8);
            this.x_1textBox.Name = "x_1textBox";
            this.x_1textBox.Size = new System.Drawing.Size(26, 23);
            this.x_1textBox.TabIndex = 12;
            // 
            // x_2label
            // 
            this.x_2label.AutoSize = true;
            this.x_2label.Location = new System.Drawing.Point(32, 13);
            this.x_2label.Name = "x_2label";
            this.x_2label.Size = new System.Drawing.Size(37, 17);
            this.x_2label.TabIndex = 11;
            this.x_2label.Text = "x^2+";
            // 
            // x_0textBox
            // 
            this.x_0textBox.Location = new System.Drawing.Point(59, 8);
            this.x_0textBox.Name = "x_0textBox";
            this.x_0textBox.Size = new System.Drawing.Size(28, 23);
            this.x_0textBox.TabIndex = 14;
            // 
            // x_1label
            // 
            this.x_1label.AutoSize = true;
            this.x_1label.Location = new System.Drawing.Point(35, 11);
            this.x_1label.Name = "x_1label";
            this.x_1label.Size = new System.Drawing.Size(22, 17);
            this.x_1label.TabIndex = 13;
            this.x_1label.Text = "x+";
            // 
            // x_0label
            // 
            this.x_0label.AutoSize = true;
            this.x_0label.Location = new System.Drawing.Point(89, 11);
            this.x_0label.Name = "x_0label";
            this.x_0label.Size = new System.Drawing.Size(28, 17);
            this.x_0label.TabIndex = 15;
            this.x_0label.Text = "= 0";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confirmButton.Location = new System.Drawing.Point(237, 133);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(115, 23);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearButton.Location = new System.Drawing.Point(237, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 23);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.x_5label);
            this.panel5.Controls.Add(this.x_5textBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 37);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.x_4label);
            this.panel4.Controls.Add(this.x_4textBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel4.Location = new System.Drawing.Point(75, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 37);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.x_3label);
            this.panel3.Controls.Add(this.x_3textBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel3.Location = new System.Drawing.Point(154, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 37);
            this.panel3.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.x_2label);
            this.panel2.Controls.Add(this.x_2textBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 37);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.x_1textBox);
            this.panel1.Controls.Add(this.x_1label);
            this.panel1.Controls.Add(this.x_0textBox);
            this.panel1.Controls.Add(this.x_0label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(297, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 37);
            this.panel1.TabIndex = 22;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.panel5);
            this.mainPanel.Location = new System.Drawing.Point(95, 90);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(419, 37);
            this.mainPanel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 531);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Решение алгебраических уравнений";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox x_5textBox;
        private System.Windows.Forms.TextBox x_4textBox;
        private System.Windows.Forms.Label x_5label;
        private System.Windows.Forms.TextBox x_3textBox;
        private System.Windows.Forms.Label x_4label;
        private System.Windows.Forms.TextBox x_2textBox;
        private System.Windows.Forms.Label x_3label;
        private System.Windows.Forms.TextBox x_1textBox;
        private System.Windows.Forms.Label x_2label;
        private System.Windows.Forms.TextBox x_0textBox;
        private System.Windows.Forms.Label x_1label;
        private System.Windows.Forms.Label x_0label;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
    }
}

