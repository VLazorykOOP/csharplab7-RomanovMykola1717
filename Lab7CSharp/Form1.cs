using System;
using System.Windows.Forms;

namespace TextBoxDuplication
{
    public partial class MainForm : Form    
    {
        private TextBox textBox;
        private Button duplicateButton;
        private Button exitButton;

        public MainForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Створення компонента TextBox
            textBox = new TextBox();
            textBox.Dock = DockStyle.Fill;

            // Створення кнопки "Дублювати"
            duplicateButton = new Button();
            duplicateButton.Text = "Дублювати";
            duplicateButton.Dock = DockStyle.Bottom;
            duplicateButton.Click += duplicateButton_Click;

            // Створення кнопки "Вихід"
            exitButton = new Button();
            exitButton.Text = "Вихід";
            exitButton.Dock = DockStyle.Bottom;
            exitButton.Click += exitButton_Click;

            // Додавання компонентів на форму
            Controls.Add(textBox);
            Controls.Add(duplicateButton);
            Controls.Add(exitButton);
        }

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            // Обробник події для кнопки "Дублювати"
            // Тут додається логіка для створення нового вікна
            // з аналогічним текстом TextBox.
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Обробник події для кнопки "Вихід"
            // Тут додається логіка для виходу з програми.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
