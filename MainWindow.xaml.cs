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

namespace MontyHole
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameMain gameMain;
        public MainWindow()
        {
            InitializeComponent();
            gameMain = new GameMain(this);
        }


        private void Image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gameMain.Player.SelectionNumber = 1;
            SelectionLabel.Content = $"選択中のドアは{gameMain.Player.SelectionNumber}番です。";
            gameMain.Player.openDoor();

        }

        private void Image2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gameMain.Player.SelectionNumber = 2;
            SelectionLabel.Content = $"選択中のドアは{gameMain.Player.SelectionNumber}番です。";
            gameMain.Player.openDoor();
        }

        private void Image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gameMain.Player.SelectionNumber = 3;
            SelectionLabel.Content = $"選択中のドアは{gameMain.Player.SelectionNumber}番です。";
            gameMain.Player.openDoor();
        }

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageLabel.Content = "司会者の番";//テスト用コード。後で消す。
            switch (gameMain.Stage) {
                case 2:gameMain.ChairPersonTurn();
                    break;
            }
        }
        
    }
}

