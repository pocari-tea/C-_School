using System;
// System.Array 활용
namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 70, 80, 35, 65 };
            PrintArray(scores);

            Array.Sort(scores); // 정렬
            PrintArray(scores);

            //배열의 각 요소에 대해 특정 함수 실행
            Array.ForEach<int>(scores, new Action<int>(Print));

            //배열의 차원
            Console.WriteLine();
            Console.WriteLine($"{scores.Rank}차원");
            int[,] scores2 = new int[3, 4];
            Console.WriteLine($"{scores2.Rank}차원");

            //탐색
            Console.WriteLine(Array.BinarySearch<int>(scores, 80)); //이진 탐색
            Console.WriteLine(Array.IndexOf<int>(scores, 80));

            Console.WriteLine(Array.TrueForAll<int>(scores, CheckPassed)); //모든 요소가 60이상인가?
            int index = Array.FindIndex<int>(scores, delegate (int score) { return (score < 60) ? true : false; });
            Console.WriteLine($"index: {index}");
            scores[index] = 60;
            Console.WriteLine(Array.TrueForAll<int>(scores, CheckPassed));

            // 배열의 크기 재설정
            Console.WriteLine($"scores 배열의 크기 : {scores.GetLength(0)}"); // 0은 1차원
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"scores 배열의 크기 : {scores.GetLength(0)}");

            // 배열 초기화
            PrintArray(scores);
            Array.Clear(scores, 1, 4);
            PrintArray(scores);
        }

        static void PrintArray(int[] scores)
        {
            foreach (var a in scores)
                Console.Write($"{a} ");
            Console.WriteLine();
        }

        static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static bool CheckPassed(int score)
        {
            return (score >= 60) ? true : false;
        }
    }
}