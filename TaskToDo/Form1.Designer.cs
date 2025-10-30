namespace TaskToDo
{
    partial class Form1
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
            this.lbEquipa = new System.Windows.Forms.Label();
            this.lbFunc = new System.Windows.Forms.Label();
            this.lbTarefa = new System.Windows.Forms.Label();
            this.lbStartData = new System.Windows.Forms.Label();
            this.lbEndData = new System.Windows.Forms.Label();
            this.lbDescrição = new System.Windows.Forms.Label();
            this.cmbEquipa = new System.Windows.Forms.ComboBox();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mtxtStartData = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEndData = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbEquipa
            // 
            this.lbEquipa.AutoSize = true;
            this.lbEquipa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipa.Location = new System.Drawing.Point(23, 19);
            this.lbEquipa.Name = "lbEquipa";
            this.lbEquipa.Size = new System.Drawing.Size(68, 21);
            this.lbEquipa.TabIndex = 0;
            this.lbEquipa.Text = "Equipa";
            // 
            // lbFunc
            // 
            this.lbFunc.AutoSize = true;
            this.lbFunc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunc.Location = new System.Drawing.Point(199, 19);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(104, 21);
            this.lbFunc.TabIndex = 1;
            this.lbFunc.Text = "Funcionário";
            // 
            // lbTarefa
            // 
            this.lbTarefa.AutoSize = true;
            this.lbTarefa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarefa.Location = new System.Drawing.Point(23, 97);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(63, 21);
            this.lbTarefa.TabIndex = 2;
            this.lbTarefa.Text = "Tarefa";
            // 
            // lbStartData
            // 
            this.lbStartData.AutoSize = true;
            this.lbStartData.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartData.Location = new System.Drawing.Point(23, 170);
            this.lbStartData.Name = "lbStartData";
            this.lbStartData.Size = new System.Drawing.Size(130, 21);
            this.lbStartData.TabIndex = 3;
            this.lbStartData.Text = "Data de Início";
            // 
            // lbEndData
            // 
            this.lbEndData.AutoSize = true;
            this.lbEndData.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndData.Location = new System.Drawing.Point(199, 170);
            this.lbEndData.Name = "lbEndData";
            this.lbEndData.Size = new System.Drawing.Size(113, 21);
            this.lbEndData.TabIndex = 4;
            this.lbEndData.Text = "Data de Fim";
            // 
            // lbDescrição
            // 
            this.lbDescrição.AutoSize = true;
            this.lbDescrição.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrição.Location = new System.Drawing.Point(23, 238);
            this.lbDescrição.Name = "lbDescrição";
            this.lbDescrição.Size = new System.Drawing.Size(94, 21);
            this.lbDescrição.TabIndex = 5;
            this.lbDescrição.Text = "Descrição";
            // 
            // cmbEquipa
            // 
            this.cmbEquipa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipa.FormattingEnabled = true;
            this.cmbEquipa.Location = new System.Drawing.Point(27, 44);
            this.cmbEquipa.Name = "cmbEquipa";
            this.cmbEquipa.Size = new System.Drawing.Size(140, 28);
            this.cmbEquipa.TabIndex = 6;
            // 
            // cmbFunc
            // 
            this.cmbFunc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Location = new System.Drawing.Point(203, 44);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(140, 28);
            this.cmbFunc.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 8;
            // 
            // mtxtStartData
            // 
            this.mtxtStartData.Location = new System.Drawing.Point(27, 195);
            this.mtxtStartData.Name = "mtxtStartData";
            this.mtxtStartData.Size = new System.Drawing.Size(140, 22);
            this.mtxtStartData.TabIndex = 9;
            // 
            // mtxtEndData
            // 
            this.mtxtEndData.Location = new System.Drawing.Point(203, 195);
            this.mtxtEndData.Name = "mtxtEndData";
            this.mtxtEndData.Size = new System.Drawing.Size(140, 22);
            this.mtxtEndData.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(27, 263);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 175);
            this.textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.mtxtEndData);
            this.Controls.Add(this.mtxtStartData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbFunc);
            this.Controls.Add(this.cmbEquipa);
            this.Controls.Add(this.lbDescrição);
            this.Controls.Add(this.lbEndData);
            this.Controls.Add(this.lbStartData);
            this.Controls.Add(this.lbTarefa);
            this.Controls.Add(this.lbFunc);
            this.Controls.Add(this.lbEquipa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEquipa;
        private System.Windows.Forms.Label lbFunc;
        private System.Windows.Forms.Label lbTarefa;
        private System.Windows.Forms.Label lbStartData;
        private System.Windows.Forms.Label lbEndData;
        private System.Windows.Forms.Label lbDescrição;
        private System.Windows.Forms.ComboBox cmbEquipa;
        private System.Windows.Forms.ComboBox cmbFunc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox mtxtStartData;
        private System.Windows.Forms.MaskedTextBox mtxtEndData;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

