using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tu_dien.all_class
{
    internal class Speak_Test
    {
        private WebBrowser browser;

        public Speak_Test(WebBrowser browser)
        {
            this.browser = browser;
        }

        public WebBrowser Browser { get => browser; set => browser = value; }

        public void speak_text(WebBrowser wb)
        {
            this.browser = wb;
        }

        private void set_text(string text)
        {
            HtmlElement element = browser.Document.GetElementById("text");
            element.SetAttribute("value", text);
        }

        private void play_button()
        {
            HtmlElement element = browser.Document.GetElementById("playbutton");
            element.InvokeMember("click");
        }

        public void speak(string text) 
        {
            set_text(text);
            play_button();
        }

    }
}
