namespace GitConfigMaster
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnApplyConfig = new System.Windows.Forms.Button();
            this.btnAddConfig = new System.Windows.Forms.Button();
            this.comboBoxConfigs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnApplyConfig
            // 
            this.btnApplyConfig.Image = global::GitConfigMaster.Properties.Resources._checked;
            this.btnApplyConfig.Location = new System.Drawing.Point(12, 12);
            this.btnApplyConfig.Name = "btnApplyConfig";
            this.btnApplyConfig.Size = new System.Drawing.Size(51, 45);
            this.btnApplyConfig.TabIndex = 0;
            this.btnApplyConfig.UseVisualStyleBackColor = true;
            this.btnApplyConfig.Click += new System.EventHandler(this.btnApplyConfig_Click);
            // 
            // btnAddConfig
            // 
            this.btnAddConfig.BackColor = System.Drawing.Color.White;
            this.btnAddConfig.Image = global::GitConfigMaster.Properties.Resources.add;
            this.btnAddConfig.Location = new System.Drawing.Point(156, 12);
            this.btnAddConfig.Name = "btnAddConfig";
            this.btnAddConfig.Size = new System.Drawing.Size(50, 45);
            this.btnAddConfig.TabIndex = 1;
            this.btnAddConfig.UseVisualStyleBackColor = false;
            this.btnAddConfig.Click += new System.EventHandler(this.btnAddConfig_Click);
            // 
            // comboBoxConfigs
            // 
            this.comboBoxConfigs.FormattingEnabled = true;
            this.comboBoxConfigs.Location = new System.Drawing.Point(12, 63);
            this.comboBoxConfigs.Name = "comboBoxConfigs";
            this.comboBoxConfigs.Size = new System.Drawing.Size(194, 24);
            this.comboBoxConfigs.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(218, 97);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxConfigs);
            this.Controls.Add(this.btnAddConfig);
            this.Controls.Add(this.btnApplyConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Git";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplyConfig;
        private System.Windows.Forms.Button btnAddConfig;
        private System.Windows.Forms.ComboBox comboBoxConfigs;
    }
}

