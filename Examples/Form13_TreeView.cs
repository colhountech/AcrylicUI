using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Form13_TreeView : AcrylicForm
    {
        public Form13_TreeView()
        {
            InitializeComponent();
            // Make sure you set this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // Program.cs : Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            this.Text = "";
            this.IsAcrylic = true;
            this.BlurColor = Colors.GreyBackground;
            this.AutoScaleMode = AutoScaleMode.Dpi;

            BuildTreeView();
        }
        public async void BuildTreeView()
        {
            // Create TreeView


            acrylicTreeView1.Indent = 12;
            acrylicTreeView1.ItemHeight = 22;
            acrylicTreeView1.ShowIcons = false;

            BuildTeamView();

            BuildProjectView();

            BuildJobView();

        }

        private void BuildJobView()
        {
            AcrylicTreeNode jobs = new AcrylicTreeNode("Jobs");


            AcrylicTreeNode job1 = new AcrylicTreeNode("Job 1");
            jobs.Nodes.Add(job1);

            AcrylicTreeNode job2 = new AcrylicTreeNode("Job 2");
            jobs.Nodes.Add(job2);

            AcrylicTreeNode job3 = new AcrylicTreeNode("Job 3");
            jobs.Nodes.Add(job3);

            acrylicTreeView1.Nodes.Add(jobs);
        }

        private void BuildProjectView()
        {
            AcrylicTreeNode projects = new AcrylicTreeNode("Projects");
            acrylicTreeView1.Nodes.Add(projects);
        }

        private void BuildTeamView()
        {
            AcrylicTreeNode team = new AcrylicTreeNode("Team");

            AcrylicTreeNode player1 = new AcrylicTreeNode("Player 1");
            team.Nodes.Add(player1);

            AcrylicTreeNode player2 = new AcrylicTreeNode("Player 2");
            team.Nodes.Add(player2);

            AcrylicTreeNode player3 = new AcrylicTreeNode("Player 3");
            team.Nodes.Add(player3);

            acrylicTreeView1.Nodes.Add(team);
        }
    }
    
}
