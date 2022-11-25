﻿// Метод 
Console.Clear();
int[,] pic = new int[,]
{
// здесь надо заполнить
}

void PrintImage(int[,] image)
{
    for(int i=0; i<image.GetLength(0); i++)
    {
        for(int j=0; j<image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
       // pic[row, col] = void FillImage(int row, int col);
       pic[row, col] = 1;
       FillImage(row-1, col);
       FillImage(row, col-1);
       FillImage(row+1, col);
       FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);