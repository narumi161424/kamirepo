using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemydamege : MonoBehaviour
{


    public AudioClip destroySound;
    public int m_HP;
    public int m_damage;

    public Explosion m_explosionPrefab; // 爆発エフェクトのプレハブ



    // 他のオブジェクトと衝突した時に呼び出される関数
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 弾と衝突した場合
        if (collision.name.Contains("tama"))
        {
        


            // 弾が当たった場所に爆発エフェクトを生成する
            Instantiate(
                m_explosionPrefab,
                collision.transform.localPosition,
                Quaternion.identity);


            // 弾を削除する
            Destroy(collision.gameObject);

            // 敵の HP を減らす
            m_HP--;

            // 敵の HP がまだ残っている場合はここで処理を終える
            if (0 <m_HP) return;

            // 敵を削除する
            Destroy(gameObject);




   // プレイヤーと衝突した場合プレイヤーにダメージを与える
     
            if (collision.name.Contains("Player"))
            {
                // プレイヤーにダメージを与える
                var player = collision.GetComponent<Player>();
                player.Damage(m_damage);
                return;
            }

        }
    }
            }


   

