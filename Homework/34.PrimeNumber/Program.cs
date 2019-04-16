using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Thread
{
    class Program
    {
        static void Main (string[] args) // task 사용 시 main thread 종료안되게 주의
        {
            var p = new CheckPrimerNumber();
            p.AddTask(0, 11);
            p.AddTask(12, 20);
            p.AddTask(21, 1000);
            p.Start();

            int n = p.GetNumberOfPrime();
            Console.WriteLine("#PrimeNumber = " + n);
            Console.WriteLine(n == 168); // 총 갯수
        }
    }

    // task return type는 list
    // 각 부분 callback? callback // Task(lambda, object(list) lambda에 들어갈 파라미터(시작과 끝)) how to pass param in task
    public class CheckPrimerNumber
    {
        List<Task<List<int>>> taskList = new List<Task<List<int>>>(); // taskList: int type List를 return하는 Task들의 List
        List<int> pNum = new List<int>();                             // Prime Number가 저장될 List
        public void AddTask(int start, int end)
        {
            var t = new Task<List<int>>( () => {
            var list = new List<int>();
            for (int i = start; i <= end; i++)                        // start에서 end까지의 숫자들이 Prime Number인지 확인
            {
                if (IsPrime(i) == true)
                list.Add(i);
            }
            return list;
            });
            taskList.Add(t);
        }

        public void Start()
        {
            for (int i = 0; i < taskList.Count; i++)                   // Task.Start()
            {
                taskList[i].Start();
            }
            var t = Task.WhenAll(taskList.ToArray());                  // 모든 Task가 완료될 때 까지 기다림
            for (int i = 0; i < taskList.Count; i++)
            {
                pNum.AddRange(taskList[i].Result);                     // Task가 구한 Prime Number들을 pNum에 추가
            }
        }

        public int GetNumberOfPrime()
        {
            return pNum.Count;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            return false;
            if (number != 2 && number % 2 == 0)
            return false;
            for (int i = 2; i < number; i++)
            {
            if (number % i == 0)
                return false;
            }
            return true;
        }
    }

    public static class ClassExtension
    {
        public static string Stringify<T>(this IEnumerable<T> list)
        {
            return String.Join(" ", list);
        }
    }
}

/*
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
  whenall 써봅시다
*/
