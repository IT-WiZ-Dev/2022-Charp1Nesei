namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            OK = new Button();
            label2 = new Label();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // OK
            // 
            OK.Location = new Point(52, 126);
            OK.Name = "OK";
            OK.Size = new Size(140, 59);
            OK.TabIndex = 2;
            OK.Text = "OK";
            OK.UseVisualStyleBackColor = true;
            OK.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 84);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // textBoxName
            // 
            textBoxName.AcceptsTab = true;
            textBoxName.ForeColor = SystemColors.InactiveCaption;
            textBoxName.Location = new Point(105, 25);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 0;
            textBoxName.TabStop = false;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 422);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(OK);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource bindingSource1;
        private Button OK;
        private Label label2;
        private TextBox textBoxName;
    }
}