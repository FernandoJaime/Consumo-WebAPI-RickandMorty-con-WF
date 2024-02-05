using RickandMorty.Controllers;
using RickandMorty.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RickandMorty.Views
{
    public partial class InfoCharacter : Form
    {
        private EpisodeController episodeController;
        private LocationController locationController;
        private Character instance;
        public InfoCharacter(Character character)
        {
            InitializeComponent();
            instance = character;
            episodeController = new EpisodeController();
            locationController = new LocationController();
        }

        private void InfoCharacter_Load(object sender, EventArgs e)
        {
            DGVepisodes.Hide();
            PanelLocation.Visible = false;

            lblNombre.Text = instance.name;
            pictureCharacter.ImageLocation = instance.image;
            lblStatus.Text = "Status: " + instance.status;
            lblSpecie.Text = "Specie: " + instance.species;
            lblGender.Text = "Gender: " + instance.gender;
            lblCreated.Text = "Created: " + instance.created;
        }

        private async void btnLocation_Click(object sender, EventArgs e)
        {
            PanelLocation.Visible = true;
            var locacion = await locationController.GetForCharacter(instance);
            lblNamePanel.Text = "Name: " + locacion.name;
            lblTypePanel.Text = "Type: " + locacion.type;
            lblDimensionPanel.Text = "Dimension: " + locacion.dimension;
        }

        private async void btnEpisode_Click(object sender, EventArgs e)
        {
            DGVepisodes.Show();
            DGVepisodes.AutoGenerateColumns = false;
            List<Episode> episodios = new List<Episode>();
            for (int i = 0; i < instance.episode.Length; i++)
            {
                var Episodio = await episodeController.GetForCharacter(instance.episode[i]);
                episodios.Add(Episodio);
            }
            DGVepisodes.DataSource = null;
            DGVepisodes.DataSource = episodios;
            DGVepisodes.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
