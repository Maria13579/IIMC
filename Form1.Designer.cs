
namespace IIMC
{
    partial class frmIMC
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblkg = new System.Windows.Forms.Label();
            this.lblm = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.cmdImc = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmdtabl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(98, 100);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(62, 25);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatura.Location = new System.Drawing.Point(45, 138);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(115, 25);
            this.lblEstatura.TabIndex = 1;
            this.lblEstatura.Text = "Estatura";
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkg.Location = new System.Drawing.Point(349, 100);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(192, 25);
            this.lblkg.TabIndex = 2;
            this.lblkg.Text = "Kilogramos (Kg)";
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblm.Location = new System.Drawing.Point(349, 138);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(131, 25);
            this.lblm.TabIndex = 3;
            this.lblm.Text = "Metros (m)";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(210, 100);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(119, 20);
            this.txtpeso.TabIndex = 4;
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(210, 138);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(119, 20);
            this.txtestatura.TabIndex = 5;
            // 
            // cmdImc
            // 
            this.cmdImc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cmdImc.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImc.Location = new System.Drawing.Point(168, 348);
            this.cmdImc.Name = "cmdImc";
            this.cmdImc.Size = new System.Drawing.Size(203, 62);
            this.cmdImc.TabIndex = 6;
            this.cmdImc.Text = "Indice de masa Corporal";
            this.cmdImc.UseVisualStyleBackColor = false;
            this.cmdImc.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(260, 295);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(21, 22);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "0";
            // 
            // cmdtabl
            // 
            this.cmdtabl.BackColor = System.Drawing.Color.OrangeRed;
            this.cmdtabl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdtabl.Location = new System.Drawing.Point(424, 375);
            this.cmdtabl.Name = "cmdtabl";
            this.cmdtabl.Size = new System.Drawing.Size(100, 35);
            this.cmdtabl.TabIndex = 8;
            this.cmdtabl.Text = "Tabla IMC";
            this.cmdtabl.UseVisualStyleBackColor = false;
            this.cmdtabl.Click += new System.EventHandler(this.cmdtabl_Click);
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(559, 438);
            this.Controls.Add(this.cmdtabl);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmdImc);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.lblEstatura);
            this.Controls.Add(this.lblPeso);
            this.Name = "frmIMC";
            this.Text = "Indice de Masa Corporal";
            this.Load += new System.EventHandler(this.frmIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.Button cmdImc;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button cmdtabl;
    }
}

