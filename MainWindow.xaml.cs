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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            BoardGameMaster.BoardGameMasterDataSet boardGameMasterDataSet = ((BoardGameMaster.BoardGameMasterDataSet)(this.FindResource("boardGameMasterDataSet")));
            // Load data into the table boardgame. You can modify this code as needed.
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.boardgameTableAdapter boardGameMasterDataSetboardgameTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.boardgameTableAdapter();
            boardGameMasterDataSetboardgameTableAdapter.Fill(boardGameMasterDataSet.boardgame);
            System.Windows.Data.CollectionViewSource boardgameViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("boardgameViewSource")));
            boardgameViewSource.View.MoveCurrentToFirst();
            // Load data into the table game_player_score. You can modify this code as needed.
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.game_player_scoreTableAdapter boardGameMasterDataSetgame_player_scoreTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.game_player_scoreTableAdapter();
            boardGameMasterDataSetgame_player_scoreTableAdapter.Fill(boardGameMasterDataSet.game_player_score);
            System.Windows.Data.CollectionViewSource game_player_scoreViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("game_player_scoreViewSource")));
            game_player_scoreViewSource.View.MoveCurrentToFirst();
            // Load data into the table category. You can modify this code as needed.
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.categoryTableAdapter boardGameMasterDataSetcategoryTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.categoryTableAdapter();
            boardGameMasterDataSetcategoryTableAdapter.Fill(boardGameMasterDataSet.category);
            System.Windows.Data.CollectionViewSource categoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoryViewSource")));
            categoryViewSource.View.MoveCurrentToFirst();
            // Load data into the table subcategory. You can modify this code as needed.
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.subcategoryTableAdapter boardGameMasterDataSetsubcategoryTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.subcategoryTableAdapter();
            boardGameMasterDataSetsubcategoryTableAdapter.Fill(boardGameMasterDataSet.subcategory);
            System.Windows.Data.CollectionViewSource subcategoryViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("subcategoryViewSource")));
            subcategoryViewSource.View.MoveCurrentToFirst();
            // Load data into the table score. You can modify this code as needed.
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.scoreTableAdapter boardGameMasterDataSetscoreTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.scoreTableAdapter();
            boardGameMasterDataSetscoreTableAdapter.Fill(boardGameMasterDataSet.score);
            System.Windows.Data.CollectionViewSource scoreViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("scoreViewSource")));
            scoreViewSource.View.MoveCurrentToFirst();
        }

        private void btnSavePlayer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSaveCat_Click(object sender, RoutedEventArgs e)
        {
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.categoryTableAdapter boardGameMasterDataSetcategoryTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.categoryTableAdapter();
            boardGameMasterDataSetcategoryTableAdapter.Insert(txtNameCategory.Text, txtDescriptionCat.Text);
            MessageBox.Show("Category saved");
        }

        private void btnSaveSubCat_Click(object sender, RoutedEventArgs e)
        {
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.subcategoryTableAdapter boardGameMasterDataSetsubcategoryTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.subcategoryTableAdapter();
            boardGameMasterDataSetsubcategoryTableAdapter.Insert(txtNameSubCat.Text, txtDescriptionSubCat.Text);
            MessageBox.Show("SubCategory saved");
        }

        private void btnSaveScoreType_Click(object sender, RoutedEventArgs e)
        {
            BoardGameMaster.BoardGameMasterDataSetTableAdapters.scoreTableAdapter boardGameMasterDataSetscoreTableAdapter = new BoardGameMaster.BoardGameMasterDataSetTableAdapters.scoreTableAdapter();
            boardGameMasterDataSetscoreTableAdapter.Insert(txtNameScore.Text, int.Parse(txtTypeScore.Text));
            MessageBox.Show("Score saved");
        }
    }
}
