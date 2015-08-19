namespace MatrixCreator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MainProgram
    {
        public static void Main()
        {
            Matrix firstMatrix = new Matrix(3);
            firstMatrix.WriteMatrix();
            Matrix secondMatrix = new Matrix(6);
            secondMatrix.WriteMatrix();
        }
    }
}
