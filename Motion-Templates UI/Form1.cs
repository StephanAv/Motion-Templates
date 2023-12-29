using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.Setup.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using TCatSysManagerLib;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Motion_Templates_UI
{
    public partial class Form1 : Form
    {
        string _home = "";
        const string _sDTE = "TcXaeShell.DTE.15.0"; // TcXaeShell
        //Visual Studio Instance
        EnvDTE.DTE _dte;
        //Solution Instance
        EnvDTE.Solution _solution;
        //Project Instance
        EnvDTE.Project _project;
        // Scope Project
        EnvDTE.Project _scopeProject;
        //SystemManager Object
        ITcSysManager10 _systemManager;
        // PLC Object
        ITcSmTreeItem _plc;
        //Results of the Broadcast Search

        public Form1()
        {
            InitializeComponent();
            _home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            folder_box.Text = _home + @"\Documents\TcXaeShell";

            template_box.BeginUpdate();
            // Loop through and add 50 items to the ListBox.

            template_box.Items.Add("MC2 Base");
            template_box.Items.Add("MC2 PTP");
            template_box.Items.Add("MC2 Homing");

            // Allow the ListBox to repaint and display the new items.
            template_box.EndUpdate();

            template_box.SelectedIndex = 0;
        }

        private void selected_template_changed(object sender, EventArgs e)
        {
            tc_name_box.Text = template_box.SelectedItem.ToString();
            plc_name_box.Text = template_box.SelectedItem.ToString();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            //Get Visual Studio Version from registry
            Type t = System.Type.GetTypeFromProgID(_sDTE);
            _dte = (EnvDTE.DTE)System.Activator.CreateInstance(t);
            _dte.SuppressUI = false;
            _dte.MainWindow.Visible = true;

            string sln_path = folder_box.Text + "\\" + tc_name_box.Text;

            if (Directory.Exists(sln_path))
                Directory.Delete(sln_path, true);
            Directory.CreateDirectory(sln_path);
            Directory.CreateDirectory(sln_path + "\\" + tc_name_box.Text);
            dynamic solution = _dte.Solution;
            solution.Create(sln_path, tc_name_box.Text);
            solution.SaveAs(sln_path + "\\" + tc_name_box.Text + ".sln");
            ////Create new solution from template
            string tc_template = @"C:\TwinCAT\3.1\Components\Base\PrjTemplate\TwinCAT Project.tsproj";
            _solution = _dte.Solution;
            _project = _solution.AddFromTemplate(tc_template, sln_path + "\\" + tc_name_box.Text, tc_name_box.Text);

            //// Add PLC Project
            Thread.Sleep(2000);
            _systemManager = _project.Object;
            _plc = _systemManager.LookupTreeItem("TIPC");
            string plc_template = template_box.SelectedItem.ToString();
            string plc_name_box_Text = plc_name_box.Text;
            string plc_template_path = @"C:\Users\StephanA\source\repos\Motion-Templates\Templates\"
                                       + plc_template
                                       + "\\"
                                       + plc_template
                                       + "\\"
                                       + plc_template
                                       + "\\"
                                       + plc_template
                                       + ".plcproj";
            _plc.CreateChild(plc_name_box.Text, 0, null, plc_template_path);


            // Add axis to GVL
            string gvl_tree_item = "TIPC^" + plc_name_box.Text + "^" + plc_name_box.Text + " Projekt^GVLs^GVL";
            ITcSmTreeItem gvl = _systemManager.LookupTreeItem(gvl_tree_item);

            ITcPlcDeclaration gvl_dec = (ITcPlcDeclaration)gvl;
            string decl = gvl_dec.DeclarationText;
            int i = decl.IndexOf("END_VAR");
            decl = decl.Insert(i, "\taxis_b : AXIS_REF;\n");
            gvl_dec.DeclarationText = decl;

            // Add axis to MAIN
            string main_tree_item = "TIPC^" + plc_name_box.Text + "^" + plc_name_box.Text + " Projekt^POUs^MAIN";
            ITcSmTreeItem main = _systemManager.LookupTreeItem(main_tree_item);


            ITcPlcDeclaration main_dec = (ITcPlcDeclaration)main;
            string s_main_decl = main_dec.DeclarationText;
            i = s_main_decl.IndexOf("END_VAR");
            string new_axis = "\taxis_a : FB_AxisBase := (\tbStart\t \t\t:= TRUE,\n\t\t\t\t\t\t\t\tbPowerEnable \t:= TRUE,\n\t\t\t\t\t\t\t\tbPosEnable \t\t:= TRUE,\n\t\t\t\t\t\t\t\tbNegEnable \t\t:= TRUE,\n\t\t\t\t\t\t\t\tfOverride \t\t:= 100.0);\n";
            s_main_decl = s_main_decl.Insert(i, new_axis);
            main_dec.DeclarationText = s_main_decl;

            int x = 3;

        }

        private void select_folder_btn_Click(object sender, EventArgs e)
        {
            var directoryDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select Folder"
            };
            CommonFileDialogResult result = directoryDialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                folder_box.Text = directoryDialog.FileName;
            }
        }
    }
}
