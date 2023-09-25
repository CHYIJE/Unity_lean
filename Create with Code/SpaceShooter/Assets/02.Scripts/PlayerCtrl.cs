using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float h = 0.0f;
    private float v = 0.0f;

    // 접근해야 하는 컴포넌트는 반드시 변수에 할당한 후 사용
    private Transform tr;
    // 이동 속도 변수(publick으로 선언되어 Inspector에 노출됨)
    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        // 스크립트가 실행된 후 처음 수행되어 Start 함수에서 Transform 컴포넌트르 할당 
        tr = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Debug.Log("h=" + h.ToString());
        Debug.Log("v=" + v.ToString());

        // Translate(이동방향 * 속도 * 변위값 * Time.delataTime, 기준좌표)
        tr.Translate(Vector3.forward * moveSpeed * v * Time.deltaTime, Space.Self);
    }
}
