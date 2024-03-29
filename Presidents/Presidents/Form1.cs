namespace Presidents
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers = new Dictionary<string, Premier>();
        public Form1()
        {
            InitializeComponent();

            InitialiseGUI();
        }

        private void InitialiseGUI()
        {
            List<Premier> premier = new List<Premier>();
            premier = Premier.GetPremiers();
            foreach (var prem in premier)
            {
                premiers.Add(prem.GenerateKey(), prem);
            }

            List<string> keys = new List<string>(premiers.Keys);
            listBox1.DataSource = keys;

        }

        private void UpdateGUI(string key)
        {
            Premier cur_obj = premiers[key];
            label1.Text = cur_obj.Name;
            label2.Text = cur_obj.Life;
            label3.Text = cur_obj.Start + "-" + cur_obj.End;
            pictureBox1.ImageLocation = key + ".jpg";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI(listBox1.SelectedValue.ToString());
        }
    }
}
