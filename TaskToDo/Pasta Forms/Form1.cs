using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TaskToDo.Pasta_Classes;

namespace TaskToDo
{
    public partial class Form1 : Form
    {
        //Guarda o Path da pasta onde estão os ficheiros com os dados da app (employees.txt, etc...)
        //Serve para o programa saber onde deve procurar esses ficheiros (dados) na próxima vez que for aberto

        //Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData):
        //Ele guarda o ficheiro de config (config.text) que diz onde estão os ficheiros com os dados
        //Na Pasta AppData do nosso User e não na mesma pasta da aplicação
        private string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TaskToDo", "config.txt");

        //Vai guardar a pasta onde estão os ficheiros com os dados
        private string dataFolder;

        private const string FUNCIONARIOS_FILE = "funcionarios.txt"; //Vai representar a lista de funcionários (que vai ser carregada para a comboBox)
        private const string EQUIPAS_FILE = "equipas.txt"; //Vai representar a lista de equipas
        private const string TREE_FILE = "tree.xml"; //Vai representar a serialização da tree view com as equipas, funcionários e tarefas
        private const string LOG_FILE = "log.txt"; //É o ficheiro de logs de erros que o professor pediu no final do enuncionado

        public Form1()
        {
            InitializeComponent();
            cmbEquipa.DropDownStyle = ComboBoxStyle.DropDownList; // O Style DropDownList impede o utilizador de escrever na ComboBox
            
            //Máscaras das Datas
            mtxtStartData.Mask = "00/00/0000";
            mtxtEndData.Mask = "00/00/0000";
        }

        //Função que tentar ler o caminho do config.txt e se não conseguir descobrir onde estão os ficheiros com os dados
        //usa uma pasta padrão. 
        //SERVE PARA QUE? Saber sempre onde estão os ficheiros com os dados, mesmo que o user mude de computador ou apague o
        //ficheiro, basicamente garande que o app arranque sem erro, mesmo que o config.txt não exista.
        private string CarregarConfigPastaDados()
        {
            try
            {
                if (File.Exists(configPath)) //Verificamos se o ficheiro config.txt existe
                {
                    string p = File.ReadAllText(configPath).Trim(); //Lê o conteúdo do config.txt, onde deve ter a pasta com os dados
                    if (!string.IsNullOrEmpty(p)) return p; //Da return desse Path que retira do config.txt se não estiver vazio
                }
            }
            //Se der algum erro a ler o ficheiro(tipo falta de permissão), guarda o erro no log e continua.
            catch (Exception ex) 
            { 
                LogError("Falha a ler config: " + ex.ToString()); 
            }

            //Caso o config.txt não exista ou esteja vazio
            //Usamos uma pasta alternativa chamada TaskToDoData dentro dos Documentos do utilizador.
            //Assim nunca falha ao arrancar, mesmo se não tiver o config
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TaskToDoData");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Chamamos a função para descobrir onde estão os ficheiros com os dados.
                dataFolder = CarregarConfigPastaDados();
                //Se a pasta não existir nos Documentos, criamos a pasta
                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                }

                //Criamos o Path completo dos ficheiros com os nossos dados
                //Juntamos a pasta que acabamos de criar/descobrir + o nome dos ficheiros
                string empPath = Path.Combine(dataFolder, FUNCIONARIOS_FILE);
                string teamPath = Path.Combine(dataFolder, EQUIPAS_FILE);

                //Verificamos se os 2 primeiros ficheiros obrigatórios existem
                if (!File.Exists(empPath) || !File.Exists(teamPath))
                {
                    //Mostramos mensagem de erro e abrimos o FormEscolherFicheiro
                    //Para o utilizador escolher a pasta onde ele tem o ficheiro com os dados
                    MessageBox.Show($"Ficheiros obrigatórios não encontrados na pasta:\n{dataFolder}\n\nA aplicação não pode iniciar.", "Ficheiros em falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    using (var frm = new Pasta_Forms.FormEscolherFicheiro(configPath))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            dataFolder = File.ReadAllText(configPath).Trim(); //Lemos o conteúdo do ficheiro que a pessoa escolheu no FormEscolherFicheiro
                            //Criamos o Path completo dos ficheiros com os nossos dados
                            empPath = Path.Combine(dataFolder, FUNCIONARIOS_FILE);
                            teamPath = Path.Combine(dataFolder, EQUIPAS_FILE);

                            if (File.Exists(empPath) && File.Exists(teamPath))
                            {
                                //Se os dois ficheiros existirem nesta pasta
                                //Então as funções de carregar os dados são chamadas
                                CarregaFuncionarios(empPath);
                                CarregaEquipas(teamPath);
                            }
                            else
                            {
                                //Se mesmo assim clicar em OK e os ficheiros não existirem
                                MessageBox.Show("Os ficheiros ainda não foram encontrados na pasta selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit();
                            }
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    return;
                }

                //Se o programa nem entrar no IF
                //Ou seja se o programa encontrar já os ficheiros criados
                //Carrega logo os dados dos funcionarios e equipas
                CarregaFuncionarios(empPath);
                CarregaEquipas(teamPath);

                //Tentamos carregar a TreeView
                string treePath = Path.Combine(dataFolder, TREE_FILE);
                //Se o ficheiro existir, reconstruímos a TreeView
                if (File.Exists(treePath))
                {
                    CarregaTreeViewDoXML(treePath);
                }
            }
            //Guardamos o erro no ficheiro de log e mostramos mensagem de erro ao utilizador
            catch (Exception ex)
            {
                LogError("Erro no arranque: " + ex.ToString());
                MessageBox.Show("Ocorreu um erro durante o arranque. Verifique o ficheiro de logs.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }


        private void CarregaFuncionarios(string path)
        {
            try
            {
                //Vamos ler todas as linhas do ficheiro do paramétro 'path'
                //Ignoramos as linhas vazias e retiramos os espaços em branco
                //Depois colocamos tudo numa lista
                var lines = File.ReadAllLines(path).Where(l => !string.IsNullOrWhiteSpace(l)).Select(l => l.Trim()).ToList();
                //Limpamos ComboBox antes de adicionar alguma coisa
                cmbFunc.Items.Clear();
                //Adicionamos cada funcionário da lista à ComboBox
                foreach (var l in lines) cmbFunc.Items.Add(l);
            }
            //Se der erro, guardamos no ficheiro de log e lançamos o erro
            catch (Exception ex)
            {
                LogError("Erro a ler employees: " + ex.ToString());
                throw;
            }
        }


        private void CarregaEquipas(string path)
        {
            //MESMO FUNCIONAMENTO EXPLICADO NO CARREGAR FUNCIONÁRIOS
            try
            {
                var lines = File.ReadAllLines(path).Where(l => !string.IsNullOrWhiteSpace(l)).Select(l => l.Trim()).ToList();
                cmbEquipa.Items.Clear();
                foreach (var l in lines) cmbEquipa.Items.Add(l);
            }
            catch (Exception ex)
            {
                LogError("Erro a ler teams: " + ex.ToString());
                throw;
            }
        }

        private void CarregaTreeViewDoXML(string path)
        {
            try
            {
                //Criamos um objeto Serializer.
                //O tipo Root é a classe modelo que vai representar a estrutura da TreeView (Ver Classe Root.cs)
                //Basicamente o tree.xml é uma versão em texto do objeto Root
                XmlSerializer xs = new XmlSerializer(typeof(Root));

                using (var fs = File.OpenRead(path)) //Lemos o ficheiro
                {
                    //Convertemos o XML de volta para um objeto Root
                    var rootObj = (Root)xs.Deserialize(fs); //Desserializamos o ficheiro para um objeto do tipo Class Root
                    //Chamamos o método que vai "popular" a TreeView com os dados do objeto Root que foi desserializado
                    PopularTreeView(rootObj);
                }
            }
            //Se der erro, guardamos no ficheiro de log e mostramos mensagem de aviso ao utilizador
            catch (Exception ex)
            {
                LogError("Erro a ler tree xml: " + ex.ToString());
                // não é fatal: apenas avisar
                MessageBox.Show("Ficheiro tree.xml inválido — ignorado. Verifique o log.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Recebemos o objeto Root que foi desserializado do XML e reconstruimos a TreeView
        private void PopularTreeView(Root rootObj) 
        {
            //Limpa TreeView
            tvw_main.Nodes.Clear();
            //Percorremos todas as equipas do objeto Root passado como parâmetro
            foreach (var equipa in rootObj.Equipas)
            {
                //Para cada equipa cria um Node com o nome da Equipa
                //Guardamos dentro do Node o objeto Equipa com todos os dados (nome, lista func, etc..)
                TreeNode equipaNode = new TreeNode(equipa.Nome) { Tag = equipa };
                //NOTA: Tag é uma propriedade escondida que qualquer controlo tem (TreeViews, Botoes etc..) serve para guardar qualquer objeto associado a esse controlo

                //Dentro de cada equipa, percorremos os funcionários
                foreach (var func in equipa.Funcionarios)
                {
                    //Criamos um Node com o nome do Func e também guardamos o objeto na Tag
                    TreeNode funcNode = new TreeNode(func.Nome) { Tag = func };

                    //Dentro de cada funcionário, percorremos as tarefas
                    foreach (var tarefa in func.Tarefas)
                    {
                        //Criamos um Node para cada Tarefa e adicionamos como SubNode do Func
                        //O ToString() é só pra mostrar o nome da tarefa
                        TreeNode tarNode = new TreeNode(tarefa.ToString()) { Tag = tarefa };
                        funcNode.Nodes.Add(tarNode);
                    }
                    //Depois de adicionarmos tarefas, o Node do Func é adicionado dentro da Equipa
                    equipaNode.Nodes.Add(funcNode);
                }
                //No fim, a equipa inteira, com funcs e tarefas é adicionada à TreeView
                tvw_main.Nodes.Add(equipaNode);
            }
            tvw_main.ExpandAll();
        }

        //Método para guardar os erros num ficheiro de log - log.txt
        private void LogError(string message)
        {
            try
            {
                string logFolder = Path.GetDirectoryName(configPath); //Descobre a pasta onde está o ficheiro config.txt
                if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder); //Se não existir, criamos
                string logFull = Path.Combine(logFolder, LOG_FILE); //Criamos o caminho completo do ficheiro de log
                //Escreve /ou acrescenta (Append) uma nova linha com data/hora e mensagem de erro
                File.AppendAllText(logFull, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao tentar gravar log: " + ex.Message);
            }
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            //Error Providers - ComboBoxes, TextBox e CheckBoxes
            if (string.IsNullOrEmpty(txtTarefa.Text))
            {
                errorProvider1.SetError(txtTarefa, "O nome da tarefa não pode estar vazio.");
                valido = false;
            }
            if (chbCoordenador.Checked == false && chbResponsavel.Checked == false || (chbCoordenador.Checked && chbResponsavel.Checked))
            {
                errorProvider2.SetError(grbCargo, "Deve selecionar pelo menos um tipo de cargo.");
                valido = false;
            }
            if (cmbEquipa.SelectedIndex == -1)
            {
                errorProvider3.SetError(cmbEquipa, "Deve selecionar uma equipa.");
                valido = false;
            }
            if (cmbFunc.Text == "")
            {
                errorProvider4.SetError(cmbFunc, "Deve selecionar um funcionário.");
                valido = false;
            }
            if (!cmbFunc.Items.Contains(cmbFunc.Text))
            {
                cmbFunc.Items.Add(cmbFunc.Text);
            }

            //Error Providers - MaskedTextBoxes (Datas)
            if (!mtxtStartData.MaskCompleted) //MaskCompleted vê se as entradas obrigatórias da máscara estão preenchidas / MaskFull ve as obrigatórias e opcionais
            {
                errorProvider5.SetError(mtxtStartData, "Deve inserir uma data de início válida.");
                valido = false;
            }
            if (!mtxtEndData.MaskCompleted)
            {
                errorProvider6.SetError(mtxtEndData, "Deve inserir uma data de fim válida.");
                valido = false;
            }

            //Validação das Datas

            if (mtxtStartData.MaskCompleted && mtxtEndData.MaskCompleted)
            {
                DateTime dataInicio, dataFim;

                bool InicioOK = DateTime.TryParse(mtxtStartData.Text, out dataInicio);
                bool FimOK = DateTime.TryParse(mtxtEndData.Text, out dataFim);

                //Só caso o utilizador coloque algo estúpido tipo 99/99/9999 é que o TryParse falha e manda este erro
                if (!InicioOK)
                {
                    errorProvider5.SetError(mtxtStartData, "Data de início inválida.");
                    valido = false;
                }
                //QUERO OPINIÃO AQUI = Devo colocar isso ou não? Porque o Admin disto pode estar a atribuir uma tarefa que começa antes de hoje, 
                //tipo uma tarefa que já devia ter começado mas ainda não foi registada no sistema
                //Verifica se DataInicio é maior do que o Dia de Hoje
                else if (dataInicio.Date < DateTime.Today)
                {
                    errorProvider5.SetError(mtxtStartData, "A data de início não pode ser anterior a hoje.");
                    valido = false;
                }

                //Novamente verificação caso user coloque algo estúpido
                if (!FimOK)
                {
                    errorProvider6.SetError(mtxtEndData, "Data de fim inválida.");
                    valido = false;
                }
                //Verifica se DataFim é maior que a DataInicio, senão não faz sentido
                else if (InicioOK && FimOK && dataFim.Date < dataInicio.Date)
                {
                    errorProvider6.SetError(mtxtEndData, "A data de fim não pode ser anterior à data de início.");
                    valido = false;
                }
            }

            //Se não for válido, mostra mensagem de erro
            if (!valido)
            {
                MessageBox.Show("Foram detetados erros na introdução dos dados. Por favor, verifique e preencha todas as informações corretamente.", "Falha na introdução de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Procura a equipe na TreeView
            TreeNode teamNode = tvw_main.Nodes
                .Cast<TreeNode>()
                .FirstOrDefault(n => n.Text == cmbEquipa.Text);

            if (teamNode == null)
            {
                // Se não existir, cria a equipe
                teamNode = new TreeNode(cmbEquipa.Text) { Tag = new Equipa { Nome = cmbEquipa.Text } };
                tvw_main.Nodes.Add(teamNode);
            }


            // 2. Procura o funcionário dentro da equipe
            TreeNode funcNode = teamNode.Nodes
                .Cast<TreeNode>()
                .FirstOrDefault(n => n.Text.StartsWith(cmbFunc.Text));

            if (chbCoordenador.Checked)
            {
                bool jaTemCoord = teamNode?.Nodes
                    .Cast<TreeNode>()
                    .Any(n => n.Text.Contains("Coordenador")) == true;

                if (jaTemCoord)
                {
                    MessageBox.Show("Esta equipa já possui um Coordenador atribuído.",
                        "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (teamNode != null && teamNode.Nodes.Count >= 5)
            {
                MessageBox.Show("Cada equipa pode ter no máximo 5 funcionários.",
                    "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (funcNode != null && funcNode.Nodes.Count >= 3)
            {
                MessageBox.Show("Cada funcionário pode ter no máximo 3 tarefas.",
                    "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (funcNode == null)
            {
                // Adiciona o funcionário e indica cargo
                string cargo = (chbCoordenador.Checked ? "Coordenador" : "") +
                               (chbResponsavel.Checked ? (chbCoordenador.Checked ? " / " : "") + "Responsável" : "");

                string nomeComCargo = string.IsNullOrEmpty(cargo) ? cmbFunc.Text : $"{cmbFunc.Text} - {cargo}";

                funcNode = new TreeNode(nomeComCargo) { Tag = new Funcionario(cmbFunc.Text) };

                // Se for Coordenador, adiciona no topo da lista de funcionários da equipe
                if (chbCoordenador.Checked)
                    teamNode.Nodes.Insert(0, funcNode); // topo
                else
                    teamNode.Nodes.Add(funcNode); // final
            }

            if (teamNode.Tag is Equipa equipa && funcNode.Tag is Funcionario funci)
            {
                equipa.Funcionarios.Add(funci);
            }//Adiciona o funcionário à lista de funcionários da equipa

            // 3. Adiciona ou edita a tarefa
            TreeNode taskNode = funcNode.Nodes
                .Cast<TreeNode>()
                .FirstOrDefault(n => n.Tag is Tarefa t && t.Nome.Equals(txtTarefa.Text, StringComparison.OrdinalIgnoreCase));

            if (taskNode != null && taskNode.Tag is Tarefa tarefaExistente)
            {
                // Editar a tarefa existente
                tarefaExistente.Descricao = txt_desc.Text;
                tarefaExistente.DataInicio = Convert.ToDateTime(mtxtStartData.Text);
                tarefaExistente.DataFim = Convert.ToDateTime(mtxtEndData.Text);

                // Atualiza o texto do nó se quiseres mostrar nome + outros detalhes
                taskNode.Text = tarefaExistente.Nome;
            }
            else
            {
                //Criar nova tarefa
                var novaTarefa = new Tarefa(
                    txtTarefa.Text,
                    txt_desc.Text,
                    Convert.ToDateTime(mtxtStartData.Text),
                    Convert.ToDateTime(mtxtEndData.Text)
                );

                taskNode = new TreeNode(novaTarefa.Nome) { Tag = novaTarefa };

                if (funcNode.Tag is Funcionario func)
                {
                    func.Tarefas.Add(novaTarefa);
                }

                funcNode.Nodes.Add(taskNode);
            }

            // Seleciona o nó atualizado/novo
            tvw_main.SelectedNode = taskNode;
            tvw_main.SelectedNode.EnsureVisible();

            LimparControlos();



        }


        //INICIO - EVENTOS LIMPA ERROR PROVIDERS AO ALTERAR OS VALORES DOS CONTROLOS

        private void chbCoordenador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCoordenador.Checked || chbResponsavel.Checked)
            {
                errorProvider2.SetError(grbCargo, "");
            }
        }

        private void chbResponsavel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCoordenador.Checked || chbResponsavel.Checked)
            { 
                errorProvider2.SetError(grbCargo, "");
            }
        }

        private void cmbEquipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipa.SelectedIndex != -1)
            {
                errorProvider3.SetError(cmbEquipa, "");
            }
        }

        private void cmbFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFunc.SelectedIndex != -1)
            { 
                errorProvider4.SetError(cmbFunc, "");
            }
        }

        private void mtxtStartData_TextChanged(object sender, EventArgs e)
        {
            if (!mtxtStartData.MaskCompleted)
            {
                errorProvider5.SetError(mtxtStartData, "");
            }
        }

        private void mtxtEndData_TextChanged(object sender, EventArgs e)
        {
            if (!mtxtEndData.MaskCompleted)
            {
                errorProvider6.SetError(mtxtEndData, "");
            }
        }

        private void txtTarefa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                errorProvider1.SetError(txtTarefa, "");
            }
        }
        //FIM - EVENTOS LIMPA ERROR PROVIDERS AO ALTERAR OS VALORES DOS CONTROLOS


        private void tvw_main_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Seleciona o nó clicado (importante para botão direito)
            tvw_main.SelectedNode = e.Node;

            // Verifica o tipo através da Tag
            string tipo = e.Node.Tag?.GetType().Name;

            // Escolhe o menu certo
            switch (tipo)
            {
                case "Equipa":
                    tvw_main.ContextMenuStrip = cmm_equipa;
                    break;

                case "Funcionario":
                    tvw_main.ContextMenuStrip = cmm_func;
                    break;

                case "Tarefa":
                    tvw_main.ContextMenuStrip = cmm_tarefa;
                    break;

                default:
                    tvw_main.ContextMenuStrip = null; // sem menu
                    break;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvw_main.SelectedNode.Tag is Tarefa tarefa)
                {
                    txtTarefa.Text = tarefa.Nome;
                    txt_desc.Text = tarefa.Descricao;
                    mtxtStartData.Text = tarefa.DataInicio.ToString("dd/MM/yyyy");
                    mtxtEndData.Text = tarefa.DataFim.ToString("dd/MM/yyyy");
                    TreeNode funcNode = tvw_main.SelectedNode.Parent;
                    if (funcNode.Tag is Funcionario func)
                    {

                        cmbFunc.Text = func.Nome;
                    }
                    if (funcNode.Text.Contains("Coordenador"))
                    {
                        chbCoordenador.Checked = true;
                    }
                    else
                    {
                        chbCoordenador.Checked = false;
                    }
                    if (funcNode.Text.Contains("Responsável"))
                    {
                        chbResponsavel.Checked = true;
                    }
                    else
                    {
                        chbResponsavel.Checked = false;
                    }

                    TreeNode teamNode = funcNode.Parent;
                    cmbEquipa.Text = teamNode.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nenhum Item selecionado");
            }
                
            
            

        }

        private void LimparControlos()
        {
            txtTarefa.Clear();
            txt_desc.Clear();
            mtxtStartData.Clear();
            mtxtEndData.Clear();
            cmbEquipa.SelectedIndex = -1;
            cmbFunc.Text = "";  
            chbCoordenador.Checked = false;
            chbResponsavel.Checked = false;
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = tvw_main.SelectedNode;
                if (selectedNode == null) return; // Nenhum nó selecionado

                // Só pode apagar tarefas
                if (selectedNode.Tag is Tarefa tarefa)
                {
                    // Nó do funcionário (pai da tarefa)
                    TreeNode funcNode = selectedNode.Parent;
                    if (funcNode?.Tag is Funcionario funcionario)
                    {
                        // Nó da equipa (pai do funcionário) — guardamos antes de remover funcNode
                        TreeNode teamNode = funcNode.Parent;
                        Equipa equipa = teamNode?.Tag as Equipa;

                        // Remove a tarefa da lista de tarefas do funcionário
                        funcionario.Tarefas.Remove(tarefa);

                        // Remove o nó da tarefa da TreeView
                        selectedNode.Remove();

                        // Se o funcionário ficou sem tarefas, remove o nó do funcionário
                        if (!funcionario.Tarefas.Any())
                        {
                            // Remove o funcionário da lista da equipa
                            equipa?.Funcionarios.Remove(funcionario);

                            // Remove o nó do funcionário da TreeView
                            funcNode.Remove();

                            // Se a equipa ficou sem funcionários, remove o nó da equipa
                            if (equipa != null && !equipa.Funcionarios.Any())
                            {
                                teamNode.Remove();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Item selecionado");
            }


        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = tvw_main.SelectedNode;
                if (selectedNode == null) return;

                // Só funciona para tarefas
                if (selectedNode.Tag is Tarefa tarefa)
                {
                    // Nó do funcionário (pai da tarefa)
                    TreeNode funcNode = selectedNode.Parent;

                    // Nó da equipa (pai do funcionário)
                    TreeNode teamNode = funcNode?.Parent;
                    Equipa equipa = teamNode?.Tag as Equipa;

                    // Monta a mensagem principal
                    string mensagem = "Detalhes da Tarefa:\n";
                    mensagem += "Nome: " + tarefa.Nome + "\n";
                    mensagem += "Descrição: " + tarefa.Descricao + "\n";
                    mensagem += "Data Início: " + tarefa.DataInicio.ToString("dd/MM/yyyy") + "\n";
                    mensagem += "Data Fim: " + tarefa.DataFim.ToString("dd/MM/yyyy") + "\n";

                    if (equipa != null)
                        mensagem += "Equipa: " + equipa.Nome + "\n";

                    // Procura todos os funcionários que têm a mesma tarefa
                    List<string> funcionariosComTarefa = new List<string>();

                    foreach (TreeNode team in tvw_main.Nodes)
                    {
                        foreach (TreeNode func in team.Nodes)
                        {
                            if (func.Tag is Funcionario f)
                            {
                                if (f.Tarefas.Any(t => t.Nome.Equals(tarefa.Nome, StringComparison.OrdinalIgnoreCase)))
                                {
                                    funcionariosComTarefa.Add(f.Nome);
                                }
                            }
                        }
                    }

                    // Adiciona todos os funcionários em um único campo
                    if (funcionariosComTarefa.Any())
                    {
                        mensagem += "Funcionários: " + string.Join(", ", funcionariosComTarefa) + "\n";
                    }

                    MessageBox.Show(mensagem, "Detalhes da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Item selecionado");
            }
        }

        private void tarefasAtivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = tvw_main.SelectedNode;
                if (selectedNode == null) return;

                // Só funciona se o nó selecionado for um funcionário
                if (selectedNode.Tag is Funcionario funcionario)
                {
                    // Nó da equipa (pai do funcionário)
                    TreeNode teamNode = selectedNode.Parent;
                    Equipa equipa = teamNode?.Tag as Equipa;

                    // Monta a mensagem
                    string mensagem = "Tarefas Ativas do Funcionário:\n";
                    mensagem += "Funcionário: " + funcionario.Nome + "\n";
                    if (equipa != null)
                        mensagem += "Equipa: " + equipa.Nome + "\n\n";

                    if (funcionario.Tarefas.Any())
                    {
                        foreach (var tarefa in funcionario.Tarefas)
                        {
                            mensagem += "Tarefa: " + tarefa.Nome + "\n";
                            mensagem += "Data Início: " + tarefa.DataInicio.ToString("dd/MM/yyyy") + "\n";
                            mensagem += "Data Fim: " + tarefa.DataFim.ToString("dd/MM/yyyy") + "\n\n";
                        }
                    }
                    else
                    {
                        mensagem += "Este funcionário não tem tarefas ativas.\n";
                    }

                    MessageBox.Show(mensagem, "Tarefas Ativas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Item selecionado");
            }


        }

        private void listaDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = tvw_main.SelectedNode;
                if (selectedNode == null) return;

                // Só funciona se o nó selecionado for um funcionário
                if (selectedNode.Tag is Funcionario funcionario)
                {
                    // Nó da equipa (pai do funcionário)
                    TreeNode teamNode = selectedNode.Parent;
                    Equipa equipa = teamNode?.Tag as Equipa;

                    // Monta a mensagem
                    string mensagem = "Lista de Tarefas do Funcionário:\n";
                    mensagem += "Funcionário: " + funcionario.Nome + "\n";
                    if (equipa != null)
                        mensagem += "Equipa: " + equipa.Nome + "\n\n";

                    if (funcionario.Tarefas.Any())
                    {
                        foreach (var tarefa in funcionario.Tarefas)
                        {
                            mensagem += "Tarefa: " + tarefa.Nome + "\n";
                            mensagem += "Data Início: " + tarefa.DataInicio.ToString("dd/MM/yyyy") + "\n";
                            mensagem += "Data Fim: " + tarefa.DataFim.ToString("dd/MM/yyyy") + "\n\n";
                        }
                    }
                    else
                    {
                        mensagem += "Este funcionário não tem tarefas atribuídas.\n";
                    }

                    MessageBox.Show(mensagem, "Lista de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Item selecionado");
            }


        }

        private void ContextMenuCargaTrab_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = tvw_main.SelectedNode;
                if (selectedNode == null) return;

                // Só funciona se o nó selecionado for uma equipa
                if (selectedNode.Tag is Equipa equipa)
                {
                    string mensagem = $"Carga de Trabalho da Equipa: {equipa.Nome}\n\n";

                    // Lista de todas as tarefas da equipa
                    List<string> tarefasList = new List<string>();

                    foreach (var func in equipa.Funcionarios)
                    {
                        foreach (var tarefa in func.Tarefas)
                        {
                            tarefasList.Add($"Tarefa: {tarefa.Nome} | Funcionário: {func.Nome} | Data Fim: {tarefa.DataFim:dd/MM/yyyy}");
                        }
                    }

                    mensagem += $"Quantidade de tarefas: {tarefasList.Count}\n\n";

                    if (tarefasList.Count > 0)
                    {
                        mensagem += string.Join("\n", tarefasList);
                    }
                    else
                    {
                        mensagem += "Nenhuma tarefa atribuída aos funcionários desta equipa.";
                    }

                    MessageBox.Show(mensagem, "Carga de Trabalho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Item selecionado");

            }
            }

        private void ContextMenuDesempenho_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = tvw_main.SelectedNode;
                if (selectedNode == null) return;

                // Só funciona se o nó selecionado for uma equipa
                if (selectedNode.Tag is Equipa equipa)
                {
                    Equipa equipaXml = new Equipa
                    {
                        Nome = equipa.Nome
                    };
                    foreach (var func in equipa.Funcionarios)
                    {
                        Funcionario funcXml = new Funcionario
                        {
                            Nome = func.Nome
                        };

                        foreach (var tarefa in func.Tarefas)
                        {
                            funcXml.Tarefas.Add(new Tarefa(tarefa.Nome, tarefa.Descricao, tarefa.DataInicio, tarefa.DataFim));
                        }

                        equipaXml.Funcionarios.Add(funcXml);
                    }
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Title = "Salvar relatório de desempenho (XML)";
                        sfd.Filter = "Ficheiro XML (*.xml)|*.xml";
                        sfd.FileName = $"Desempenho_{equipa.Nome}.xml";

                        if (sfd.ShowDialog() != DialogResult.OK) return;

                        try
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(Equipa));
                            using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                serializer.Serialize(fs, equipaXml);
                            }

                            MessageBox.Show("Relatório de desempenho em XML gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao gerar o relatório XML: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Item selecionado");
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTreeViewParaXML();
            GuardarNovosFuncionarios();
            MessageBox.Show("Dados guardados com sucesso!");
        }


        private void GuardarNovosFuncionarios()
        {
            string empPath = Path.Combine(dataFolder, FUNCIONARIOS_FILE);

            // Criar lista de funcionários já existentes (se o ficheiro existir)
            List<string> funcionariosAntigos = new List<string>();
            if (File.Exists(empPath))
            {
                string[] linhas = File.ReadAllLines(empPath);
                foreach (string linha in linhas)
                {
                    if (linha.Trim() != "")
                        funcionariosAntigos.Add(linha.Trim());
                }
            }

            // Recolher funcionários atuais da TreeView
            List<string> funcionariosAtuais = new List<string>();
            foreach (TreeNode equipaNode in tvw_main.Nodes)
            {
                foreach (TreeNode funcNode in equipaNode.Nodes)
                {
                    if (funcNode.Tag is Funcionario func)
                    {
                        funcionariosAtuais.Add(func.Nome);
                    }
                }
            }

            // Verificar quais são novos (não estão na lista antiga)
            List<string> novos = new List<string>();
            foreach (string nome in funcionariosAtuais)
            {
                bool jaExiste = false;
                foreach (string antigo in funcionariosAntigos)
                {
                    if (nome == antigo)
                    {
                        jaExiste = true;
                        break;
                    }
                }

                if (!jaExiste)
                {
                    novos.Add(nome);
                }
            }

            // Só escreve se houver novos
            if (novos.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(empPath, true))
                {
                    foreach (string nomeNovo in novos)
                    {
                        sw.WriteLine(nomeNovo);
                    }
                }
            }
        }

        private void GuardarTreeViewParaXML()
        {
            string treePath = Path.Combine(dataFolder, TREE_FILE);
            Root rootObj = new Root();

            foreach (TreeNode equipaNode in tvw_main.Nodes)
            {
                if (equipaNode.Tag is Equipa equipa)
                {
                    Equipa equipaXml = new Equipa();
                    equipaXml.Nome = equipa.Nome;

                    foreach (TreeNode funcNode in equipaNode.Nodes)
                    {
                        if (funcNode.Tag is Funcionario func)
                        {
                            Funcionario funcXml = new Funcionario();
                            funcXml.Nome = func.Nome;

                            foreach (TreeNode tarefaNode in funcNode.Nodes)
                            {
                                if (tarefaNode.Tag is Tarefa tarefa)
                                {
                                    funcXml.Tarefas.Add(new Tarefa(
                                        tarefa.Nome,
                                        tarefa.Descricao,
                                        tarefa.DataInicio,
                                        tarefa.DataFim
                                    ));
                                }
                            }

                            equipaXml.Funcionarios.Add(funcXml);
                        }
                    }

                    rootObj.Equipas.Add(equipaXml);
                }
            }

            XmlSerializer xs = new XmlSerializer(typeof(Root));
            using (var fs = new FileStream(treePath, FileMode.Create))
            {
                xs.Serialize(fs, rootObj);
            }
        }
    }

}

