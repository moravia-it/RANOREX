﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SyncSharepointFilesAndFolders
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("bb68d91c-8109-4627-85aa-77f5ef12d6e1", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SyncSharepointFilesAndFoldersRepository repository.
        /// </summary>
        public static SyncSharepointFilesAndFoldersRepository repo = SyncSharepointFilesAndFoldersRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            string1 = "C:\\Users\\User\\Documents\\files\\_ENU\\";
            string2 = "Asia Q2 Sales.xlsx";
            string3 = "Carbon 3D Printing Proposal.docx";
            string4 = "Contoso Sales by Product Analysis.xlsx";
            ScreenPath = "C:\\Users\\User\\Documents\\Ranorex\\RanorexStudio Projects\\SyncSharepointFilesAndFolders\\SyncSharepointFilesAndFolders\\_files\\Screens\\_ENU\\";
            string5 = "admin@harula.onmicrosoft.com";
            string6 = "C:\\Users\\User\\Documents\\Files2\\_ENU\\";
            Loggerpath = "";
            LANGUAGE = "_ENU";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _string1;

        /// <summary>
        /// Gets or sets the value of variable string1.
        /// </summary>
        [TestVariable("dd284ab4-b807-477b-a439-5083601bc1a0")]
        public string string1
        {
            get { return _string1; }
            set { _string1 = value; }
        }

        string _ScreenPath;

        /// <summary>
        /// Gets or sets the value of variable ScreenPath.
        /// </summary>
        [TestVariable("3b3e4765-5ea4-4dea-adb7-dacf3e10d3b2")]
        public string ScreenPath
        {
            get { return _ScreenPath; }
            set { _ScreenPath = value; }
        }

        string _string5;

        /// <summary>
        /// Gets or sets the value of variable string5.
        /// </summary>
        [TestVariable("9c704617-5c0c-4c5e-993a-87458e862049")]
        public string string5
        {
            get { return _string5; }
            set { _string5 = value; }
        }

        string _string6;

        /// <summary>
        /// Gets or sets the value of variable string6.
        /// </summary>
        [TestVariable("a8eb0d7a-dd19-4306-b624-372b7e3d0aeb")]
        public string string6
        {
            get { return _string6; }
            set { _string6 = value; }
        }

        string _Loggerpath;

        /// <summary>
        /// Gets or sets the value of variable Loggerpath.
        /// </summary>
        [TestVariable("5d727a82-9ee1-4454-9af3-ad79f6f84b11")]
        public string Loggerpath
        {
            get { return _Loggerpath; }
            set { _Loggerpath = value; }
        }

        string _LANGUAGE;

        /// <summary>
        /// Gets or sets the value of variable LANGUAGE.
        /// </summary>
        [TestVariable("cd76e981-1300-46b6-8566-3fbfceb2e516")]
        public string LANGUAGE
        {
            get { return _LANGUAGE; }
            set { _LANGUAGE = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable string2.
        /// </summary>
        [TestVariable("d36ad539-c7b6-4a5d-ac39-f676f319ba60")]
        public string string2
        {
            get { return repo.string2; }
            set { repo.string2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable string3.
        /// </summary>
        [TestVariable("3ccb3ac3-73ee-4f70-89e3-1c4a789d4618")]
        public string string3
        {
            get { return repo.string3; }
            set { repo.string3 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable string4.
        /// </summary>
        [TestVariable("72489f8b-2ecd-4afa-a2f9-8127ecf0f18a")]
        public string string4
        {
            get { return repo.string4; }
            set { repo.string4 = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://harula.sharepoint.com/sites/harula/Sdilene%20dokumenty/Forms/AllItems.aspx' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            //Host.Current.OpenBrowser("https://harula.sharepoint.com/sites/harula/Sdilene%20dokumenty/Forms/AllItems.aspx", "IE", "", false, false, false, false, false);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://harula2.sharepoint.com/sites/harula/Shared%20Documents/Forms/AllItems.aspx' with browser 'IE' in normal mode.", new RecordItemIndex(1));
            Host.Current.OpenBrowser("https://harula2.sharepoint.com/sites/harula/Shared%20Documents/Forms/AllItems.aspx", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(2));
            Delay.Duration(6000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HarulaDocumentsAllDocuments.DivTagUseA' at Center.", repo.HarulaDocumentsAllDocuments.DivTagUseAInfo, new RecordItemIndex(3));
                repo.HarulaDocumentsAllDocuments.DivTagUseA.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.CredUseridInputtext' at Center.", repo.HarulaDocumentsAllDocuments.CredUseridInputtextInfo, new RecordItemIndex(4));
            repo.HarulaDocumentsAllDocuments.CredUseridInputtext.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$string5'.", new RecordItemIndex(5));
            Keyboard.Press(string5, 10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.CredPasswordInputtext' at Center.", repo.HarulaDocumentsAllDocuments.CredPasswordInputtextInfo, new RecordItemIndex(6));
            repo.HarulaDocumentsAllDocuments.CredPasswordInputtext.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Moravia123'.", new RecordItemIndex(8));
            Keyboard.Press("Moravia123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.CredSignInButton' at Center.", repo.HarulaDocumentsAllDocuments.CredSignInButtonInfo, new RecordItemIndex(9));
            repo.HarulaDocumentsAllDocuments.CredSignInButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(10));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.File' at 7631;42.", repo.HarulaDocumentsAllDocuments.FileInfo, new RecordItemIndex(11));
            repo.HarulaDocumentsAllDocuments.File.Click("7631;42");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InternetExplorer.ToolBar1001' at CenterRight.", repo.InternetExplorer.ToolBar1001Info, new RecordItemIndex(12));
            repo.InternetExplorer.ToolBar1001.Click(Location.CenterRight);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$string1'.", new RecordItemIndex(13));
            Keyboard.Press(string1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(14));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+None' Down.", new RecordItemIndex(15));
            Keyboard.Down(System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InternetExplorer.ShellView.SystemItemNameDisplay' at Center.", repo.InternetExplorer.ShellView.SystemItemNameDisplayInfo, new RecordItemIndex(16));
            repo.InternetExplorer.ShellView.SystemItemNameDisplay.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InternetExplorer.ShellView.SystemItemNameDisplay1' at 109;19.", repo.InternetExplorer.ShellView.SystemItemNameDisplay1Info, new RecordItemIndex(17));
            repo.InternetExplorer.ShellView.SystemItemNameDisplay1.Click("109;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InternetExplorer.ShellView.SystemItemNameDisplay2' at 50;19.", repo.InternetExplorer.ShellView.SystemItemNameDisplay2Info, new RecordItemIndex(18));
            repo.InternetExplorer.ShellView.SystemItemNameDisplay2.Click("50;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+None' Up.", new RecordItemIndex(19));
            Keyboard.Up(System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(20));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+R' Press.", new RecordItemIndex(21));
            Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, 19, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(22));
            Delay.Duration(10000, false);
            
            Snap(ScreenPath, "01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.Sync' at Center.", repo.HarulaDocumentsAllDocuments.SyncInfo, new RecordItemIndex(24));
            repo.HarulaDocumentsAllDocuments.Sync.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(25));
            Delay.Duration(3000, false);
            
            Snap(ScreenPath, "02");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InternetExplorer.ButtonAllow' at Center.", repo.InternetExplorer.ButtonAllowInfo, new RecordItemIndex(27));
            repo.InternetExplorer.ButtonAllow.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MicrosoftOneDrive.Text8512' at Center.", repo.MicrosoftOneDrive.Text8512Info, new RecordItemIndex(28));
            repo.MicrosoftOneDrive.Text8512.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'admin@harula.onmicrosoft.com'.", new RecordItemIndex(29));
            Keyboard.Press("admin@harula.onmicrosoft.com");
            Delay.Milliseconds(0);
            
            Snap(ScreenPath, "05");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MicrosoftOneDrive.SignIn' at Center.", repo.MicrosoftOneDrive.SignInInfo, new RecordItemIndex(31));
            repo.MicrosoftOneDrive.SignIn.Click();
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "6"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(33));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'HarulaDocumentsAllDocuments.CredPasswordInputtext' at Center.", repo.HarulaDocumentsAllDocuments.CredPasswordInputtextInfo, new RecordItemIndex(34));
            repo.HarulaDocumentsAllDocuments.CredPasswordInputtext.MoveTo();
            Delay.Milliseconds(200);
            
            Snap(ScreenPath, "06");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.CredPasswordInputtext' at Center.", repo.HarulaDocumentsAllDocuments.CredPasswordInputtextInfo, new RecordItemIndex(36));
            repo.HarulaDocumentsAllDocuments.CredPasswordInputtext.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'M'.", new RecordItemIndex(37));
            Keyboard.Press("M");
            Delay.Milliseconds(0);
            
            Snap(ScreenPath, "07");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'oravia123'.", new RecordItemIndex(39));
            Keyboard.Press("oravia123");
            Delay.Milliseconds(0);
            
            Snap(ScreenPath, "08");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.CredSignInButton' at Center.", repo.HarulaDocumentsAllDocuments.CredSignInButtonInfo, new RecordItemIndex(41));
            repo.HarulaDocumentsAllDocuments.CredSignInButton.Click();
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "8"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MicrosoftOneDrive.SignIn' at Center.", repo.MicrosoftOneDrive.SignInInfo, new RecordItemIndex(43));
            repo.MicrosoftOneDrive.SignIn.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(44));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MicrosoftOneDrive.SignIn' at Center.", repo.MicrosoftOneDrive.SignInInfo, new RecordItemIndex(45));
            repo.MicrosoftOneDrive.SignIn.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(46));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MicrosoftOneDrive.Close' at Center.", repo.MicrosoftOneDrive.CloseInfo, new RecordItemIndex(47));
            repo.MicrosoftOneDrive.Close.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(48));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.InternetExplorer1RunningWindow' at Center.", repo.Explorer.InternetExplorer1RunningWindowInfo, new RecordItemIndex(49));
            repo.Explorer.InternetExplorer1RunningWindow.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(50));
            Delay.Duration(2000, false);
            
            Snap(ScreenPath, "10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.ShowDesktop' at Center.", repo.Explorer.ShowDesktopInfo, new RecordItemIndex(52));
            repo.Explorer.ShowDesktop.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(53));
            Delay.Duration(2000, false);
            
            Snap(ScreenPath, "11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.FileExplorer1RunningWindow' at Center.", repo.Explorer.FileExplorer1RunningWindowInfo, new RecordItemIndex(55));
            repo.Explorer.FileExplorer1RunningWindow.Click();
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "14"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "20"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Resize('1050', '1050') on item 'CUsersUserDocumentsRanorexRanorexS'.", repo.CUsersUserDocumentsRanorexRanorexS.SelfInfo, new RecordItemIndex(58));
            repo.CUsersUserDocumentsRanorexRanorexS.Self.Resize(ValueConverter.ArgumentFromString<int>("width", "1050"), ValueConverter.ArgumentFromString<int>("height", "1050"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Move('300', '250') on item 'CUsersUserDocumentsRanorexRanorexS'.", repo.CUsersUserDocumentsRanorexRanorexS.SelfInfo, new RecordItemIndex(59));
            repo.CUsersUserDocumentsRanorexRanorexS.Self.Move(ValueConverter.ArgumentFromString<int>("x", "300"), ValueConverter.ArgumentFromString<int>("y", "250"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(60));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CUsersUserDocumentsRanorexRanorexS.QuickAccess' at Center.", repo.CUsersUserDocumentsRanorexRanorexS.QuickAccessInfo, new RecordItemIndex(61));
            repo.CUsersUserDocumentsRanorexRanorexS.QuickAccess.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(62));
            Delay.Duration(2000, false);
            
            Snap(ScreenPath, "12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CUsersUserDocumentsRanorexRanorexS.HarulaDocuments' at Center.", repo.CUsersUserDocumentsRanorexRanorexS.HarulaDocumentsInfo, new RecordItemIndex(64));
            repo.CUsersUserDocumentsRanorexRanorexS.HarulaDocuments.Click();
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "16"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(66));
            Delay.Duration(2000, false);
            
            Snap(ScreenPath, "13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'Explorer.FileExplorer1RunningWindow' at Center.", repo.Explorer.FileExplorer1RunningWindowInfo, new RecordItemIndex(68));
            repo.Explorer.FileExplorer1RunningWindow.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(69));
            Delay.Duration(4000, false);
            
            Snap(ScreenPath, "14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Windows\\explorer.exe' with arguments from variable $string6 in normal mode.", new RecordItemIndex(71));
            Host.Local.RunApplication("C:\\Windows\\explorer.exe", string6, "", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Resize('950', '950') on item 'Files2'.", repo.Files2.SelfInfo, new RecordItemIndex(72));
            repo.Files2.Self.Resize(ValueConverter.ArgumentFromString<int>("width", "950"), ValueConverter.ArgumentFromString<int>("height", "950"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Move('1300', '200') on item 'Files2'.", repo.Files2.SelfInfo, new RecordItemIndex(73));
            repo.Files2.Self.Move(ValueConverter.ArgumentFromString<int>("x", "1300"), ValueConverter.ArgumentFromString<int>("y", "200"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Files2.VistaElementos' at Center.", repo.Files2.VistaElementosInfo, new RecordItemIndex(74));
            repo.Files2.VistaElementos.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(75));
            Delay.Duration(3000, false);
            
            Snap(ScreenPath, "15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Files2.SystemItemNameDisplay' at CenterLeft.", repo.Files2.SystemItemNameDisplayInfo, new RecordItemIndex(77));
            repo.Files2.SystemItemNameDisplay.Click(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}'.", new RecordItemIndex(78));
            //Keyboard.Press("{LShiftKey down}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Files2.SystemItemNameDisplay2' at 60;14.", repo.Files2.SystemItemNameDisplay2Info, new RecordItemIndex(79));
            //repo.Files2.SystemItemNameDisplay2.Click("60;14");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey up}' with focus on 'Files2.ShellView.ListItem4'.", repo.Files2.ShellView.ListItem4Info, new RecordItemIndex(80));
            //repo.Files2.ShellView.ListItem4.PressKeys("{LShiftKey up}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(81));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(82));
            Delay.Duration(3000, false);
            
            Snap(ScreenPath, "16");
            Delay.Milliseconds(0);
            
            Snap(ScreenPath, "17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Files2.SystemItemNameDisplay' at CenterLeft.", repo.Files2.SystemItemNameDisplayInfo, new RecordItemIndex(85));
            repo.Files2.SystemItemNameDisplay.MoveTo(Location.CenterLeft);
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "28"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move at {X=900,Y=700}.", new RecordItemIndex(87));
            Mouse.MoveTo(900, 700);
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "30"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Snap(ScreenPath, "18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Copy_of_CUsersUserDocumentsRanorexRanorexS.Copy_of_HarulaDocuments' at Center.", repo.Copy_of_CUsersUserDocumentsRanorexRanorexS.Copy_of_HarulaDocumentsInfo, new RecordItemIndex(90));
            repo.Copy_of_CUsersUserDocumentsRanorexRanorexS.Copy_of_HarulaDocuments.MoveTo();
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Snap(ScreenPath, "19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.OneDriveMoraviaUpToDate' at Center.", repo.Explorer.OneDriveMoraviaUpToDateInfo, new RecordItemIndex(92));
            repo.Explorer.OneDriveMoraviaUpToDate.Click();
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "32"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(94));
            Delay.Duration(4000, false);
            
            Snap(ScreenPath, "20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'Explorer.OneDriveMoraviaUpToDate' at Center.", repo.Explorer.OneDriveMoraviaUpToDateInfo, new RecordItemIndex(96));
            repo.Explorer.OneDriveMoraviaUpToDate.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OneDrive.Settings' at Center.", repo.OneDrive.SettingsInfo, new RecordItemIndex(97));
            repo.OneDrive.Settings.Click();
            Delay.Milliseconds(200);
            
            Snap(ScreenPath, "21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MicrosoftOneDrive.Text8050' at Center.", repo.MicrosoftOneDrive.Text8050Info, new RecordItemIndex(99));
            repo.MicrosoftOneDrive.Text8050.Click();
            Delay.Milliseconds(200);
            
            Snap(ScreenPath, "09");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Copy_of_Cancel' at Center.", repo.Copy_of_CancelInfo, new RecordItemIndex(101));
            repo.Copy_of_Cancel.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MicrosoftOneDrive.Settings' at Center.", repo.MicrosoftOneDrive.SettingsInfo, new RecordItemIndex(102));
            repo.MicrosoftOneDrive.Settings.Click();
            Delay.Milliseconds(200);
            
            Logger(Loggerpath, ValueConverter.ArgumentFromString<int>("row", "38"), LANGUAGE);
            Delay.Milliseconds(0);
            
            Snap(ScreenPath, "22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking EnsureVisible() on item 'HarulaDocumentsAllDocuments'.", repo.HarulaDocumentsAllDocuments.SelfInfo, new RecordItemIndex(105));
            repo.HarulaDocumentsAllDocuments.Self.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+R' Press.", new RecordItemIndex(106));
            Keyboard.Press(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control, 19, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(107));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.OdOverlayHostContent.SomeITag' at 16;24.", repo.HarulaDocumentsAllDocuments.OdOverlayHostContent.SomeITagInfo, new RecordItemIndex(108));
            repo.HarulaDocumentsAllDocuments.OdOverlayHostContent.SomeITag.Click("16;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(109));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.OdOverlayHostContent.Delete' at Center.", repo.HarulaDocumentsAllDocuments.OdOverlayHostContent.DeleteInfo, new RecordItemIndex(110));
            repo.HarulaDocumentsAllDocuments.OdOverlayHostContent.Delete.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HarulaDocumentsAllDocuments.Delete1' at Center.", repo.HarulaDocumentsAllDocuments.Delete1Info, new RecordItemIndex(111));
            repo.HarulaDocumentsAllDocuments.Delete1.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
