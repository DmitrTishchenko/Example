﻿int[] array = { 1, 12, 17, 26, 31, 4, 18};

int n = array.Length;
int find = 4;

int index = 0;
while (index < n)
{
    if (array[index] == find)
        {
            Console.WriteLine(index);
            break;

        }
    index++;
}