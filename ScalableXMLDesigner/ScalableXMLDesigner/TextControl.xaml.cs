using System;
using System.Collections.Generic;
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
using System.Xml;

namespace ScalableXMLDesigner
{
    public partial class TextControl : UserControl
    {
        public TextControl()
        {
            InitializeComponent();
        }

        private void english_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.english.Text))
            {
                english.Visibility = System.Windows.Visibility.Collapsed;
                englishWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }
        private void englishWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            englishWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            english.Visibility = System.Windows.Visibility.Visible;
            english.Focus();
        }

        private void romaji_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.romaji.Text))
            {
                romaji.Visibility = System.Windows.Visibility.Collapsed;
                romajiWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void romajiWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            romajiWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            romaji.Visibility = System.Windows.Visibility.Visible;
            romaji.Focus();
        }

        private void japanese_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.japanese.Text))
            {
                japanese.Visibility = System.Windows.Visibility.Collapsed;
                japaneseWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }
        private void japaneseWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            japaneseWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            japanese.Visibility = System.Windows.Visibility.Visible;
            japanese.Focus();
        }
        private void romaja_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.romaja.Text))
            {
                romaja.Visibility = System.Windows.Visibility.Collapsed;
                romajaWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void romajaWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            romajaWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            romaja.Visibility = System.Windows.Visibility.Visible;
            romaja.Focus();
        }

        private void korean_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.korean.Text))
            {
                korean.Visibility = System.Windows.Visibility.Collapsed;
                koreanWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void koreanWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            koreanWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            korean.Visibility = System.Windows.Visibility.Visible;
            korean.Focus();
        }

        private void sChinese_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.sChinese.Text))
            {
                sChinese.Visibility = System.Windows.Visibility.Collapsed;
                sChineseWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void sChinese_GotFocus(object sender, RoutedEventArgs e)
        {
            sChineseWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            sChinese.Visibility = System.Windows.Visibility.Visible;
            sChinese.Focus();
        }

        private void tChineseWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            tChineseWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            tChinese.Visibility = System.Windows.Visibility.Visible;
            tChinese.Focus();
        }

        private void tChinese_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.tChinese.Text))
            {
                tChinese.Visibility = System.Windows.Visibility.Collapsed;
                tChineseWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void pinyin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.pinyin.Text))
            {
                pinyin.Visibility = System.Windows.Visibility.Collapsed;
                pinyinWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void pinyinWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            pinyinWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            pinyin.Visibility = System.Windows.Visibility.Visible;
            pinyin.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            var Main = MainWindow.GetWindow(this);
            Main.Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string Path = @"Data/newDictionary.xml";
            XmlDocument doc = new XmlDocument();

            if (!System.IO.File.Exists(Path))
            {
                // Node Creation
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlComment comment = doc.CreateComment("This is a generated XML File");
                XmlElement root = doc.CreateElement("WordList");
                XmlElement Word = doc.CreateElement("Word");
                XmlElement English = doc.CreateElement("English");
                XmlElement Romaji = doc.CreateElement("Romaji");
                XmlElement Romaja = doc.CreateElement("Romaja");
                XmlElement Korean = doc.CreateElement("Korean");
                XmlElement Japanese = doc.CreateElement("Japanese");
                XmlElement Pinyin = doc.CreateElement("Pinyin");
                XmlElement Simplified_Chinese = doc.CreateElement("Simplified_Chinese");
                XmlElement Traditional_Chinese = doc.CreateElement("Traditional_Chinese");

                //Values to the nodes
                English.InnerText = english.Text;
                Romaji.InnerText = romaji.Text;
                Japanese.InnerText = japanese.Text;
                Romaja.InnerText = romaja.Text;
                Korean.InnerText = korean.Text;
                Pinyin.InnerText = pinyin.Text;
                Simplified_Chinese.InnerText = sChinese.Text;
                Traditional_Chinese.InnerText = tChinese.Text;

                //Document Construction
                doc.AppendChild(declaration);
                doc.AppendChild(comment);
                doc.AppendChild(root);

                // Append root element to word element
                root.AppendChild(Word);

                //Append written values to word as child element
                Word.AppendChild(English);
                Word.AppendChild(Romaji);
                Word.AppendChild(Japanese);
                Word.AppendChild(Romaja);
                Word.AppendChild(Korean);
                Word.AppendChild(Pinyin);
                Word.AppendChild(Simplified_Chinese);
                Word.AppendChild(Traditional_Chinese);
                

                //Save document
                doc.Save(Path);
            }

            else
            {
                doc.Load(Path);

                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlComment comment = doc.CreateComment("This is a generated XML File");
                XmlElement root = doc.CreateElement("WordList");
                XmlElement Word = doc.CreateElement("Word");
                XmlElement English = doc.CreateElement("English");
                XmlElement Romaji = doc.CreateElement("Romaji");
                XmlElement Romaja = doc.CreateElement("Romaja");
                XmlElement Korean = doc.CreateElement("Korean");
                XmlElement Japanese = doc.CreateElement("Japanese");
                XmlElement Pinyin = doc.CreateElement("Pinyin");
                XmlElement Simplified_Chinese = doc.CreateElement("Simplified_Chinese");
                XmlElement Traditional_Chinese = doc.CreateElement("Traditional_Chinese");

                //Values to the nodes
                English.InnerText = english.Text;
                Romaji.InnerText = romaji.Text;
                Japanese.InnerText = japanese.Text;
                Romaja.InnerText = romaja.Text;
                Korean.InnerText = korean.Text;
                Pinyin.InnerText = pinyin.Text;
                Simplified_Chinese.InnerText = sChinese.Text;
                Traditional_Chinese.InnerText = tChinese.Text;

                // Append root element to word element
                root.AppendChild(Word);

                //Append written values to word as child element
                Word.AppendChild(English);
                Word.AppendChild(Romaji);
                Word.AppendChild(Japanese);
                Word.AppendChild(Romaja);
                Word.AppendChild(Korean);
                Word.AppendChild(Pinyin);
                Word.AppendChild(Simplified_Chinese);
                Word.AppendChild(Traditional_Chinese);
            }

            //Show confirmation message
            MessageBox.Show("Data has been added to the XML File");

            //Reset text fileds
            english.Text = string.Empty;
            romaji.Text = string.Empty;
            japanese.Text = string.Empty;
            romaja.Text = string.Empty;
            korean.Text = string.Empty;
            pinyin.Text = string.Empty;
            sChinese.Text = string.Empty;
            tChinese.Text = string.Empty;
        }
    }
}
