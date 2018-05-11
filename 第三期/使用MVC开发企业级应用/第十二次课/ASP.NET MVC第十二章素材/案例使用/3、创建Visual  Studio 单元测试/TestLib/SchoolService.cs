using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public enum ScoreType
    {
        Advance,
        Good,
        Nomal,
        Bad
    }

    public class ResultService
    {
        // 根据分数给评价
        public ScoreType EvaluateScore(double score)
        {
            if (score >= 90)
            {
                return ScoreType.Advance;
            }
            else if (score >= 80 && score < 90)
            {
                return ScoreType.Good;
            }
            else if (score >= 60 && score < 80)
            {
                return ScoreType.Nomal;
            }
            else
            {
                return ScoreType.Bad;
            }
        }

        // 判断字符串是否是数字
        public bool IsDigit(string data)
        {
            double result;
            return double.TryParse(data, out result);
        }
    }
}
