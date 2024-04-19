using tu_dien.all_class;

namespace tu_dien
{
    public partial class Form1 : Form
    {
        Dictionary_Manager dic;
        Speak_Test speak_viet;
        Speak_Test speak_eng;
        public Form1()
        {

            InitializeComponent();

            cb_word.DisplayMember = "Key";
            dic = new Dictionary_Manager();
            dic.load_data_to_combobox(cb_word);

            WebBrowser wb_vn = new WebBrowser();
            wb_vn.Width = 0; wb_vn.Height = 0;
            wb_vn.Visible = false;
            wb_vn.Navigate(Const.EnglishLink);
            this.Controls.Add(wb_vn);

            WebBrowser wb_eng = new WebBrowser();
            wb_eng.Width = 0; wb_eng.Height = 0;
            wb_eng.Visible = false;
            wb_eng.Navigate(Const.VietNamLink);
            this.Controls.Add(wb_eng);

            speak_viet = new Speak_Test(wb_vn);
            speak_eng = new Speak_Test(wb_eng);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co muon dong form khong?", "thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }

            dic.serialize();
        }

        private void cb_word_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = sender as ComboBox;


            try
            {
                DictionaryData data = cb.SelectedItem as DictionaryData;
                tb_mean.Text = data.Meaning;
                tb_explain.Text = data.Explaination;
            }
            catch
            {
                MessageBox.Show("khong co data");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            speak_eng.speak((cb_word.SelectedItem as DictionaryData).Key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            speak_viet.speak((cb_word.SelectedItem as DictionaryData).Meaning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speak_viet.speak((cb_word.SelectedItem as DictionaryData).Explaination);

        }
    }
}
