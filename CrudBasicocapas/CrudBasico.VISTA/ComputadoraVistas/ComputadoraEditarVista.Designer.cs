namespace CrudBasico.VISTA.ComputadoraVistas
{
    partial class ComputadoraEditarVista
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
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(230, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // button2
            // 
            button2.Location = new Point(328, 346);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 33;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(165, 346);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 32;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(230, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 231);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 28;
            label4.Text = "FECHA_FAB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 183);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 27;
            label3.Text = "PRECIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 134);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 26;
            label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 85);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 25;
            label1.Text = "NOMBRE";
            // 
            // ComputadoraEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComputadoraEditarVista";
            Text = "ComputadoraEditarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}