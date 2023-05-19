namespace GenTarefa
{
    partial class NovaLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeLista = new System.Windows.Forms.Label();
            this.nameContent = new System.Windows.Forms.TextBox();
            this.conteudoLista = new System.Windows.Forms.Label();
            this.conteudoList = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeLista
            // 
            this.nomeLista.AutoSize = true;
            this.nomeLista.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomeLista.Location = new System.Drawing.Point(12, 27);
            this.nomeLista.Name = "nomeLista";
            this.nomeLista.Size = new System.Drawing.Size(172, 30);
            this.nomeLista.TabIndex = 0;
            this.nomeLista.Text = "Nome da tarefa:";
            // 
            // nameContent
            // 
            this.nameContent.Location = new System.Drawing.Point(179, 33);
            this.nameContent.Name = "nameContent";
            this.nameContent.Size = new System.Drawing.Size(377, 23);
            this.nameContent.TabIndex = 1;
            // 
            // conteudoLista
            // 
            this.conteudoLista.AutoSize = true;
            this.conteudoLista.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.conteudoLista.Location = new System.Drawing.Point(330, 100);
            this.conteudoLista.Name = "conteudoLista";
            this.conteudoLista.Size = new System.Drawing.Size(132, 32);
            this.conteudoLista.TabIndex = 2;
            this.conteudoLista.Text = "Descrição:";
            // 
            // conteudoList
            // 
            this.conteudoList.Location = new System.Drawing.Point(4, 144);
            this.conteudoList.Multiline = true;
            this.conteudoList.Name = "conteudoList";
            this.conteudoList.Size = new System.Drawing.Size(794, 216);
            this.conteudoList.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(179, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(139, 51);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.voltarButton.Location = new System.Drawing.Point(490, 387);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(125, 51);
            this.voltarButton.TabIndex = 5;
            this.voltarButton.Text = "VOLTAR";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // NovaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.conteudoList);
            this.Controls.Add(this.conteudoLista);
            this.Controls.Add(this.nameContent);
            this.Controls.Add(this.nomeLista);
            this.Name = "NovaLista";
            this.Text = "NovaLista";
            this.Load += new System.EventHandler(this.NovaLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nomeLista;
        private TextBox nameContent;
        private Label conteudoLista;
        private TextBox conteudoList;
        private Button saveButton;
        private Button voltarButton;
    }
}