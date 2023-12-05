using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : IEnumerator
{
    private int index = -1;
    private int [ ] bullet;

    public Rifle()
    {
        bullet = new int[5];
    }

    // Current : �б� ���� ������Ƽ�� ���� ��ġ�� �����͸� object Ÿ������ ��ȯ�մϴ�.
    public object Current
    {
        get { return bullet[index]; }
    }
    
    // MoveNext : ���� ��ġ�� �̵��ϴµ� ���� ��ġ�� �����Ͱ� ������ true ���� ��ȯ�ϰ�
    //            ������ false ���� ��ȯ�մϴ�.
    public bool MoveNext()
    {
        index++;

        return index < bullet.Length;
    }

    // Reset : �ε����� �ʱ� ���� ��ġ�� �̵���ŵ�ϴ�.
    //         Index�� -1�� �ʱ�ȭ�մϴ�.
    public void Reset()
    {
        index = -1;
    }
}

public static class CoroutineCache 
{
    class FloatCompare : IEqualityComparer<float>
    {
        public bool Equals(float x, float y)
        {
            return x == y;
        }

        public int GetHashCode(float obj)
        {
            return obj.GetHashCode();
        }
    }

    private static readonly Dictionary<float, WaitForSeconds> timeInterval = new Dictionary<float, WaitForSeconds>(new FloatCompare());

    public static WaitForSeconds waitForSeconds(float time)
    {
        WaitForSeconds waitForSeconds;

        if (timeInterval.TryGetValue(time,out waitForSeconds) == false)
        {
            timeInterval.Add(time, waitForSeconds = new WaitForSeconds(time));
        }

        return waitForSeconds;
    }
}
