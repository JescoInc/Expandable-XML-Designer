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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ScalableXMLDesigner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string loadFile = @"Data/newDictionary.xml";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void reloadXml_Click(object sender, RoutedEventArgs e)
        {      
            loadRichTextBox();
        }

        private void loadRichTextBox()
        {
            richTextBox.Selection.Load(new FileStream(loadFile, FileMode.Open), DataFormats.Text); 
        }
    }
}
