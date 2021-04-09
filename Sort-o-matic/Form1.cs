using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

/// <summary>
/// Name: Jack Tran
/// RedID: 817117711
/// Date : 10/29/2017
/// </summary>
namespace Sort_o_matic
{
    /// <summary>
    /// This partial class deals with all the windows form behind the scenes methods for the buttons, labels, etc
    /// </summary>
    public partial class SortOmaticForm : Form
    {
        /// <summary>
        /// This array holds the labels that displays the array and will be edited to mirror what the array looks like for movement purposes
        /// </summary>
        private readonly Label[] _arrayoflabels = new Label[10];
        /// <summary>
        /// variables here for the sorting process to use as reference to the array index to swap and i and j for using timers as loop
        /// </summary>
        private int _firstnum, _secondnum , _i = 0, _j = 0;
        /// <summary>
        /// size of the arrayofint and array of label used for sorting algorithm calculations and y coord for the labels
        /// </summary>
        private const int size = 10, _y = 112;
        /// <summary>
        /// creates a global array for the button methods to use for creating an array and sorting the array w/ downcasting
        /// </summary>
        private ArrayOfInts _numbertoDisplay;

        public SortOmaticForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button will create a class that will create an array of random int in no order everytime the button is clicked
        /// Also will assign each label to each element of the array by converting the ints to strings
        /// will assign those labels to an array of controls for easier access to the specific elements to treat as an array of ints for sorting
        /// each time the button is pressed it will put the labels back to its place for the next sorting algorithm to run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomArrayFill_Click(object sender, EventArgs e)
        {
            _numbertoDisplay = new RandomArray();
            _numbertoDisplay.FillArray();
            ConvertArrayToLabel();
            ResetLabelArrayPosition();
            ResetLabelColor();
            SortDescription.Clear();
            SortDescription.Text = Convert.ToString("Select a Sorting Algorithm");
            EnableSortButton();
            TimerReset();
        }
        /// <summary>
        /// This button will create a class that will create an array of random ints in ascending order everytime the button is clicked
        /// assigns the labels to elements of the array by converting the ints to strings
        /// will assign those labels to an array of controls for easier access to the specific elements to treat as an array of ints for sorting
        /// each time the button is pressed it will put the labels back to its place for the next sorting algorithm to run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomArrayFillAscendingOrder_Click(object sender, EventArgs e)
        {
            _numbertoDisplay = new AscendingOrderRandomArray();
            _numbertoDisplay.FillArray();
            ConvertArrayToLabel();
            ResetLabelArrayPosition();
            ResetLabelColor();
            SortDescription.Clear();
            SortDescription.Text = Convert.ToString("Select a Sorting Algorithm");
            EnableSortButton();
            TimerReset();
        }

        /// <summary>
        /// This button will create a class that will create an array of random ints in descending order everytime the button is clicked
        /// assigns the labels to elements of the array by converting the ints to strings
        /// will assign those labels to an array of controls for easier access to the specific elements to treat as an array of ints for sorting
        /// each time the button is pressed it will put the labels back to its place for the next sorting algorithm to run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomArrayFillDescendingOrder_Click(object sender, EventArgs e)
        {
            _numbertoDisplay = new DescendingOrderRandomArray();
            _numbertoDisplay.FillArray();
            ConvertArrayToLabel();
            ResetLabelArrayPosition();
            ResetLabelColor();
            SortDescription.Clear();
            SortDescription.Text = Convert.ToString("Select a Sorting Algorithm");
            EnableSortButton();
            TimerReset();
        }
        /// <summary>
        /// resets the timer intervals for the sorts so that the first iteration would respond faster
        /// </summary>
        private void TimerReset()
        {
            bubbletimer1.Interval = 500;
            gnometimer1.Interval = 500;
        }
        /// <summary>
        /// Enables the create array buttons
        /// </summary>
        private void EnableCreationButton()
        {
            RandomArrayFill.Enabled = true;
            RandomArrayFillAscendingOrder.Enabled = true;
            RandomArrayFillDescendingOrder.Enabled = true;
        }

        private void EnableSortButton()
        {
            SelectionSort.Enabled = true;
            BubbleSort.Enabled = true;
            GnomeSort.Enabled = true;
        }
        /// <summary>
        /// Resets the Array position back to what it was for making another array for sorting
        /// </summary>
        private void ResetLabelArrayPosition()
        {
            _i = 0;
            _j = 0;
            _arrayoflabels[0].Location = new Point(36, _y);
            _arrayoflabels[1].Location = new Point(91, _y);
            _arrayoflabels[2].Location = new Point(146, _y);
            _arrayoflabels[3].Location = new Point(201, _y);
            _arrayoflabels[4].Location = new Point(256, _y);
            _arrayoflabels[5].Location = new Point(311, _y);
            _arrayoflabels[6].Location = new Point(366, _y);
            _arrayoflabels[7].Location = new Point(421, _y);
            _arrayoflabels[8].Location = new Point(476, _y);
            _arrayoflabels[9].Location = new Point(531, _y);
        }
        /// <summary>
        /// resets the label background color back to its original form and resets the description box
        /// </summary>
        private void ResetLabelColor()
        {
            _arrayoflabels[0].BackColor = Color.Transparent;
            _arrayoflabels[1].BackColor = Color.Transparent;
            _arrayoflabels[2].BackColor = Color.Transparent;
            _arrayoflabels[3].BackColor = Color.Transparent;
            _arrayoflabels[4].BackColor = Color.Transparent;
            _arrayoflabels[5].BackColor = Color.Transparent;
            _arrayoflabels[6].BackColor = Color.Transparent;
            _arrayoflabels[7].BackColor = Color.Transparent;
            _arrayoflabels[8].BackColor = Color.Transparent;
            _arrayoflabels[9].BackColor = Color.Transparent;
            textBoxDescrip.Clear();
        }
        /// <summary>
        /// Converts the arrayofints elements into the labels and puts the label into an array of labels for dynamic access during sort
        /// </summary>
        private void ConvertArrayToLabel()
        {
            ArrayElement0.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[0]);
            ArrayElement1.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[1]);
            ArrayElement2.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[2]);
            ArrayElement3.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[3]);
            ArrayElement4.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[4]);
            ArrayElement5.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[5]);
            ArrayElement6.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[6]);
            ArrayElement7.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[7]);
            ArrayElement8.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[8]);
            ArrayElement9.Text = Convert.ToString(_numbertoDisplay.ArrayofInts[9]);
            _arrayoflabels[0] = ArrayElement0;
            _arrayoflabels[1] = ArrayElement1;
            _arrayoflabels[2] = ArrayElement2;
            _arrayoflabels[3] = ArrayElement3;
            _arrayoflabels[4] = ArrayElement4;
            _arrayoflabels[5] = ArrayElement5;
            _arrayoflabels[6] = ArrayElement6;
            _arrayoflabels[7] = ArrayElement7;
            _arrayoflabels[8] = ArrayElement8;
            _arrayoflabels[9] = ArrayElement9;
        }
        /// <summary>
        /// exits the program with a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Selection Sort button will do selection sort and call timer for animations of the labels using the label of arrays
        /// First this button will disable all the other buttons before performing its task and then enables the other buttons after it finishes its task
        /// This button will be default be greyed out until a new array is created by the random array creation buttons
        /// calls timers in order to deal with the animation of labels
        /// this will edit the position of the array in both the arrayofint and the label array to match each other for the timers to easily move the labels to its correct new position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionSort_Click(object sender, EventArgs e)
        {
            //grey out the other buttons
            RandomArrayFill.Enabled = false;
            RandomArrayFillAscendingOrder.Enabled = false;
            RandomArrayFillDescendingOrder.Enabled = false;
            SelectionSort.Enabled = false;
            BubbleSort.Enabled = false;
            GnomeSort.Enabled = false;
            textBoxDescrip.Clear();
            textBoxDescrip.Visible = true;
            textBoxDescrip.Text = Convert.ToString("Selection Sort scans the array to find the smallest number then swaps that number with the left most number. Then it will move that number down because that number is the smallest compared to the rest so theres no use to check it anymore. It repeats this method with the next number over until it has the array in order.");
            SortDescription.Clear();
            SortDescription.Text = Convert.ToString("Selection Sort in Progress");
            MoveArray.Start();
        }
        /// <summary>
        /// This is the first part of a two part timer for selection sorting algorithm
        /// This has the algorithm of the selection sort found on http://cforbeginners.com/CSharp/SelectionSort.html
        /// Each time the timer gets ticked the timer will run through 1 illeration of the loop until the size of array is reached meaning the array is in order
        /// 1 illeration the code will find the smallest number then swaps its position in the array with the number to the left most position and repeats with the next number over
        /// the swapped number will never be swapped again because the swapped number is smaller compared to the rest of the number left in the array
        /// I have the delay long enough for the user to see that the array is being swapped around with lowest number right to the left most position and then calls a 500ms timer to highlight the number and move it to show that it is in place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveArray_Tick(object sender, EventArgs e)
        {           
            if (_i < size)
            {
                MoveArray.Interval = (3000 - (_i * 100));
                int min = 0, tmp = 0;
                min = _i;
                for (var j = _i; j < size; j++)
                {
                    if (_numbertoDisplay.ArrayofInts[j] < _numbertoDisplay.ArrayofInts[min])
                    {
                        min = j;
                    }
                }
                _firstnum = min;
                _secondnum = _i;
                _arrayoflabels[_firstnum].BackColor = Color.HotPink;
                tmp = _numbertoDisplay.ArrayofInts[_i];
                _numbertoDisplay.ArrayofInts[_i] = _numbertoDisplay.ArrayofInts[min];
                _numbertoDisplay.ArrayofInts[min] = tmp;
                MoveElements.Start();
            }
            else
            {
                SortDescription.Clear();
                SortDescription.Text = Convert.ToString("Select a type of array you want to create");
                EnableCreationButton();
                SelectionSort.Enabled = false;
                MoveArray.Stop();
            }
            _i++;
        }
        /// <summary>
        /// this timer creations an animation by reassiging the labels their new values after this timer is enabled in the previous timer
        /// This will highlight current leftmost position of the array after assigning the label also disables the previous highlight to make it look like the smallest current number is moving to the left most position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveElements_Tick(object sender, EventArgs e)
        {
            _arrayoflabels[_firstnum].BackColor = Color.Transparent;
            _arrayoflabels[_secondnum].BackColor = Color.HotPink;
            ConvertArrayToLabel();
            PlaceArray.Start();
            MoveElements.Stop();
        }
        /// <summary>
        /// This is part 3 of the two part timer animation which takes place after the numbers has changed it position to move the smallest number in the array down into its own array to show the user that this number is currently in its right position 
        /// this timer will not be continuously ran with the 1st timer instead it runs only once then turns itself off until it is called again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlaceArray_Tick(object sender, EventArgs e)
        {
            if (_i <= size)
            {
                _arrayoflabels[_secondnum].BackColor = Color.Transparent;
                _arrayoflabels[_i-1].Location = new Point(_arrayoflabels[_i-1].Location.X, _y + 70);
                _arrayoflabels[_i-1].BackColor = Color.Aquamarine;
            }
            PlaceArray.Stop();
        }
        /// <summary>
        /// Bubble Sort button when pressed will disable all the buttons then begins its sorting process by changing the text in the text boxes to match the sorting algorithm selection and start up the bubble sort timers
        /// algorithm for the the bubbletimers is found on https://cathyatseneca.github.io/DSAnim/web/bubble.html
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BubbleSort_Click(object sender, EventArgs e)
        {
            RandomArrayFill.Enabled = false;
            RandomArrayFillAscendingOrder.Enabled = false;
            RandomArrayFillDescendingOrder.Enabled = false;
            SelectionSort.Enabled = false;
            BubbleSort.Enabled = false;
            GnomeSort.Enabled = false;
            textBoxDescrip.Clear();
            textBoxDescrip.Visible = true;
            textBoxDescrip.Text = Convert.ToString("Bubble Sort compares two adjacent numbers in the array and swaps the them if they are in the wrong order. This will pass through the array multiple times until no swap is needed.");
            SortDescription.Clear();
            SortDescription.Text = Convert.ToString("Bubble Sort in Progress");
            bubbletimer1.Start();
        }

        /// <summary>
        /// This bubbletimer1 will act as a loop by incrementing _i every initial 500 ticks and later ticks being [(bubbletimer2 ticks * 10) - (_i * bubbletimer2 ticks)] or else the delay would be too long after a couple of iterations of this timer being ran
        /// this timer will call the second timer to start processing the array
        /// When _i is less than array size it will continually call bubbletimer2 to scan the array and make swaps and assigns _j = 0 for that timer to check the array from the beginning of the array
        /// when _i is equal to the size we know the sorting is done and that this else-if statement exist to properly put the label in place to be in line with the others
        /// when _i is greater than size means this timer will now disable itself and enable the other buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bubbletimer1_Tick(object sender, EventArgs e)
        {
            if (_i == 0)//assign the interval to 4750  because the bubbletimer1 initial tick count is 500 to lower the first sorting delay
            {
                bubbletimer1.Interval = (bubbletimer2.Interval *10 + 250);

            }
            if (_i < size )
            {
                _j = 0;
                if (_i > 0)
                {
                    _arrayoflabels[size - _i].BackColor = Color.Aquamarine;
                    _arrayoflabels[size - _i].Location = new Point(_arrayoflabels[size - _i].Location.X, _y + 70);
                }
                bubbletimer2.Start();
                bubbletimer1.Interval = ((bubbletimer2.Interval * 10 + 250) - (_i * bubbletimer2.Interval));//decrement total timer according how many array spots are left to be put into position
            }
            else if (_i == size)
            {
                _arrayoflabels[0].BackColor = Color.Aquamarine;
                _arrayoflabels[0].Location = new Point(_arrayoflabels[size - _i].Location.X, _y + 70);
            }
            else if(_i > size)
            {
                SortDescription.Clear();
                SortDescription.Text = Convert.ToString("Select a type of array you want to create");
                EnableCreationButton();
                SelectionSort.Enabled = false;
                BubbleSort.Enabled = false;
                GnomeSort.Enabled = false;
                bubbletimer1.Stop();

            }            
            ++_i;
        }
        /// <summary>
        /// bubbletimer2 runs every 700 ticks to go through the array to check for any number out of order then it will highlight which numbers to swap and call bubbletimer3 which with animation for swapping numbers
        /// bubbletimer2 assist bubbletimer3 in animation by changing the real array and enabling the label colors coresponding to which array position it is changing
        /// bubbletimer2 runs at 700 ticks and bubbletimer3 runs at 300 ticks so the 400 ticks inbetween creates an animation like swap by utilizing the label back color changes
        /// this timer continuously runs until it scans through the entire array by checking _j to the size of the array and or left over array numbers to check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bubbletimer2_Tick(object sender, EventArgs e)
        {
            if (_j < (size - _i))
            {
                _firstnum = _j;
                _secondnum = _j + 1;
                _arrayoflabels[_firstnum].BackColor = Color.GreenYellow;
                _arrayoflabels[_secondnum].BackColor = Color.GreenYellow;
                if (_numbertoDisplay.ArrayofInts[_j] > _numbertoDisplay.ArrayofInts[_j + 1])
                {
                    //had to assign these values to some global variable for timer3 to process its color config, using _j and _j+1 in timer3 causes a out of index error due timer overlap issues
                    //_firstnum = _j;
                    //_secondnum = _j + 1;             
                    _arrayoflabels[_firstnum].BackColor = Color.HotPink;
                    _arrayoflabels[_secondnum].BackColor = Color.HotPink;

                    var tmp = _numbertoDisplay.ArrayofInts[_j];
                    _numbertoDisplay.ArrayofInts[_j] = _numbertoDisplay.ArrayofInts[_j + 1];
                    _numbertoDisplay.ArrayofInts[_j + 1] = tmp;
                    //bubbletimer3.Start();
                }
                bubbletimer3.Start();
            }
            else
            {
                bubbletimer2.Stop();
            }

            _j++;
        }
        /// <summary>
        /// This bubbletimer3 will create an animation by reassigning the labels to equal the array that is actually being sorted and puts the label color back to default for the ones that were affected
        /// it creates an animation like swap because it runs every 300 ticks it gets called by bubbletimer2 and it disables itself means it only runs once every call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bubbletimer3_Tick(object sender, EventArgs e)
        {
            ConvertArrayToLabel();
            _arrayoflabels[_firstnum].BackColor = Color.Transparent;
            _arrayoflabels[_secondnum].BackColor = Color.Transparent;
            bubbletimer3.Stop();
        }
        /// <summary>
        /// GnomeSort button will disable all the other buttons change the text boxes to match its algorithm and then assigns _i = 1 and calls the timer to begin the sort
        /// _i must be 1 before the sorting begins because the algorithm checks the array by using the _i index and _i -1 index and if _i = 0 still then there would be an error
        /// https://www.programmingalgorithms.com/algorithm/gnome-sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GnomeSort_Click(object sender, EventArgs e)
        {
            RandomArrayFill.Enabled = false;
            RandomArrayFillAscendingOrder.Enabled = false;
            RandomArrayFillDescendingOrder.Enabled = false;
            SelectionSort.Enabled = false;
            BubbleSort.Enabled = false;
            GnomeSort.Enabled = false;
            textBoxDescrip.Clear();
            textBoxDescrip.Visible = true;
            textBoxDescrip.Text = Convert.ToString("Gnome sort or Stupid sort goes through the array of numbers and moves the elements to its proper place using a series of swaps.");
            SortDescription.Clear();
            SortDescription.Text = Convert.ToString("Gnome Sort in Progress");
            _i = 1;
            gnometimer1.Start();
        }
        /// <summary>
        /// This timer will act as a loop for the gnome sorting algorithm
        /// The method will use GreenYellow to show the algorithm scanning through an array because unlike the other two sort this one jumps around in the array rather than start left to right scan
        /// When a swap is necesarry the method changes the label color to red to show that those two numbers are being sorted
        /// We call the second timer within the timer loop in order to turn the label back color back to its transparent default self to create an illusion of animation of the array jumping back and forth and swapping the numbers
        /// When _i exceedes the array size the sort has officially ended so it enables the creation array buttons and turns off all the sorting buttons also it will make the labels green to show that the array is green due to gnome sort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gnometimer1_Tick(object sender, EventArgs e)
        {
            if (_i < size)
            {
                _firstnum = _i - 1;
                _secondnum = _i;
                _arrayoflabels[_firstnum].BackColor = Color.GreenYellow;
                _arrayoflabels[_secondnum].BackColor = Color.GreenYellow;
                if (_numbertoDisplay.ArrayofInts[_i - 1] <= _numbertoDisplay.ArrayofInts[_i])
                {
                    _i++;                  
                }
                else
                {
                    _arrayoflabels[_firstnum].BackColor = Color.HotPink;
                    _arrayoflabels[_secondnum].BackColor = Color.HotPink;
                    var tmp = _numbertoDisplay.ArrayofInts[_i];
                    _numbertoDisplay.ArrayofInts[_i] = _numbertoDisplay.ArrayofInts[_i - 1];
                    _numbertoDisplay.ArrayofInts[_i - 1] = tmp;
                    _i--;
                    if (_i == 0)
                    {
                        _i = 1;
                    }
                }
                gnometimer2.Start();
            }
            else
            {
                TurnLabelGreen();
                SortDescription.Clear();
                SortDescription.Text = Convert.ToString("Select a type of array you want to create");
                EnableCreationButton();
                SelectionSort.Enabled = false;
                BubbleSort.Enabled = false;
                GnomeSort.Enabled = false;
                gnometimer1.Stop();
            }
        }

        /// <summary>
        /// This method will take the two indexes of the colors that are currently changed and reverts it back to its transparent background color then refill the labels to make an animation like swap then stops itself from running again until it is called on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gnometimer2_Tick(object sender, EventArgs e)
        {
            _arrayoflabels[_firstnum].BackColor = Color.Transparent;
            _arrayoflabels[_secondnum].BackColor = Color.Transparent;
            ConvertArrayToLabel();
            gnometimer2.Stop();
        }
        /// <summary>
        /// Method to turning all the labels background color to being Aquamarine and moves the labels down to show that the array is sorted
        /// </summary>
        private void TurnLabelGreen()
        {
            _arrayoflabels[0].BackColor = Color.Aquamarine;
            _arrayoflabels[1].BackColor = Color.Aquamarine;
            _arrayoflabels[2].BackColor = Color.Aquamarine;
            _arrayoflabels[3].BackColor = Color.Aquamarine;
            _arrayoflabels[4].BackColor = Color.Aquamarine;
            _arrayoflabels[5].BackColor = Color.Aquamarine;
            _arrayoflabels[6].BackColor = Color.Aquamarine;
            _arrayoflabels[7].BackColor = Color.Aquamarine;
            _arrayoflabels[8].BackColor = Color.Aquamarine;
            _arrayoflabels[9].BackColor = Color.Aquamarine;
            _arrayoflabels[0].Location = new Point(36, _y + 70);
            _arrayoflabels[1].Location = new Point(91, _y + 70);
            _arrayoflabels[2].Location = new Point(146, _y + 70);
            _arrayoflabels[3].Location = new Point(201, _y + 70);
            _arrayoflabels[4].Location = new Point(256, _y + 70);
            _arrayoflabels[5].Location = new Point(311, _y + 70);
            _arrayoflabels[6].Location = new Point(366, _y + 70);
            _arrayoflabels[7].Location = new Point(421, _y + 70);
            _arrayoflabels[8].Location = new Point(476, _y + 70);
            _arrayoflabels[9].Location = new Point(531, _y + 70);
        }
    }
}
