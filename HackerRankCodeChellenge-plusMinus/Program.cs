

using System;

//Sample Input
List<int> arr = new List<int> { 1,-3,-4,0,1};

int arr_length = arr.Count;

int positive = 0;
int negative = 0;
int zero = 0;

foreach (var item in arr)
{
    if(item > 0)
    {
        positive++;
    }
    else if (item < 0)
    {
        negative++;
    }
    else
    {
        zero++;
    }
}


Console.WriteLine(((float)positive / arr_length).ToString("N6"));
Console.WriteLine(((float)negative / arr_length).ToString("N6"));
Console.WriteLine(((float)zero / arr_length).ToString("N6"));
