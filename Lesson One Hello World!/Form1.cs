namespace Lesson_One_Hello_World_
{
    public partial class helloWorld : Form
    {
        public helloWorld()
        {
            InitializeComponent();
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Did you know that the colour blue has the unique ability to influence our emotions and mental stress?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Only two percent of the world's population have green eyes";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Did you know that red is the first colour that human babies can see?";
        }
    }
}
