using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Jack Tran
/// RedID: 817117711
/// Date : 10/29/2017
/// Creates an array of elements using random in descending order
/// </summary>
namespace Sort_o_matic
{
    /// <summary>
    /// This class will implment the fill array with random numbers however it will put the number in descending order
    /// </summary>
    class DescendingOrderRandomArray : ArrayOfInts
    {
        /// <summary>
        /// Similiar method to the ascending and random array FillArray methods however it reverses the sorted array and puts it into descending order
        /// </summary>
        public override void FillArray()
        {
            var random = new Random();
            var intArray = new int[10];

            for (var i = 0; i < 10; i++)
            {
                intArray[i] = random.Next(0, 100);
            }

            Array.Sort(intArray);
            Array.Reverse(intArray);

            ArrayofInts = intArray;
        }
    }
}
