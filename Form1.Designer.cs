
namespace Parqueadero
{
    partial class MainW
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
            this.components = new System.ComponentModel.Container();
            this.lbtit = new System.Windows.Forms.Label();
            this.btIn = new System.Windows.Forms.Button();
            this.btEx = new System.Windows.Forms.Button();
            this.lbdate = new System.Windows.Forms.Label();
            this.tmtime = new System.Windows.Forms.Timer(this.components);
            this.btTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtit
            // 
            this.lbtit.AutoSize = true;
            this.lbtit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtit.Location = new System.Drawing.Point(12, 9);
            this.lbtit.Name = "lbtit";
            this.lbtit.Size = new System.Drawing.Size(226, 31);
            this.lbtit.TabIndex = 0;
            this.lbtit.Text = "PARQUEADERO";
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Location = new System.Drawing.Point(18, 60);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(100, 35);
            this.btIn.TabIndex = 1;
            this.btIn.Text = "Ingreso";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // btEx
            // 
            this.btEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEx.Location = new System.Drawing.Point(124, 60);
            this.btEx.Name = "btEx";
            this.btEx.Size = new System.Drawing.Size(100, 35);
            this.btEx.TabIndex = 2;
            this.btEx.Text = "Salida";
            this.btEx.UseVisualStyleBackColor = true;
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(529, 24);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(0, 17);
            this.lbdate.TabIndex = 3;
            this.lbdate.Visible = false;
            // 
            // tmtime
            // 
            this.tmtime.Tick += new System.EventHandler(this.tmtime_Tick);
            // 
            // btTime
            // 
            this.btTime.Location = new System.Drawing.Point(448, 21);
            this.btTime.Name = "btTime";
            this.btTime.Size = new System.Drawing.Size(75, 23);
            this.btTime.TabIndex = 4;
            this.btTime.Text = "Mostrar hora";
            this.btTime.UseVisualStyleBackColor = true;
            this.btTime.Click += new System.EventHandler(this.btTime_Click);
            // 
            // MainW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 445);
            this.Controls.Add(this.btTime);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.btEx);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.lbtit);
            this.Name = "MainW";
            this.Text = "Park";
            this.Load += new System.EventHandler(this.MainW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtit;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btEx;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Timer tmtime;
        private System.Windows.Forms.Button btTime;
    }
}

