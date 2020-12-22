using UnityEngine;
using System.Collections;
 

public class Network : MonoBehaviour
{
    bool net = false;
    // Start is called before the first frame update
    void Awake()
    {
        // ネットワークの状態を出力
        switch ( Application.internetReachability ) {
        case NetworkReachability.NotReachable:
            Debug.LogError("ネットワークには到達不可");
                net = true;
            break;
        case NetworkReachability.ReachableViaCarrierDataNetwork:
            Debug.Log("キャリアデータネットワーク経由で到達可能");
                net = true;
            break;
        case NetworkReachability.ReachableViaLocalAreaNetwork:
            Debug.Log("Wifiまたはケーブル経由で到達可能");
            break;
        }
    }

    private void Start()
    {
        if(!net)
        {
            Debug.LogError("アクセスキーが違うよ^^");
        }
    }
}
