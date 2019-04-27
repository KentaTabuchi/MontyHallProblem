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
        public Player(MainWindow mainWindow){
            this.mainWindow = mainWindow;
        }
        public int SelectionNumber { get => selectionNumber; set => selectionNumber = value; }
        
        /*ドアを選んで開けたとき*/
        public void openDoor() {
            string fnameOpen;
            string fnameClose;
            //fnameOpen = "ms-appx:///Assets/opendoor.png";
            //fnameClose = "ms-appx:///Assets/closedoor.jpg";
            fnameOpen = "C:/Users/tabuchikenta/source/repos/MontyHole/MontyHole/Assets/opendoor.png";
            fnameClose = "C:/Users/tabuchikenta/source/repos/MontyHole/MontyHole/Assets/closedoor.jpg";
            BitmapImage imageOpen = new BitmapImage(new Uri(fnameOpen));
            BitmapImage imageClose = new BitmapImage(new Uri(fnameClose));

            switch (selectionNumber) {
                case 1:
                    mainWindow.Image1.Source = imageOpen;
                    mainWindow.Image2.Source = imageClose;
                    mainWindow.Image3.Source = imageClose;
                    break;
                case 2:
                    mainWindow.Image2.Source = imageOpen;
                    mainWindow.Image1.Source = imageClose;
                    mainWindow.Image3.Source = imageClose;
                    break;
                case 3:
                    mainWindow.Image3.Source = imageOpen;
                    mainWindow.Image1.Source = imageClose;
                    mainWindow.Image2.Source = imageClose;
                    break;
            }
        }

    }
}
