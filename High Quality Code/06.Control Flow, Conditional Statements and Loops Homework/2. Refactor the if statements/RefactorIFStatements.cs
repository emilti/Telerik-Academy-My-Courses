namespace IStatements
{
    using System;

    public class IfStatementsTask
    {
        public const int MinX = 1;
        public const int MaxX = 15;
        public const int MinY = 1;
        public const int MaxY = 15;

        public static void Vegetables()
        {
            Potato potato;

            // Code..
            if (potato != null)
            {
                if (potato.isPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
            }
            else
            {
                
            }
        }

        public static void CellCheck()
        {
            int y = 12;
            int x = 11;

            bool shouldVisitCell = true;
            bool isInRangeY = MinY <= y && y <= MaxY;
            bool isInRangeX = MinX <= x && x <= MaxX;
            if (isInRangeX && isInRangeY && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
