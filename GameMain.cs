using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHole
{
    class GameMain
    {
        private int winningNo;      //当たりのドア番号
        private int stage; //ゲームの進行状況
        private ChairPerson chairPerson;
        private Player player;
        const int FIRST_PLAYER_TURN = 1;
        const int CHAIRMAN_TURN = 2;
        const int SECOND_PLAYER_TURN = 3;

        public GameMain(MainWindow mainWindow) {
            chairPerson = new ChairPerson(mainWindow,this);
            player = new Player(mainWindow);
            stage = FIRST_PLAYER_TURN;
            winningNo = 2;//テスト用の仮の数字。これを1～3のランダムに変える。

        }
        public void ChairPersonTurn() {
            chairPerson.DoorOpen();
            stage = CHAIRMAN_TURN;
        }
        public int WinningNo { get => WinningNo; }
        public int Stage { get => stage; }
        internal ChairPerson ChairPerson { get => chairPerson;}
        internal Player Player { get => player; }
       
    }
}
