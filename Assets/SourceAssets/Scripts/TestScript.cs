using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start()는 이 게임오브젝트가 생성고 난 첫 프레임에 실행됩니다
    private void Start()
    {
        Debug.Log("스타트!");
    }

    // Update()는 Start()이후에 매 프레임에 실행됩니다.
    private void Update()
    {
        Debug.Log("업데이트!");
    }
}
