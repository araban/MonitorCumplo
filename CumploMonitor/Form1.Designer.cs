namespace CumploMonitor
{
    partial class MonitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorForm));
            this.msgLabel = new System.Windows.Forms.Label();
            this.monitorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgLabel
            // 
            this.msgLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.Location = new System.Drawing.Point(7, 0);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(775, 155);
            this.msgLabel.TabIndex = 0;
            this.msgLabel.Text = "Apareció una nueva OPORTUNIDAD DE INVERSIÓN";
            this.msgLabel.Visible = false;
            // 
            // monitorButton
            // 
            this.monitorButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.monitorButton.Location = new System.Drawing.Point(241, 178);
            this.monitorButton.Name = "monitorButton";
            this.monitorButton.Size = new System.Drawing.Size(297, 47);
            this.monitorButton.TabIndex = 1;
            this.monitorButton.Text = "Continuar &Monitoreando";
            this.monitorButton.UseVisualStyleBackColor = true;
            this.monitorButton.Click += new System.EventHandler(this.monitorButton_Click);
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 257);
            this.Controls.Add(this.monitorButton);
            this.Controls.Add(this.msgLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonitorForm";
            this.Text = "Monitor Cumplo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button monitorButton;
    }
}

