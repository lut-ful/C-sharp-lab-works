namespace lab_tutorial_d2
{
    internal class MatrixMultiplication
    {
        int[,] matrix1, matrix2;
        int rows1, cols1, rows2, cols2;
        public MatrixMultiplication()
        {
            Console.WriteLine("Enter the number of rows for the first matrix: ");
            rows1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns for the first matrix: ");
            cols1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of rows for the second matrix: ");
            rows2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns for the second matrix: ");
            cols2=int.Parse(Console.ReadLine());
            this.rows1 = rows1;
            this.cols1 = cols1;
            this.rows2 = rows2;
            this.cols2 = cols2;
            matrix1 = new int[rows1, cols1];
            matrix2 = new int[rows2, cols2];
        }
        public bool isValid()
        {
            if (cols1 != rows2)
            {
                Console.WriteLine("The matrices cannot be multiplied!");
                return false;
            }
            return true;
        }
        public void InputMatrix()
        {
  
            Console.WriteLine("Enter the elements of the first matrix: ");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of the second matrix: ");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        
        public void MultiplyMatrix()
        {
            if (!isValid())
            {
                return;
            }
            int[,] result = new int[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            Console.WriteLine("The result of the matrix multiplication is: ");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
