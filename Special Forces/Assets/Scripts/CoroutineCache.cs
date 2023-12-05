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

    // Current : 읽기 전용 프로퍼티로 현재 위치의 데이터를 object 타입으로 반환합니다.
    public object Current
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
        get { return bullet[index]; }
    }
    
    // MoveNext : 다음 위치로 이동하는데 다음 위치에 데이터가 있으면 true 값을 반환하고
    //            없으면 false 값을 반환합니다.
    public bool MoveNext()
    {
        index++;

        return index < bullet.Length;
=======
>>>>>>> Stashed changes
        get { return bullet[index]; }    
    }

    //MoveNext : 다음 위치로 이동하는데 다음 위치에 데이터가 있으면 true 값을 반환하고
    //           없으면 false 값을 반환합니다.
    public bool MoveNext()
    {
        throw new System.NotImplementedException();
<<<<<<< Updated upstream
=======
>>>>>>> 34b1a0ca68b044f18da83944e18964cc35e02e08
>>>>>>> Stashed changes
    }

    // Reset : 인덱스를 초기 상태 위치로 이동시킵니다.
    //         Index를 -1로 초기화합니다.
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
