namespace RadioButton_tp_02
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
            txtValor = new TextBox();
            txtConvertido = new TextBox();
            btnConverter = new Button();
            label1 = new Label();
            label2 = new Label();
            rbKmMilha = new RadioButton();
            rbMilhaKm = new RadioButton();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(186, 44);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 0;
            // 
            // txtConvertido
            // 
            txtConvertido.Location = new Point(186, 213);
            txtConvertido.Name = "txtConvertido";
            txtConvertido.Size = new Size(100, 23);
            txtConvertido.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(186, 99);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(99, 76);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 47);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Digite um Valor :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 216);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor Convertido :";
            // 
            // rbKmMilha
            // 
            rbKmMilha.AutoSize = true;
            rbKmMilha.Location = new Point(57, 111);
            rbKmMilha.Name = "rbKmMilha";
            rbKmMilha.Size = new Size(102, 19);
            rbKmMilha.TabIndex = 5;
            rbKmMilha.TabStop = true;
            rbKmMilha.Text = "KM para Milha";
            rbKmMilha.UseVisualStyleBackColor = true;
            // 
            // rbMilhaKm
            // 
            rbMilhaKm.AutoSize = true;
            rbMilhaKm.Location = new Point(57, 136);
            rbMilhaKm.Name = "rbMilhaKm";
            rbMilhaKm.Size = new Size(102, 19);
            rbMilhaKm.TabIndex = 6;
            rbMilhaKm.TabStop = true;
            rbMilhaKm.Text = "Milha para KM";
            rbMilhaKm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 301);
            Controls.Add(rbMilhaKm);
            Controls.Add(rbKmMilha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConverter);
            Controls.Add(txtConvertido);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private TextBox txtConvertido;
        private Button btnConverter;
        private Label label1;
        private Label label2;
        private RadioButton rbKmMilha;
        private RadioButton rbMilhaKm;
    }
}