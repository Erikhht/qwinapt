using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WinApt.Common;

namespace WinApt.Client.GUI
{
    public partial class SplashForm : Form
    {
        private string configFile = MainForm.configFile;
        public SplashForm()
        {
            InitializeComponent();
        }
        public void InitApp()
        {
            //
            //TODO: add init code before main form show.
            //

            this.lbSplash.Text = MainForm.LocRM.GetString("strSplashLabelText");

            if (MainForm.myCmdMgr == null)
                MainForm.myCmdMgr = new CmdMgr();
            
            //if we already build one, no need to check the file.
            if (MainForm.myCmdMgr.Config == null)
            {
                //load config file
                if (File.Exists(configFile))
                {
                    MainForm.myCmdMgr.Config = (AppInfoConfig)WinAptLib.ReadFromFile(typeof(AppInfoConfig), configFile);
                }
                else
                {
                    //no config file, need to builder one
                    throw new Exception("new");
                }
            }
            //download update page.
            string content = "";
            this.lbSplash.Text = MainForm.LocRM.GetString("strSplashLabelLoadDB");
            lbSplash.Update();
            try
            {
                string fileName = "appinfodb_" + MainForm.myCmdMgr.Config.local + ".xml";
                if (!File.Exists(fileName))
                {
                    this.lbSplash.Text = MainForm.LocRM.GetString("strSplashLabelDownloadDB");
                    lbSplash.Update();
                    if (!WinAptLib.DownloadDbFile(MainForm.myCmdMgr.Config.updateUrl))
                        throw new Exception("Download file error.\n");
                }
                StreamReader infile = File.OpenText(fileName);
                content = infile.ReadToEnd();
                infile.Close();
            }
            catch (Exception e)
            {
                throw new Exception(string.Format(MainForm.LocRM.GetString("strSplashLabelDownloadError")));
            }
            finally
            {
                //save the config file, then quit program.
                WinAptLib.WriteToFile(MainForm.myCmdMgr.Config, configFile);
            }
            MainForm.myCmdMgr.UpdateAppDB(content);
        }
    }
}