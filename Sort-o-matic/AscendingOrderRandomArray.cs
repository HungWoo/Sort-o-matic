using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Jack Tran
/// RedID: 817117711
/// Date : 10/29/2017
/// Creates an array of elements using random in ascending order
/// </summary>
namespace Sort_o_matic
{
    /// <summary>
    /// This class will fill the array with random numbers but this time will put the numbers in the array in ascending order
    /// </summary>
    class AscendingOrderRandomArray : ArrayOfInts
    {
        /// <summary>
        /// Method is similiar to RandomArray implementation however this one uses Array class sort method to put the array in ascending order
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
            ArrayofInts = intArray;
        }
    }
}
