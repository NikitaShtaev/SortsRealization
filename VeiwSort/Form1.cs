using SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VeiwSort
{
    public partial class SortView : Form
    {
        private List<int> Collection { get; set; }
        private List<System.Windows.Forms.Label> PrefubCollection { get; set; }
        private int PosX { get; set; }
        private int DeltaPosX { get; set; } = 26;
        private int DeltaPosY { get; set; } = 20;
        private int PosY { get; set; }
        private int Count { get; set; }
        private bool IsBig { get; set; }
        public SortView()
        {
            InitializeComponent();
            Collection = new List<int>();
            PrefubCollection = new List<System.Windows.Forms.Label>();
            Count = 0;
            PosX = 0;
            PosY = -DeltaPosY;
            SortDatarichTextBox.Text = "If you add more than 10000 elements\n" +
                "some sorts will not work and \nthere will not be graphical elements on right side\n" +
                "if there are more than 1000 elements.";
        }
        private void AddValues_Click(object sender, EventArgs e)
        {
            SortDatarichTextBox.Text = "";
            if (Int32.TryParse(QuantityTextBox.Text, out int result))
            {
                if (result > 1000)
                {
                    IsBig = true;
                    GetForBigCollection(result);
                    foreach (var item in PrefubCollection)
                    {
                        item.Text = "";
                    }
                }
                else
                {
                    IsBig = false;
                    AddItems(result);
                }
                
            }
            else
            {
                QuantityTextBox.Text = "";
            }
            QuantityTextBox.Text = "";
        }
        private void GetForBigCollection(int result)
        {
            var rnd = new Random();
            int value;
            var newCollection = new List<int>();
            for (int i = 0; i < result; i++)
            {
                value = rnd.Next(0, 10000000);
                newCollection.Add(value);
            }
            Collection.AddRange(newCollection);
        }
        private void AddItems(int result)
        {
            var rnd = new Random();
            int value;
            var newCollection = new List<int>();
            for (int i = 0; i < result; i++)
            {
                value = rnd.Next(10, 99);
                newCollection.Add(value);
            }
            Collection.AddRange(newCollection);
            var newPrefubs = AddLabels(newCollection);
            PrefubCollection.AddRange(newPrefubs);
        }
        private List<System.Windows.Forms.Label> AddLabels(List<int> collection)
        {
            var newPrefubs = new List<System.Windows.Forms.Label>();
            foreach (var item in collection)
            {
                if (Count % 35 == 0)
                {
                    PosX = 0;
                    PosY += DeltaPosY;
                }
                var labelValue = new System.Windows.Forms.Label();
                labelValue.AutoSize = true;
                labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelValue.Location = new System.Drawing.Point(3 + PosX, 3 + PosY);
                labelValue.Name = "SortValue" + Count;
                labelValue.Size = new System.Drawing.Size(33, 37);
                labelValue.TabIndex = Collection.Count;
                labelValue.Text = item.ToString();
                labelValue.BackColor = Color.Aquamarine;
                labelValue.AutoSize = true;
                newPrefubs.Add(labelValue);
                panel3.Controls.Add(labelValue);
                Count++;
                PosX += DeltaPosX;
            }
            return newPrefubs;
        }
        private void ChangeValuesAfterSort(List<int> newValues)
        {
            for (int i = 0; i < Count; i++)
            {
                PrefubCollection[i].Text = newValues[i].ToString();
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SortDatarichTextBox.Text = "";
            Collection.Clear();
            foreach (var item in PrefubCollection)
            {
                item.Text = "";
            }
            PrefubCollection.Clear();
            Count = 0;
            PosX = 0;
            PosY = -DeltaPosY;
            BubbleLabel.Text = "Time: ";
            SelectionLabel.Text = "Time: ";
            CocktailLabel.Text = "Time: ";
            GnomeLabel.Text = "Time: ";
            HeapLabel.Text = "Time: ";
            InsertionLabel.Text = "Time: ";
            LSDLabel.Text = "Time: ";
            MSDLabel.Text = "Time: ";
            MergeLabel.Text = "Time: ";
            QuickLabel.Text = "Time: ";
            ShellLabel.Text = "Time: ";
            TreeLabel.Text = "Time: ";
        }
        private void DisplayInfoFromSort(BaseAlgorithm<int> sort)
        {
            SortDatarichTextBox.Text = $"Time: {sort.Time};";
            SortDatarichTextBox.Text += $"\nCount: { sort.Items.Count};";
            SortDatarichTextBox.Text += $"\nSwapCount: { sort.SwapCount};";
            SortDatarichTextBox.Text += $"\nCompareCount: { sort.CompareCount};";
            if(IsBig)
            {
                ChangeValuesAfterSort(sort.Items);
            }  
        }
        private void BubbleSort_Click(object sender, EventArgs e)
        {
            if (Collection.Count < 10001)
            {
                BubbleLabel.Text = "Time: ";
                var bubble = new BubbleSort<int>(Collection, "BubbleSort");
                bubble.Sort();
                DisplayInfoFromSort(bubble);
                BubbleLabel.Text += bubble.Time.ToString();
            }
            else
            {
                BubbleLabel.Text = "To much for it ...";
            }
        }

        private void SelectionSortButton_Click(object sender, EventArgs e)
        {
            if (Collection.Count < 10001)
            {
                SelectionLabel.Text = "Time: ";
                var selection = new SelectionSort<int>(Collection, "SelectionSort");
                selection.Sort();
                DisplayInfoFromSort(selection);
                SelectionLabel.Text += selection.Time.ToString();
            }
            else
            {
                SelectionLabel.Text = "To much for it ...";
            }
        }

        private void CocktailSortButton_Click(object sender, EventArgs e)
        {
            if (Collection.Count < 10001)
            {
                CocktailLabel.Text = "Time: ";
                var cocktail = new CocktailSort<int>(Collection, "CocktailSort");
                cocktail.Sort();
                DisplayInfoFromSort(cocktail);
                CocktailLabel.Text += cocktail.Time.ToString();
            }
            else 
            {
                CocktailLabel.Text = "To much for it ...";
            }
        }

        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            if (Collection.Count < 10001)
            {
                GnomeLabel.Text = "Time: ";
                var Gnome = new GnomeSort<int>(Collection, "GnomeSort");
                Gnome.Sort();
                DisplayInfoFromSort(Gnome);
                GnomeLabel.Text += Gnome.Time.ToString();
            }
            else
            {
                GnomeLabel.Text = "To much for it ...";
            }
        }

        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            HeapLabel.Text = "Time: ";
            var Heap = new HeapSort<int>(Collection, "HeapSort");
            Heap.Sort();
            DisplayInfoFromSort(Heap);
            HeapLabel.Text += Heap.Time.ToString();
        }

        private void InsertionSortButton_Click(object sender, EventArgs e)
        {
            if (Collection.Count < 10001)
            {
                InsertionLabel.Text = "Time: ";
                var Insertion = new InsertionSort<int>(Collection, "InsertionSort");
                Insertion.Sort();
                DisplayInfoFromSort(Insertion);
                InsertionLabel.Text += Insertion.Time.ToString();
            }
            else
            {
                InsertionLabel.Text = "To much for it ...";
            }
        }

        private void LSDRadixSortButton_Click(object sender, EventArgs e)
        {
            LSDLabel.Text = "Time: ";
            var LSDRadix = new LSDRadixSort<int>(Collection, "LSDRadixSort");
            LSDRadix.Sort();
            DisplayInfoFromSort(LSDRadix);
            LSDLabel.Text += LSDRadix.Time.ToString();
        }

        private void MSDRadixSortButton_Click(object sender, EventArgs e)
        {
            MSDLabel.Text = "Time: ";
            var MSDRadix = new MSDRadixSort<int>(Collection, "MSDRadixSort");
            MSDRadix.Sort();
            DisplayInfoFromSort(MSDRadix);
            MSDLabel.Text += MSDRadix.Time.ToString();
        }

        private void MergeSortButton_Click(object sender, EventArgs e)
        {
            MergeLabel.Text = "Time: ";
            var Merge = new MergeSort<int>(Collection, "MergeSort");
            Merge.Sort();
            DisplayInfoFromSort(Merge);
            MergeLabel.Text += Merge.Time.ToString();
        }

        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            QuickLabel.Text = "Time: ";
            var Quick = new QuickSort<int>(Collection, "QuickSort");
            Quick.Sort();
            DisplayInfoFromSort(Quick);
            QuickLabel.Text += Quick.Time.ToString();
        }

        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            ShellLabel.Text = "Time: ";
            var Shell = new ShellSort<int>(Collection, "ShellSort");
            Shell.Sort();
            DisplayInfoFromSort(Shell);
            ShellLabel.Text += Shell.Time.ToString();
        }

        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            TreeLabel.Text = "Time: ";
            var Tree = new TreeSort<int>(Collection, "TreeSort");
            Tree.Sort();
            DisplayInfoFromSort(Tree);
            TreeLabel.Text += Tree.Time.ToString();
        }
        private void AllSortButton_Click(object sender, EventArgs e)
        {
            SortDatarichTextBox.Text = "Calculating ... Wait a moment ...";
            BubbleLabel.Text = "Time: ";
            SelectionLabel.Text = "Time: ";
            CocktailLabel.Text = "Time: ";
            GnomeLabel.Text = "Time: ";
            HeapLabel.Text = "Time: ";
            InsertionLabel.Text = "Time: ";
            LSDLabel.Text = "Time: ";
            MSDLabel.Text = "Time: ";
            MergeLabel.Text = "Time: ";
            QuickLabel.Text = "Time: ";
            ShellLabel.Text = "Time: ";
            TreeLabel.Text = "Time: ";
            SortDatarichTextBox.Text = "";
            var min = new List<BaseAlgorithm<int>>();
            if (Collection.Count < 10001)
            {
                var bubble = new BubbleSort<int>(Collection, "BubbleSort");
                bubble.Sort();
                BubbleLabel.Text += bubble.Time.ToString();
                min.Add(bubble);
            }
            if (Collection.Count < 10001)
            {
                var selection = new SelectionSort<int>(Collection, "SelectionSort");
                selection.Sort();
                SelectionLabel.Text += selection.Time.ToString();
                min.Add(selection);
            }
            if (Collection.Count < 10001)
            {
                var cocktail = new CocktailSort<int>(Collection, "CocktailSort");
                cocktail.Sort();
                CocktailLabel.Text += cocktail.Time.ToString();
                min.Add(cocktail);
            }
            if (Collection.Count < 10001)
            {
                var Gnome = new GnomeSort<int>(Collection, "GnomeSort");
                Gnome.Sort();
                GnomeLabel.Text += Gnome.Time.ToString();
                min.Add(Gnome);
            }
            if (Collection.Count < 10001)
            {
                var Insertion = new InsertionSort<int>(Collection, "InsertionSort");
                Insertion.Sort();
                InsertionLabel.Text += Insertion.Time.ToString();
                min.Add(Insertion);
            }
            var Tree = new TreeSort<int>(Collection, "TreeSort");
            Tree.Sort();
            TreeLabel.Text += Tree.Time.ToString();
            min.Add(Tree);
            var Heap = new HeapSort<int>(Collection, "HeapSort");
            Heap.Sort();
            HeapLabel.Text += Heap.Time.ToString();
            min.Add(Heap);
            var LSDRadix = new LSDRadixSort<int>(Collection, "LSDRadixSort");
            LSDRadix.Sort();
            LSDLabel.Text += LSDRadix.Time.ToString();
            min.Add(LSDRadix);
            var MSDRadix = new MSDRadixSort<int>(Collection, "MSDRadixSort");
            MSDRadix.Sort();
            MSDLabel.Text += MSDRadix.Time.ToString();
            min.Add(MSDRadix);
            var Merge = new MergeSort<int>(Collection, "MergeSort");
            Merge.Sort();
            MergeLabel.Text += Merge.Time.ToString();
            min.Add(Merge);
            var Quick = new QuickSort<int>(Collection, "QuickSort");
            Quick.Sort();
            QuickLabel.Text += Quick.Time.ToString();
            min.Add(Quick);
            var Shell = new ShellSort<int>(Collection, "ShellSort");
            Shell.Sort();
            ShellLabel.Text += Shell.Time.ToString();
            min.Add(Shell);
            var best = GetMinTime(min);
            SortDatarichTextBox.Text = $"THE BEST:\n" + best.Name + $"\n{best.Time}";
        }
        private BaseAlgorithm<int> GetMinTime(List<BaseAlgorithm<int>> sorts)
        {
            var min = sorts[0];
            foreach (var item in sorts)
            {
                if (item.Time.CompareTo(min.Time) == -1 )
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
