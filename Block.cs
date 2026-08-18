using UnityEngine;

public class Block : MonoBehaviour
{
    public GameManager gameManager; // GameManager スクリプトへの参照

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collison)
	{
		gameManager.AddScore(); // スコア加算
		Destroy (gameObject);
	}
}
