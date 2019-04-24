using System;
using System.Collections.Generic;

class MainClass
{
  public static void Main (string[] args)
  {
    Action<object> print = Console.WriteLine;
  
  }
}

public static class ClassExtension
{
  public static string Stringify<T>(this IEnumerable<T> list)
  {
    return String.Join(" ", list);
  }
}

/*
CSharp Homework

2019-04-15
1. Linq

낙제생 (과락(60미만)없이 평균 80이상) 쿼리로 뽑기
합격생도...

출력은 이름만 찍기

2. Thread

// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/async/
// https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/concepts/async/how-to-extend-the-async-walkthrough-by-using-task-whenall

소수(prime number)
2보다 작으면 소수가 아님
짝수는 소수가 아님
i=2부터 number 전까지 i++ i로 나눠서 나머지가 0이면 아님

bool IsPrime(int number)

CheckPrimerNumber p = new CheckPrimerNumber();
  p.AddTask(0, 11);
  p.AddTask(12, 20);
  p.AddTask(21, 1000);
  p.Start();

  int n = p.GetNumberOfPrime();
  Console.WriteLine("#PrimeNumber = " + n);
  Console.WriteLine(n == 168); // 총 갯수

3. 8-Way A*

대각선 D = 피타고라스

4. JPS Algorithm (Jump Point Search, Path finding)

구현?

5. Circular Queue

구현?

6. K * Sorted Array Merge (효율 고려) (?)

구현?

7. Line Drawing (Bresenham Algorithm)

구현?

8. A* algorithm closed list를 list말고 Hash로 바꿔보기 (hashset: key만 있고 value없음)

다른 작업 없이 그냥 바꾸기만하면 안됨
구현?

*/

/*
Unity Homework

 */