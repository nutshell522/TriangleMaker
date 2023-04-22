using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.TriangleMaker
{
    public class TriangleMaker
    {
        public string PrintTriangle(int levels, Func<int, string> func)
            => func(levels);
        public string PrintTriangle(int levels, char letter, Func<int, char, string> func)
            => func(levels, letter);

        public string PadLeft(int levels)
            => TriangleBuilder(levels, HorizontalAlign.靠左, Vertical.向上);

        public string PadRight(int levels)
            => TriangleBuilder(levels, HorizontalAlign.靠右, Vertical.向上);

        public string InvertedLeft(int levels)
            => TriangleBuilder(levels, HorizontalAlign.靠左, Vertical.向下);

        public string InvertedRight(int levels)
            => TriangleBuilder(levels, HorizontalAlign.靠右, Vertical.向下);

        public string Center(int levels)
            => CenterTriangleBuilder(levels, Vertical.向上);

        public string InvertCenter(int levels)
            => CenterTriangleBuilder(levels, Vertical.向下);

        public string CharTriangle(int levels, char letter)
            => CenterTriangleBuilder(levels, letter, Vertical.向上, CharIncrease.遞增);

        public string InvertCharTriangle(int levels, char letter)
            => CenterTriangleBuilder(levels, letter, Vertical.向下, CharIncrease.遞增);

        /// <summary>
        /// 置中正/倒，星號三角形
        /// </summary>
        /// <param name="levels"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        private string CenterTriangleBuilder(int levels, Vertical direction = Vertical.向上)
        {
            return CenterTriangleBuilder(levels, '*', direction);
        }
        /// <summary>
        /// 置中正/倒，字元三角形
        /// </summary>
        /// <param name="levels">層數</param>
        /// <param name="letter">字元</param>
        /// <param name="direction">向上/向下</param>
        /// <param name="increase">是否做字元遞增</param>
        /// <returns></returns>
        private string CenterTriangleBuilder(int levels, char letter, Vertical direction = Vertical.向上, CharIncrease increase = CharIncrease.NO)
        {
            var sb = new StringBuilder();
            int starPerRow = direction == Vertical.向上 ? 1 : levels * 2 - 1;
            int spacePerRow;
            for (int i = 1; i <= levels; i++)
            {
                spacePerRow = direction == Vertical.向上 ? levels - i : i - 1;

                sb.AppendLine(RowBuilder(letter, starPerRow, spacePerRow, increase));


                starPerRow = direction == Vertical.向上
                                        ? starPerRow + 2
                                        : starPerRow - 2;
            }
            return sb.ToString();
        }

        /// <summary>
        /// 置左/置右三角形
        /// </summary>
        /// <param name="levels">層數</param>
        /// <param name="align">置左/置右</param>
        /// <param name="direction">向上/向下</param>
        /// <returns></returns>
        private string TriangleBuilder(int levels, HorizontalAlign align = HorizontalAlign.靠左, Vertical direction = Vertical.向上)
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= levels; i++)
            {
                int space = levels - i;

                int spacePerRow = align == HorizontalAlign.靠左 ? 0 : space - (space - i + 1) * (int)direction;
                int starPerRow = direction == Vertical.向上 ? i : levels - i + 1;

                sb.AppendLine(RowBuilder('*', starPerRow, spacePerRow));

            }
            return sb.ToString();
        }
        /// <summary>
        /// 得到三角形每行字串
        /// </summary>
        /// <param name="mark">拼接的字元</param>
        /// <param name="markCount">字元數量</param>
        /// <param name="spaceCount">空白數量</param>
        /// <param name="increase">是否字元遞增</param>
        /// <returns></returns>
        private string RowBuilder(char mark, int markCount, int spaceCount, CharIncrease increase = CharIncrease.NO)
        {

            List<char> charsList = GetChars(mark, markCount, spaceCount, increase);

            char[] chars = charsList.ToArray();
            string row = string.Join("", chars);

            return row;
        }
        /// <summary>
        /// 得到每行的字元(Char)清單
        /// </summary>
        /// <param name="mark">拼接的字元</param>
        /// <param name="markCount">字元數量</param>
        /// <param name="spaceCount">空白數量</param>
        /// <param name="increase">是否字元遞增</param>
        /// <returns></returns>
        private List<char> GetChars(char mark, int markCount, int spaceCount, CharIncrease increase = CharIncrease.NO)
        {
            List<char> charsList = new List<char>();
            for (int i = 0; i < spaceCount; i++)
            {
                charsList.Add(' ');
            }
            int index = 0;
            for (int i = 0; i < markCount; i++)
            {
                if (increase == CharIncrease.遞增)
                {
                    charsList.Add((char)(mark + index));
                    index = i < markCount / 2
                            ? index + 1
                            : index - 1;
                }
                else
                {
                    charsList.Add(mark);
                }
            }
            return charsList;
        }
        

        private enum HorizontalAlign
        {
            靠左 = 0,
            靠右 = 1,
        }
        private enum Vertical
        {
            向上 = 0,
            向下 = 1,
        }
        private enum CharIncrease
        {
            遞增,
            NO
        }
    }
}
