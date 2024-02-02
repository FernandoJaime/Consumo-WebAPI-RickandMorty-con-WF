using RickandMorty.Controllers;
using RickandMorty.Models;

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
            }
        }

        // Metodo verificacion de campos vacios.
        private bool CheckCampos()
        {
            if (string.IsNullOrEmpty(txtName.Text))
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
            return true;
        }

        // Metodo Load de la pagina.
        private async void PagesCharacters_Load(object sender, EventArgs e)
        {
            CheckTodos.Checked = true;
            ComboStatus.Enabled = false;
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
                    if (ComboStatus.Enabled == true)
                    {
                        instance = await controller.GetForNameAndStatus(txtName.Text, ComboStatus.Text);
                        if (instance.results != null)
                        {
                            LoadImages(instance.results);
                        }
                    }
                    else if (CheckTodos.Checked == true)
                    {
                        instance = await controller.GetForName(txtName.Text);
                        if (instance.results != null)
                        {
                            LoadImages(instance.results);
                        }
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
            ComboStatus.SelectedIndex = -1;
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
        private void CheckTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTodos.Checked)
            {
                ComboStatus.Enabled = false;
                ComboStatus.SelectedIndex = -1;
            }
            else
            {
                ComboStatus.Enabled = true;
            }
        }
    }
}
