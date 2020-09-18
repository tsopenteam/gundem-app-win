using gundem_app_win.Models;
using gundem_app_win.Services.Podcast;
using gundem_app_win.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gundem_app_win
{
    public partial class formMain : Form
    {
        IPodcastService _podcastService;
        List<PodcastModel> _podcasts;

        public formMain()
        {
            InitializeComponent();

            _podcastService = new PodcastService();
            _podcasts = new List<PodcastModel>();

            lblVersion.Text = VersionTools.GetVersion();
        }

        public void WriteLog(string message)
        {
            lblLog.Text = message;
        }

        public void DisplayChangeAllComponent(bool state)
        {
            listBoxPodcast.Enabled = state;
            btnUpdateList.Enabled = state;
            btnRandomPodcast.Enabled = state;
        }

        public void UpdatePodcastList()
        {
            try
            {
                DisplayChangeAllComponent(false);
                WriteLog("podcast listesi alınıyor.");

                _podcasts = _podcastService.GetPodcasts();
                _podcasts.Reverse();

                listBoxPodcast.Items.Clear();
                foreach (var item in _podcasts)
                {
                    listBoxPodcast.Items.Add(item.TitlePodcast);
                }

                WriteLog("");
                lblPodcastCount.Text = $"Podcast Sayısı: {_podcasts.Count.ToString()}";
            }
            catch (Exception exp)
            {
                WriteLog(exp.Message);
            }
            finally
            {
                DisplayChangeAllComponent(true);
            }
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            UpdatePodcastList();
        }

        private void listBoxPodcast_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PodcastModel podcastModel = _podcasts[listBoxPodcast.SelectedIndex];

            mediaPlayerPodcast.URL = podcastModel.PodcastLink;
            lblCurrentPodcast.Text = podcastModel.TitlePodcast;
        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/tsopenteam");
        }

        private void linkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://tsopenteam.github.io");
        }

        private void btnRandomPodcast_Click(object sender, EventArgs e)
        {
            if (_podcasts.Count < 1)
            {
                WriteLog("podcast listesi boş !");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(0, _podcasts.Count);

            PodcastModel podcastModel = _podcasts[randomIndex];

            mediaPlayerPodcast.URL = podcastModel.PodcastLink;
            lblCurrentPodcast.Text = podcastModel.TitlePodcast;
        }
    }
}