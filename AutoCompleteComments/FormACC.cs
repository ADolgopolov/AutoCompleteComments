namespace AutoCompleteComments
{
    public partial class FormACC : Form
    {
        public FormACC()
        {
            InitializeComponent();
        }

        private void button_CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_Comment.Text);
            checkBox_box.Checked = false;
            checkBox_hook.Checked = false;
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Comment.Text = string.Empty;
        }

        private void checkBoxAllwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxAllwaysTop.Checked;
        }

        private void button_JU_Click(object sender, EventArgs e)
        {
            textBox_Comment.Text += button_JU.Text;
            if (checkBox_hook.Checked)
            {
                textBox_Comment.Text += checkBox_hook.Text;
            }
            if (checkBox_box.Checked)
            {
                textBox_Comment.Text += checkBox_box.Text;
            }
        }

        private void button_add_its_text_and_send_focus_to_editor_Click(object sender, EventArgs e)
        {
            this.textBox_Comment.Text += ((Button)sender).Text;
            textBox_Comment.Focus();
            textBox_Comment.AppendText(" ");
        }

        private void button_simply_add_its_text_Click(object sender, EventArgs e)
        {
            this.textBox_Comment.Text += ((Button)sender).Text;
        }
    }
}