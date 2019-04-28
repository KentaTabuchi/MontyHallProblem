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
            switch (gameMain.Stage)
            {
                case GameMain.FIRST_PLAYER_TURN:
                    gameMain.PlayerFirstTurn(1);
                    break;
                case GameMain.SECOND_PLAYER_TURN:
                    gameMain.PlayerSecondTurn(1);
                    break;
            }
        }

        private void Image2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (gameMain.Stage)
            {
                case GameMain.FIRST_PLAYER_TURN:
                    gameMain.PlayerFirstTurn(2);
                    break;
                case GameMain.SECOND_PLAYER_TURN:
                    gameMain.PlayerSecondTurn(2);
                    break;
            }
        }

        private void Image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            switch (gameMain.Stage)
            {
                case GameMain.FIRST_PLAYER_TURN:
                    gameMain.PlayerFirstTurn(3);
                    break;
                case GameMain.SECOND_PLAYER_TURN:
                    gameMain.PlayerSecondTurn(3);
                    break;
            }

        }

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {

            switch (gameMain.Stage) {
                case GameMain.FIRST_PLAYER_TURN:
                    gameMain.Stage = GameMain.CHAIRMAN_TURN;
 
                    gameMain.ChairPersonTurn();
                    MessageLabel.Content = "司会者が開きます。";
                    
                    break;
                case GameMain.CHAIRMAN_TURN:
                    gameMain.Stage = GameMain.SECOND_PLAYER_TURN;
                    break;
                case GameMain.SECOND_PLAYER_TURN:
                    
                    if (gameMain.Player.SelectionNumber == gameMain.WinningNo)
                    {
                        gameMain.GameSuccess();
                    }
                    else {
                        gameMain.GameFailed();
                    }
                    break;
            }
        }
        
    }
}

