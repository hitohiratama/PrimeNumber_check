namespace 素数フォーム
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Primenum_check = new Button();
            Input_date = new TextBox();
            Output_data = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 89);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "入力数値";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 195);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 1;
            label2.Text = "判定";
            // 
            // Primenum_check
            // 
            Primenum_check.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Primenum_check.Location = new Point(588, 308);
            Primenum_check.Name = "Primenum_check";
            Primenum_check.Size = new Size(112, 34);
            Primenum_check.TabIndex = 2;
            Primenum_check.Text = "確認";
            Primenum_check.UseVisualStyleBackColor = true;
            Primenum_check.Click += Primenum_check_Click;
            // 
            // Input_date
            // 
            Input_date.Location = new Point(317, 94);
            Input_date.Name = "Input_date";
            Input_date.Size = new Size(208, 31);
            Input_date.TabIndex = 3;
            // 
            // Output_data
            // 
            Output_data.Location = new Point(317, 195);
            Output_data.Name = "Output_data";
            Output_data.Size = new Size(208, 31);
            Output_data.TabIndex = 4;
            // 
            // Form1
            // 
            AcceptButton = Primenum_check;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output_data);
            Controls.Add(Input_date);
            Controls.Add(Primenum_check);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "素数確認";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Primenum_check;
        private TextBox Input_date;
        private TextBox Output_data;
    }
}
