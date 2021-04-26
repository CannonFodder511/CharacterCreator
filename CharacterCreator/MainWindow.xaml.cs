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

namespace CharacterCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void NewCharacter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadCharacter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadDatapack_Click(object sender, RoutedEventArgs e)
        {
            Datapack d = new Datapack(Common.LoadFile());

            (App.Current as App).datapacks.Add(d);
        }
    }
}
