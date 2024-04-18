using tu_dien.all_class;

namespace tu_dien
{
    public partial class Form1 : Form
    {
        Dictionary_Manager dic;
        public Form1()
        {

            InitializeComponent();

            cb_word.DisplayMember = "Key";
            dic = new Dictionary_Manager();
            dic.load_data_to_combobox(cb_word);

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
    }
}
