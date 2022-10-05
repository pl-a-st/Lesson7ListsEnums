using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7ListsEnums {
    public enum Operation {
        Sum = 5,
        Dif,
        Mult,
        Default = Sum
    }
    class Program {
        static void Main(string[] args) {
            WhyNotArry();
            MustHaveMetodsForList();
            RemoveMethod();
            MakeOperation(1, 2, Operation.Sum);
        }
        private static void MakeOperation(int firstValue, int secondValue, Operation operation) {
            double result;
            int b = (int)operation;
            if(operation == Operation.Sum) {
                result = firstValue + secondValue;
            }
            if(operation == Operation.Dif) {
                result = firstValue - secondValue;
            }
        }
        private static void RemoveMethod() {
            List<int> nums = GetListNum();
            var nums2 = GetListNum();
            for (int i = 0; i < nums.Count; i++) {
                while (nums[i] > 5) {
                    nums.RemoveAt(i);
                    i--;// для компенсации сдвига элементов list
                }
            }
        }

        private static List<int> GetListNum() {
            List<int> nums = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++) {
                nums.Add(rnd.Next(0, 10));
            }
            return nums;
        }

        private static void MustHaveMetodsForList() {
            List<string> strings = new List<string>() { "Андрей", "Сергей" };
            strings.Add("Владимир");
            int CountElemnts = strings.Count;
            strings.RemoveAt(0);
            //strings.RemoveAt(5); будет ошибка 
            strings.Insert(1, "Иван");
            strings.Add("Сергей");
            bool isContains = strings.Contains("Сергей");
            int index = strings.IndexOf("Сергей");
            index = strings.IndexOf("Сергей", index + 1);
            strings.Remove("Сергей");
            strings.Reverse();
            strings.Sort();
        }

        private static void WhyNotArry() {
            int[] arry = new int[6];
            Array.Resize(ref arry, 7);
            arry[6] = 5;
        }
    }
}
