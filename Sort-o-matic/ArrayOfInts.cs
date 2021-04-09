using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Jack Tran
/// RedID: 817117711
/// Date : 10/29/2017
/// Top level class to tell the other derived classes to have all these elements
/// </summary>
namespace Sort_o_matic
{
    /// <summary>
    /// This abstract class will be the base of the three random array classes to determine which type of random to use for creating a random array for the program.
    /// Tells the other classes to have its own implementation of FillArray , ToString, And CompareTo
    /// </summary>
    public abstract class ArrayOfInts 
    {
        /// <summary>
        /// Array contains an array of ints created by its subclass
        /// </summary>
        public int[] ArrayofInts { get; set; }
        /// <summary>
        /// Uses a random number generator and fills the array until it is full
        /// </summary>
        public abstract void FillArray();
        /// <summary>
        /// ToString for printing out the values in array
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{ArrayofInts[0]}, {ArrayofInts[1]}, {ArrayofInts[2]}, {ArrayofInts[3]}, {ArrayofInts[4]}";
    }
}
