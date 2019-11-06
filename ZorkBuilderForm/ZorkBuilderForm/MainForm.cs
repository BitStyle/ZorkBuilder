using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZorkBuilder.Data;
using ZorkBuilderForm.WinForms.ViewModels;

namespace ZorkBuilderForm.WinForms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
        private WorldViewModel mViewModel;
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }
        private bool mIsGameLoaded;
        private bool IsGameLoaded
        {
            get => mIsGameLoaded;
            set
            {
                mIsGameLoaded = value;
                //mainTabControl.Enabled = mIsGameLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsGameLoaded = false;
        }

        private void openWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Game = game;
                ViewModel.Filename = openFileDialog.FileName;
                IsGameLoaded = true;
            }
        }
    }
}
