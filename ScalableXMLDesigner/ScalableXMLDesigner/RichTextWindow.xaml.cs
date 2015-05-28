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
        public bool confirmClose { get; set; }
        string filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
        string Path = @"/Data/newDictionary.xml";
        public RichTextWindow()
        {
            InitializeComponent();
            loadRTFFile();
            confirmClose = false;
        }

        private void loadRTFFile()
        {
            if (File.Exists(filePath + Path))
            {
                var fileStream = new FileStream(filePath + Path, FileMode.Open);

                richText.Selection.Load(fileStream, DataFormats.Text);
                fileStream.Close();
            }
        }

        public void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.confirmClose = true;
            this.Close();
        }
    }
}
