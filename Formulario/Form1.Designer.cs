namespace Formulario
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
            lblnombre = new Label();
            lblapellido = new Label();
            lbltelefono = new Label();
            lblestatura = new Label();
            lbledad = new Label();
            tbnombre = new TextBox();
            tbapellido = new TextBox();
            tbtelefono = new TextBox();
            tbestatura = new TextBox();
            tbedad = new TextBox();
            btnguardar = new Button();
            btncancelar = new Button();
            gpgenero = new GroupBox();
            rbmujer = new RadioButton();
            rbhombre = new RadioButton();
            gpgenero.SuspendLayout();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(33, 22);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(56, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombres";
            lblnombre.Click += label1_Click;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(33, 61);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(56, 15);
            lblapellido.TabIndex = 1;
            lblapellido.Text = "Apellidos";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(33, 100);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(52, 15);
            lbltelefono.TabIndex = 2;
            lbltelefono.Text = "Telefono";
            // 
            // lblestatura
            // 
            lblestatura.AutoSize = true;
            lblestatura.Location = new Point(33, 139);
            lblestatura.Name = "lblestatura";
            lblestatura.Size = new Size(49, 15);
            lblestatura.TabIndex = 3;
            lblestatura.Text = "Estatura";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(33, 176);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 4;
            lbledad.Text = "Edad";
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(116, 14);
            tbnombre.Name = "tbnombre";
            tbnombre.Size = new Size(144, 23);
            tbnombre.TabIndex = 5;
            // 
            // tbapellido
            // 
            tbapellido.Location = new Point(116, 53);
            tbapellido.Name = "tbapellido";
            tbapellido.Size = new Size(144, 23);
            tbapellido.TabIndex = 6;
            // 
            // tbtelefono
            // 
            tbtelefono.Location = new Point(116, 92);
            tbtelefono.Name = "tbtelefono";
            tbtelefono.Size = new Size(144, 23);
            tbtelefono.TabIndex = 7;
            // 
            // tbestatura
            // 
            tbestatura.Location = new Point(116, 131);
            tbestatura.Name = "tbestatura";
            tbestatura.Size = new Size(144, 23);
            tbestatura.TabIndex = 8;
            // 
            // tbedad
            // 
            tbedad.Location = new Point(116, 168);
            tbedad.Name = "tbedad";
            tbedad.Size = new Size(144, 23);
            tbedad.TabIndex = 9;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(89, 286);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(90, 38);
            btnguardar.TabIndex = 10;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(89, 344);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(90, 38);
            btncancelar.TabIndex = 11;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // gpgenero
            // 
            gpgenero.Controls.Add(rbmujer);
            gpgenero.Controls.Add(rbhombre);
            gpgenero.Location = new Point(33, 210);
            gpgenero.Name = "gpgenero";
            gpgenero.Size = new Size(227, 54);
            gpgenero.TabIndex = 12;
            gpgenero.TabStop = false;
            gpgenero.Text = "Genero";
            // 
            // rbmujer
            // 
            rbmujer.AutoSize = true;
            rbmujer.Location = new Point(154, 22);
            rbmujer.Name = "rbmujer";
            rbmujer.Size = new Size(56, 19);
            rbmujer.TabIndex = 1;
            rbmujer.TabStop = true;
            rbmujer.Text = "Mujer";
            rbmujer.UseVisualStyleBackColor = true;
            // 
            // rbhombre
            // 
            rbhombre.AutoSize = true;
            rbhombre.Location = new Point(15, 22);
            rbhombre.Name = "rbhombre";
            rbhombre.Size = new Size(69, 19);
            rbhombre.TabIndex = 0;
            rbhombre.TabStop = true;
            rbhombre.Text = "Hombre";
            rbhombre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpgenero);
            Controls.Add(btncancelar);
            Controls.Add(btnguardar);
            Controls.Add(tbedad);
            Controls.Add(tbestatura);
            Controls.Add(tbtelefono);
            Controls.Add(tbapellido);
            Controls.Add(tbnombre);
            Controls.Add(lbledad);
            Controls.Add(lblestatura);
            Controls.Add(lbltelefono);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Name = "Form1";
            Text = "Form1";
            gpgenero.ResumeLayout(false);
            gpgenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lblapellido;
        private Label lbltelefono;
        private Label lblestatura;
        private Label lbledad;
        private TextBox tbnombre;
        private TextBox tbapellido;
        private TextBox tbtelefono;
        private TextBox tbestatura;
        private TextBox tbedad;
        private Button btnguardar;
        private Button btncancelar;
        private GroupBox gpgenero;
        private RadioButton rbmujer;
        private RadioButton rbhombre;
    }
}
