namespace CADTestFormApplication
{
    partial class CADTestForm
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

        private bool dimVisible;
        private bool useWinEllipse;
        private bool showLineWeight;
        private bool whiteBackGround;
        private bool blackBackGround;
        private bool propPnVisible;
        private bool textVisible;
        private CADImport.CADImportControls.CADEditorControl cadEditorControl;
        private static readonly string fileSettingsName;
        private string lngFile;
        private CADImport.FaceModule.MultipleLanguage mlng;
        private int curLngIndex;

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem miFile;
        private System.Windows.Forms.MenuItem miPrintCustom;
        private System.Windows.Forms.MenuItem editMenuItem;
        private System.Windows.Forms.MenuItem miUndo;
        private System.Windows.Forms.MenuItem miRedo;
        private System.Windows.Forms.MenuItem miDelete;
        private System.Windows.Forms.MenuItem miCopy;
        private System.Windows.Forms.MenuItem miCut;
        private System.Windows.Forms.MenuItem miPaste;
        private System.Windows.Forms.MenuItem miView;
        private System.Windows.Forms.MenuItem miLng;
        private System.Windows.Forms.MenuItem miAbout;
        private System.Windows.Forms.MenuItem miOpenFile;
        private System.Windows.Forms.MenuItem miSaveFile;
        private System.Windows.Forms.MenuItem miSaveAsDXF;
        private System.Windows.Forms.MenuItem miPrint;
        private System.Windows.Forms.MenuItem miPrintPrev;
        private System.Windows.Forms.MenuItem miClose;
        private System.Windows.Forms.MenuItem miSep;
        private System.Windows.Forms.MenuItem miExit;
        private System.Windows.Forms.MenuItem miCopyAsBMP;
        private System.Windows.Forms.MenuItem miShowEntitiesPanel;
        private System.Windows.Forms.MenuItem miZoomIn;
        private System.Windows.Forms.MenuItem miZoomOut;
        private System.Windows.Forms.MenuItem miScale;
        private System.Windows.Forms.MenuItem miZoom10;
        private System.Windows.Forms.MenuItem miZoom25;
        private System.Windows.Forms.MenuItem miZoom50;
        private System.Windows.Forms.MenuItem miZoom100;
        private System.Windows.Forms.MenuItem miZoom200;
        private System.Windows.Forms.MenuItem miZoom400;
        private System.Windows.Forms.MenuItem miZoom800;
        private System.Windows.Forms.MenuItem miFit;
        private System.Windows.Forms.MenuItem miShowSHXForm;
        private System.Windows.Forms.MenuItem miShowOptionsForm;
        private System.Windows.Forms.MenuItem miColorMode;
        private System.Windows.Forms.MenuItem miBlackMode;
        private System.Windows.Forms.MenuItem miWhiteBack;
        private System.Windows.Forms.MenuItem miBlackBack;
        private System.Windows.Forms.MenuItem miSep2;
        private System.Windows.Forms.MenuItem miShowLineWeight;
        private System.Windows.Forms.MenuItem miArcsSplit;
        private System.Windows.Forms.MenuItem miDimShow;
        private System.Windows.Forms.MenuItem miTextsShow;
        private System.Windows.Forms.MenuItem miSep3;
        private System.Windows.Forms.MenuItem miLayersShow;
        private System.Windows.Forms.MenuItem miSep5;
        private System.Windows.Forms.MenuItem mSep4;
        private System.Windows.Forms.MenuItem miCADFiles;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem miHelp;


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CADTestForm));
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.miFile = new System.Windows.Forms.MenuItem();
            this.miOpenFile = new System.Windows.Forms.MenuItem();
            this.miSaveFile = new System.Windows.Forms.MenuItem();
            this.miSaveAsDXF = new System.Windows.Forms.MenuItem();
            this.miPrint = new System.Windows.Forms.MenuItem();
            this.miPrintCustom = new System.Windows.Forms.MenuItem();
            this.miPrintPrev = new System.Windows.Forms.MenuItem();
            this.miClose = new System.Windows.Forms.MenuItem();
            this.miSep = new System.Windows.Forms.MenuItem();
            this.miExit = new System.Windows.Forms.MenuItem();
            this.editMenuItem = new System.Windows.Forms.MenuItem();
            this.miCopyAsBMP = new System.Windows.Forms.MenuItem();
            this.miUndo = new System.Windows.Forms.MenuItem();
            this.miRedo = new System.Windows.Forms.MenuItem();
            this.miDelete = new System.Windows.Forms.MenuItem();
            this.miCopy = new System.Windows.Forms.MenuItem();
            this.miCut = new System.Windows.Forms.MenuItem();
            this.miPaste = new System.Windows.Forms.MenuItem();
            this.miView = new System.Windows.Forms.MenuItem();
            this.miShowEntitiesPanel = new System.Windows.Forms.MenuItem();
            this.miSep5 = new System.Windows.Forms.MenuItem();
            this.miZoomIn = new System.Windows.Forms.MenuItem();
            this.miZoomOut = new System.Windows.Forms.MenuItem();
            this.miScale = new System.Windows.Forms.MenuItem();
            this.miZoom10 = new System.Windows.Forms.MenuItem();
            this.miZoom25 = new System.Windows.Forms.MenuItem();
            this.miZoom50 = new System.Windows.Forms.MenuItem();
            this.miZoom100 = new System.Windows.Forms.MenuItem();
            this.miZoom200 = new System.Windows.Forms.MenuItem();
            this.miZoom400 = new System.Windows.Forms.MenuItem();
            this.miZoom800 = new System.Windows.Forms.MenuItem();
            this.miFit = new System.Windows.Forms.MenuItem();
            this.mSep4 = new System.Windows.Forms.MenuItem();
            this.miShowSHXForm = new System.Windows.Forms.MenuItem();
            this.miShowOptionsForm = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.miCADFiles = new System.Windows.Forms.MenuItem();
            this.miColorMode = new System.Windows.Forms.MenuItem();
            this.miBlackMode = new System.Windows.Forms.MenuItem();
            this.miWhiteBack = new System.Windows.Forms.MenuItem();
            this.miBlackBack = new System.Windows.Forms.MenuItem();
            this.miSep2 = new System.Windows.Forms.MenuItem();
            this.miShowLineWeight = new System.Windows.Forms.MenuItem();
            this.miArcsSplit = new System.Windows.Forms.MenuItem();
            this.miDimShow = new System.Windows.Forms.MenuItem();
            this.miTextsShow = new System.Windows.Forms.MenuItem();
            this.miSep3 = new System.Windows.Forms.MenuItem();
            this.miLayersShow = new System.Windows.Forms.MenuItem();
            this.miHelp = new System.Windows.Forms.MenuItem();
            this.miLng = new System.Windows.Forms.MenuItem();
            this.miAbout = new System.Windows.Forms.MenuItem();
            this.cadEditorControl = new CADImport.CADImportControls.CADEditorControl();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miFile,
            this.editMenuItem,
            this.miView,
            this.miCADFiles,
            this.miHelp});
            // 
            // miFile
            // 
            this.miFile.Index = 0;
            this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miOpenFile,
            this.miSaveFile,
            this.miSaveAsDXF,
            this.miPrint,
            this.miPrintCustom,
            this.miPrintPrev,
            this.miClose,
            this.miSep,
            this.miExit});
            this.miFile.Text = "&File";
            // 
            // miOpenFile
            // 
            this.miOpenFile.Index = 0;
            this.miOpenFile.Text = "Open...";
            this.miOpenFile.Click += new System.EventHandler(this.miOpenFile_Click);
            // 
            // miSaveFile
            // 
            this.miSaveFile.Enabled = false;
            this.miSaveFile.Index = 1;
            this.miSaveFile.Text = "Save...";
            this.miSaveFile.Click += new System.EventHandler(this.miSaveFile_Click);
            // 
            // miSaveAsDXF
            // 
            this.miSaveAsDXF.Enabled = false;
            this.miSaveAsDXF.Index = 2;
            this.miSaveAsDXF.Text = "Save as DXF...";
            this.miSaveAsDXF.Click += new System.EventHandler(this.miSaveAsDXF_Click);
            // 
            // miPrint
            // 
            this.miPrint.Enabled = false;
            this.miPrint.Index = 3;
            this.miPrint.Text = "Print ";
            this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // miPrintCustom
            // 
            this.miPrintCustom.Enabled = false;
            this.miPrintCustom.Index = 4;
            this.miPrintCustom.Text = "Custom Print Preview...";
            this.miPrintCustom.Click += new System.EventHandler(this.miPrintCustom_Click);
            // 
            // miPrintPrev
            // 
            this.miPrintPrev.Enabled = false;
            this.miPrintPrev.Index = 5;
            this.miPrintPrev.Text = "Print Preview...";
            this.miPrintPrev.Click += new System.EventHandler(this.miPrintPrev_Click);
            // 
            // miClose
            // 
            this.miClose.Enabled = false;
            this.miClose.Index = 6;
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // miSep
            // 
            this.miSep.Index = 7;
            this.miSep.Text = "-";
            // 
            // miExit
            // 
            this.miExit.Index = 8;
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Index = 1;
            this.editMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miCopyAsBMP,
            this.miUndo,
            this.miRedo,
            this.miDelete,
            this.miCopy,
            this.miCut,
            this.miPaste});
            this.editMenuItem.Text = "&Edit";
            // 
            // miCopyAsBMP
            // 
            this.miCopyAsBMP.Enabled = false;
            this.miCopyAsBMP.Index = 0;
            this.miCopyAsBMP.Text = "Copy as BMP";
            this.miCopyAsBMP.Click += new System.EventHandler(this.miCopyAsBMP_Click);
            // 
            // miUndo
            // 
            this.miUndo.Enabled = false;
            this.miUndo.Index = 1;
            this.miUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.miUndo.Text = "Undo";
            this.miUndo.Click += new System.EventHandler(this.miUndo_Click);
            // 
            // miRedo
            // 
            this.miRedo.Enabled = false;
            this.miRedo.Index = 2;
            this.miRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.miRedo.Text = "Redo";
            this.miRedo.Click += new System.EventHandler(this.miRedo_Click);
            // 
            // miDelete
            // 
            this.miDelete.Enabled = false;
            this.miDelete.Index = 3;
            this.miDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.miDelete.Text = "Delete";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // miCopy
            // 
            this.miCopy.Enabled = false;
            this.miCopy.Index = 4;
            this.miCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.miCopy.Text = "&Copy";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miCut
            // 
            this.miCut.Enabled = false;
            this.miCut.Index = 5;
            this.miCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.miCut.Text = "Cu&t";
            this.miCut.Click += new System.EventHandler(this.miCut_Click);
            // 
            // miPaste
            // 
            this.miPaste.Enabled = false;
            this.miPaste.Index = 6;
            this.miPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.miPaste.Text = "Paste";
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // miView
            // 
            this.miView.Index = 2;
            this.miView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miShowEntitiesPanel,
            this.miSep5,
            this.miZoomIn,
            this.miZoomOut,
            this.miScale,
            this.miFit,
            this.mSep4,
            this.miShowSHXForm,
            this.miShowOptionsForm,
            this.menuItem1});
            this.miView.Text = "&View";
            // 
            // miShowEntitiesPanel
            // 
            this.miShowEntitiesPanel.Checked = true;
            this.miShowEntitiesPanel.Index = 0;
            this.miShowEntitiesPanel.Text = "Show entities panel";
            this.miShowEntitiesPanel.Click += new System.EventHandler(this.miShowEntitiesPanel_Click);
            // 
            // miSep5
            // 
            this.miSep5.Index = 1;
            this.miSep5.Text = "-";
            // 
            // miZoomIn
            // 
            this.miZoomIn.Enabled = false;
            this.miZoomIn.Index = 2;
            this.miZoomIn.Text = "Zoom In (+)";
            this.miZoomIn.Click += new System.EventHandler(this.miZoomIn_Click);
            // 
            // miZoomOut
            // 
            this.miZoomOut.Enabled = false;
            this.miZoomOut.Index = 3;
            this.miZoomOut.Text = "Zoom Out (-)";
            this.miZoomOut.Click += new System.EventHandler(this.miZoomOut_Click);
            // 
            // miScale
            // 
            this.miScale.Enabled = false;
            this.miScale.Index = 4;
            this.miScale.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miZoom10,
            this.miZoom25,
            this.miZoom50,
            this.miZoom100,
            this.miZoom200,
            this.miZoom400,
            this.miZoom800});
            this.miScale.Text = "Scale";
            // 
            // miZoom10
            // 
            this.miZoom10.Index = 0;
            this.miZoom10.Text = "10%";
            this.miZoom10.Click += new System.EventHandler(this.miZoom_Click);
            // 
            // miZoom25
            // 
            this.miZoom25.Index = 1;
            this.miZoom25.Text = "25%";
            this.miZoom25.Click += new System.EventHandler(this.miZoom_Click);
            // 
            // miZoom50
            // 
            this.miZoom50.Index = 2;
            this.miZoom50.Text = "50%";
            this.miZoom50.Click += new System.EventHandler(this.miZoom_Click);
            // 
            // miZoom100
            // 
            this.miZoom100.Index = 3;
            this.miZoom100.Text = "100%";
            this.miZoom100.Click += new System.EventHandler(this.miZoom_Click);
            // 
            // miZoom200
            // 
            this.miZoom200.Index = 4;
            this.miZoom200.Text = "200%";
            this.miZoom200.Click += new System.EventHandler(this.miZoom_Click);
            // 
            // miZoom400
            // 
            this.miZoom400.Index = 5;
            this.miZoom400.Text = "400%";
            this.miZoom400.Click += new System.EventHandler(this.miZoom_Click);
            // 
            // miZoom800
            // 
            this.miZoom800.Index = 6;
            this.miZoom800.Text = "800%";
            this.miZoom800.Click += new System.EventHandler(this.miZoom_Click);
            // 
            // miFit
            // 
            this.miFit.Enabled = false;
            this.miFit.Index = 5;
            this.miFit.Text = "Fit drawing to window";
            this.miFit.Click += new System.EventHandler(this.miFit_Click);
            // 
            // mSep4
            // 
            this.mSep4.Index = 6;
            this.mSep4.Text = "-";
            // 
            // miShowSHXForm
            // 
            this.miShowSHXForm.Index = 7;
            this.miShowSHXForm.Text = "SHX Fonts";
            this.miShowSHXForm.Click += new System.EventHandler(this.miShowSHXForm_Click);
            // 
            // miShowOptionsForm
            // 
            this.miShowOptionsForm.Index = 8;
            this.miShowOptionsForm.Text = "Options";
            this.miShowOptionsForm.Click += new System.EventHandler(this.miOptions_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 9;
            this.menuItem1.Text = "Show structure";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // miCADFiles
            // 
            this.miCADFiles.Index = 3;
            this.miCADFiles.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miColorMode,
            this.miBlackMode,
            this.miWhiteBack,
            this.miBlackBack,
            this.miSep2,
            this.miShowLineWeight,
            this.miArcsSplit,
            this.miDimShow,
            this.miTextsShow,
            this.miSep3,
            this.miLayersShow});
            this.miCADFiles.Text = "&CAD files";
            // 
            // miColorMode
            // 
            this.miColorMode.Checked = true;
            this.miColorMode.Enabled = false;
            this.miColorMode.Index = 0;
            this.miColorMode.RadioCheck = true;
            this.miColorMode.Text = "Color drawing";
            this.miColorMode.Click += new System.EventHandler(this.miColorMode_Click);
            // 
            // miBlackMode
            // 
            this.miBlackMode.Enabled = false;
            this.miBlackMode.Index = 1;
            this.miBlackMode.RadioCheck = true;
            this.miBlackMode.Text = "Black drawing";
            this.miBlackMode.Click += new System.EventHandler(this.miBlackMode_Click);
            // 
            // miWhiteBack
            // 
            this.miWhiteBack.Enabled = false;
            this.miWhiteBack.Index = 2;
            this.miWhiteBack.RadioCheck = true;
            this.miWhiteBack.Text = "White Background";
            this.miWhiteBack.Click += new System.EventHandler(this.miWhiteBack_Click);
            // 
            // miBlackBack
            // 
            this.miBlackBack.Checked = true;
            this.miBlackBack.Enabled = false;
            this.miBlackBack.Index = 3;
            this.miBlackBack.RadioCheck = true;
            this.miBlackBack.Text = "Black Background";
            this.miBlackBack.Click += new System.EventHandler(this.miBlackBack_Click);
            // 
            // miSep2
            // 
            this.miSep2.Enabled = false;
            this.miSep2.Index = 4;
            this.miSep2.Text = "-";
            // 
            // miShowLineWeight
            // 
            this.miShowLineWeight.Checked = true;
            this.miShowLineWeight.Enabled = false;
            this.miShowLineWeight.Index = 5;
            this.miShowLineWeight.Text = "Show Lineweight";
            this.miShowLineWeight.Click += new System.EventHandler(this.miShowLineWeight_Click);
            // 
            // miArcsSplit
            // 
            this.miArcsSplit.Checked = true;
            this.miArcsSplit.Enabled = false;
            this.miArcsSplit.Index = 6;
            this.miArcsSplit.Text = "Arcs Splitted";
            this.miArcsSplit.Click += new System.EventHandler(this.miArcsSplit_Click);
            // 
            // miDimShow
            // 
            this.miDimShow.Checked = true;
            this.miDimShow.Enabled = false;
            this.miDimShow.Index = 7;
            this.miDimShow.Text = "Dimensions Show";
            this.miDimShow.Click += new System.EventHandler(this.miDimShow_Click);
            // 
            // miTextsShow
            // 
            this.miTextsShow.Checked = true;
            this.miTextsShow.Enabled = false;
            this.miTextsShow.Index = 8;
            this.miTextsShow.Text = "Texts Show";
            this.miTextsShow.Click += new System.EventHandler(this.miTextsShow_Click);
            // 
            // miSep3
            // 
            this.miSep3.Enabled = false;
            this.miSep3.Index = 9;
            this.miSep3.Text = "-";
            // 
            // miLayersShow
            // 
            this.miLayersShow.Enabled = false;
            this.miLayersShow.Index = 10;
            this.miLayersShow.Text = "Show Layers";
            this.miLayersShow.Click += new System.EventHandler(this.miLayersShow_Click);
            // 
            // miHelp
            // 
            this.miHelp.Index = 4;
            this.miHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miLng,
            this.miAbout});
            this.miHelp.Text = "?";
            // 
            // miLng
            // 
            this.miLng.Index = 0;
            this.miLng.Text = "Language";
            // 
            // miAbout
            // 
            this.miAbout.Index = 1;
            this.miAbout.Text = "About...";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // cadEditorControl
            // 
            this.cadEditorControl.ColorDraw = true;
            this.cadEditorControl.DimensionVisible = true;
            this.cadEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadEditorControl.EnableSnap = true;
            this.cadEditorControl.EndPoint = new System.Drawing.Point(0, 0);
            this.cadEditorControl.EntityPropertyGridVisible = true;
            this.cadEditorControl.ImageBaseSize = new System.Drawing.SizeF(0F, 0F);
            this.cadEditorControl.ImagePosition = ((System.Drawing.PointF)(resources.GetObject("cadEditorControl.ImagePosition")));
            this.cadEditorControl.ImageScale = 1F;
            this.cadEditorControl.InFileName = "";
            this.cadEditorControl.Location = new System.Drawing.Point(0, 0);
            this.cadEditorControl.Name = "cadEditorControl";
            this.cadEditorControl.OutFileName = "";
            this.cadEditorControl.PreviousImagePosition = ((System.Drawing.PointF)(resources.GetObject("cadEditorControl.PreviousImagePosition")));
            this.cadEditorControl.PreviousImageScale = 1F;
            this.cadEditorControl.PropertyEntityPanelVisible = true;
            this.cadEditorControl.ShowLineWeight = true;
            this.cadEditorControl.Size = new System.Drawing.Size(675, 462);
            this.cadEditorControl.StartPoint = new System.Drawing.Point(0, 0);
            this.cadEditorControl.StatusBarPanelVisible = true;
            this.cadEditorControl.TabIndex = 0;
            this.cadEditorControl.TextVisible = true;
            this.cadEditorControl.ToolsPanelVisible = true;
            this.cadEditorControl.EndLoadFile += new CADImport.CADImportForms.ChangeOptionsEventHandler(this.cadEditorControl_EndLoadFile);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(675, 462);
            this.Controls.Add(this.cadEditorControl);
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Editor";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

