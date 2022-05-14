
namespace Portifolio_GameClickerRPG
{
    partial class frmGame
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabInicial = new System.Windows.Forms.TabPage();
            this.btnInfoSpeed = new System.Windows.Forms.Button();
            this.btnInfoGame = new System.Windows.Forms.Button();
            this.tabUpgrades1 = new System.Windows.Forms.TabPage();
            this.btnAutoClickS3 = new System.Windows.Forms.Button();
            this.btnAutoClickS2 = new System.Windows.Forms.Button();
            this.btnAutoClickS1 = new System.Windows.Forms.Button();
            this.btnAutoClick = new System.Windows.Forms.Button();
            this.btnDoubleClick = new System.Windows.Forms.Button();
            this.tabUpgrades2 = new System.Windows.Forms.TabPage();
            this.btnAutoClickUltimate = new System.Windows.Forms.Button();
            this.btnAutoClickB3 = new System.Windows.Forms.Button();
            this.btnAutoClickB2 = new System.Windows.Forms.Button();
            this.btnAutoClickB1 = new System.Windows.Forms.Button();
            this.tabUpgrades3 = new System.Windows.Forms.TabPage();
            this.btnClickUltimate = new System.Windows.Forms.Button();
            this.btnClickP3 = new System.Windows.Forms.Button();
            this.btnClickP2 = new System.Windows.Forms.Button();
            this.btnClickP1 = new System.Windows.Forms.Button();
            this.lblDinheiroTipo = new System.Windows.Forms.Label();
            this.txtRs = new System.Windows.Forms.TextBox();
            this.lblPlus = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.tlblUper = new System.Windows.Forms.Timer(this.components);
            this.tClickImg = new System.Windows.Forms.Timer(this.components);
            this.tAutoClick = new System.Windows.Forms.Timer(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.pnlFundo.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabInicial.SuspendLayout();
            this.tabUpgrades1.SuspendLayout();
            this.tabUpgrades2.SuspendLayout();
            this.tabUpgrades3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlFundo.Controls.Add(this.tabControlMain);
            this.pnlFundo.Controls.Add(this.lblDinheiroTipo);
            this.pnlFundo.Controls.Add(this.txtRs);
            this.pnlFundo.Controls.Add(this.lblPlus);
            this.pnlFundo.Controls.Add(this.txtDinheiro);
            this.pnlFundo.Controls.Add(this.btnClick);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(684, 561);
            this.pnlFundo.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabInicial);
            this.tabControlMain.Controls.Add(this.tabUpgrades1);
            this.tabControlMain.Controls.Add(this.tabUpgrades2);
            this.tabControlMain.Controls.Add(this.tabUpgrades3);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(684, 100);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabInicial
            // 
            this.tabInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabInicial.Controls.Add(this.btnInfoSpeed);
            this.tabInicial.Controls.Add(this.btnInfoGame);
            this.tabInicial.ForeColor = System.Drawing.Color.White;
            this.tabInicial.Location = new System.Drawing.Point(4, 25);
            this.tabInicial.Name = "tabInicial";
            this.tabInicial.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicial.Size = new System.Drawing.Size(676, 71);
            this.tabInicial.TabIndex = 0;
            this.tabInicial.Text = "Home Page";
            // 
            // btnInfoSpeed
            // 
            this.btnInfoSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInfoSpeed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInfoSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoSpeed.Location = new System.Drawing.Point(117, 6);
            this.btnInfoSpeed.Name = "btnInfoSpeed";
            this.btnInfoSpeed.Size = new System.Drawing.Size(103, 59);
            this.btnInfoSpeed.TabIndex = 1;
            this.btnInfoSpeed.Text = "Informações Speed";
            this.btnInfoSpeed.UseVisualStyleBackColor = false;
            this.btnInfoSpeed.Click += new System.EventHandler(this.btnInfoSpeed_Click);
            // 
            // btnInfoGame
            // 
            this.btnInfoGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnInfoGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInfoGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoGame.Location = new System.Drawing.Point(8, 6);
            this.btnInfoGame.Name = "btnInfoGame";
            this.btnInfoGame.Size = new System.Drawing.Size(103, 59);
            this.btnInfoGame.TabIndex = 0;
            this.btnInfoGame.Text = "Informações Game";
            this.btnInfoGame.UseVisualStyleBackColor = false;
            this.btnInfoGame.Click += new System.EventHandler(this.btnInfoGame_Click);
            // 
            // tabUpgrades1
            // 
            this.tabUpgrades1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabUpgrades1.Controls.Add(this.btnAutoClickS3);
            this.tabUpgrades1.Controls.Add(this.btnAutoClickS2);
            this.tabUpgrades1.Controls.Add(this.btnAutoClickS1);
            this.tabUpgrades1.Controls.Add(this.btnAutoClick);
            this.tabUpgrades1.Controls.Add(this.btnDoubleClick);
            this.tabUpgrades1.Location = new System.Drawing.Point(4, 25);
            this.tabUpgrades1.Name = "tabUpgrades1";
            this.tabUpgrades1.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpgrades1.Size = new System.Drawing.Size(676, 71);
            this.tabUpgrades1.TabIndex = 1;
            this.tabUpgrades1.Text = "Upgrades Page 1";
            // 
            // btnAutoClickS3
            // 
            this.btnAutoClickS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClickS3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClickS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClickS3.Location = new System.Drawing.Point(529, 6);
            this.btnAutoClickS3.Name = "btnAutoClickS3";
            this.btnAutoClickS3.Size = new System.Drawing.Size(130, 59);
            this.btnAutoClickS3.TabIndex = 5;
            this.btnAutoClickS3.Text = "Auto Click Speed+++";
            this.btnAutoClickS3.UseVisualStyleBackColor = false;
            this.btnAutoClickS3.Click += new System.EventHandler(this.btnAutoClickS3_Click);
            // 
            // btnAutoClickS2
            // 
            this.btnAutoClickS2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClickS2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClickS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClickS2.Location = new System.Drawing.Point(393, 6);
            this.btnAutoClickS2.Name = "btnAutoClickS2";
            this.btnAutoClickS2.Size = new System.Drawing.Size(130, 59);
            this.btnAutoClickS2.TabIndex = 4;
            this.btnAutoClickS2.Text = "Auto Click Speed++";
            this.btnAutoClickS2.UseVisualStyleBackColor = false;
            this.btnAutoClickS2.Click += new System.EventHandler(this.btnAutoClickS2_Click);
            // 
            // btnAutoClickS1
            // 
            this.btnAutoClickS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClickS1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClickS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClickS1.Location = new System.Drawing.Point(257, 6);
            this.btnAutoClickS1.Name = "btnAutoClickS1";
            this.btnAutoClickS1.Size = new System.Drawing.Size(130, 59);
            this.btnAutoClickS1.TabIndex = 3;
            this.btnAutoClickS1.Text = "Auto Click Speed+";
            this.btnAutoClickS1.UseVisualStyleBackColor = false;
            this.btnAutoClickS1.Click += new System.EventHandler(this.btnAutoClickS1_Click);
            // 
            // btnAutoClick
            // 
            this.btnAutoClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClick.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClick.Location = new System.Drawing.Point(8, 6);
            this.btnAutoClick.Name = "btnAutoClick";
            this.btnAutoClick.Size = new System.Drawing.Size(119, 59);
            this.btnAutoClick.TabIndex = 2;
            this.btnAutoClick.Text = "Auto Click";
            this.btnAutoClick.UseVisualStyleBackColor = false;
            this.btnAutoClick.Click += new System.EventHandler(this.btnAutoClick_Click);
            // 
            // btnDoubleClick
            // 
            this.btnDoubleClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDoubleClick.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoubleClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoubleClick.Location = new System.Drawing.Point(132, 6);
            this.btnDoubleClick.Name = "btnDoubleClick";
            this.btnDoubleClick.Size = new System.Drawing.Size(119, 59);
            this.btnDoubleClick.TabIndex = 1;
            this.btnDoubleClick.Text = "Double Click";
            this.btnDoubleClick.UseVisualStyleBackColor = false;
            this.btnDoubleClick.Click += new System.EventHandler(this.btnDoubleClick_Click);
            // 
            // tabUpgrades2
            // 
            this.tabUpgrades2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabUpgrades2.Controls.Add(this.btnAutoClickUltimate);
            this.tabUpgrades2.Controls.Add(this.btnAutoClickB3);
            this.tabUpgrades2.Controls.Add(this.btnAutoClickB2);
            this.tabUpgrades2.Controls.Add(this.btnAutoClickB1);
            this.tabUpgrades2.Location = new System.Drawing.Point(4, 25);
            this.tabUpgrades2.Name = "tabUpgrades2";
            this.tabUpgrades2.Size = new System.Drawing.Size(676, 71);
            this.tabUpgrades2.TabIndex = 2;
            this.tabUpgrades2.Text = "Upgrades Page 2";
            // 
            // btnAutoClickUltimate
            // 
            this.btnAutoClickUltimate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClickUltimate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClickUltimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClickUltimate.Location = new System.Drawing.Point(378, 3);
            this.btnAutoClickUltimate.Name = "btnAutoClickUltimate";
            this.btnAutoClickUltimate.Size = new System.Drawing.Size(290, 65);
            this.btnAutoClickUltimate.TabIndex = 6;
            this.btnAutoClickUltimate.Text = "AutoClick ULTIMATE";
            this.btnAutoClickUltimate.UseVisualStyleBackColor = false;
            this.btnAutoClickUltimate.Click += new System.EventHandler(this.btnAutoClickUltimate_Click);
            // 
            // btnAutoClickB3
            // 
            this.btnAutoClickB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClickB3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClickB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClickB3.Location = new System.Drawing.Point(253, 3);
            this.btnAutoClickB3.Name = "btnAutoClickB3";
            this.btnAutoClickB3.Size = new System.Drawing.Size(119, 65);
            this.btnAutoClickB3.TabIndex = 5;
            this.btnAutoClickB3.Text = "AutoClick x10";
            this.btnAutoClickB3.UseVisualStyleBackColor = false;
            this.btnAutoClickB3.Click += new System.EventHandler(this.btnAutoClickB3_Click);
            // 
            // btnAutoClickB2
            // 
            this.btnAutoClickB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClickB2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClickB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClickB2.Location = new System.Drawing.Point(128, 3);
            this.btnAutoClickB2.Name = "btnAutoClickB2";
            this.btnAutoClickB2.Size = new System.Drawing.Size(119, 65);
            this.btnAutoClickB2.TabIndex = 4;
            this.btnAutoClickB2.Text = "AutoClick x5";
            this.btnAutoClickB2.UseVisualStyleBackColor = false;
            this.btnAutoClickB2.Click += new System.EventHandler(this.btnAutoClickB2_Click);
            // 
            // btnAutoClickB1
            // 
            this.btnAutoClickB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAutoClickB1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAutoClickB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClickB1.Location = new System.Drawing.Point(3, 3);
            this.btnAutoClickB1.Name = "btnAutoClickB1";
            this.btnAutoClickB1.Size = new System.Drawing.Size(119, 65);
            this.btnAutoClickB1.TabIndex = 3;
            this.btnAutoClickB1.Text = "AutoClick x2\r\n";
            this.btnAutoClickB1.UseVisualStyleBackColor = false;
            this.btnAutoClickB1.Click += new System.EventHandler(this.btnAutoClickB1_Click);
            // 
            // tabUpgrades3
            // 
            this.tabUpgrades3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabUpgrades3.Controls.Add(this.btnClickUltimate);
            this.tabUpgrades3.Controls.Add(this.btnClickP3);
            this.tabUpgrades3.Controls.Add(this.btnClickP2);
            this.tabUpgrades3.Controls.Add(this.btnClickP1);
            this.tabUpgrades3.Location = new System.Drawing.Point(4, 25);
            this.tabUpgrades3.Name = "tabUpgrades3";
            this.tabUpgrades3.Size = new System.Drawing.Size(676, 71);
            this.tabUpgrades3.TabIndex = 3;
            this.tabUpgrades3.Text = "Upgrades Page 3";
            // 
            // btnClickUltimate
            // 
            this.btnClickUltimate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClickUltimate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClickUltimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickUltimate.Location = new System.Drawing.Point(381, 3);
            this.btnClickUltimate.Name = "btnClickUltimate";
            this.btnClickUltimate.Size = new System.Drawing.Size(290, 65);
            this.btnClickUltimate.TabIndex = 10;
            this.btnClickUltimate.Text = "Click ULTIMATE";
            this.btnClickUltimate.UseVisualStyleBackColor = false;
            this.btnClickUltimate.Click += new System.EventHandler(this.btnClickUltimate_Click);
            // 
            // btnClickP3
            // 
            this.btnClickP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClickP3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClickP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickP3.Location = new System.Drawing.Point(256, 3);
            this.btnClickP3.Name = "btnClickP3";
            this.btnClickP3.Size = new System.Drawing.Size(119, 65);
            this.btnClickP3.TabIndex = 9;
            this.btnClickP3.Text = "Click x10";
            this.btnClickP3.UseVisualStyleBackColor = false;
            this.btnClickP3.Click += new System.EventHandler(this.btnClickP3_Click);
            // 
            // btnClickP2
            // 
            this.btnClickP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClickP2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClickP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickP2.Location = new System.Drawing.Point(131, 3);
            this.btnClickP2.Name = "btnClickP2";
            this.btnClickP2.Size = new System.Drawing.Size(119, 65);
            this.btnClickP2.TabIndex = 8;
            this.btnClickP2.Text = "Click x5";
            this.btnClickP2.UseVisualStyleBackColor = false;
            this.btnClickP2.Click += new System.EventHandler(this.btnClickP2_Click);
            // 
            // btnClickP1
            // 
            this.btnClickP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClickP1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClickP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClickP1.Location = new System.Drawing.Point(6, 3);
            this.btnClickP1.Name = "btnClickP1";
            this.btnClickP1.Size = new System.Drawing.Size(119, 65);
            this.btnClickP1.TabIndex = 7;
            this.btnClickP1.Text = "Click x2\r\n";
            this.btnClickP1.UseVisualStyleBackColor = false;
            this.btnClickP1.Click += new System.EventHandler(this.btnClickP1_Click);
            // 
            // lblDinheiroTipo
            // 
            this.lblDinheiroTipo.AutoSize = true;
            this.lblDinheiroTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblDinheiroTipo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiroTipo.ForeColor = System.Drawing.Color.White;
            this.lblDinheiroTipo.Location = new System.Drawing.Point(225, 459);
            this.lblDinheiroTipo.Name = "lblDinheiroTipo";
            this.lblDinheiroTipo.Size = new System.Drawing.Size(283, 36);
            this.lblDinheiroTipo.TabIndex = 4;
            this.lblDinheiroTipo.Text = "Você está em: Unidade";
            // 
            // txtRs
            // 
            this.txtRs.Font = new System.Drawing.Font("Market Deco", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRs.Location = new System.Drawing.Point(9, 505);
            this.txtRs.Name = "txtRs";
            this.txtRs.ReadOnly = true;
            this.txtRs.Size = new System.Drawing.Size(45, 44);
            this.txtRs.TabIndex = 3;
            this.txtRs.Text = "R$";
            this.txtRs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.BackColor = System.Drawing.Color.Transparent;
            this.lblPlus.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.ForeColor = System.Drawing.Color.Lime;
            this.lblPlus.Location = new System.Drawing.Point(161, 420);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(30, 36);
            this.lblPlus.TabIndex = 2;
            this.lblPlus.Text = "+";
            this.lblPlus.Visible = false;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Market Deco", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.Location = new System.Drawing.Point(60, 505);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.ReadOnly = true;
            this.txtDinheiro.Size = new System.Drawing.Size(612, 44);
            this.txtDinheiro.TabIndex = 1;
            this.txtDinheiro.Text = "0";
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClick
            // 
            this.btnClick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClick.BackgroundImage")));
            this.btnClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClick.FlatAppearance.BorderSize = 0;
            this.btnClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Location = new System.Drawing.Point(167, 106);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(350, 350);
            this.btnClick.TabIndex = 0;
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // tlblUper
            // 
            this.tlblUper.Interval = 10;
            this.tlblUper.Tick += new System.EventHandler(this.tlblUper_Tick);
            // 
            // tClickImg
            // 
            this.tClickImg.Tick += new System.EventHandler(this.tClickImg_Tick);
            // 
            // tAutoClick
            // 
            this.tAutoClick.Interval = 2000;
            this.tAutoClick.Tick += new System.EventHandler(this.tAutoClick_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pnlFundo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ Game Clicker - By: Gabriel Moreira/PINGUIN.ZIP ]";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabInicial.ResumeLayout(false);
            this.tabUpgrades1.ResumeLayout(false);
            this.tabUpgrades2.ResumeLayout(false);
            this.tabUpgrades3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Timer tlblUper;
        private System.Windows.Forms.Timer tClickImg;
        private System.Windows.Forms.TextBox txtRs;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label lblDinheiroTipo;
        private System.Windows.Forms.Timer tAutoClick;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabInicial;
        private System.Windows.Forms.TabPage tabUpgrades1;
        private System.Windows.Forms.TabPage tabUpgrades2;
        private System.Windows.Forms.Button btnInfoGame;
        private System.Windows.Forms.Button btnDoubleClick;
        private System.Windows.Forms.Button btnAutoClick;
        private System.Windows.Forms.Button btnInfoSpeed;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button btnAutoClickS3;
        private System.Windows.Forms.Button btnAutoClickS2;
        private System.Windows.Forms.Button btnAutoClickS1;
        private System.Windows.Forms.Button btnAutoClickB1;
        private System.Windows.Forms.Button btnAutoClickB3;
        private System.Windows.Forms.Button btnAutoClickB2;
        private System.Windows.Forms.Button btnAutoClickUltimate;
        private System.Windows.Forms.TabPage tabUpgrades3;
        private System.Windows.Forms.Button btnClickUltimate;
        private System.Windows.Forms.Button btnClickP3;
        private System.Windows.Forms.Button btnClickP2;
        private System.Windows.Forms.Button btnClickP1;
    }
}

