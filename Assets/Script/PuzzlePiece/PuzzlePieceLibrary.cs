using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePieceLibrary : SingletonMonoBehaviour<PuzzlePieceLibrary>
{
    [SerializeField]
    private GameObject NextPoj;
    [SerializeField]
    private GameObject PlayerMousePoj;


    [SerializeField] List<PuzzlePieceData> puzzlePieceDatas;

    private GameObject NextPuzzlePiece;

    protected override void Awake()
	{
		base.Awake();
		//基本一つのみなのでシーンを跨げるようにする
		//DontDestroyOnLoad(gameObject);
	}
    
    //次に出るピースを設定する
    public GameObject NextPuzzlePieceSet(int PuzzlePieceSize)
	{
        //サイズの情報が送られてくるのでその情報から出したいピースを探す
        PuzzlePieceData data = puzzlePieceDatas[PuzzlePieceSize];
        
        //ピースが出せたらそのピースを配置する
        NextPuzzlePiece = Instantiate(data.PuzzlePieceprefab, NextPoj.transform, false);
        
        //ピースが動かないように停止させる
        Rigidbody2D rb = NextPuzzlePiece.GetComponent<Rigidbody2D>();
        rb.simulated = false;

        return NextPuzzlePiece;
    }

    //次に出る予定のピースをプレイヤーが動かせるピースに変更する
    public GameObject PlayerMovePuzzlePieceSet()
	{
        NextPuzzlePiece.transform.parent = PlayerMousePoj.transform;
        NextPuzzlePiece.transform.localPosition = new Vector3(0f,0f,0f);

        return NextPuzzlePiece;
    }

}

[System.Serializable]
public class PuzzlePieceData
{
	public Sprite PuzzlePieceSprite;
    public GameObject PuzzlePieceprefab;
}