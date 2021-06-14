using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DogGame.House
{
    public class HouseSc : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == this.gameObject.tag)
            {
                //scoreを加算
                //正解の時の処理
                Destroy(other.gameObject);
            }
            else
            {
                //間違えた時の処理
                Destroy(other.gameObject);
            }
        }

    }
}
