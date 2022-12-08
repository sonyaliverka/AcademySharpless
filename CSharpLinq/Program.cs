using static System.Formats.Asn1.AsnWriter;

#region {Task_1}
double[] nums = { 3, 15, 8, 43, 2, 9, 10, 72, 4, 1};

IEnumerable<double> result =
    from num in nums
    where num   %3==0
    orderby num
    select num;

foreach (double number in result)
{
    Console.Write(number + " ");
}
#endregion

#region {Task_2}
double[] num = { -7, 15, 8, -11, 7, -9, 10, -13, -10, 14 };

#endregion