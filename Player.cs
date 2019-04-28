using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MontyHole
{
    /*プレイヤーを表すクラス*/
    class Player
    {
        int selectionNumber;//選択中のドア
        
        MainWindow mainWindow;
        GameMain gameMain;
        public Player(MainWindow mainWindow,GameMain gameMain){
            this.mainWindow = mainWindow;
            this.gameMain = gameMain;
        }
        public int SelectionNumber { get => selectionNumber; set => selectionNumber = value; }
        
        /*１回目のドア選択中*/
        public void DecideFirstSelect(int selectedDoor) {
            selectionNumber = selectedDoor;
            mainWindow.SelectionLabel.Content = $"選択中のドアは{selectionNumber}番です。";
            MovePlayerImage();
    
        }
        /*２回目のドア選択中*/
        public void DecideSecondSelect(int selectedDoor)
        {
            if (gameMain.ChairPerson.ShownNo == selectedDoor)
            {
                mainWindow.SelectionLabel.Content = "それは外れです。他を選んでください。";
            }
            else
            {
                selectionNumber = selectedDoor;

                mainWindow.SelectionLabel.Content = $"選択中のドアは{selectionNumber}番です。";
                MovePlayerImage();
            }
        }
        /*選択中のドアの上にプレイヤーの絵を動かす*/
        private void MovePlayerImage() {
            switch (selectionNumber) {
                case 1:
                    mainWindow.ImagePlayer1.Visibility = System.Windows.Visibility.Visible;
                    mainWindow.ImagePlayer2.Visibility = System.Windows.Visibility.Hidden;
                    mainWindow.ImagePlayer3.Visibility = System.Windows.Visibility.Hidden;
                    break;
                case 2:
                    mainWindow.ImagePlayer2.Visibility = System.Windows.Visibility.Visible;
                    mainWindow.ImagePlayer1.Visibility = System.Windows.Visibility.Hidden;
                    mainWindow.ImagePlayer3.Visibility = System.Windows.Visibility.Hidden;
                    break;
                case 3:
                    mainWindow.ImagePlayer3.Visibility = System.Windows.Visibility.Visible;
                    mainWindow.ImagePlayer1.Visibility = System.Windows.Visibility.Hidden;
                    mainWindow.ImagePlayer2.Visibility = System.Windows.Visibility.Hidden;
                    break;
            }
            
        }
    }
}


