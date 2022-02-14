using System.Windows.Forms;

namespace Titan.PathFindTool
{
    partial class GraphFormer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private ContextMenu MenuContextuel;
        private FlickerFreePanel GraphPanel;
        private System.Windows.Forms.ToolBarButton AEtoileEtape;
        private System.Windows.Forms.ImageList ImagesActions;
        private System.Windows.Forms.ImageList ImagesPasAPas;
        private System.Windows.Forms.ToolBar FichierToolBar;
        private System.Windows.Forms.ImageList ImagesFichier;
        private System.Windows.Forms.ToolBarButton BoutonSauver;
        private System.Windows.Forms.ToolBarButton BoutonCharger;
        private System.Windows.Forms.ToolBarButton Sep1;
        private System.Windows.Forms.ToolBarButton Sep2;
        private System.Windows.Forms.Label LabelAide;
        private System.Windows.Forms.ToolBarButton BoutonNouveau;
        private System.Windows.Forms.ToolBarButton BoutonDessiner;
        private System.Windows.Forms.ToolBarButton BoutonEffacer;
        private System.Windows.Forms.ToolBarButton BoutonDeplacer;
        private System.Windows.Forms.ToolBarButton BoutonChangerEtat;
        private System.Windows.Forms.ToolBarButton BoutonAEtoile;
        private System.Windows.Forms.ToolBarButton BoutonAProposDe;
        private System.Windows.Forms.StatusBar GraphStatusBar;
        private System.Windows.Forms.StatusBarPanel NbNodesPanel;
        private System.Windows.Forms.StatusBarPanel NbArcsPanel;
        private System.Windows.Forms.StatusBarPanel CoordsPanel;
        private System.Windows.Forms.ToolBar EditionToolBar;
        private System.Windows.Forms.ToolBar AEtoileToolBar;
        private System.Windows.Forms.ToolBarButton AEtoileDebut;
        private System.Windows.Forms.ToolBarButton AEtoileFin;
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphFormer));
            this.EditionToolBar = new System.Windows.Forms.ToolBar();
            this.BoutonDessiner = new System.Windows.Forms.ToolBarButton();
            this.BoutonEffacer = new System.Windows.Forms.ToolBarButton();
            this.BoutonDeplacer = new System.Windows.Forms.ToolBarButton();
            this.BoutonChangerEtat = new System.Windows.Forms.ToolBarButton();
            this.BoutonAEtoile = new System.Windows.Forms.ToolBarButton();
            this.ImagesActions = new System.Windows.Forms.ImageList(this.components);
            this.GraphStatusBar = new System.Windows.Forms.StatusBar();
            this.NbNodesPanel = new System.Windows.Forms.StatusBarPanel();
            this.NbArcsPanel = new System.Windows.Forms.StatusBarPanel();
            this.CoordsPanel = new System.Windows.Forms.StatusBarPanel();
            this.FichierToolBar = new System.Windows.Forms.ToolBar();
            this.BoutonNouveau = new System.Windows.Forms.ToolBarButton();
            this.BoutonCharger = new System.Windows.Forms.ToolBarButton();
            this.BoutonSauver = new System.Windows.Forms.ToolBarButton();
            this.BoutonAProposDe = new System.Windows.Forms.ToolBarButton();
            this.Sep1 = new System.Windows.Forms.ToolBarButton();
            this.ImagesFichier = new System.Windows.Forms.ImageList(this.components);
            this.AEtoileToolBar = new System.Windows.Forms.ToolBar();
            this.Sep2 = new System.Windows.Forms.ToolBarButton();
            this.AEtoileDebut = new System.Windows.Forms.ToolBarButton();
            this.AEtoileEtape = new System.Windows.Forms.ToolBarButton();
            this.AEtoileFin = new System.Windows.Forms.ToolBarButton();
            this.ImagesPasAPas = new System.Windows.Forms.ImageList(this.components);
            this.LabelAide = new System.Windows.Forms.Label();
            this.languageTxt = new System.Windows.Forms.ComboBox();
            this.GraphPanel = new Titan.PathFindTool.FlickerFreePanel();
            ((System.ComponentModel.ISupportInitialize)(this.NbNodesPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbArcsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordsPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // EditionToolBar
            // 
            resources.ApplyResources(this.EditionToolBar, "EditionToolBar");
            this.EditionToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.BoutonDessiner,
            this.BoutonEffacer,
            this.BoutonDeplacer,
            this.BoutonChangerEtat,
            this.BoutonAEtoile});
            this.EditionToolBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditionToolBar.Divider = false;
            this.EditionToolBar.ImageList = this.ImagesActions;
            this.EditionToolBar.Name = "EditionToolBar";
            this.EditionToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.GraphToolBar_ButtonClick);
            // 
            // BoutonDessiner
            // 
            resources.ApplyResources(this.BoutonDessiner, "BoutonDessiner");
            this.BoutonDessiner.Name = "BoutonDessiner";
            this.BoutonDessiner.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.BoutonDessiner.Tag = 0;
            // 
            // BoutonEffacer
            // 
            resources.ApplyResources(this.BoutonEffacer, "BoutonEffacer");
            this.BoutonEffacer.Name = "BoutonEffacer";
            this.BoutonEffacer.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.BoutonEffacer.Tag = 1;
            // 
            // BoutonDeplacer
            // 
            resources.ApplyResources(this.BoutonDeplacer, "BoutonDeplacer");
            this.BoutonDeplacer.Name = "BoutonDeplacer";
            this.BoutonDeplacer.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.BoutonDeplacer.Tag = 2;
            // 
            // BoutonChangerEtat
            // 
            resources.ApplyResources(this.BoutonChangerEtat, "BoutonChangerEtat");
            this.BoutonChangerEtat.Name = "BoutonChangerEtat";
            this.BoutonChangerEtat.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.BoutonChangerEtat.Tag = 3;
            // 
            // BoutonAEtoile
            // 
            resources.ApplyResources(this.BoutonAEtoile, "BoutonAEtoile");
            this.BoutonAEtoile.Name = "BoutonAEtoile";
            this.BoutonAEtoile.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.BoutonAEtoile.Tag = 4;
            // 
            // ImagesActions
            // 
            this.ImagesActions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesActions.ImageStream")));
            this.ImagesActions.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesActions.Images.SetKeyName(0, "pen.png");
            this.ImagesActions.Images.SetKeyName(1, "xiangpi.png");
            this.ImagesActions.Images.SetKeyName(2, "move.png");
            this.ImagesActions.Images.SetKeyName(3, "yandian.png");
            this.ImagesActions.Images.SetKeyName(4, "astar.png");
            // 
            // GraphStatusBar
            // 
            resources.ApplyResources(this.GraphStatusBar, "GraphStatusBar");
            this.GraphStatusBar.Name = "GraphStatusBar";
            this.GraphStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.NbNodesPanel,
            this.NbArcsPanel,
            this.CoordsPanel});
            this.GraphStatusBar.ShowPanels = true;
            // 
            // NbNodesPanel
            // 
            this.NbNodesPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            resources.ApplyResources(this.NbNodesPanel, "NbNodesPanel");
            // 
            // NbArcsPanel
            // 
            this.NbArcsPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            resources.ApplyResources(this.NbArcsPanel, "NbArcsPanel");
            // 
            // CoordsPanel
            // 
            resources.ApplyResources(this.CoordsPanel, "CoordsPanel");
            this.CoordsPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.CoordsPanel.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            // 
            // FichierToolBar
            // 
            resources.ApplyResources(this.FichierToolBar, "FichierToolBar");
            this.FichierToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.BoutonNouveau,
            this.BoutonCharger,
            this.BoutonSauver,
            this.BoutonAProposDe,
            this.Sep1});
            this.FichierToolBar.Divider = false;
            this.FichierToolBar.ImageList = this.ImagesFichier;
            this.FichierToolBar.Name = "FichierToolBar";
            this.FichierToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.FichierToolBar_ButtonClick);
            // 
            // BoutonNouveau
            // 
            resources.ApplyResources(this.BoutonNouveau, "BoutonNouveau");
            this.BoutonNouveau.Name = "BoutonNouveau";
            this.BoutonNouveau.Tag = 0;
            // 
            // BoutonCharger
            // 
            resources.ApplyResources(this.BoutonCharger, "BoutonCharger");
            this.BoutonCharger.Name = "BoutonCharger";
            this.BoutonCharger.Tag = 1;
            // 
            // BoutonSauver
            // 
            resources.ApplyResources(this.BoutonSauver, "BoutonSauver");
            this.BoutonSauver.Name = "BoutonSauver";
            this.BoutonSauver.Tag = 2;
            // 
            // BoutonAProposDe
            // 
            resources.ApplyResources(this.BoutonAProposDe, "BoutonAProposDe");
            this.BoutonAProposDe.Name = "BoutonAProposDe";
            this.BoutonAProposDe.Tag = 3;
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ImagesFichier
            // 
            this.ImagesFichier.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesFichier.ImageStream")));
            this.ImagesFichier.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesFichier.Images.SetKeyName(0, "BoutonNouveau.png");
            this.ImagesFichier.Images.SetKeyName(1, "openfloder.png");
            this.ImagesFichier.Images.SetKeyName(2, "save.png");
            this.ImagesFichier.Images.SetKeyName(3, "wenhao.png");
            // 
            // AEtoileToolBar
            // 
            resources.ApplyResources(this.AEtoileToolBar, "AEtoileToolBar");
            this.AEtoileToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.Sep2,
            this.AEtoileDebut,
            this.AEtoileEtape,
            this.AEtoileFin});
            this.AEtoileToolBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AEtoileToolBar.Divider = false;
            this.AEtoileToolBar.ImageList = this.ImagesPasAPas;
            this.AEtoileToolBar.Name = "AEtoileToolBar";
            this.AEtoileToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.AEtoileToolBar_ButtonClick);
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // AEtoileDebut
            // 
            resources.ApplyResources(this.AEtoileDebut, "AEtoileDebut");
            this.AEtoileDebut.Name = "AEtoileDebut";
            this.AEtoileDebut.Tag = 0;
            // 
            // AEtoileEtape
            // 
            resources.ApplyResources(this.AEtoileEtape, "AEtoileEtape");
            this.AEtoileEtape.Name = "AEtoileEtape";
            this.AEtoileEtape.Tag = 1;
            // 
            // AEtoileFin
            // 
            resources.ApplyResources(this.AEtoileFin, "AEtoileFin");
            this.AEtoileFin.Name = "AEtoileFin";
            this.AEtoileFin.Tag = 2;
            // 
            // ImagesPasAPas
            // 
            this.ImagesPasAPas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesPasAPas.ImageStream")));
            this.ImagesPasAPas.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesPasAPas.Images.SetKeyName(0, "left.png");
            this.ImagesPasAPas.Images.SetKeyName(1, "setp.png");
            this.ImagesPasAPas.Images.SetKeyName(2, "right.png");
            // 
            // LabelAide
            // 
            resources.ApplyResources(this.LabelAide, "LabelAide");
            this.LabelAide.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LabelAide.Name = "LabelAide";
            // 
            // languageTxt
            // 
            this.languageTxt.FormattingEnabled = true;
            resources.ApplyResources(this.languageTxt, "languageTxt");
            this.languageTxt.Name = "languageTxt";
            this.languageTxt.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // GraphPanel
            // 
            this.GraphPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GraphPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.GraphPanel, "GraphPanel");
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPanel_Paint);
            this.GraphPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphPanel_MouseDown);
            this.GraphPanel.MouseLeave += new System.EventHandler(this.GraphPanel_MouseLeave);
            this.GraphPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphPanel_MouseMove);
            this.GraphPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphPanel_MouseUp);
            // 
            // GraphFormer
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.languageTxt);
            this.Controls.Add(this.GraphPanel);
            this.Controls.Add(this.GraphStatusBar);
            this.Controls.Add(this.FichierToolBar);
            this.Controls.Add(this.EditionToolBar);
            this.Controls.Add(this.AEtoileToolBar);
            this.Controls.Add(this.LabelAide);
            this.Name = "GraphFormer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GraphFormer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NbNodesPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NbArcsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordsPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox languageTxt;
    }
}

