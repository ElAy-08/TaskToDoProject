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
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.chbCoordenador = new System.Windows.Forms.CheckBox();
            this.chbResponsavel = new System.Windows.Forms.CheckBox();
            this.grbCargo = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tvw_main = new System.Windows.Forms.TreeView();
            this.cmm_equipa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuCargaTrab = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDesempenho = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmm_tarefa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmm_func = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tarefasAtivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbCargo.SuspendLayout();
            this.cmm_equipa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.cmm_tarefa.SuspendLayout();
            this.cmm_func.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEquipa
            // 
            this.lbEquipa.AutoSize = true;
            this.lbEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquipa.Location = new System.Drawing.Point(23, 20);
            this.lbEquipa.Name = "lbEquipa";
            this.lbEquipa.Size = new System.Drawing.Size(60, 20);
            this.lbEquipa.TabIndex = 0;
            this.lbEquipa.Text = "Equipa";
            // 
            // lbFunc
            // 
            this.lbFunc.AutoSize = true;
            this.lbFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunc.Location = new System.Drawing.Point(199, 20);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(96, 20);
            this.lbFunc.TabIndex = 1;
            this.lbFunc.Text = "Funcionário";
            // 
            // lbTarefa
            // 
            this.lbTarefa.AutoSize = true;
            this.lbTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarefa.Location = new System.Drawing.Point(23, 81);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(57, 20);
            this.lbTarefa.TabIndex = 2;
            this.lbTarefa.Text = "Tarefa";
            // 
            // lbStartData
            // 
            this.lbStartData.AutoSize = true;
            this.lbStartData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartData.Location = new System.Drawing.Point(23, 180);
            this.lbStartData.Name = "lbStartData";
            this.lbStartData.Size = new System.Drawing.Size(112, 20);
            this.lbStartData.TabIndex = 3;
            this.lbStartData.Text = "Data de Início";
            // 
            // lbEndData
            // 
            this.lbEndData.AutoSize = true;
            this.lbEndData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndData.Location = new System.Drawing.Point(199, 180);
            this.lbEndData.Name = "lbEndData";
            this.lbEndData.Size = new System.Drawing.Size(101, 20);
            this.lbEndData.TabIndex = 4;
            this.lbEndData.Text = "Data de Fim";
            // 
            // lbDescrição
            // 
            this.lbDescrição.AutoSize = true;
            this.lbDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrição.Location = new System.Drawing.Point(23, 239);
            this.lbDescrição.Name = "lbDescrição";
            this.lbDescrição.Size = new System.Drawing.Size(86, 20);
            this.lbDescrição.TabIndex = 5;
            this.lbDescrição.Text = "Descrição";
            // 
            // cmbEquipa
            // 
            this.cmbEquipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipa.FormattingEnabled = true;
            this.cmbEquipa.Location = new System.Drawing.Point(27, 44);
            this.cmbEquipa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipa.Name = "cmbEquipa";
            this.cmbEquipa.Size = new System.Drawing.Size(140, 26);
            this.cmbEquipa.TabIndex = 6;
            this.cmbEquipa.SelectedIndexChanged += new System.EventHandler(this.cmbEquipa_SelectedIndexChanged);
            // 
            // cmbFunc
            // 
            this.cmbFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Location = new System.Drawing.Point(203, 44);
            this.cmbFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(179, 26);
            this.cmbFunc.TabIndex = 7;
            this.cmbFunc.SelectedIndexChanged += new System.EventHandler(this.cmbFunc_SelectedIndexChanged);
            // 
            // txtTarefa
            // 
            this.txtTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarefa.Location = new System.Drawing.Point(27, 107);
            this.txtTarefa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTarefa.MaxLength = 30;
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(140, 24);
            this.txtTarefa.TabIndex = 8;
            this.txtTarefa.TextChanged += new System.EventHandler(this.txtTarefa_TextChanged);
            // 
            // mtxtStartData
            // 
            this.mtxtStartData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtStartData.Location = new System.Drawing.Point(27, 207);
            this.mtxtStartData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtStartData.Name = "mtxtStartData";
            this.mtxtStartData.Size = new System.Drawing.Size(140, 24);
            this.mtxtStartData.TabIndex = 9;
            this.mtxtStartData.TextChanged += new System.EventHandler(this.mtxtStartData_TextChanged);
            // 
            // mtxtEndData
            // 
            this.mtxtEndData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtEndData.Location = new System.Drawing.Point(203, 207);
            this.mtxtEndData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtEndData.Name = "mtxtEndData";
            this.mtxtEndData.Size = new System.Drawing.Size(140, 24);
            this.mtxtEndData.TabIndex = 10;
            this.mtxtEndData.TextChanged += new System.EventHandler(this.mtxtEndData_TextChanged);
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(27, 263);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(355, 175);
            this.txt_desc.TabIndex = 11;
            // 
            // chbCoordenador
            // 
            this.chbCoordenador.AutoSize = true;
            this.chbCoordenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCoordenador.Location = new System.Drawing.Point(16, 26);
            this.chbCoordenador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCoordenador.Name = "chbCoordenador";
            this.chbCoordenador.Size = new System.Drawing.Size(127, 24);
            this.chbCoordenador.TabIndex = 12;
            this.chbCoordenador.Text = "Coordenador";
            this.chbCoordenador.UseVisualStyleBackColor = true;
            this.chbCoordenador.CheckedChanged += new System.EventHandler(this.chbCoordenador_CheckedChanged);
            // 
            // chbResponsavel
            // 
            this.chbResponsavel.AutoSize = true;
            this.chbResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbResponsavel.Location = new System.Drawing.Point(16, 52);
            this.chbResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbResponsavel.Name = "chbResponsavel";
            this.chbResponsavel.Size = new System.Drawing.Size(127, 24);
            this.chbResponsavel.TabIndex = 13;
            this.chbResponsavel.Text = "Responsável";
            this.chbResponsavel.UseVisualStyleBackColor = true;
            this.chbResponsavel.CheckedChanged += new System.EventHandler(this.chbResponsavel_CheckedChanged);
            // 
            // grbCargo
            // 
            this.grbCargo.Controls.Add(this.chbCoordenador);
            this.grbCargo.Controls.Add(this.chbResponsavel);
            this.grbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCargo.Location = new System.Drawing.Point(203, 81);
            this.grbCargo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.grbCargo.Name = "grbCargo";
            this.grbCargo.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.grbCargo.Size = new System.Drawing.Size(179, 86);
            this.grbCargo.TabIndex = 14;
            this.grbCargo.TabStop = false;
            this.grbCargo.Text = "Cargo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(223, 446);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 41);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // tvw_main
            // 
            this.tvw_main.Location = new System.Drawing.Point(408, 20);
            this.tvw_main.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tvw_main.Name = "tvw_main";
            this.tvw_main.Size = new System.Drawing.Size(299, 464);
            this.tvw_main.TabIndex = 18;
            this.tvw_main.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_main_NodeMouseClick);
            // 
            // cmm_equipa
            // 
            this.cmm_equipa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmm_equipa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuCargaTrab,
            this.ContextMenuDesempenho});
            this.cmm_equipa.Name = "contextMenuMain";
            this.cmm_equipa.Size = new System.Drawing.Size(201, 52);
            // 
            // ContextMenuCargaTrab
            // 
            this.ContextMenuCargaTrab.Name = "ContextMenuCargaTrab";
            this.ContextMenuCargaTrab.Size = new System.Drawing.Size(200, 24);
            this.ContextMenuCargaTrab.Text = "Carga de Trabalho";
            this.ContextMenuCargaTrab.Click += new System.EventHandler(this.ContextMenuCargaTrab_Click);
            // 
            // ContextMenuDesempenho
            // 
            this.ContextMenuDesempenho.Name = "ContextMenuDesempenho";
            this.ContextMenuDesempenho.Size = new System.Drawing.Size(200, 24);
            this.ContextMenuDesempenho.Text = "Desempenho";
            this.ContextMenuDesempenho.Click += new System.EventHandler(this.ContextMenuDesempenho_Click);
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
            // cmm_tarefa
            // 
            this.cmm_tarefa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmm_tarefa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.detalhesToolStripMenuItem});
            this.cmm_tarefa.Name = "cmm_tarefa";
            this.cmm_tarefa.Size = new System.Drawing.Size(137, 76);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.apagarToolStripMenuItem.Text = "Apagar";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            this.detalhesToolStripMenuItem.Click += new System.EventHandler(this.detalhesToolStripMenuItem_Click);
            // 
            // cmm_func
            // 
            this.cmm_func.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmm_func.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefasAtivasToolStripMenuItem,
            this.listaDeTarefasToolStripMenuItem});
            this.cmm_func.Name = "cmm_func";
            this.cmm_func.Size = new System.Drawing.Size(180, 52);
            // 
            // tarefasAtivasToolStripMenuItem
            // 
            this.tarefasAtivasToolStripMenuItem.Name = "tarefasAtivasToolStripMenuItem";
            this.tarefasAtivasToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.tarefasAtivasToolStripMenuItem.Text = "Tarefas Ativas";
            this.tarefasAtivasToolStripMenuItem.Click += new System.EventHandler(this.tarefasAtivasToolStripMenuItem_Click);
            // 
            // listaDeTarefasToolStripMenuItem
            // 
            this.listaDeTarefasToolStripMenuItem.Name = "listaDeTarefasToolStripMenuItem";
            this.listaDeTarefasToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.listaDeTarefasToolStripMenuItem.Text = "Lista de Tarefas";
            this.listaDeTarefasToolStripMenuItem.Click += new System.EventHandler(this.listaDeTarefasToolStripMenuItem_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(27, 446);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(160, 41);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 492);
            this.Controls.Add(this.tvw_main);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbCargo);
            this.Controls.Add(this.txt_desc);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskToDo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCargo.ResumeLayout(false);
            this.grbCargo.PerformLayout();
            this.cmm_equipa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.cmm_tarefa.ResumeLayout(false);
            this.cmm_func.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.CheckBox chbCoordenador;
        private System.Windows.Forms.CheckBox chbResponsavel;
        private System.Windows.Forms.GroupBox grbCargo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TreeView tvw_main;
        private System.Windows.Forms.ContextMenuStrip cmm_equipa;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuCargaTrab;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDesempenho;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ContextMenuStrip cmm_tarefa;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmm_func;
        private System.Windows.Forms.ToolStripMenuItem tarefasAtivasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeTarefasToolStripMenuItem;
        private System.Windows.Forms.Button btnAdicionar;
    }
}

