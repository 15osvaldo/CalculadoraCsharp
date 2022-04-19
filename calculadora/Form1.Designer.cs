namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.flPanelNumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPorcen = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.Color.Black;
            this.lblNum1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.White;
            this.lblNum1.Location = new System.Drawing.Point(32, 16);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(310, 33);
            this.lblNum1.TabIndex = 10;
            this.lblNum1.Text = "0";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOperacion
            // 
            this.lblOperacion.BackColor = System.Drawing.Color.Black;
            this.lblOperacion.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(66)))));
            this.lblOperacion.Location = new System.Drawing.Point(241, 58);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(100, 33);
            this.lblOperacion.TabIndex = 11;
            this.lblOperacion.Text = "0";
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(7, 62);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(33, 34);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.UseVisualStyleBackColor = false;
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.Black;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.ForeColor = System.Drawing.Color.White;
            this.txtPantalla.Location = new System.Drawing.Point(39, 94);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(302, 63);
            this.txtPantalla.TabIndex = 9;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flPanelNumerico
            // 
            this.flPanelNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flPanelNumerico.Location = new System.Drawing.Point(36, 270);
            this.flPanelNumerico.Name = "flPanelNumerico";
            this.flPanelNumerico.Size = new System.Drawing.Size(252, 257);
            this.flPanelNumerico.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnDiv);
            this.flowLayoutPanel2.Controls.Add(this.btnMulti);
            this.flowLayoutPanel2.Controls.Add(this.btnResta);
            this.flowLayoutPanel2.Controls.Add(this.btnSuma);
            this.flowLayoutPanel2.Controls.Add(this.btnigual);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(291, 213);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(72, 305);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // btnDiv
            // 
            this.btnDiv.BackgroundImage = global::calculadora.Properties.Resources.luna_llena;
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(3, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(55, 55);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMulti.BackgroundImage")));
            this.btnMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMulti.FlatAppearance.BorderSize = 0;
            this.btnMulti.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMulti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.Location = new System.Drawing.Point(3, 64);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(55, 55);
            this.btnMulti.TabIndex = 0;
            this.btnMulti.Text = "X";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click_1);
            // 
            // btnResta
            // 
            this.btnResta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResta.BackgroundImage")));
            this.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResta.FlatAppearance.BorderSize = 0;
            this.btnResta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnResta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.Color.White;
            this.btnResta.Location = new System.Drawing.Point(3, 125);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(55, 55);
            this.btnResta.TabIndex = 0;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click_1);
            // 
            // btnSuma
            // 
            this.btnSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuma.BackgroundImage")));
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.Location = new System.Drawing.Point(3, 186);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(55, 55);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnigual.BackgroundImage")));
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.ForeColor = System.Drawing.Color.White;
            this.btnigual.Location = new System.Drawing.Point(3, 247);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(55, 55);
            this.btnigual.TabIndex = 0;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBorrar);
            this.flowLayoutPanel1.Controls.Add(this.btnPorcen);
            this.flowLayoutPanel1.Controls.Add(this.btnoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 209);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 57);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::calculadora.Properties.Resources.circulo_1_;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(3, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(55, 55);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "AC";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPorcen
            // 
            this.btnPorcen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPorcen.BackgroundImage")));
            this.btnPorcen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPorcen.FlatAppearance.BorderSize = 0;
            this.btnPorcen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPorcen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPorcen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcen.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcen.ForeColor = System.Drawing.Color.White;
            this.btnPorcen.Location = new System.Drawing.Point(64, 3);
            this.btnPorcen.Name = "btnPorcen";
            this.btnPorcen.Size = new System.Drawing.Size(55, 55);
            this.btnPorcen.TabIndex = 0;
            this.btnPorcen.Text = "%";
            this.btnPorcen.UseVisualStyleBackColor = true;
            this.btnPorcen.Click += new System.EventHandler(this.btnPorcen_Click_1);
            // 
            // btnoff
            // 
            this.btnoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnoff.BackgroundImage")));
            this.btnoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoff.FlatAppearance.BorderSize = 0;
            this.btnoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoff.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff.ForeColor = System.Drawing.Color.White;
            this.btnoff.Location = new System.Drawing.Point(125, 3);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(55, 55);
            this.btnoff.TabIndex = 0;
            this.btnoff.Text = "off";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(421, 532);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.flPanelNumerico);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.FlowLayoutPanel flPanelNumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPorcen;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Button btnigual;
    }
}

