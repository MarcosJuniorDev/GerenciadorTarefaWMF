namespace GenTarefa
{
    partial class AreaInicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.novaListaButton = new System.Windows.Forms.Button();
            this.listasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(213, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciador de Tarefas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // novaListaButton
            // 
            this.novaListaButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.novaListaButton.Location = new System.Drawing.Point(54, 297);
            this.novaListaButton.Name = "novaListaButton";
            this.novaListaButton.Size = new System.Drawing.Size(175, 66);
            this.novaListaButton.TabIndex = 1;
            this.novaListaButton.Text = "Nova Tarefa";
            this.novaListaButton.UseVisualStyleBackColor = true;
            this.novaListaButton.Click += new System.EventHandler(this.novaListaButton_Click);
            // 
            // listasButton
            // 
            this.listasButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listasButton.Location = new System.Drawing.Point(554, 297);
            this.listasButton.Name = "listasButton";
            this.listasButton.Size = new System.Drawing.Size(199, 66);
            this.listasButton.TabIndex = 2;
            this.listasButton.Text = "Listas de Tarefas";
            this.listasButton.UseVisualStyleBackColor = true;
            this.listasButton.Click += new System.EventHandler(this.listasButton_Click);
            // 
            // AreaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listasButton);
            this.Controls.Add(this.novaListaButton);
            this.Controls.Add(this.label1);
            this.Name = "AreaInicial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AreaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button novaListaButton;
        private Button listasButton;
    }
}