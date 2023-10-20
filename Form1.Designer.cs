namespace Practica_13
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sueldo = new TextBox();
            Nsueldo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(22, 213);
            button1.Name = "button1";
            button1.Size = new Size(101, 42);
            button1.TabIndex = 0;
            button1.Text = "Desición";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(190, 213);
            button2.Name = "button2";
            button2.Size = new Size(101, 42);
            button2.TabIndex = 1;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(294, 104);
            label1.TabIndex = 2;
            label1.Text = "Dado como dato el sueldo\r\nde un trabajador, el programa\r\naplica un aumento del 15% si \r\nel sueldo es inferior a 400,000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 163);
            label2.Name = "label2";
            label2.Size = new Size(162, 26);
            label2.TabIndex = 3;
            label2.Text = "Ingresar sueldo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 288);
            label3.Name = "label3";
            label3.Size = new Size(145, 26);
            label3.TabIndex = 4;
            label3.Text = "Nuevo sueldo:";
            // 
            // sueldo
            // 
            sueldo.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sueldo.Location = new Point(190, 163);
            sueldo.Name = "sueldo";
            sueldo.Size = new Size(126, 33);
            sueldo.TabIndex = 5;
            // 
            // Nsueldo
            // 
            Nsueldo.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nsueldo.Location = new Point(190, 285);
            Nsueldo.Name = "Nsueldo";
            Nsueldo.Size = new Size(126, 33);
            Nsueldo.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 340);
            Controls.Add(Nsueldo);
            Controls.Add(sueldo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Practica 13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox sueldo;
        private TextBox Nsueldo;
    }
}