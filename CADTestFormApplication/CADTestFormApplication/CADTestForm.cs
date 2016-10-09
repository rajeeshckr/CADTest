using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CADImport;
using CADImport.FaceModule;
using CADImport.CADImportForms;
using System.Collections;
using System.IO;

namespace CADTestFormApplication
{
    public partial class CADTestForm : Form
    {
        private SaveSettings svSet;
        private static SortedList settingsLst;
        CADImage _cadImage;

        public CADTestForm()
        {

            InitializeComponent();
            string path = @"C:\Users\Rajeesh\Documents\CAD .NET 11\Files\123.dxf";
            _cadImage = CADImage.CreateImageByExtension(path);
            _cadImage.LoadFromFile(path);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (_cadImage != null)
            {
                RectangleF R;
                R = new RectangleF(0, 0, 500, 500);
                R.Height = (float)(R.Width * _cadImage.Extents.Height /
                _cadImage.Extents.Width);
                // width of image is 500, height depends on height/width of the drawing
                _cadImage.Draw(e.Graphics, R);
            }

        }


        private void ChangeControlState(bool val)
        {
            this.miTextsShow.Checked = this.cadEditorControl.TextVisible;
            this.miDimShow.Checked = this.cadEditorControl.DimensionVisible;
            this.miShowLineWeight.Checked = this.cadEditorControl.ShowLineWeight;
            bool colorblack = this.cadEditorControl.Image.BackgroundColor.Equals(Color.Black);
            this.miBlackBack.Checked = colorblack;
            this.miWhiteBack.Checked = !colorblack;
            this.miColorMode.Checked = this.cadEditorControl.ColorDraw;
            this.miBlackMode.Checked = !this.cadEditorControl.ColorDraw;
        }

        private void InitLng()
        {
            mlng = new MultipleLanguage(this.GetType());
            if (this.mainMenu != null)
                mlng.SaveNameMenuItem(this.mainMenu.MenuItems);
            if (this.ContextMenu != null)
                mlng.SaveNameMenuItem(this.ContextMenu.MenuItems);
            mlng.SaveNameNoNameElement(this.Controls);
        }

        private void SetAllFormsSettings()
        {
            this.cadEditorControl.SetAllFormsLanguageSettings(mlng.Path, lngFile);
            this.cadEditorControl.OptionsForm.ChangeLngPath += new CADImport.CADImportForms.ChangeLngPathEventHandler(ReloadLNG);
            this.cadEditorControl.OptionsForm.ChangeLanguage += new CADImport.CADImportForms.ChangeLanguageEventHandler(ChangeLanguage);
        }

        internal void ReloadLNG(string val)
        {
            this.mainMenu.MenuItems[4].MenuItems[0].MenuItems.Clear();
            mlng.Path = val;
            mlng.LoadLngFileList(this.mainMenu.MenuItems[4].MenuItems[0], new System.EventHandler(LanguageSelect_Click));
            if (this.mainMenu.MenuItems[4].MenuItems[0].MenuItems.Count > this.curLngIndex)
                this.mainMenu.MenuItems[4].MenuItems[0].MenuItems[this.curLngIndex].Checked = true;
        }

        private void InitSettings()
        {
            svSet = new SaveSettings(fileSettingsName);
            settingsLst = svSet.LoadOptions();
            if (settingsLst != null)
            {
                string key = ApplicationConstants.languagepath;
                if (settingsLst.ContainsKey(key))
                    this.mlng.Path = Convert.ToString(settingsLst[key]);
            }
            else
                this.mlng.Path = @".\Languages";
            mlng.LoadLngFileList(this.mainMenu.MenuItems[4].MenuItems[0], new System.EventHandler(LanguageSelect_Click));
            if (settingsLst == null)
                CreateNewSettingsList();
            else
                SetSettings();
        }

        private void LanguageSelect_Click(object sender, System.EventArgs e)
        {
            if (!(sender is MenuItem))
                return;
            MenuItem mn = (sender as MenuItem);
            curLngIndex = (byte)mn.Index;
            lngFile = mn.Text + ApplicationConstants.lngextstr;
            this.cadEditorControl.SetAllFormsLanguageSettings(this.mlng.Path, lngFile);
            SetLNG();
            this.cadEditorControl.ChangeControlState();
        }

        #region Help
#if RUSHELP
		/// <summary>
		/// Óñòàíàâëèâàåò óêàçàííûé ÿçûê äëÿ ïðèëîæåíèÿ
		/// </summary>
		/// <param name="val">Óñòàíàâëèâàåìû ÿçûê</param>
		/// <param name="index">Èíäåêñ óñòàíàâëèâàåìîãî ÿçûêà â ñïèñêå ÿçûêîâ</param>
#else
        /// <summary>
        /// Sets specified linguage for the application
        /// </summary>
        /// <param name="val">A language to set</param>
        /// <param name="index">An index of a language in the languages list</param>
#endif
        #endregion
        public void ChangeLanguage(string val, int index)
        {
            curLngIndex = index;
            lngFile = val + ApplicationConstants.lngextstr;
            this.cadEditorControl.SetAllFormsLanguageSettings(this.mlng.Path, lngFile);
            SetLNG();
            this.cadEditorControl.ChangeControlState();
        }

        private void SetLNG()
        {
            mlng.LoadLNG(lngFile);
            mlng.RestoreLanguage(this.Controls, this.Menu);
            this.mainMenu.MenuItems[4].MenuItems[0].MenuItems.Clear();
            mlng.LoadLngFileList(this.mainMenu.MenuItems[4].MenuItems[0], new System.EventHandler(LanguageSelect_Click));
            this.Text = ApplicationConstants.appnamestr;
            this.Text = mlng.SetLanguage(this.Controls, this.Menu, this.Text);
            if (this.mainMenu.MenuItems[4].MenuItems[0].MenuItems.Count > this.curLngIndex)
                this.mainMenu.MenuItems[4].MenuItems[0].MenuItems[this.curLngIndex].Checked = true;
        }

        internal void SetSettings()
        {
            if (settingsLst == null)
                return;
            string tmp;
            int cn = 0;
            //Language path
            string key = ApplicationConstants.languagepath;
            if (settingsLst.ContainsKey(key))
                this.mlng.Path = Convert.ToString(settingsLst[key]);
            //Language
            key = ApplicationConstants.languagestr;
            if (settingsLst.ContainsKey(key))
                lngFile = (string)settingsLst[key];
            mlng.LoadLNG(lngFile);
            this.Text = mlng.SetLanguage(this.Controls, this.Menu, this.Text);
            //Language ID
            key = ApplicationConstants.languageIDstr;
            if (settingsLst.ContainsKey(key))
                this.curLngIndex = Convert.ToByte(settingsLst[key]);
            //BackgroundColor
            key = ApplicationConstants.backcolorstr;
            tmp = ApplicationConstants.blackstr;
            if (settingsLst.ContainsKey(key))
                tmp = Convert.ToString(settingsLst[key]);
            if (tmp.ToUpper() == ApplicationConstants.blackstr)
                this.cadEditorControl.Black_Click();
            else
                this.cadEditorControl.White_Click();
            //Show entity panel
            key = ApplicationConstants.showentitystr;
            if (settingsLst.ContainsKey(key))
                tmp = Convert.ToString(settingsLst[key]);
            //Color drawing
            key = ApplicationConstants.drawmodestr;
            if (settingsLst.ContainsKey(key))
                tmp = Convert.ToString(settingsLst[key]);
            if (tmp.ToUpper() == ApplicationConstants.truestr)
                this.cadEditorControl.ColorDraw = true;
            else
                this.cadEditorControl.ColorDraw = false;
            //SHXPathCount
            key = ApplicationConstants.shxpathcnstr;
            if (settingsLst.ContainsKey(key))
                cn = Convert.ToInt32(settingsLst[key]);
            //SHXPaths
            for (int i = 0; i < cn; i++)
            {
                key = string.Format("SHXPath_{0}", (i + 1));
                if (settingsLst.ContainsKey(key))
                    this.cadEditorControl.SHXForm.AddPath(Convert.ToString(settingsLst[key]));
            }
            //First start
            key = ApplicationConstants.installstr;
            if (settingsLst.ContainsKey(key))
            {
                if (cadEditorControl.Image.Converter.SHXSettings.SearchSHXPaths)
                {
                    this.cadEditorControl.SHXForm.lstDir.Items.Clear();
                    this.cadEditorControl.SHXForm.lstPath.Clear();
                    ArrayList vPaths = new ArrayList();
                    CADImport.CADConst.FindAutoCADSHXPaths(vPaths);
                    for (int i = 0; i < vPaths.Count; i++)
                    {
                        tmp = (string)vPaths[i];
                        this.cadEditorControl.SHXForm.lstDir.Items.Add(tmp);
                        this.cadEditorControl.SHXForm.lstPath.Add(tmp, string.Empty);
                        cadEditorControl.Image.Converter.SHXSettings.SHXSearchPaths += cadEditorControl.Image.Converter.SHXSettings.SHXSearchPaths + tmp + ApplicationConstants.sepstr3;
                    }
                }
            }
        }

        private void CreateNewSettingsList()
        {
            string tmp;
            settingsLst = new SortedList();
            //Language path
            settingsLst.Add(ApplicationConstants.languagepath, mlng.Path);
            //Language
            settingsLst.Add(ApplicationConstants.languagestr, lngFile);
            //Language ID
            settingsLst.Add(ApplicationConstants.languageIDstr, this.curLngIndex);
            //BackgroundColor
            if (cadEditorControl.EditorCADPictureBox.BackColor == Color.Black)
                tmp = ApplicationConstants.blackstr;
            else tmp = ApplicationConstants.whitestr;
            settingsLst.Add(ApplicationConstants.backcolorstr, tmp);
            //Color drawing
            if (this.cadEditorControl.Image != null)
                settingsLst.Add(ApplicationConstants.colorDraw, (this.cadEditorControl.Image.DrawMode == CADImport.CADDrawMode.Normal));
            else
                settingsLst.Add(ApplicationConstants.colorDraw, this.cadEditorControl.ColorDraw);
            //SHXPathCount
            int cn = cadEditorControl.SHXForm.lstDir.Items.Count;
            settingsLst.Add(ApplicationConstants.shxpathcnstr, cadEditorControl.SHXForm.lstDir.Items.Count);
            //SHXPaths
            for (int i = 0; i < cn; i++)
            {
                settingsLst.Add("SHXPath_" + (i + 1), cadEditorControl.SHXForm.lstDir.Items[i]);
            }
            this.cadEditorControl.NewProtectionSettings(settingsLst);
        }

        private void SelectLanguage()
        {
            for (int i = 0; i < this.mainMenu.MenuItems[4].MenuItems[0].MenuItems.Count; i++)
                if (this.mainMenu.MenuItems[4].MenuItems[0].MenuItems[i].Text == "English")
                {
                    this.mainMenu.MenuItems[4].MenuItems[0].MenuItems[i].Checked = true;
                    this.curLngIndex = i;
                    break;
                }
        }

        internal void ReloadLNG()
        {
            mlng.LoadLngFileList(this.mainMenu.MenuItems[4].MenuItems[0], new System.EventHandler(LanguageSelect_Click));
        }

        private void miOpenFile_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.LoadFile(true);
        }

        private void cadEditorControl_EndLoadFile(bool val)
        {
            if (val)
                EnableMenuItems(true);
        }

        #region Help
        /// <summary>
        /// Enables menu items
        /// </summary>
        /// <param name="val">If <b>true</b> menu items are enabled, else - disabled</param>
        #endregion
        public void EnableMenuItems(bool val)
        {
            #region Export
#if Export
			this.miSaveAsDXF.Enabled = val;
#endif
            #endregion
            miScale.Enabled = val;
            miSaveFile.Enabled = val;
            miCopyAsBMP.Enabled = val;
            miZoomIn.Enabled = val;
            miZoomOut.Enabled = val;
            miFit.Enabled = val;
            miColorMode.Enabled = val;
            miBlackMode.Enabled = val;
            miWhiteBack.Enabled = val;
            miBlackBack.Enabled = val;
            miShowLineWeight.Enabled = val;
            miArcsSplit.Enabled = val;
            miDimShow.Enabled = val;
            miTextsShow.Enabled = val;
            miLayersShow.Enabled = val;
            miClose.Enabled = val;
            miPrint.Enabled = val;
            miPrintCustom.Enabled = val;
            miPrintPrev.Enabled = val;
            miUndo.Enabled = val;
            miRedo.Enabled = val;
            miDelete.Enabled = val;
            miCopy.Enabled = val;
            miPaste.Enabled = val;
            miCut.Enabled = val;
        }

        private void miAbout_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.AboutForm.ShowDialog();
        }

        private void miSaveFile_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.SaveAsImage(true);
        }

        private void miSaveAsDXF_Click(object sender, System.EventArgs e)
        {
            #region Export
#if Export
			this.cadEditorControl.SaveAsDXF(true);
#endif
            #endregion Export			
        }

        private void miPrint_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.Image.Print(true, true, null);
        }

        private void miPrintCustom_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.ShowCustomPrintPreviewDialog();
        }

        private void miPrintPrev_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.ShowPrintPreviewDialog();
        }

        private void miExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void miClose_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.CloseFile();
        }

        private void miCopyAsBMP_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.PutToClipboard();
        }

        private void miUndo_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.UndoChangeEntity();
        }

        private void miRedo_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.RedoChangeEntity();
        }

        private void miDelete_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.DeleteSelectedEntities();
        }

        private void miCopy_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.Image.CopyEntities();
        }

        private void miCut_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.Image.CutEntities();
            this.cadEditorControl.EditorCADPictureBox.Invalidate();
        }

        private void miPaste_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.Image.PasteEntities();
            this.cadEditorControl.EditorCADPictureBox.Invalidate();
        }

        private void miShowEntitiesPanel_Click(object sender, System.EventArgs e)
        {
            propPnVisible = !propPnVisible;
            this.cadEditorControl.PropertyEntityPanelVisible = propPnVisible;
            this.miShowEntitiesPanel.Checked = propPnVisible;
        }

        private void miZoomIn_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.DoZoomIn();
        }

        private void miZoomOut_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.DoZoomOut();
        }

        private void miFit_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.CalculateNewSizeImage();
        }

        private void miShowSHXForm_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.SHXForm.ShowDialog();
        }

        private void miOptions_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.EntitiesCreator.OptionsForm.ShowDialog();
        }

        private void miColorMode_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.ColorDraw = true;
            this.miColorMode.Checked = true;
            this.miBlackMode.Checked = false;
        }

        private void miBlackMode_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.ColorDraw = false;
            this.miColorMode.Checked = false;
            this.miBlackMode.Checked = true;
        }

        private void miWhiteBack_Click(object sender, System.EventArgs e)
        {
            this.whiteBackGround = true;
            this.blackBackGround = false;
            ChangeBackground();
        }

        private void ChangeBackground()
        {
            this.miWhiteBack.Checked = this.whiteBackGround;
            this.miBlackBack.Checked = this.blackBackGround;
            if (this.whiteBackGround)
                this.cadEditorControl.SetWhiteBackGround();
            if (this.blackBackGround)
                this.cadEditorControl.SetBlackBackGround();
        }

        private void miShowLineWeight_Click(object sender, System.EventArgs e)
        {
            showLineWeight = !showLineWeight;
            this.cadEditorControl.ShowLineWeight = showLineWeight;
            this.miShowLineWeight.Checked = showLineWeight;
        }

        private void miArcsSplit_Click(object sender, System.EventArgs e)
        {
            this.useWinEllipse = !this.useWinEllipse;
            //this.cadEditorControl.UseWinEllipse(useWinEllipse);
            this.miArcsSplit.Checked = !useWinEllipse;
        }

        private void miDimShow_Click(object sender, System.EventArgs e)
        {
            dimVisible = !dimVisible;
            this.cadEditorControl.DimensionVisible = dimVisible;
            this.miDimShow.Checked = dimVisible;
        }

        private void miBlackBack_Click(object sender, System.EventArgs e)
        {
            this.whiteBackGround = false;
            this.blackBackGround = true;
            ChangeBackground();
        }

        private void miTextsShow_Click(object sender, System.EventArgs e)
        {
            textVisible = !textVisible;
            this.cadEditorControl.TextVisible = textVisible;
            this.miTextsShow.Checked = textVisible;
        }

        private void miLayersShow_Click(object sender, System.EventArgs e)
        {
            this.cadEditorControl.LayerForm.ShowDialog();
        }

        private void miZoom_Click(object sender, System.EventArgs e)
        {
            float i = 1.0f;
            switch ((sender as MenuItem).Index)
            {
                case 0:
                    i = 0.1f;
                    break;
                case 1:
                    i = 0.25f;
                    break;
                case 2:
                    i = 0.5f;
                    break;
                case 3:
                    i = 1;
                    break;
                case 4:
                    i = 2;
                    break;
                case 5:
                    i = 4;
                    break;
                case 6:
                    i = 8;
                    break;
            }
            this.cadEditorControl.SetScale(i);
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CreateNewSettingsList();
            svSet.SaveOptions(settingsLst);
        }

        private void ShowStructure()
        {
            CADTreeView treeForm = new CADTreeView();
            treeForm.Image = cadEditorControl.Image;
            treeForm.DrawTarget = cadEditorControl.PictureBox;
            treeForm.Show(this);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            ShowStructure();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cadEditorControl.SHXForm.AddPath(Path.GetFullPath(@"..\..\..\..\..\shx"));
            this.cadEditorControl.SHXForm.AddDefaultSHXPaths();
        }
    }

    internal abstract class ApplicationConstants
    {
        public static readonly string defaultstr;
        public static readonly string languagepath;
        public static readonly string msgBoxDebugCaption;
        public static readonly string sepstr;
        public static readonly string notsupportedstr;
        public static readonly string notsupportedextstr;
        public static readonly string appnamestr;
        public static readonly string sepstr2;
        public static readonly string lngextstr;
        public static readonly string languagestr;
        public static readonly string languageIDstr;
        public static readonly string backcolorstr;
        public static readonly string blackstr;
        public static readonly string showentitystr;
        public static readonly string drawmodestr;
        public static readonly string truestr;
        public static readonly string shxpathcnstr;
        public static readonly string installstr;
        public static readonly string sepstr3;
        public static readonly string typelcstr;
        public static readonly string hoststr;
        public static readonly string portstr;
        public static readonly string appconst;
        public static readonly string blackstr2;
        public static readonly string whitestr;
        public static readonly string registerstr;
        public static readonly string namestr;
        public static readonly string visiblestr;
        public static readonly string freezestr;
        public static readonly string colorstr;
        public static readonly string colorDraw;

        static ApplicationConstants()
        {
            defaultstr = "Default";
            languagepath = "LanguagePath";
            msgBoxDebugCaption = "Debug application message";
            sepstr = " - ";
            notsupportedstr = "not supported";
            notsupportedextstr = "Not supported in current version!";
            appnamestr = "CADImportNet Demo";
            sepstr2 = " : ";
            lngextstr = ".lng";
            languagestr = "Language";
            languageIDstr = "LanguageID";
            backcolorstr = "BackgroundColor";
            blackstr = "BLACK";
            showentitystr = "ShowEntity";
            drawmodestr = "drawMode";
            truestr = "TRUE";
            shxpathcnstr = "SHXPathCount";
            installstr = "Install";
            sepstr3 = ";";
            typelcstr = "Type_license";
            hoststr = "Host";
            portstr = "Port";
            appconst = "Application";
            blackstr2 = "Black";
            whitestr = "White";
            registerstr = "register";
            namestr = "Name";
            visiblestr = "Visible";
            freezestr = "Freeze";
            colorstr = "Color";
            colorDraw = "ColorDraw";
        }
    }
}
