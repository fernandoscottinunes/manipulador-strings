using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringHandler.Entity;
using StringHandler.Model;

namespace StringHandler.View
{
    public partial class frmStringHandler : frmBase
    {

        EntityStringHandler objStringHandler = new EntityStringHandler();

        public frmStringHandler()
        {
            InitializeComponent();
        }

        private void frmStringHandler_Load(object sender, EventArgs e)
        {
            this.listGrid();
        }

        private void tbInputText_TextChanged(object sender, EventArgs e)
        {
            //int characterCount = 250 - this.tbInputText.Text.Length;
            this.lblCharacterCount.Text = "(Restam " + (250 - this.tbInputText.Text.Length) + " de 250 caracteres)";
            //this.tbOutputText.Text = this.tbInputText.Text;

        }

        private void lblClearText_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnCountWord_Click(object sender, EventArgs e)
        {
            this.executeOption(1, this.btnCountWord.Text);
        }

        private void btnCountLetter_Click(object sender, EventArgs e)
        {
            this.executeOption(2, this.btnCountLetter.Text);
        }

        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            this.executeOption(3, this.btnUpperCase.Text);
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            this.executeOption(4, this.btnLowerCase.Text);
        }

        private void btnReverseWord_Click(object sender, EventArgs e)
        {
            this.executeOption(5, this.btnReverseWord.Text);
        }

        private void btnReverseLetter_Click(object sender, EventArgs e)
        {
            this.executeOption(6, this.btnReverseLetter.Text);
        }

        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            this.executeOption(7, this.btnWordWrap.Text);
        }

        private void btnShuffleWord_Click(object sender, EventArgs e)
        {
            this.executeOption(8, this.btnShuffleWord.Text);
        }

        private void btnShuffleLetter_Click(object sender, EventArgs e)
        {
            this.executeOption(9, this.btnShuffleLetter.Text);
        }

        private void clearFields()
        {
            this.tbInputText.Clear();
            this.tbOutputText.Clear();
        }


        // Função para execução das opções dos botões do formulário
        private void executeOption(int option, string functionUsed)
        {

            objStringHandler.InputText = this.tbInputText.Text;
            objStringHandler.FunctionUsed = functionUsed;
            objStringHandler.DateAndTime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");

            // Verifica qual opção/botão foi selecionado
            if (this.tbInputText.TextLength != 0)
            {
                switch (option)
                {
                    case 1:
                        try
                        {
                            int opt = StringHandlerModel.countWord(objStringHandler);
                            this.tbOutputText.Text = objStringHandler.OutputText;
                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            int opt = StringHandlerModel.countCharacter(objStringHandler);
                            this.tbOutputText.Text = objStringHandler.OutputText;
                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            int opt = StringHandlerModel.upperCaseText(objStringHandler);
                            this.tbOutputText.Text = objStringHandler.OutputText;
                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }
                        
                        break;

                    case 4:
                        try
                        {

                            int opt = StringHandlerModel.lowerCaseText(objStringHandler);

                            this.tbOutputText.Text = objStringHandler.OutputText;

                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }

                        break;

                    case 5:
                        try
                        {

                            int opt = StringHandlerModel.reverseWord(objStringHandler);

                            this.tbOutputText.Text = objStringHandler.OutputText;

                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }

                        break;

                    case 6:
                        try
                        {
                            int opt = StringHandlerModel.reverseCharacter(objStringHandler);

                            this.tbOutputText.Text = objStringHandler.OutputText;

                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }

                        break;

                    case 7:
                        try
                        {
                            int opt = StringHandlerModel.wordWrap(objStringHandler);

                            this.tbOutputText.Text = objStringHandler.OutputText;

                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }

                        break;

                    case 8:
                        try
                        {
                            int opt = StringHandlerModel.shuffleWord(objStringHandler);

                            this.tbOutputText.Text = objStringHandler.OutputText;

                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }

                        break;

                    case 9:
                        try
                        {
                            int opt = StringHandlerModel.shuffleCharacter(objStringHandler);

                            this.tbOutputText.Text = objStringHandler.OutputText;

                            if (opt == 0)
                            {
                                MessageBox.Show("Erro ao salvar histórico!");
                            }
                            else
                            {
                                listGrid();
                                MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ocorreu um erro!\n" + e.Message);
                        }

                        break;

                    default:
                        MessageBox.Show(string.Format("Função '{0}' executada com êxito!", functionUsed));
                        break;
                }

                
            }
            else
            {
                MessageBox.Show("Digite algum texto...");
            }

        }

        public void listGrid()
        {
            try
            {
                List<EntityStringHandler> listHistory = new List<EntityStringHandler>();
                listHistory = new StringHandlerModel().listHistory();
                dgHistory.AutoGenerateColumns = false;
                this.dgHistory.DataSource = listHistory;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao recuperar dados do histórico!\n" + e.Message);
            }
        }

        
    }
}
