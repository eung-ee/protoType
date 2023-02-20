using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public Transform character; // 이동할 캐릭터
    public GameObject player;
    public float speed; // 이동 속도
    public List<Vector3> movePositions; // 이동할 위치들을 저장한 리스트
    private int currentPositionIndex; // 현재 이동 중인 위치의 인덱스
    private int size;
    private int flag = 1;

    void Start()
    {
        currentPositionIndex = 0; // 시작 위치는 0번째 위치로 설정
        size = movePositions.Count;
    }

    void Update()
    {
        // 현재 이동 중인 위치에 도착하지 않았다면 이동을 계속합니다.
        if (character.position != movePositions[currentPositionIndex])
        {
            character.position = Vector3.MoveTowards(character.position, movePositions[currentPositionIndex], speed * Time.deltaTime);
        }
        // 현재 이동 중인 위치에 도착하면 다음 위치로 이동합니다.
        else
        {
            // 다음 위치의 인덱스를 계산합니다.
            if (currentPositionIndex >= size - 1)
                flag = -1;
            else if (currentPositionIndex == 0)
                flag = 1;
            currentPositionIndex += flag;
        }
    }

}
