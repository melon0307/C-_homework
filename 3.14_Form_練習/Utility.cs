using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14_Form_練習
{
    public class StudentData
    {
        public string Name;
        public int[] grade = new int[3];
        string maxsubject;
    }

    public class stgrList
    {
        public string Name;
        public int[] grade = new int[3];
        public string[] subtitle = { "國文", "英文", "數學" };

        public string 最大分數()
        {
            return grade.Max().ToString();
        }

        public string 最小分數()
        {
            return grade.Min().ToString();
        }

        public string 最大分數科目()
        {
            return subtitle[Array.IndexOf(grade, grade.Max())] + 最大分數();
        }

        public string 最小分數科目()
        {
            return subtitle[Array.IndexOf(grade, grade.Min())] + 最小分數();
        }
        
        public string 平均分數()
        {
            return Math.Round(grade.Average(), 1).ToString();
        }

        public string 總分()
        {
            return grade.Sum().ToString();
        }
        
    }
}
