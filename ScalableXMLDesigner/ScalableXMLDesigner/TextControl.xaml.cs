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

namespace ScalableXMLDesigner
{
    public partial class TextControl : UserControl
    {
        public TextControl()
        {
            InitializeComponent();
        }

        private void japaneseWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            japaneseWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            japanese.Visibility = System.Windows.Visibility.Visible;
            japanese.Focus();
        }

        private void japanese_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.japanese.Text))
            {
                japanese.Visibility = System.Windows.Visibility.Collapsed;
                japaneseWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void romajiWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            romajiWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            romaji.Visibility = System.Windows.Visibility.Visible;
            romaji.Focus();
        }

        private void romaji_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.romaji.Text))
            {
                romaji.Visibility = System.Windows.Visibility.Collapsed;
                romajiWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void englishWatermarked_GotFocus(object sender, RoutedEventArgs e)
        {
            englishWatermarked.Visibility = System.Windows.Visibility.Collapsed;
            english.Visibility = System.Windows.Visibility.Visible;
            english.Focus();
        }

        private void english_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.english.Text))
            {
                english.Visibility = System.Windows.Visibility.Collapsed;
                englishWatermarked.Visibility = System.Windows.Visibility.Visible;
            }
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
    }
}
