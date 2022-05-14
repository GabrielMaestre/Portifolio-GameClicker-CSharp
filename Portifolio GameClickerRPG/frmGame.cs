using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portifolio_GameClickerRPG
{
    public partial class frmGame : Form
    {

        int _conta = 0;
        int _perClick = 10;
        int _perClickAuto = 1;
        int _tAutoClickSpeed = 2000;//CADA 2000ms (2segundos)

        //UPGRADES TABELA//
        const int upAutoClick = 100;
        const int upDoubleClick = 500;

        const int upAutoClickS1 = 500;
        const int upAutoClickS2 = 1000;
        const int upAutoClickS3 = 10000;
        const int upAutoClickB1 = 5000;
        const int upAutoClickB2 = 10000;
        const int upAutoClickB3 = 100000;
        const int upAutoClickUltimate = 1000000;

        const int upClickP1 = 1000;
        const int upClickP2 = 10000;
        const int upClickP3 = 100000;
        const int upClickUltimate = 1000000;
        //obs.: eu sei que os nomes das variaveis não estão padronizadas e eu poderia usar AC..ACS1..AC1..AC2..ETC...
        //FIM------TABELA//

        public frmGame()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            ClickPrincipalFunc();
        }

        private void btnAutoClick_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClick;
            const string upgradeName = "AutoClick";
            ComprarUpgrade(custoUpgrade, this.btnAutoClick, upgradeName);
        }

        int qtdTimerRun = 0;
        private void tlblUper_Tick(object sender, EventArgs e)
        {
            if (qtdTimerRun == 50)
            {
                this.tlblUper.Stop();
                lblPlus.Visible = false;
                qtdTimerRun = 0;
                lblPlus.Text = null;
                lblPlus.Location = new Point(20, 20);
                this.tlblUper.Dispose();
            }
            //FuncUpper Deleted
            lblPlus.Location = new Point(lblPlus.Location.X, lblPlus.Location.Y - 1);
            qtdTimerRun++;
        }
        private void tClickImg_Tick(object sender, EventArgs e)
        {
            btnClick.BackgroundImage = Portifolio_GameClickerRPG.Properties.Resources.tdefault;
            this.tClickImg.Stop();
            this.tClickImg.Dispose();
        }

        public void ClickPrincipalFunc()
        {
            btnClick.BackgroundImage = Portifolio_GameClickerRPG.Properties.Resources.tclicked01;
            //lblPlus = CustomControls.lblPlus(lblPlus, 1, MousePosition.X, MousePosition.Y);
            ShowLabel(false);
            lblPlus.Visible = true;

            tlblUper.Start();
            tClickImg.Start();

            AddMoney(true, _perClick);
        }

        public void AutoClickFunc()
        {
            btnClick.BackgroundImage = Portifolio_GameClickerRPG.Properties.Resources.tclicked01;
            //lblPlus = CustomControls.lblPlus(lblPlus, _perClickAuto, MousePosition.X, MousePosition.Y);//DEFAULT WAY
            ShowLabel(true);
            lblPlus.Visible = true;

            tlblUper.Start();
            tClickImg.Start();

            AddMoney(false, _perClickAuto);
        }

        public void ShowLabel(bool tipo)
        {
            btnClick.BackgroundImage = Portifolio_GameClickerRPG.Properties.Resources.tclicked01;

            //PADRAO ANTIGO
            //lblPlus = CustomControls.lblPlus(lblPlus, _perClick, MousePosition.X, MousePosition.Y, pnlFundo.Width, pnlFundo.Height);
            if(tipo == false)//MANUAL
                lblPlus = CustomControls.lblPlus(lblPlus, _perClick);
            else if (tipo == true)//AUTO
            lblPlus = CustomControls.lblPlus(lblPlus, _perClickAuto);

            lblPlus.Visible = true;
            tlblUper.Start();
            tClickImg.Start();
        }

        public void UpdateTxt()
        {
            txtDinheiro.Text = _conta.ToString();
        }

        public void UpdateLbl()
        {
            string strTipo = "";

            if (_conta < 10)//UNIDADE
            {
                strTipo = "Unidade";
            }
            else if (_conta >= 10 && _conta < 100)//DEZENA
            {
                strTipo = "Dezena";
            }
            else if (_conta >= 100 && _conta < 1000)//CENTENA
            {
                strTipo = "Centena";
            }
            else if (_conta >= 1000 && _conta < 10000)//MILHAR
            {
                strTipo = "Milhar";
            }
            else if (_conta >= 10000 && _conta < 100000)//D. MILHAR
            {
                strTipo = "Dezena de Milhar";
            }
            else if (_conta >= 100000 && _conta < 1000000)//C. MILHAR
            {
                strTipo = "Centena de Milhar";
            }
            else if (_conta >= 1000000 && _conta < 1000000000)//BILHAO
            {
                strTipo = "BILHÕES!";
            }
            else if (_conta >= 1000000000)//BILHAO
            {
                strTipo = "?!?!?!TRILHÕES?!?!?!";
            }
            else if (_conta >= 2000000000)//BILHAO
            {
                strTipo = "PARABÉNS VOCÊ VENCEU!!!";
                MessageBox.Show("Meus parabéns, você deixou o seu Game aberto farmando e você Venceu!!!", "ALERTA SUPREMA", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }

            lblDinheiroTipo.Text = "Você está em: " + strTipo;
        }

        public void ComprarUpgrade(int valorUp, Button btnUp, string tipoUp)
        {
            if (_conta >= valorUp)
            {
                btnUp.Enabled = false;
                btnUp.ForeColor = Color.White;
                btnUp.BackColor = Color.Lime;
                btnUp.Text = "COMPRADO";
                RemoveMoney(valorUp);
                UpdateTxt();
                UpdateLbl();

                switch (tipoUp)
                {
                case "AutoClick":
                tAutoClick.Interval = _tAutoClickSpeed;
                tAutoClick.Start();
                break;

                case "DoubleClick":
                _perClick = _perClick * 2;
                break;

                //

                case "AutoClickS1":
                tAutoClick.Interval = _tAutoClickSpeed/2;
                break;

                case "AutoClickS2":
                tAutoClick.Interval = _tAutoClickSpeed/2;
                break;

                case "AutoClickS3":
                tAutoClick.Interval = _tAutoClickSpeed/2;
                break;

                //

                case "AutoClickB1":
                _perClickAuto = _perClickAuto*2;
                break;

                case "AutoClickB2":
                _perClickAuto = _perClickAuto * 5;
                break;

                case "AutoClickB3":
                _perClickAuto = _perClickAuto * 10;
                break;

                //

                case "AutoClickUltimate":
                _perClickAuto = _perClickAuto * 1000;
                tAutoClick.Interval = 100;
                _tAutoClickSpeed = 100;
                break;

                    //

                    case "ClickP1":
                        _perClick *= 2;
                        break;

                    case "ClickP2":
                        _perClick *= 5;
                        break;

                    case "ClickP3":
                        _perClick *= 10;
                        break;

                    case "ClickUltimate":
                        _perClick *= 1000;
                        break;

                    default:
                break;

                }//SWITCH
            }//IF
        }

        public void RemoveMoney(int valor)
        {
            _conta -= valor;
            UpdateTxt();
        }

        public void AddMoney(bool tipo, int qtd)
        {
            _conta += qtd;
            //Console.WriteLine($"Valor Ganho: {qtd} -- Valor Total: {_conta}");

            UpdateTxt();
            UpdateLbl();
        }

        private void tAutoClick_Tick(object sender, EventArgs e)
        {
            AutoClickFunc();
        }

        private void btnDoubleClick_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upDoubleClick;
            const string upgradeName = "DoubleClick";
            ComprarUpgrade(custoUpgrade, this.btnDoubleClick, upgradeName);
        }

        private void btnInfoGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada click que você da na LUA você ganha 1R$.\nVocê pode comprar UPGRADES e ficar rico o mais rápido!\n\nIsso é um portifolio feito por: Gabriel Moreira.", "Game Moon Clicker", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnInfoSpeed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cada Upgrade de Speed (+, ++, +++, etc...) É cortado pela Metade a Velocidade da Ação.", "Game Moon Clicker", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnAutoClickS1_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClickS1;
            const string upgradeName = "AutoClickS1";
            ComprarUpgrade(custoUpgrade, this.btnAutoClickS1, upgradeName);
        }

        private void btnAutoClickS2_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClickS2;
            const string upgradeName = "AutoClickS2";
            ComprarUpgrade(custoUpgrade, this.btnAutoClickS2, upgradeName);
        }

        private void btnAutoClickS3_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClickS3;
            const string upgradeName = "AutoClickS3";
            ComprarUpgrade(custoUpgrade, this.btnAutoClickS3, upgradeName);
        }

        private void btnAutoClickB1_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClickB1;
            const string upgradeName = "AutoClickB1";
            ComprarUpgrade(custoUpgrade, this.btnAutoClickB1, upgradeName);
        }

        private void btnAutoClickB2_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClickB2;
            const string upgradeName = "AutoClickB2";
            ComprarUpgrade(custoUpgrade, this.btnAutoClickB2, upgradeName);
        }

        private void btnAutoClickB3_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClickB3;
            const string upgradeName = "AutoClickB3";
            ComprarUpgrade(custoUpgrade, this.btnAutoClickB3, upgradeName);
        }

        private void btnAutoClickUltimate_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upAutoClickUltimate;
            const string upgradeName = "AutoClickUltimate";
            ComprarUpgrade(custoUpgrade, this.btnAutoClickUltimate, upgradeName);
        }

        private void btnClickP1_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upClickP1;
            const string upgradeName = "ClickP1";
            ComprarUpgrade(custoUpgrade, this.btnClickP1, upgradeName);
        }

        private void btnClickP2_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upClickP2;
            const string upgradeName = "ClickP2";
            ComprarUpgrade(custoUpgrade, this.btnClickP2, upgradeName);
        }

        private void btnClickP3_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upClickP3;
            const string upgradeName = "ClickP3";
            ComprarUpgrade(custoUpgrade, this.btnClickP3, upgradeName);
        }

        private void btnClickUltimate_Click(object sender, EventArgs e)
        {
            const int custoUpgrade = upClickUltimate;
            const string upgradeName = "ClickUltimate";
            ComprarUpgrade(custoUpgrade, this.btnClickUltimate, upgradeName);
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            //WHEN LOAD SCREEN
        }
    }
}