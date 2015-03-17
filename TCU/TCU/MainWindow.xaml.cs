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
using TCU;

namespace TCU
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          InitializeComponent();

          List<Key> TCUKeyboard = new List<Key>();
          
          TCUKeyboard.Add(new Key("key01"));
          TCUKeyboard.Add(new Key("key02"));
          TCUKeyboard.Add(new Key("key03"));
          TCUKeyboard.Add(new Key("key04"));
          TCUKeyboard.Add(new Key("key05"));
          TCUKeyboard.Add(new Key("key06"));
          TCUKeyboard.Add(new Key("key07"));
          TCUKeyboard.Add(new Key("key08"));
          TCUKeyboard.Add(new Key("key09"));
          TCUKeyboard.Add(new Key("key10"));
          TCUKeyboard.Add(new Key("key11"));
          TCUKeyboard.Add(new Key("key12"));
          TCUKeyboard.Add(new Key("key13"));
          TCUKeyboard.Add(new Key("key14"));
          TCUKeyboard.Add(new Key("key15"));

          this.DataContext = TCUKeyboard;
        }

        private void Key_MouseDown(object sender, MouseButtonEventArgs e)
        {
          Control label = ((Control)sender);
          if (label.Background == Brushes.Bisque)
          {
            label.Background = Brushes.DarkGray;
          }
          else
          {
            label.Background = Brushes.Bisque;
          }
          keyName.Text = label.Name;
        }

    }
}
