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
            this.components = new System.ComponentModel.Container();
            this.lbEquipa = new System.Windows.Forms.Label();
            this.lbFunc = new System.Windows.Forms.Label();
            this.lbTarefa = new System.Windows.Forms.Label();
            this.lbStartData = new System.Windows.Forms.Label();
            this.lbEndData = new System.Windows.Forms.Label();
            this.lbDescrição = new System.Windows.Forms.Label();
            this.cmbEquipa = new System.Windows.Forms.ComboBox();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.mtxtStartData = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEndData = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chbCoordenador = new System.Windows.Forms.CheckBox();
            this.chbResponsavel = new System.Windows.Forms.CheckBox();
            this.grbCargo = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDetalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuTarefasAct = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuListaTar = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuCargaTrab = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDesempenho = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbCargo.SuspendLayout();
            this.contextMenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEquipa
            // 
            this.lbEquipa.AutoSize = true;
            this.lbEquipa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipa.Location = new System.Drawing.Point(26, 24);
            this.lbEquipa.Name = "lbEquipa";
            this.lbEquipa.Size = new System.Drawing.Size(79, 24);
            this.lbEquipa.TabIndex = 0;
            this.lbEquipa.Text = "Equipa";
            // 
            // lbFunc
            // 
            this.lbFunc.AutoSize = true;
            this.lbFunc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunc.Location = new System.Drawing.Point(224, 24);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(127, 24);
            this.lbFunc.TabIndex = 1;
            this.lbFunc.Text = "Funcionário";
            // 
            // lbTarefa
            // 
            this.lbTarefa.AutoSize = true;
            this.lbTarefa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarefa.Location = new System.Drawing.Point(26, 103);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(73, 24);
            this.lbTarefa.TabIndex = 2;
            this.lbTarefa.Text = "Tarefa";
            // 
            // lbStartData
            // 
            this.lbStartData.AutoSize = true;
            this.lbStartData.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartData.Location = new System.Drawing.Point(26, 225);
            this.lbStartData.Name = "lbStartData";
            this.lbStartData.Size = new System.Drawing.Size(155, 24);
            this.lbStartData.TabIndex = 3;
            this.lbStartData.Text = "Data de Início";
            // 
            // lbEndData
            // 
            this.lbEndData.AutoSize = true;
            this.lbEndData.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndData.Location = new System.Drawing.Point(224, 225);
            this.lbEndData.Name = "lbEndData";
            this.lbEndData.Size = new System.Drawing.Size(135, 24);
            this.lbEndData.TabIndex = 4;
            this.lbEndData.Text = "Data de Fim";
            // 
            // lbDescrição
            // 
            this.lbDescrição.AutoSize = true;
            this.lbDescrição.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrição.Location = new System.Drawing.Point(26, 298);
            this.lbDescrição.Name = "lbDescrição";
            this.lbDescrição.Size = new System.Drawing.Size(113, 24);
            this.lbDescrição.TabIndex = 5;
            this.lbDescrição.Text = "Descrição";
            // 
            // cmbEquipa
            // 
            this.cmbEquipa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipa.FormattingEnabled = true;
            this.cmbEquipa.Location = new System.Drawing.Point(30, 55);
            this.cmbEquipa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipa.Name = "cmbEquipa";
            this.cmbEquipa.Size = new System.Drawing.Size(157, 29);
            this.cmbEquipa.TabIndex = 6;
            this.cmbEquipa.SelectedIndexChanged += new System.EventHandler(this.cmbEquipa_SelectedIndexChanged);
            // 
            // cmbFunc
            // 
            this.cmbFunc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Location = new System.Drawing.Point(228, 55);
            this.cmbFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(201, 29);
            this.cmbFunc.TabIndex = 7;
            this.cmbFunc.SelectedIndexChanged += new System.EventHandler(this.cmbFunc_SelectedIndexChanged);
            // 
            // txtTarefa
            // 
            this.txtTarefa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarefa.Location = new System.Drawing.Point(30, 134);
            this.txtTarefa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTarefa.MaxLength = 30;
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(157, 30);
            this.txtTarefa.TabIndex = 8;
            this.txtTarefa.TextChanged += new System.EventHandler(this.txtTarefa_TextChanged);
            // 
            // mtxtStartData
            // 
            this.mtxtStartData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtStartData.Location = new System.Drawing.Point(30, 257);
            this.mtxtStartData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtStartData.Name = "mtxtStartData";
            this.mtxtStartData.Size = new System.Drawing.Size(157, 30);
            this.mtxtStartData.TabIndex = 9;
            this.mtxtStartData.TextChanged += new System.EventHandler(this.mtxtStartData_TextChanged);
            // 
            // mtxtEndData
            // 
            this.mtxtEndData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtEndData.Location = new System.Drawing.Point(228, 257);
            this.mtxtEndData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtEndData.Name = "mtxtEndData";
            this.mtxtEndData.Size = new System.Drawing.Size(157, 30);
            this.mtxtEndData.TabIndex = 10;
            this.mtxtEndData.TextChanged += new System.EventHandler(this.mtxtEndData_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(30, 329);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(399, 218);
            this.textBox2.TabIndex = 11;
            // 
            // chbCoordenador
            // 
            this.chbCoordenador.AutoSize = true;
            this.chbCoordenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCoordenador.Location = new System.Drawing.Point(18, 32);
            this.chbCoordenador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCoordenador.Name = "chbCoordenador";
            this.chbCoordenador.Size = new System.Drawing.Size(163, 29);
            this.chbCoordenador.TabIndex = 12;
            this.chbCoordenador.Text = "Coordenador";
            this.chbCoordenador.UseVisualStyleBackColor = true;
            this.chbCoordenador.CheckedChanged += new System.EventHandler(this.chbCoordenador_CheckedChanged);
            // 
            // chbResponsavel
            // 
            this.chbResponsavel.AutoSize = true;
            this.chbResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbResponsavel.Location = new System.Drawing.Point(18, 65);
            this.chbResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbResponsavel.Name = "chbResponsavel";
            this.chbResponsavel.Size = new System.Drawing.Size(163, 29);
            this.chbResponsavel.TabIndex = 13;
            this.chbResponsavel.Text = "Responsável";
            this.chbResponsavel.UseVisualStyleBackColor = true;
            this.chbResponsavel.CheckedChanged += new System.EventHandler(this.chbResponsavel_CheckedChanged);
            // 
            // grbCargo
            // 
            this.grbCargo.Controls.Add(this.chbCoordenador);
            this.grbCargo.Controls.Add(this.chbResponsavel);
            this.grbCargo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCargo.Location = new System.Drawing.Point(228, 103);
            this.grbCargo.Name = "grbCargo";
            this.grbCargo.Size = new System.Drawing.Size(201, 108);
            this.grbCargo.TabIndex = 14;
            this.grbCargo.TabStop = false;
            this.grbCargo.Text = "Cargo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(448, 496);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 51);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(448, 430);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(180, 51);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuMain;
            this.treeView1.Location = new System.Drawing.Point(642, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(190, 523);
            this.treeView1.TabIndex = 18;
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuEditar,
            this.ContextMenuApagar,
            this.ContextMenuDetalhes,
            this.ContextMenuTarefasAct,
            this.ContextMenuListaTar,
            this.ContextMenuCargaTrab,
            this.ContextMenuDesempenho});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(228, 228);
            // 
            // ContextMenuEditar
            // 
            this.ContextMenuEditar.Name = "ContextMenuEditar";
            this.ContextMenuEditar.Size = new System.Drawing.Size(227, 32);
            this.ContextMenuEditar.Text = "Editar";
            // 
            // ContextMenuApagar
            // 
            this.ContextMenuApagar.Name = "ContextMenuApagar";
            this.ContextMenuApagar.Size = new System.Drawing.Size(227, 32);
            this.ContextMenuApagar.Text = "Apagar";
            // 
            // ContextMenuDetalhes
            // 
            this.ContextMenuDetalhes.Name = "ContextMenuDetalhes";
            this.ContextMenuDetalhes.Size = new System.Drawing.Size(227, 32);
            this.ContextMenuDetalhes.Text = "Detalhes";
            // 
            // ContextMenuTarefasAct
            // 
            this.ContextMenuTarefasAct.Name = "ContextMenuTarefasAct";
            this.ContextMenuTarefasAct.Size = new System.Drawing.Size(227, 32);
            this.ContextMenuTarefasAct.Text = "Tarefas Activas";
            // 
            // ContextMenuListaTar
            // 
            this.ContextMenuListaTar.Name = "ContextMenuListaTar";
            this.ContextMenuListaTar.Size = new System.Drawing.Size(227, 32);
            this.ContextMenuListaTar.Text = "Lista de Tarefas";
            // 
            // ContextMenuCargaTrab
            // 
            this.ContextMenuCargaTrab.Name = "ContextMenuCargaTrab";
            this.ContextMenuCargaTrab.Size = new System.Drawing.Size(227, 32);
            this.ContextMenuCargaTrab.Text = "Carga de Trabalho";
            // 
            // ContextMenuDesempenho
            // 
            this.ContextMenuDesempenho.Name = "ContextMenuDesempenho";
            this.ContextMenuDesempenho.Size = new System.Drawing.Size(227, 32);
            this.ContextMenuDesempenho.Text = "Desempenho";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 562);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbCargo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.mtxtEndData);
            this.Controls.Add(this.mtxtStartData);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.cmbFunc);
            this.Controls.Add(this.cmbEquipa);
            this.Controls.Add(this.lbDescrição);
            this.Controls.Add(this.lbEndData);
            this.Controls.Add(this.lbStartData);
            this.Controls.Add(this.lbTarefa);
            this.Controls.Add(this.lbFunc);
            this.Controls.Add(this.lbEquipa);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCargo.ResumeLayout(false);
            this.grbCargo.PerformLayout();
            this.contextMenuMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
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
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.MaskedTextBox mtxtStartData;
        private System.Windows.Forms.MaskedTextBox mtxtEndData;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox chbCoordenador;
        private System.Windows.Forms.CheckBox chbResponsavel;
        private System.Windows.Forms.GroupBox grbCargo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuEditar;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuApagar;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDetalhes;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuTarefasAct;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuListaTar;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCargaTrab;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDesempenho;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}

