﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* group by into로 데이터 분류하기 */
/* 494p 예제 */
namespace LINQ03_GroupBy
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스(Profile 객체 배열)
            Profile[] arrProfile =
            {
                new Profile(){Name="김동현",Height=180, Gender="남성"},
                new Profile(){Name="임영민",Height=182, Gender="여성"},
                new Profile(){Name="박우진",Height=177, Gender="여성"},
                new Profile(){Name="전우성",Height=175, Gender="남성"},
                new Profile(){Name="이대휘",Height=176, Gender="남성"}
            };

            #region 성별로 분류
            // 2. 쿼리 만들기
            var profileList1 = from profile in arrProfile
                               group profile by profile.Gender; // group A by B => A를 B 따라 그룹화

            // 3. 쿼리 실행(출력)
            PrintLinqList<string>(profileList1);
            #endregion

            #region 키로 분류 (그룹 요소가 3명 이상인 경우만 필터링)
            // 2. 쿼리 만들기(키 175미만과 키 175이상의 그룹의 분류)
            // group A by B into C => A를 B조건에 따라 C에 저장
            var profileList2 = from profile in arrProfile
                               orderby profile.Height
                               group profile by profile.Height < 175 into g // => profile을 기준에 따라 g에 저장
                               where g.Count() >= 3
                               select g;


            // 3. 쿼리 실행(그룹별로 출력)
            PrintLinqList<bool>(profileList2);
            #endregion

            #region 키로 분류 (Name, centiHeight, inchHeight)로 구성
            // 2. 쿼리 만들기(키 175미만과 키 175이상의 그룹의 분류)
            // group A by B into C => A를 B조건에 따라 C에 저장
            var profileList3 = from profile in arrProfile
                               orderby profile.Height
                               group new
                               {
                                   Name = profile.Name,
                                   centiHeight = profile.Height,
                                   inchiHeight = profile.Height * 0.393
                               }
                               by profile.Gender;


            // 3. 쿼리 실행(그룹별로 출력)
            foreach (var g in profileList3)
            {
                Console.WriteLine($"그룹의 이름: {g.Key}");
                foreach (var item in g)
                    Console.WriteLine($" {item.Name}, {item.centiHeight}, {item.inchiHeight}");
                Console.WriteLine();
            }
            #endregion
        }

        private static void PrintLinqList<T>(IEnumerable<IGrouping<T, Profile>> profileList)
        {
            foreach (var Group in profileList)
            {
                Console.WriteLine($"그룹명: {Group.Key}");
                foreach (var item in Group)
                    Console.WriteLine($"{item.Name}, {item.Height}");
                Console.WriteLine();
            }
        }
    }
}
