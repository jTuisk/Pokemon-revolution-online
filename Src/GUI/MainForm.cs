using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_revolution_online_bot.Src.GUI
{
    public partial class MainForm : Form
    {

        private Form currentFormView;

        private HomeForm homeForm;
        private PresetForm presetForm;
        private BotSettingsForm botSettingsForm;
        private SettingsForm settingsForm;

        public MainForm()
        {
            InitializeComponent();
            InitializeAppForms();
            UpdateMainPanelTo(homeForm);
        }

        private void InitializeAppForms()
        {
            homeForm = new HomeForm();
            presetForm = new PresetForm();
            botSettingsForm = new BotSettingsForm();
            settingsForm = new SettingsForm();
        }

        private void UpdateMainPanelTo(Form toForm)
        {
            if (toForm != null)
            {
                toForm.TopLevel = false;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(toForm);
                mainPanel.Tag = toForm;
                toForm.BringToFront();
                toForm.Show();
                currentFormView = toForm;
                Console.WriteLine($"MainForm::UpdateMainPanelTo: {toForm.Name} form loaded to main panel!");
            }
            else
                throw new NullReferenceException();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            UpdateMainPanelTo(homeForm);
        }

        private void PresetButton_Click(object sender, EventArgs e)
        {
            UpdateMainPanelTo(presetForm);
        }

        private void BotSettingsButton_Click(object sender, EventArgs e)
        {
            UpdateMainPanelTo(botSettingsForm);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UpdateMainPanelTo(settingsForm);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Quit button was pressed!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
