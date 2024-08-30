using System;

class Program
{
    static void Main()
    {
        // Bước 1: Tạo ma trận hai chiều (mảng 2 chiều) với giá trị có sẵn
        double[,] matrix = {
            { 1.2, 3.4, 5.6 },
            { 7.8, 9.0, 2.3 },
            { 4.5, 6.7, 8.9 }
        };

        // Khởi tạo các biến để lưu trữ giá trị lớn nhất và tọa độ của nó
        double max = matrix[0, 0]; // Giá trị lớn nhất ban đầu
        int maxRow = 0; // Tọa độ hàng của giá trị lớn nhất
        int maxCol = 0; // Tọa độ cột của giá trị lớn nhất

        // Duyệt qua tất cả các phần tử trong ma trận để tìm phần tử lớn nhất
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j]; // Cập nhật giá trị lớn nhất
                    maxRow = i; // Cập nhật tọa độ hàng của giá trị lớn nhất
                    maxCol = j; // Cập nhật tọa độ cột của giá trị lớn nhất
                }
            }
        }

        // Thông báo kết quả
        Console.WriteLine("The largest value in the matrix is " + max + " at position (" + maxRow + ", " + maxCol + ")");
        
        // Bước 2: Thu thập đầu vào từ người dùng để tạo ma trận và tìm phần tử lớn nhất
        Console.WriteLine("\nNow, let's create a custom matrix based on user input.");

        // Yêu cầu người dùng nhập kích thước của ma trận
        Console.WriteLine("Enter the number of rows:");
        int rows = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns:");
        int cols = Int32.Parse(Console.ReadLine());

        // Tạo ma trận dựa trên kích thước mà người dùng nhập vào
        double[,] userMatrix = new double[rows, cols];

        // Yêu cầu người dùng nhập giá trị cho từng phần tử trong ma trận
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Enter value for element at position (" + i + ", " + j + "):");
                userMatrix[i, j] = Double.Parse(Console.ReadLine());
            }
        }

        // Tìm phần tử lớn nhất trong ma trận người dùng nhập vào
        max = userMatrix[0, 0];
        maxRow = 0;
        maxCol = 0;

        for (int i = 0; i < userMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < userMatrix.GetLength(1); j++)
            {
                if (userMatrix[i, j] > max)
                {
                    max = userMatrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        // Thông báo kết quả tìm kiếm
        Console.WriteLine("The largest value in the custom matrix is " + max + " at position (" + maxRow + ", " + maxCol + ")");
    }
}
