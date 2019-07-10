using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CodeSamples.Common
{
    public class ControlWriter : TextWriter
    {
        private RichTextBox textbox;
        public ControlWriter(RichTextBox textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            textbox.Text += value;
        }

        public override void WriteLine(string line)
        {
            textbox.Text += line + "\r\n";
            textbox.Refresh();
            Application.DoEvents();
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
