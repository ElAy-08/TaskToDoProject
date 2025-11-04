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

namespace TaskToDo.Pasta_Forms
{
    public partial class FormEscolherFicheiro : Form
    {
        private string configPath; //vamos receber como paramêtro

        public FormEscolherFicheiro(string configPath)
        {
            InitializeComponent();
            this.configPath = configPath;
        }

        private void btnEscolherPasta_Click(object sender, EventArgs e)
        {
            //NOTA: Usamos o using para garantir que o objeto é destruído após o uso
            using (var dlg = new FolderBrowserDialog()) //Criamos objeto OpenFileDialog (abre o Selecionador de Pastas)
            {
                dlg.Description = "Escolha qualquer ficheiro dentro da pasta dos dados";
                dlg.ShowNewFolderButton = true; // permite criar uma nova pasta
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = dlg.SelectedPath; //Mostra o path na TextBox
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var folder = txtPath.Text.Trim(); //Lemos o Path que ficou na TextBox
            if (!Directory.Exists(folder)) //verifica se a pasta existe
            {
                MessageBox.Show("Pasta inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Se ainda não existir a pasta onde vai ficar o config.txt cria automaticamente
            Directory.CreateDirectory(Path.GetDirectoryName(configPath)); 
            //Escreve o caminho da pasta com dados lá dentro
            File.WriteAllText(configPath, folder);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
