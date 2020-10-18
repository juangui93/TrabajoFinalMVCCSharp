namespace Olimpiadas_Vista_
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnpaises = new System.Windows.Forms.Button();
            this.btnparticipantes = new System.Windows.Forms.Button();
            this.btnposiciones = new System.Windows.Forms.Button();
            this.btnresultados = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track and Field";
            // 
            // btnpaises
            // 
            this.btnpaises.Location = new System.Drawing.Point(64, 303);
            this.btnpaises.Name = "btnpaises";
            this.btnpaises.Size = new System.Drawing.Size(141, 70);
            this.btnpaises.TabIndex = 1;
            this.btnpaises.Text = "Paises";
            this.btnpaises.UseVisualStyleBackColor = true;
            this.btnpaises.Click += new System.EventHandler(this.btnpaises_Click);
            // 
            // btnparticipantes
            // 
            this.btnparticipantes.Location = new System.Drawing.Point(244, 303);
            this.btnparticipantes.Name = "btnparticipantes";
            this.btnparticipantes.Size = new System.Drawing.Size(141, 70);
            this.btnparticipantes.TabIndex = 2;
            this.btnparticipantes.Text = "Participantes";
            this.btnparticipantes.UseVisualStyleBackColor = true;
            this.btnparticipantes.Click += new System.EventHandler(this.btnparticipantes_Click);
            // 
            // btnposiciones
            // 
            this.btnposiciones.Location = new System.Drawing.Point(425, 303);
            this.btnposiciones.Name = "btnposiciones";
            this.btnposiciones.Size = new System.Drawing.Size(141, 70);
            this.btnposiciones.TabIndex = 3;
            this.btnposiciones.Text = "Posiciones";
            this.btnposiciones.UseVisualStyleBackColor = true;
            this.btnposiciones.Click += new System.EventHandler(this.btnposiciones_Click);
            // 
            // btnresultados
            // 
            this.btnresultados.Location = new System.Drawing.Point(615, 303);
            this.btnresultados.Name = "btnresultados";
            this.btnresultados.Size = new System.Drawing.Size(141, 70);
            this.btnresultados.TabIndex = 4;
            this.btnresultados.Text = "Resultados";
            this.btnresultados.UseVisualStyleBackColor = true;
            this.btnresultados.Click += new System.EventHandler(this.btnresultados_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(323, 379);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(141, 70);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Menú de Opciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 222);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnresultados);
            this.Controls.Add(this.btnposiciones);
            this.Controls.Add(this.btnparticipantes);
            this.Controls.Add(this.btnpaises);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUEGOS OLÍMPICOS TOKIO 2021";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpaises;
        private System.Windows.Forms.Button btnparticipantes;
        private System.Windows.Forms.Button btnposiciones;
        private System.Windows.Forms.Button btnresultados;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

