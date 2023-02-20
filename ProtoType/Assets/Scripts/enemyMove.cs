using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public Transform character; // �̵��� ĳ����
    public GameObject player;
    public float speed; // �̵� �ӵ�
    public List<Vector3> movePositions; // �̵��� ��ġ���� ������ ����Ʈ
    private int currentPositionIndex; // ���� �̵� ���� ��ġ�� �ε���
    private int size;
    private int flag = 1;

    void Start()
    {
        currentPositionIndex = 0; // ���� ��ġ�� 0��° ��ġ�� ����
        size = movePositions.Count;
    }

    void Update()
    {
        // ���� �̵� ���� ��ġ�� �������� �ʾҴٸ� �̵��� ����մϴ�.
        if (character.position != movePositions[currentPositionIndex])
        {
            character.position = Vector3.MoveTowards(character.position, movePositions[currentPositionIndex], speed * Time.deltaTime);
        }
        // ���� �̵� ���� ��ġ�� �����ϸ� ���� ��ġ�� �̵��մϴ�.
        else
        {
            // ���� ��ġ�� �ε����� ����մϴ�.
            if (currentPositionIndex >= size - 1)
                flag = -1;
            else if (currentPositionIndex == 0)
                flag = 1;
            currentPositionIndex += flag;
        }
    }

}
