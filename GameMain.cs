using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHole
{
    class GameMain
    {
        private MainWindow mainWindow;
        private int winningNo;      //当たりのドア番号
        private int stage; //ゲームの進行状況
        private ChairPerson chairPerson;
        private Player player;
        private int winNum = 0;//ゲームに成功した数
        private int looseNum = 0;//ゲームに失敗した数
        
        public const int FIRST_PLAYER_TURN = 1;
        public const int CHAIRMAN_TURN = 2;
        public const int SECOND_PLAYER_TURN = 3;

        public GameMain(MainWindow mainWindow) {
            this.mainWindow = mainWindow; 
            chairPerson = new ChairPerson(mainWindow,this);
            player = new Player(mainWindow,this);
            Stage = FIRST_PLAYER_TURN;
            winningNo = 2;//テスト用の仮の数字。これを1～3のランダムに変える。

        }
        /*プレイヤーがド１回目のドアを選んでいる間*/
        public void PlayerFirstTurn(int selectedDoor) {
            player.DecideFirstSelect(selectedDoor);
        }
        /*司会者がドアを選ぶところ*/
        public void ChairPersonTurn() {
            chairPerson.DoorOpen();
            Stage = SECOND_PLAYER_TURN;
        }
        /*プレイヤーが２回目のドアを選んでいる間*/
        public void PlayerSecondTurn(int selectedDoor)
        {
            player.DecideSecondSelect(selectedDoor);
        }
        /*正解のドアを選んだ場合の演出*/
        public void GameSuccess()
        {
            mainWindow.SelectionLabel.Content = "正解です。おめでとうございます!!";
        }
        /*不正解のドアを選んだ場合の演出*/
        public void GameFailed() {
            mainWindow.SelectionLabel.Content = "残念。反対でした・・";
        }
        public int WinningNo { get => winningNo; }
        
        internal ChairPerson ChairPerson { get => chairPerson;}
        internal Player Player { get => player; }
        public int Stage { get => stage; set => stage = value; }
        public int WinNum { get => winNum; set => winNum = value; }
        public int LooseNum { get => looseNum; set => looseNum = value; }
    }
}
