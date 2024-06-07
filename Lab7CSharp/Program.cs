using System;
using System.Windows.Forms;

namespace TextBoxDuplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            // Створення нового вікна
            Form newForm = new Form();
            newForm.Text = "Дубль";

            // Створення нового компонента TextBox
            TextBox newTextBox = new TextBox();
            newTextBox.Text = textBox.Text;
            newTextBox.Dock = DockStyle.Fill;

            // Додавання нового TextBox на нове вікно
            newForm.Controls.Add(newTextBox);

            // Показ нового вікна
            newForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Закриття поточного вікна або виход з програми, якщо вікно останнє
            if (Application.OpenForms.Count == 1)
                Application.Exit();
            else
                this.Close();
        }
    }
}
