using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbEquipa.DropDownStyle = ComboBoxStyle.DropDownList; // O Style DropDownList impede o utilizador de escrever na ComboBox
            
            //Máscaras das Datas
            mtxtStartData.Mask = "00/00/0000";
            mtxtEndData.Mask = "00/00/0000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*(Gabriel Edições - 30/10/2025 9:30PM)
            MaxLenght da TextBox Tarefa já esta setada a 30
            ContextMenuMain foi ligado à TreeView através da propriedade ContextMenuStrip da TreeView
            ContextMenuMain já tem as opções, mas as mesmas ainda não tem funcionalidades
            3 Classes essenciais criadas: Funcionário, Equipa e Tarefa
            As Classes já têm os campos que considerei essenciais*/
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            //Error Providers - ComboBoxes, TextBox e CheckBoxes
            if(string.IsNullOrEmpty(txtTarefa.Text))
            {
                errorProvider1.SetError(txtTarefa,"O nome da tarefa não pode estar vazio.");
                valido = false;
            }
            if (chbCoordenador.Checked == false && chbResponsavel.Checked == false)
            {
                errorProvider2.SetError(grbCargo, "Deve selecionar pelo menos um tipo de cargo.");
                valido = false;
            }
            if(cmbEquipa.SelectedIndex == -1)
            {
                errorProvider3.SetError(cmbEquipa,"Deve selecionar uma equipa.");
                valido = false;
            }
            if (cmbFunc.SelectedIndex == -1)
            {
                errorProvider4.SetError(cmbFunc,"Deve selecionar um funcionário.");
                valido = false;
            }

            //Error Providers - MaskedTextBoxes (Datas)
            if (!mtxtStartData.MaskCompleted) //MaskCompleted vê se as entradas obrigatórias da máscara estão preenchidas / MaskFull ve as obrigatórias e opcionais
            {
                errorProvider5.SetError(mtxtStartData,"Deve inserir uma data de início válida.");
                valido = false;
            }
            if (!mtxtEndData.MaskCompleted)
            {
                errorProvider6.SetError(mtxtEndData,"Deve inserir uma data de fim válida.");
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

            //FALTA MENSAGEM CASO CORRA COM SUCESSO E A TAREFA SEJA ADICIONADA

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
            if (mtxtStartData.MaskCompleted)
            {
                errorProvider5.SetError(mtxtStartData, "");
            }
        }

        private void mtxtEndData_TextChanged(object sender, EventArgs e)
        {
            if (mtxtEndData.MaskCompleted)
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
    }
}
