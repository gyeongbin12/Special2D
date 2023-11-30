using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    [SerializeField] int n;
    [SerializeField] List<int> array;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Find(array, n);
        }
    }

    void Find(List<int> array, int target)
    {
        int left = 0;
        int right = array.Count - 1;

        while(left <= right)
        {
            // 1. �迭�� ��� ����� �ε����� pivot���� �����մϴ�.
            int pivot = (left + right) / 2;

            // 2. [pivot]�� ���� ã���� �ϴ� target ���� ���ٸ� �˻� ����
            if (array[pivot] == target)
            {
                Debug.Log("pivot�� �� : " + array[pivot]);
                return;
            }
            else if (array[pivot] > target) // 3. [pivot]�� ���� ã�� ������ ũ�ٸ� left ~ pivot���� Ž���մϴ�.
            {
                right = pivot - 1;
            }
            else
            {
                left = pivot + 1;
            }
        }

        Debug.Log("���� ã�� ���߽��ϴ�.");
    }

}
