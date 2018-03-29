namespace MailSender
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.val = new System.Windows.Forms.Button();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but_pj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(373, 440);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(137, 49);
            this.val.TabIndex = 0;
            this.val.Text = "Valider";
            this.val.UseVisualStyleBackColor = true;
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(99, 12);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(206, 22);
            this.tb_from.TabIndex = 1;
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(16, 15);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(52, 17);
            this.from.TabIndex = 2;
            this.from.Text = "From : ";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(16, 43);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(37, 17);
            this.to.TabIndex = 4;
            this.to.Text = "To : ";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(99, 40);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(206, 22);
            this.tb_to.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(16, 71);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(77, 17);
            this.pass.TabIndex = 6;
            this.pass.Text = "Password :";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(99, 68);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(206, 22);
            this.tb_pass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titre : ";
            // 
            // tb_titre
            // 
            this.tb_titre.Location = new System.Drawing.Point(655, 12);
            this.tb_titre.Name = "tb_titre";
            this.tb_titre.Size = new System.Drawing.Size(206, 22);
            this.tb_titre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pièce jointe :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(655, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 9;
            // 
            // but_pj
            // 
            this.but_pj.Location = new System.Drawing.Point(655, 65);
            this.but_pj.Name = "but_pj";
            this.but_pj.Size = new System.Drawing.Size(206, 23);
            this.but_pj.TabIndex = 11;
            this.but_pj.Text = "Ajouter";
            this.but_pj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Message";
            // 
            // tb_mess
            // 
            this.tb_mess.Location = new System.Drawing.Point(12, 146);
            this.tb_mess.Multiline = true;
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.Size = new System.Drawing.Size(849, 200);
            this.tb_mess.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 501);
            this.Controls.Add(this.tb_mess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.but_pj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_titre);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.to);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.val);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button val;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_pj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mess;
    }
}

