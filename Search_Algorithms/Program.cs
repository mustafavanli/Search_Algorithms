using Search_Algorithms.Algorithms;

int[] numbers = new int[] {1,3,5,8,10,15,24,25};
int value = 25;

#region Binary Search
int result = BinarySearch.Search(numbers, value, 0,numbers.Count()-1);
Console.WriteLine($"Aranan değer şu indeksde: {result}");
#endregion
Console.Read();