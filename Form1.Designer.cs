namespace WinFormsApp2
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
            addbutton = new Button();
            tabla = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            texto = new TextBox();
            texto1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.LightSteelBlue;
            addbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addbutton.ForeColor = SystemColors.ControlText;
            addbutton.Location = new Point(69, 286);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(140, 70);
            addbutton.TabIndex = 0;
            addbutton.Text = "add";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += button1_Click;
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Usuario, Edad });
            tabla.Location = new Point(318, 50);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(246, 315);
            tabla.TabIndex = 1;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Nombre";
            Usuario.Name = "Usuario";
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // texto
            // 
            texto.Location = new Point(69, 129);
            texto.Name = "texto";
            texto.Size = new Size(140, 23);
            texto.TabIndex = 2;
            // 
            // texto1
            // 
            texto1.Location = new Point(69, 200);
            texto1.Name = "texto1";
            texto1.Size = new Size(140, 23);
            texto1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(69, 102);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(69, 173);
            label2.Name = "label2";
            label2.Size = new Size(52, 24);
            label2.TabIndex = 5;
            label2.Text = "Edad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(595, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(texto1);
            Controls.Add(texto);
            Controls.Add(tabla);
            Controls.Add(addbutton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbutton;
        private DataGridView tabla;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Edad;
        private TextBox texto;
        private TextBox texto1;
        private Label label1;
        private Label label2;
    }
}