using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MontyHole
{
    /*司会者を表すクラス*/

    class ChairPerson
    {
        private int shownNo;        //司会者が開けて見せるドア番号
        MainWindow mainWindow;
        GameMain gameMain;

        public ChairPerson(MainWindow mainWindow,GameMain gameMain)
        {
            this.mainWindow = mainWindow;
            this.gameMain = gameMain;
        }

        public int ShownNo { get => shownNo; set => shownNo = value; }

        public void DoorOpen()
        {
            //司会者はプレイヤーが選んだドアと正解のドア以外を選ぶ
          
            for (int i = 1; i < 4; i++) {
                if (gameMain.Player.SelectionNumber != i && gameMain.WinningNo != i) {
                    ShownNo = i;
                }
               
            }
            string fnameOpen;
            string fnameClose;

            fnameOpen = "C:/Users/tabuchikenta/source/repos/MontyHole/MontyHole/Assets/opendoor.png";
            fnameClose = "C:/Users/tabuchikenta/source/repos/MontyHole/MontyHole/Assets/closedoor.jpg";
            BitmapImage imageOpen = new BitmapImage(new Uri(fnameOpen));
            BitmapImage imageClose = new BitmapImage(new Uri(fnameClose));

            //司会者はドアを開けるだけで閉めない。
            mainWindow.MessageLabel.Content = $"は{ShownNo}を選びました。";
            switch (ShownNo)
            {
                case 1:
                    mainWindow.Image1.Source = imageOpen;

                    break;
                case 2:
                    mainWindow.Image2.Source = imageOpen;
                    break;
                case 3:
                    mainWindow.Image3.Source = imageOpen;
                    break;
            }
            mainWindow.MessageLabel.Content = "さあ、もう一度ドアを選んでください。";
        }
    }

}
