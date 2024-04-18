using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tu_dien.all_class
{
    internal class Dictionary_Manager
    {
        
        private DictionaryItem items;
        private string file_path = "data.xml";

        public Dictionary_Manager()
        {
            items = (DictionaryItem) deserialize_from_xml(file_path);
        }

        internal DictionaryItem Items { get => items; set => items = value; }

        public void load_data_to_combobox(ComboBox comboBox)
        {
            comboBox.DataSource = items.Items;
        }

        public void serialize()
        {
            serialize_to_xml(items, file_path);
        }

        public void serialize_to_xml(object obj, string file_path)
        {
            FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            sr.Serialize(fs, obj);
            fs.Close();
        }

        public object deserialize_from_xml(string file_path)
        {
            FileStream fs = new FileStream(file_path,FileMode.OpenOrCreate,FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            Object obj = sr.Deserialize(fs);
            fs.Close();
            return obj;
        }


    }
}
