namespace Day04
{
    public class PrintingDepartmentFloor
    {
        public string[,] RollDiagram;
        public int Width { get { return RollDiagram.GetLength(0); } }
        public int Height { get { return RollDiagram.GetLength(1); } }
        public PrintingDepartmentFloor(int width, int height)
        {
            RollDiagram = new string[width, height];
        }
    }
}
