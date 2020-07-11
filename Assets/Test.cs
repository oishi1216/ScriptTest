using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void For1(){
        // 配列を初期化する
        int[] array = { 5, 10, 15, 20, 25 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int a = 0; a < array.Length; a++)
        {
            // 配列の要素を表示する
            Debug.Log(array[a]);
        }
    }

    public void For2()
    {
        // 配列を初期化する
        int[] array = { 5, 10, 15, 20, 25 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int b = 4; b >= 0; b--)
        {
            // 配列の要素を表示する
            Debug.Log(array[b]);
        }
    }

    public class Boss
    {
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
        private int mp = 53;        //マジックポイント

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }

        //魔法攻撃用の関数
        public void Magic()
        {

            if(mp >= 5){

                // 残りmpを減らす
                this.mp -= 5;

                //MPが5以上の場合
                string a = "魔法攻撃をした。残りMPは";
                string b = "。";

                Debug.Log(a + mp + b);

            } else{
                //MPがなくなった場合
                Debug.Log("MPが足りないため魔法が使えない。");
            }



        }

    }

    void Start()
    {
        For1();
        For2();

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        for(int i =0; i <= 10; i++){ 
        // 魔法攻撃用の関数を呼び出す
        lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}