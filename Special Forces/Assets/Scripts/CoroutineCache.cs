using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : IEnumerator
{
    private int index = -1;
<<<<<<< Updated upstream
    private int [] bullet;
=======
<<<<<<< HEAD
    private int [ ] bullet;
=======
    private int [] bullet;
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes

    public Rifle()
    {
        bullet = new int[5];
    }

    // Current : �б� ���� ������Ƽ�� ���� ��ġ�� �����͸� object Ÿ������ ��ȯ�մϴ�.
    public object Current
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
        get { return bullet[index]; }
    }
    
    // MoveNext : ���� ��ġ�� �̵��ϴµ� ���� ��ġ�� �����Ͱ� ������ true ���� ��ȯ�ϰ�
    //            ������ false ���� ��ȯ�մϴ�.
    public bool MoveNext()
    {
        index++;

        return index < bullet.Length;
=======
>>>>>>> Stashed changes
        get { return bullet[index]; }    
    }

    //MoveNext : ���� ��ġ�� �̵��ϴµ� ���� ��ġ�� �����Ͱ� ������ true ���� ��ȯ�ϰ�
    //           ������ false ���� ��ȯ�մϴ�.
    public bool MoveNext()
    {
        throw new System.NotImplementedException();
<<<<<<< Updated upstream
=======
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes
    }

    // Reset : �ε����� �ʱ� ���� ��ġ�� �̵���ŵ�ϴ�.
    //         Index�� -1�� �ʱ�ȭ�մϴ�.
<<<<<<< Updated upstream

=======
<<<<<<< HEAD
=======

>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
            return obj.GetHashCode();
        }
    }

    private static readonly Dictionary<float, WaitForSeconds> timeInterval = new Dictionary<float, WaitForSeconds>(new FloatCompare());
=======
>>>>>>> Stashed changes
           return obj.GetHashCode();
        }
    }


    private static readonly Dictionary<float, WaitForSeconds> timeInterval = new Dictionary<float, WaitForSeconds>(new FloatCompare()); 
<<<<<<< Updated upstream
=======
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes

    public static WaitForSeconds waitForSeconds(float time)
    {
        WaitForSeconds waitForSeconds;

<<<<<<< Updated upstream
        if(timeInterval.TryGetValue(time, out waitForSeconds) == false)
=======
<<<<<<< HEAD
        if (timeInterval.TryGetValue(time,out waitForSeconds) == false)
=======
        if(timeInterval.TryGetValue(time, out waitForSeconds) == false)
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes
        {
            timeInterval.Add(time, waitForSeconds = new WaitForSeconds(time));
        }

        return waitForSeconds;
    }
<<<<<<< Updated upstream
} 
=======
<<<<<<< HEAD
}
=======
} 
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes
