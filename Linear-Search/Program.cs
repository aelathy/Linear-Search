#nullable disable
Console.Clear();

List<Object> cars = new List<Object> { "Volvo", "BMW", "Ram", "Ford" };
List<Object> nums = new List<Object> { 1, 2, 3, 4, 5, 6 };

int index = -1;
// Test CONTAINS list and value of i in loop
int linearSearch(List<Object> aList, Object item)
{
    foreach (Object element in aList)
    {
        index++;
        if (element.Equals(item))
        {
            return index;
        }
    }
    return -1;
}

Console.WriteLine(linearSearch(nums, 4));
Console.WriteLine(linearSearch(cars, "Ram"));

