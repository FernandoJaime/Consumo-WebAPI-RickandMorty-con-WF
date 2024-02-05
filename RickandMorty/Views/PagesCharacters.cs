using RickandMorty.Controllers;
using RickandMorty.Models;
using RickandMorty.Views;

namespace RickandMorty
{
    public partial class PagesCharacters : Form
    {
        private CharacterController controller;
        private Characters instance;

        public PagesCharacters()
        {
            InitializeComponent();
            controller = new CharacterController();
            instance = new Characters();
        }

        // Metodo que abre la informacion del personaje.
        private void OpenInfoCharacter(Character character)
        {
            InfoCharacter infoCharacter = new InfoCharacter(character);
            infoCharacter.ShowDialog();
        }

        // Metodo que carga las imagenes de los personajes atraves de su lista.
        private void LoadImages(List<Character> characters)
        {
            // Limpio los controles existentes en el contenedor.
            PanelDeImages.Controls.Clear();

            foreach (Character character in characters)
            {
                PictureBox pictureBox = new PictureBox(); // Creo un nuevo objeto de tipo PictureBox por cada personaje.
                pictureBox.Load(character.image); // Cargo la imagen del personaje.
                pictureBox.Size = new Size(201, 130);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                PanelDeImages.Controls.Add(pictureBox); // Agrego el PictureBox al contenedor.

                pictureBox.Click += (sender, e) => OpenInfoCharacter(character); // Agrego un evento click al PictureBox.
            }
        }

        // Metodo verificacion de campos vacios.
        private bool CheckCampos()
        {
            if (txtName.Enabled == true && string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("El campo del nombre no puede estar vacio si quiere aplicar el filtro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Text = "";
                txtName.Focus();
                return false;
            }
            if (ComboStatus.Enabled == true && string.IsNullOrEmpty(ComboStatus.Text))
            {
                MessageBox.Show("El campo del status no puede estar vacio si quiere aplicar el filtro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ComboStatus.Focus();
                return false;
            }
            if (ComboGender.Enabled == true && string.IsNullOrEmpty(ComboGender.Text))
            {
                MessageBox.Show("El campo del gender no puede estar vacio si quiere aplicar el filtro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ComboGender.Focus();
                return false;
            }
            return true;
        }

        // Metodo Load de la pagina.
        private async void PagesCharacters_Load(object sender, EventArgs e)
        {
            instance = await controller.GetAll();
            LoadImages(instance.results);
        }

        // Metodo Aplicar filtros.
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCampos())
                {
                    instance = await controller.GetForAllFilters(txtName.Text, ComboStatus.Text, ComboGender.Text);
                    if (instance.results != null)
                    {
                        LoadImages(instance.results);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = "";
            }
        }

        // Metodo Quitar filtros.
        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Enabled = false;
            CheckName.Checked = false;
            ComboStatus.SelectedIndex = -1;
            ComboStatus.Enabled = false;
            CheckStatus.Checked = false;
            ComboGender.SelectedIndex = -1;
            ComboGender.Enabled = false;
            CheckGender.Checked = false;
            PagesCharacters_Load(sender, e);
        }

        // Metodo Back page.
        private async void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                instance = await controller.GetPrevPage(instance);
                if (instance.results != null)
                {
                    LoadImages(instance.results);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Metodo Next page.
        private async void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                instance = await controller.GetNextPage(instance);
                if (instance.results != null)
                {
                    LoadImages(instance.results);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Metodo para manejar el filtro de status.

        private void CheckName_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckName.Checked)
            {
                txtName.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
                txtName.Text = "";
            }
        }

        private void CheckStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStatus.Checked)
            {
                ComboStatus.Enabled = true;
            }
            else
            {
                ComboStatus.Enabled = false;
                ComboStatus.SelectedIndex = -1;
            }
        }

        private void CheckGender_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckGender.Checked)
            {
                ComboGender.Enabled = true;
            }
            else
            {
                ComboGender.Enabled = false;
                ComboGender.SelectedIndex = -1;
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}