namespace Ubik_Code_API_Exemple
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_btnRun = new System.Windows.Forms.Button();
            this.m_txtScriptOutput = new System.Windows.Forms.TextBox();
            this.m_lblConsole = new System.Windows.Forms.Label();
            this.m_txtBuildOutput = new System.Windows.Forms.TextBox();
            this.m_lblUbikVM = new System.Windows.Forms.Label();
            this.m_txtSource = new System.Windows.Forms.TextBox();
            this.m_lblSource = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_btnRun
            // 
            this.m_btnRun.Location = new System.Drawing.Point(12, 554);
            this.m_btnRun.Name = "m_btnRun";
            this.m_btnRun.Size = new System.Drawing.Size(788, 26);
            this.m_btnRun.TabIndex = 13;
            this.m_btnRun.Text = "Run";
            this.m_btnRun.UseVisualStyleBackColor = true;
            this.m_btnRun.Click += new System.EventHandler(this.m_btnRunScript_Click_1);
            // 
            // m_txtScriptOutput
            // 
            this.m_txtScriptOutput.Location = new System.Drawing.Point(12, 398);
            this.m_txtScriptOutput.Multiline = true;
            this.m_txtScriptOutput.Name = "m_txtScriptOutput";
            this.m_txtScriptOutput.ReadOnly = true;
            this.m_txtScriptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_txtScriptOutput.Size = new System.Drawing.Size(400, 150);
            this.m_txtScriptOutput.TabIndex = 12;
            this.m_txtScriptOutput.WordWrap = false;
            // 
            // m_lblConsole
            // 
            this.m_lblConsole.AutoSize = true;
            this.m_lblConsole.Location = new System.Drawing.Point(367, 382);
            this.m_lblConsole.Name = "m_lblConsole";
            this.m_lblConsole.Size = new System.Drawing.Size(45, 13);
            this.m_lblConsole.TabIndex = 11;
            this.m_lblConsole.Text = "Console";
            // 
            // m_txtBuildOutput
            // 
            this.m_txtBuildOutput.Location = new System.Drawing.Point(418, 398);
            this.m_txtBuildOutput.Multiline = true;
            this.m_txtBuildOutput.Name = "m_txtBuildOutput";
            this.m_txtBuildOutput.ReadOnly = true;
            this.m_txtBuildOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_txtBuildOutput.Size = new System.Drawing.Size(380, 150);
            this.m_txtBuildOutput.TabIndex = 10;
            this.m_txtBuildOutput.WordWrap = false;
            // 
            // m_lblUbikVM
            // 
            this.m_lblUbikVM.AutoSize = true;
            this.m_lblUbikVM.Location = new System.Drawing.Point(722, 382);
            this.m_lblUbikVM.Name = "m_lblUbikVM";
            this.m_lblUbikVM.Size = new System.Drawing.Size(76, 13);
            this.m_lblUbikVM.TabIndex = 9;
            this.m_lblUbikVM.Text = "Ubik Code VM";
            // 
            // m_txtSource
            // 
            this.m_txtSource.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtSource.Location = new System.Drawing.Point(12, 23);
            this.m_txtSource.Multiline = true;
            this.m_txtSource.Name = "m_txtSource";
            this.m_txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_txtSource.Size = new System.Drawing.Size(786, 350);
            this.m_txtSource.TabIndex = 8;
            this.m_txtSource.Text = resources.GetString("m_txtSource.Text");
            this.m_txtSource.WordWrap = false;
            // 
            // m_lblSource
            // 
            this.m_lblSource.AutoSize = true;
            this.m_lblSource.Location = new System.Drawing.Point(9, 6);
            this.m_lblSource.Name = "m_lblSource";
            this.m_lblSource.Size = new System.Drawing.Size(32, 13);
            this.m_lblSource.TabIndex = 7;
            this.m_lblSource.Text = "Code";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 588);
            this.Controls.Add(this.m_btnRun);
            this.Controls.Add(this.m_txtScriptOutput);
            this.Controls.Add(this.m_lblConsole);
            this.Controls.Add(this.m_txtBuildOutput);
            this.Controls.Add(this.m_lblUbikVM);
            this.Controls.Add(this.m_txtSource);
            this.Controls.Add(this.m_lblSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubik Code API Exemple";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnRun;
        private System.Windows.Forms.TextBox m_txtScriptOutput;
        private System.Windows.Forms.Label m_lblConsole;
        private System.Windows.Forms.TextBox m_txtBuildOutput;
        private System.Windows.Forms.Label m_lblUbikVM;
        private System.Windows.Forms.TextBox m_txtSource;
        private System.Windows.Forms.Label m_lblSource;
    }
}

