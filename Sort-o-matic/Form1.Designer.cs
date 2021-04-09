namespace Sort_o_matic
{
    partial class SortOmaticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ArrayElement0 = new System.Windows.Forms.Label();
            this.RandomArrayFill = new System.Windows.Forms.Button();
            this.MoveArray = new System.Windows.Forms.Timer(this.components);
            this.ArrayElement1 = new System.Windows.Forms.Label();
            this.ArrayElement2 = new System.Windows.Forms.Label();
            this.ArrayElement3 = new System.Windows.Forms.Label();
            this.ArrayElement4 = new System.Windows.Forms.Label();
            this.RandomArrayFillAscendingOrder = new System.Windows.Forms.Button();
            this.RandomArrayFillDescendingOrder = new System.Windows.Forms.Button();
            this.InstructionLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionSort = new System.Windows.Forms.Button();
            this.PlaceArray = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SortDescription = new System.Windows.Forms.TextBox();
            this.ExitApplication = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.ToolTipSort = new System.Windows.Forms.ToolTip(this.components);
            this.GnomeSort = new System.Windows.Forms.Button();
            this.ArrayElement5 = new System.Windows.Forms.Label();
            this.ArrayElement6 = new System.Windows.Forms.Label();
            this.ArrayElement7 = new System.Windows.Forms.Label();
            this.ArrayElement8 = new System.Windows.Forms.Label();
            this.ArrayElement9 = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.bubbletimer1 = new System.Windows.Forms.Timer(this.components);
            this.bubbletimer2 = new System.Windows.Forms.Timer(this.components);
            this.bubbletimer3 = new System.Windows.Forms.Timer(this.components);
            this.gnometimer1 = new System.Windows.Forms.Timer(this.components);
            this.gnometimer2 = new System.Windows.Forms.Timer(this.components);
            this.MoveElements = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrayElement0
            // 
            this.ArrayElement0.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement0.Location = new System.Drawing.Point(36, 112);
            this.ArrayElement0.Name = "ArrayElement0";
            this.ArrayElement0.Size = new System.Drawing.Size(49, 28);
            this.ArrayElement0.TabIndex = 0;
            // 
            // RandomArrayFill
            // 
            this.RandomArrayFill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomArrayFill.Location = new System.Drawing.Point(898, 88);
            this.RandomArrayFill.Name = "RandomArrayFill";
            this.RandomArrayFill.Size = new System.Drawing.Size(112, 52);
            this.RandomArrayFill.TabIndex = 1;
            this.RandomArrayFill.Text = "No Order";
            this.ToolTipSort.SetToolTip(this.RandomArrayFill, "Creates an array of numbers. Example: 99 12 22 11 56");
            this.RandomArrayFill.UseVisualStyleBackColor = true;
            this.RandomArrayFill.Click += new System.EventHandler(this.RandomArrayFill_Click);
            // 
            // MoveArray
            // 
            this.MoveArray.Interval = 3000;
            this.MoveArray.Tick += new System.EventHandler(this.MoveArray_Tick);
            // 
            // ArrayElement1
            // 
            this.ArrayElement1.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement1.Location = new System.Drawing.Point(91, 112);
            this.ArrayElement1.Name = "ArrayElement1";
            this.ArrayElement1.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement1.TabIndex = 6;
            // 
            // ArrayElement2
            // 
            this.ArrayElement2.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement2.Location = new System.Drawing.Point(140, 112);
            this.ArrayElement2.Name = "ArrayElement2";
            this.ArrayElement2.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement2.TabIndex = 7;
            // 
            // ArrayElement3
            // 
            this.ArrayElement3.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement3.Location = new System.Drawing.Point(189, 112);
            this.ArrayElement3.Name = "ArrayElement3";
            this.ArrayElement3.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement3.TabIndex = 8;
            // 
            // ArrayElement4
            // 
            this.ArrayElement4.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement4.Location = new System.Drawing.Point(238, 112);
            this.ArrayElement4.Name = "ArrayElement4";
            this.ArrayElement4.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement4.TabIndex = 9;
            // 
            // RandomArrayFillAscendingOrder
            // 
            this.RandomArrayFillAscendingOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomArrayFillAscendingOrder.Location = new System.Drawing.Point(898, 162);
            this.RandomArrayFillAscendingOrder.Name = "RandomArrayFillAscendingOrder";
            this.RandomArrayFillAscendingOrder.Size = new System.Drawing.Size(112, 52);
            this.RandomArrayFillAscendingOrder.TabIndex = 2;
            this.RandomArrayFillAscendingOrder.Text = "Ascending Order";
            this.ToolTipSort.SetToolTip(this.RandomArrayFillAscendingOrder, "Creates an array of numbers in ascending order. Example: 1 2 3 4 5 6 ");
            this.RandomArrayFillAscendingOrder.UseVisualStyleBackColor = true;
            this.RandomArrayFillAscendingOrder.Click += new System.EventHandler(this.RandomArrayFillAscendingOrder_Click);
            // 
            // RandomArrayFillDescendingOrder
            // 
            this.RandomArrayFillDescendingOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomArrayFillDescendingOrder.Location = new System.Drawing.Point(898, 238);
            this.RandomArrayFillDescendingOrder.Name = "RandomArrayFillDescendingOrder";
            this.RandomArrayFillDescendingOrder.Size = new System.Drawing.Size(112, 52);
            this.RandomArrayFillDescendingOrder.TabIndex = 3;
            this.RandomArrayFillDescendingOrder.Text = "Descending Order";
            this.ToolTipSort.SetToolTip(this.RandomArrayFillDescendingOrder, "Creates an array of numbers in descending order. Example: 5 4 3 2 1");
            this.RandomArrayFillDescendingOrder.UseVisualStyleBackColor = true;
            this.RandomArrayFillDescendingOrder.Click += new System.EventHandler(this.RandomArrayFillDescendingOrder_Click);
            // 
            // InstructionLabel1
            // 
            this.InstructionLabel1.AutoSize = true;
            this.InstructionLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel1.Location = new System.Drawing.Point(862, 44);
            this.InstructionLabel1.Name = "InstructionLabel1";
            this.InstructionLabel1.Size = new System.Drawing.Size(189, 23);
            this.InstructionLabel1.TabIndex = 14;
            this.InstructionLabel1.Text = "Create Random Array";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sorting Options";
            // 
            // SelectionSort
            // 
            this.SelectionSort.Enabled = false;
            this.SelectionSort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionSort.Location = new System.Drawing.Point(41, 338);
            this.SelectionSort.Name = "SelectionSort";
            this.SelectionSort.Size = new System.Drawing.Size(112, 52);
            this.SelectionSort.TabIndex = 4;
            this.SelectionSort.Text = "Selection Sort";
            this.ToolTipSort.SetToolTip(this.SelectionSort, "Selection Sort scans the array of numbers to find the smallest number and places " +
        "it to the left most position. It repeats this process for the next position afte" +
        "r.");
            this.SelectionSort.UseVisualStyleBackColor = true;
            this.SelectionSort.Click += new System.EventHandler(this.SelectionSort_Click);
            // 
            // PlaceArray
            // 
            this.PlaceArray.Interval = 500;
            this.PlaceArray.Tick += new System.EventHandler(this.PlaceArray_Tick);
            // 
            // SortDescription
            // 
            this.SortDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SortDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SortDescription.Enabled = false;
            this.SortDescription.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortDescription.ForeColor = System.Drawing.Color.Black;
            this.SortDescription.Location = new System.Drawing.Point(41, 33);
            this.SortDescription.Multiline = true;
            this.SortDescription.Name = "SortDescription";
            this.SortDescription.ReadOnly = true;
            this.SortDescription.Size = new System.Drawing.Size(506, 46);
            this.SortDescription.TabIndex = 0;
            this.SortDescription.Text = "Select a type of array you want to create";
            // 
            // ExitApplication
            // 
            this.ExitApplication.AutoSize = true;
            this.ExitApplication.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitApplication.Location = new System.Drawing.Point(898, 338);
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(112, 52);
            this.ExitApplication.TabIndex = 7;
            this.ExitApplication.Text = "Close Program";
            this.ToolTipSort.SetToolTip(this.ExitApplication, "Shut Down Program");
            this.ExitApplication.UseVisualStyleBackColor = true;
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Enabled = false;
            this.BubbleSort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubbleSort.Location = new System.Drawing.Point(194, 338);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(112, 52);
            this.BubbleSort.TabIndex = 5;
            this.BubbleSort.Text = "Bubble Sort";
            this.ToolTipSort.SetToolTip(this.BubbleSort, "Bubble sort compares two adjacent numbers and swaps them if they are out of order" +
        ". \r\nThis sort goes left to right.");
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // ToolTipSort
            // 
            this.ToolTipSort.ShowAlways = true;
            // 
            // GnomeSort
            // 
            this.GnomeSort.Enabled = false;
            this.GnomeSort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GnomeSort.Location = new System.Drawing.Point(352, 338);
            this.GnomeSort.Name = "GnomeSort";
            this.GnomeSort.Size = new System.Drawing.Size(112, 52);
            this.GnomeSort.TabIndex = 6;
            this.GnomeSort.Text = "Gnome Sort";
            this.ToolTipSort.SetToolTip(this.GnomeSort, "Gnome Sort bounces back and forth in an array comparing two adjacent numbers toge" +
        "ther and swapping if necessary.");
            this.GnomeSort.UseVisualStyleBackColor = true;
            this.GnomeSort.Click += new System.EventHandler(this.GnomeSort_Click);
            // 
            // ArrayElement5
            // 
            this.ArrayElement5.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement5.Location = new System.Drawing.Point(311, 112);
            this.ArrayElement5.Name = "ArrayElement5";
            this.ArrayElement5.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement5.TabIndex = 22;
            // 
            // ArrayElement6
            // 
            this.ArrayElement6.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement6.Location = new System.Drawing.Point(366, 112);
            this.ArrayElement6.Name = "ArrayElement6";
            this.ArrayElement6.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement6.TabIndex = 23;
            // 
            // ArrayElement7
            // 
            this.ArrayElement7.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement7.Location = new System.Drawing.Point(421, 112);
            this.ArrayElement7.Name = "ArrayElement7";
            this.ArrayElement7.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement7.TabIndex = 24;
            // 
            // ArrayElement8
            // 
            this.ArrayElement8.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement8.Location = new System.Drawing.Point(476, 112);
            this.ArrayElement8.Name = "ArrayElement8";
            this.ArrayElement8.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement8.TabIndex = 25;
            // 
            // ArrayElement9
            // 
            this.ArrayElement9.BackColor = System.Drawing.Color.Transparent;
            this.ArrayElement9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayElement9.Location = new System.Drawing.Point(531, 112);
            this.ArrayElement9.Name = "ArrayElement9";
            this.ArrayElement9.Size = new System.Drawing.Size(43, 28);
            this.ArrayElement9.TabIndex = 26;
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDescrip.Enabled = false;
            this.textBoxDescrip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrip.ForeColor = System.Drawing.Color.Black;
            this.textBoxDescrip.Location = new System.Drawing.Point(628, 88);
            this.textBoxDescrip.Multiline = true;
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.ReadOnly = true;
            this.textBoxDescrip.Size = new System.Drawing.Size(239, 302);
            this.textBoxDescrip.TabIndex = 0;
            this.textBoxDescrip.Text = "Please choose to create an array followed by choosing a sorting algorithm in orde" +
    "r to start the sorting animation.";
            // 
            // bubbletimer1
            // 
            this.bubbletimer1.Interval = 500;
            this.bubbletimer1.Tick += new System.EventHandler(this.bubbletimer1_Tick);
            // 
            // bubbletimer2
            // 
            this.bubbletimer2.Interval = 700;
            this.bubbletimer2.Tick += new System.EventHandler(this.bubbletimer2_Tick);
            // 
            // bubbletimer3
            // 
            this.bubbletimer3.Interval = 600;
            this.bubbletimer3.Tick += new System.EventHandler(this.bubbletimer3_Tick);
            // 
            // gnometimer1
            // 
            this.gnometimer1.Interval = 1500;
            this.gnometimer1.Tick += new System.EventHandler(this.gnometimer1_Tick);
            // 
            // gnometimer2
            // 
            this.gnometimer2.Interval = 500;
            this.gnometimer2.Tick += new System.EventHandler(this.gnometimer2_Tick);
            // 
            // MoveElements
            // 
            this.MoveElements.Interval = 1500;
            this.MoveElements.Tick += new System.EventHandler(this.MoveElements_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Swap Position";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sorted";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Compare Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Color Key :";
            // 
            // SortOmaticForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1066, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GnomeSort);
            this.Controls.Add(this.textBoxDescrip);
            this.Controls.Add(this.ArrayElement9);
            this.Controls.Add(this.ArrayElement8);
            this.Controls.Add(this.ArrayElement7);
            this.Controls.Add(this.ArrayElement6);
            this.Controls.Add(this.ArrayElement5);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.ExitApplication);
            this.Controls.Add(this.SortDescription);
            this.Controls.Add(this.SelectionSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InstructionLabel1);
            this.Controls.Add(this.RandomArrayFillDescendingOrder);
            this.Controls.Add(this.RandomArrayFillAscendingOrder);
            this.Controls.Add(this.ArrayElement4);
            this.Controls.Add(this.ArrayElement3);
            this.Controls.Add(this.ArrayElement2);
            this.Controls.Add(this.ArrayElement1);
            this.Controls.Add(this.RandomArrayFill);
            this.Controls.Add(this.ArrayElement0);
            this.MinimumSize = new System.Drawing.Size(1082, 488);
            this.Name = "SortOmaticForm";
            this.Text = "Sort-O-Matic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArrayElement0;
        private System.Windows.Forms.Button RandomArrayFill;
        private System.Windows.Forms.Timer MoveArray;
        private System.Windows.Forms.Label ArrayElement1;
        private System.Windows.Forms.Label ArrayElement2;
        private System.Windows.Forms.Label ArrayElement3;
        private System.Windows.Forms.Label ArrayElement4;
        private System.Windows.Forms.Button RandomArrayFillAscendingOrder;
        private System.Windows.Forms.Button RandomArrayFillDescendingOrder;
        private System.Windows.Forms.Label InstructionLabel1;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectionSort;
        private System.Windows.Forms.Timer PlaceArray;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ExitApplication;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.ToolTip ToolTipSort;
        private System.Windows.Forms.Label ArrayElement5;
        private System.Windows.Forms.Label ArrayElement6;
        private System.Windows.Forms.Label ArrayElement7;
        private System.Windows.Forms.Label ArrayElement8;
        private System.Windows.Forms.Label ArrayElement9;
        private System.Windows.Forms.Timer bubbletimer1;
        private System.Windows.Forms.Timer bubbletimer2;
        private System.Windows.Forms.Timer bubbletimer3;
        private System.Windows.Forms.Button GnomeSort;
        private System.Windows.Forms.Timer gnometimer1;
        private System.Windows.Forms.Timer gnometimer2;
        private System.Windows.Forms.Timer MoveElements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SortDescription;
        private System.Windows.Forms.TextBox textBoxDescrip;
    }
}

