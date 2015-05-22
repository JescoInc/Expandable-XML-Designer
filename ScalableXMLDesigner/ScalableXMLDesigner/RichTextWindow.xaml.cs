using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ScalableXMLDesigner
{
    /// <summary>
    /// Interaction logic for RichTextWindow.xaml
    /// </summary>
    public partial class RichTextWindow : Window
    {
        private const string loadFile = @"Data/newDictionary.xml";
        public RichTextWindow()
        {
            InitializeComponent();
            loadRTFFile();
        }

        private void loadRTFFile()
        {
            richText.Selection.Load(new FileStream(loadFile, FileMode.Open), DataFormats.Text);
        }
    }
}
