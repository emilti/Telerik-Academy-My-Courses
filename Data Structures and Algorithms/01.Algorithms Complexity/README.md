## Data Structures, Algorithms and Complexity Homework

1. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
Answer:
The algorithm complexity is O(n*n). 
The outer for- loop is iterated n- times and the inner while- loop n-times.

2. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
Answer:
The first for loop will be executed n times.The inner for loop will be executed only if a number from the first row of the matrix is even. The second for loop will execute m times but for certain conditions. There are different formulas if the numbers from the row are all even, half even or almost no even(best, average, worst case scenarios) but the actual count of even numbers doesn't matter because this will be a constant to the equation. Therefore the algorithm complexity is n*m.

3. (*) What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```
Answer:
The first for loop will be executed n(number of columns) times. For each loop the if will execute m-1(m - number of rows) times recursively. The equation is n*(m-1). Since the constant is not relevant to the algorithm complexity formula the final equation is O(n*m).
