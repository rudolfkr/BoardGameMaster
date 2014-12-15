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

namespace BoardGameMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txt1.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            BoardGameMaster.BoardGameMasterDataSet boardGameMasterDataSet = ((BoardGameMaster.BoardGameMasterDataSet)(this.FindResource("boardGameMasterDataSet")));
            // Load data into the table boardgame. You can modify this code as needed.
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.boardgameTableAdapter boardGameMasterDataSetboardgameTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.boardgameTableAdapter();
            boardGameMasterDataSetboardgameTableAdapter.Fill(boardGameMasterDataSet.boardgame);
            System.Windows.Data.CollectionViewSource boardgameViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("boardgameViewSource")));
            boardgameViewSource.View.MoveCurrentToFirst();
        }

        private void tbPlayerStats_GotFocus(object sender, RoutedEventArgs e)
        {
            txt2.Focus();
        }

        private void tbStatistics_GotFocus(object sender, RoutedEventArgs e)
        {
            txt1.Focus();
        }

 
    }
}
