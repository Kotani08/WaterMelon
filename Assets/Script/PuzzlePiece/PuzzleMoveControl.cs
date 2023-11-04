using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveControl : MonoBehaviour
{
    [SerializeField]
    private GameObject NextPiece;
    [SerializeField]
    private GameObject PlayerMovePiece;

    void Start()
    {
        //サイズ0から3のピースをランダムによびだすやつ
        PuzzlePieceRandomCreate();
        PlayerMovePazzlePieceSet();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PuzzlePieceRandomCreate()
    {
        //サイズ0から3のピースをランダムによびだすやつ
        int Val = Random.Range (0, 4);
        NextPiece = PuzzlePieceLibrary.Instance.NextPuzzlePieceSet(Val);
    }

    private void PlayerMovePazzlePieceSet()
    {
        //ピースをプレイヤーが動かせるピースとして設定する
        PlayerMovePiece = PuzzlePieceLibrary.Instance.PlayerMovePuzzlePieceSet();
        //その後次のピースをセットする
        PuzzlePieceRandomCreate();

    }


    

}
