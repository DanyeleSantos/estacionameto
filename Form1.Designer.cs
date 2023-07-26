namespace Aula09Estacionamento
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
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnestacionar = new System.Windows.Forms.Button();
            this.btnretirar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsttotal = new System.Windows.Forms.ListView();
            this.lblcontador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(6, 70);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(209, 23);
            this.txtplaca.TabIndex = 0;
            this.txtplaca.TextChanged += new System.EventHandler(this.txtplaca_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtplaca);
            this.groupBox1.Controls.Add(this.btnestacionar);
            this.groupBox1.Controls.Add(this.btnretirar);
            this.groupBox1.Location = new System.Drawing.Point(69, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite a placa";
            // 
            // btnestacionar
            // 
            this.btnestacionar.Location = new System.Drawing.Point(9, 152);
            this.btnestacionar.Name = "btnestacionar";
            this.btnestacionar.Size = new System.Drawing.Size(75, 23);
            this.btnestacionar.TabIndex = 4;
            this.btnestacionar.Text = "Estacionar";
            this.btnestacionar.UseVisualStyleBackColor = true;
            this.btnestacionar.Click += new System.EventHandler(this.btnestacionar_Click);
            // 
            // btnretirar
            // 
            this.btnretirar.Location = new System.Drawing.Point(140, 152);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(75, 23);
            this.btnretirar.TabIndex = 5;
            this.btnretirar.Text = "Retirar";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsttotal);
            this.groupBox2.Controls.Add(this.lblcontador);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnfechar);
            this.groupBox2.Location = new System.Drawing.Point(407, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listagem de veículos";
            // 
            // lsttotal
            // 
            this.lsttotal.Location = new System.Drawing.Point(28, 93);
            this.lsttotal.Name = "lsttotal";
            this.lsttotal.Size = new System.Drawing.Size(121, 97);
            this.lsttotal.TabIndex = 10;
            this.lsttotal.UseCompatibleStateImageBehavior = false;
            this.lsttotal.View = System.Windows.Forms.View.List;
            this.lsttotal.SelectedIndexChanged += new System.EventHandler(this.lsttotal_SelectedIndexChanged);
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcontador.Location = new System.Drawing.Point(101, 45);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(14, 15);
            this.lblcontador.TabIndex = 9;
            this.lblcontador.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Veículos";
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(-326, 196);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(209, 23);
            this.btnfechar.TabIndex = 6;
            this.btnfechar.Text = "fechar estacionamento";
            this.btnfechar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar estacionamento";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtplaca;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnestacionar;
        private Button btnretirar;
        private GroupBox groupBox2;
        private Label lblcontador;
        private Label label2;
        private Button btnfechar;
        private ListView lsttotal;
        private Button button1;
    }
}