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
         
            //ここでプライヤーがドアの前に立つイラストを入れる。
        }
        /*２回目のドア選択中*/
        public void DecideSecondSelect(int selectedDoor)
        {
            if(gameMain.ChairPerson.ShownNo == selectedDoor) {
                mainWindow.SelectionLabel.Content = "それは外れです。他を選んでください。";
            }
            selectionNumber = selectedDoor;
            
            mainWindow.SelectionLabel.Content = $"選択中のドアは{selectionNumber}番です。";

            //ここでプライヤーがドアの前に立つイラストを入れる。
        }


    }
}
