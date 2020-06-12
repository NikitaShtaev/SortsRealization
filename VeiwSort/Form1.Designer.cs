namespace VeiwSort
{
    partial class SortView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddValues = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.SortDatarichTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.InsertionSortButton = new System.Windows.Forms.Button();
            this.LSDRadixSortButton = new System.Windows.Forms.Button();
            this.MSDRadixSortButton = new System.Windows.Forms.Button();
            this.MergeSortButton = new System.Windows.Forms.Button();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.BubbleLabel = new System.Windows.Forms.Label();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.AllSortButton = new System.Windows.Forms.Button();
            this.CocktailLabel = new System.Windows.Forms.Label();
            this.GnomeLabel = new System.Windows.Forms.Label();
            this.HeapLabel = new System.Windows.Forms.Label();
            this.InsertionLabel = new System.Windows.Forms.Label();
            this.LSDLabel = new System.Windows.Forms.Label();
            this.MSDLabel = new System.Windows.Forms.Label();
            this.MergeLabel = new System.Windows.Forms.Label();
            this.QuickLabel = new System.Windows.Forms.Label();
            this.ShellLabel = new System.Windows.Forms.Label();
            this.TreeLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.AddValues);
            this.panel2.Controls.Add(this.QuantityTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 37);
            this.panel2.TabIndex = 2;
            // 
            // AddValues
            // 
            this.AddValues.AutoSize = true;
            this.AddValues.Location = new System.Drawing.Point(195, 6);
            this.AddValues.Name = "AddValues";
            this.AddValues.Size = new System.Drawing.Size(38, 23);
            this.AddValues.TabIndex = 3;
            this.AddValues.Text = "Add";
            this.AddValues.UseVisualStyleBackColor = true;
            this.AddValues.Click += new System.EventHandler(this.AddValues_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityTextBox.Location = new System.Drawing.Point(94, 8);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(95, 20);
            this.QuantityTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write quantity:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.Location = new System.Drawing.Point(255, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 668);
            this.panel3.TabIndex = 3;
            // 
            // BubbleSort
            // 
            this.BubbleSort.AutoSize = true;
            this.BubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BubbleSort.Location = new System.Drawing.Point(12, 245);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(96, 28);
            this.BubbleSort.TabIndex = 4;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // SortDatarichTextBox
            // 
            this.SortDatarichTextBox.Location = new System.Drawing.Point(12, 46);
            this.SortDatarichTextBox.Name = "SortDatarichTextBox";
            this.SortDatarichTextBox.Size = new System.Drawing.Size(237, 159);
            this.SortDatarichTextBox.TabIndex = 5;
            this.SortDatarichTextBox.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(12, 211);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 28);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.AutoSize = true;
            this.SelectionSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectionSortButton.Location = new System.Drawing.Point(12, 279);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(102, 28);
            this.SelectionSortButton.TabIndex = 7;
            this.SelectionSortButton.Text = "SelectionSort";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.SelectionSortButton_Click);
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.AutoSize = true;
            this.CocktailSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CocktailSortButton.Location = new System.Drawing.Point(12, 313);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(102, 28);
            this.CocktailSortButton.TabIndex = 8;
            this.CocktailSortButton.Text = "CocktailSort";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.CocktailSortButton_Click);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.AutoSize = true;
            this.GnomeSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GnomeSortButton.Location = new System.Drawing.Point(12, 347);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(102, 28);
            this.GnomeSortButton.TabIndex = 9;
            this.GnomeSortButton.Text = "GnomeSort";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.AutoSize = true;
            this.HeapSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeapSortButton.Location = new System.Drawing.Point(12, 381);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(102, 28);
            this.HeapSortButton.TabIndex = 10;
            this.HeapSortButton.Text = "HeapSort";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // InsertionSortButton
            // 
            this.InsertionSortButton.AutoSize = true;
            this.InsertionSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertionSortButton.Location = new System.Drawing.Point(12, 415);
            this.InsertionSortButton.Name = "InsertionSortButton";
            this.InsertionSortButton.Size = new System.Drawing.Size(102, 28);
            this.InsertionSortButton.TabIndex = 11;
            this.InsertionSortButton.Text = "InsertionSort";
            this.InsertionSortButton.UseVisualStyleBackColor = true;
            this.InsertionSortButton.Click += new System.EventHandler(this.InsertionSortButton_Click);
            // 
            // LSDRadixSortButton
            // 
            this.LSDRadixSortButton.AutoSize = true;
            this.LSDRadixSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSDRadixSortButton.Location = new System.Drawing.Point(12, 449);
            this.LSDRadixSortButton.Name = "LSDRadixSortButton";
            this.LSDRadixSortButton.Size = new System.Drawing.Size(106, 28);
            this.LSDRadixSortButton.TabIndex = 12;
            this.LSDRadixSortButton.Text = "LSDRadixSort";
            this.LSDRadixSortButton.UseVisualStyleBackColor = true;
            this.LSDRadixSortButton.Click += new System.EventHandler(this.LSDRadixSortButton_Click);
            // 
            // MSDRadixSortButton
            // 
            this.MSDRadixSortButton.AutoSize = true;
            this.MSDRadixSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSDRadixSortButton.Location = new System.Drawing.Point(12, 483);
            this.MSDRadixSortButton.Name = "MSDRadixSortButton";
            this.MSDRadixSortButton.Size = new System.Drawing.Size(109, 28);
            this.MSDRadixSortButton.TabIndex = 13;
            this.MSDRadixSortButton.Text = "MSDRadixSort";
            this.MSDRadixSortButton.UseVisualStyleBackColor = true;
            this.MSDRadixSortButton.Click += new System.EventHandler(this.MSDRadixSortButton_Click);
            // 
            // MergeSortButton
            // 
            this.MergeSortButton.AutoSize = true;
            this.MergeSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MergeSortButton.Location = new System.Drawing.Point(12, 517);
            this.MergeSortButton.Name = "MergeSortButton";
            this.MergeSortButton.Size = new System.Drawing.Size(109, 28);
            this.MergeSortButton.TabIndex = 14;
            this.MergeSortButton.Text = "MergeSort";
            this.MergeSortButton.UseVisualStyleBackColor = true;
            this.MergeSortButton.Click += new System.EventHandler(this.MergeSortButton_Click);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.AutoSize = true;
            this.QuickSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuickSortButton.Location = new System.Drawing.Point(12, 551);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(109, 28);
            this.QuickSortButton.TabIndex = 15;
            this.QuickSortButton.Text = "QuickSort";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.AutoSize = true;
            this.ShellSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShellSortButton.Location = new System.Drawing.Point(12, 585);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(109, 28);
            this.ShellSortButton.TabIndex = 16;
            this.ShellSortButton.Text = "ShellSort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.AutoSize = true;
            this.TreeSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TreeSortButton.Location = new System.Drawing.Point(12, 619);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(109, 28);
            this.TreeSortButton.TabIndex = 17;
            this.TreeSortButton.Text = "TreeSort";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // BubbleLabel
            // 
            this.BubbleLabel.AutoSize = true;
            this.BubbleLabel.Location = new System.Drawing.Point(114, 253);
            this.BubbleLabel.Name = "BubbleLabel";
            this.BubbleLabel.Size = new System.Drawing.Size(33, 13);
            this.BubbleLabel.TabIndex = 18;
            this.BubbleLabel.Text = "Time:";
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(114, 287);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(33, 13);
            this.SelectionLabel.TabIndex = 19;
            this.SelectionLabel.Text = "Time:";
            // 
            // AllSortButton
            // 
            this.AllSortButton.AutoSize = true;
            this.AllSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllSortButton.Location = new System.Drawing.Point(12, 653);
            this.AllSortButton.Name = "AllSortButton";
            this.AllSortButton.Size = new System.Drawing.Size(96, 28);
            this.AllSortButton.TabIndex = 20;
            this.AllSortButton.Text = "All Sorts";
            this.AllSortButton.UseVisualStyleBackColor = true;
            this.AllSortButton.Click += new System.EventHandler(this.AllSortButton_Click);
            // 
            // CocktailLabel
            // 
            this.CocktailLabel.AutoSize = true;
            this.CocktailLabel.Location = new System.Drawing.Point(114, 321);
            this.CocktailLabel.Name = "CocktailLabel";
            this.CocktailLabel.Size = new System.Drawing.Size(33, 13);
            this.CocktailLabel.TabIndex = 21;
            this.CocktailLabel.Text = "Time:";
            // 
            // GnomeLabel
            // 
            this.GnomeLabel.AutoSize = true;
            this.GnomeLabel.Location = new System.Drawing.Point(114, 355);
            this.GnomeLabel.Name = "GnomeLabel";
            this.GnomeLabel.Size = new System.Drawing.Size(33, 13);
            this.GnomeLabel.TabIndex = 22;
            this.GnomeLabel.Text = "Time:";
            // 
            // HeapLabel
            // 
            this.HeapLabel.AutoSize = true;
            this.HeapLabel.Location = new System.Drawing.Point(114, 389);
            this.HeapLabel.Name = "HeapLabel";
            this.HeapLabel.Size = new System.Drawing.Size(33, 13);
            this.HeapLabel.TabIndex = 23;
            this.HeapLabel.Text = "Time:";
            // 
            // InsertionLabel
            // 
            this.InsertionLabel.AutoSize = true;
            this.InsertionLabel.Location = new System.Drawing.Point(114, 423);
            this.InsertionLabel.Name = "InsertionLabel";
            this.InsertionLabel.Size = new System.Drawing.Size(33, 13);
            this.InsertionLabel.TabIndex = 24;
            this.InsertionLabel.Text = "Time:";
            // 
            // LSDLabel
            // 
            this.LSDLabel.AutoSize = true;
            this.LSDLabel.Location = new System.Drawing.Point(124, 457);
            this.LSDLabel.Name = "LSDLabel";
            this.LSDLabel.Size = new System.Drawing.Size(33, 13);
            this.LSDLabel.TabIndex = 25;
            this.LSDLabel.Text = "Time:";
            // 
            // MSDLabel
            // 
            this.MSDLabel.AutoSize = true;
            this.MSDLabel.Location = new System.Drawing.Point(124, 491);
            this.MSDLabel.Name = "MSDLabel";
            this.MSDLabel.Size = new System.Drawing.Size(33, 13);
            this.MSDLabel.TabIndex = 26;
            this.MSDLabel.Text = "Time:";
            // 
            // MergeLabel
            // 
            this.MergeLabel.AutoSize = true;
            this.MergeLabel.Location = new System.Drawing.Point(124, 525);
            this.MergeLabel.Name = "MergeLabel";
            this.MergeLabel.Size = new System.Drawing.Size(33, 13);
            this.MergeLabel.TabIndex = 27;
            this.MergeLabel.Text = "Time:";
            // 
            // QuickLabel
            // 
            this.QuickLabel.AutoSize = true;
            this.QuickLabel.Location = new System.Drawing.Point(124, 559);
            this.QuickLabel.Name = "QuickLabel";
            this.QuickLabel.Size = new System.Drawing.Size(33, 13);
            this.QuickLabel.TabIndex = 28;
            this.QuickLabel.Text = "Time:";
            // 
            // ShellLabel
            // 
            this.ShellLabel.AutoSize = true;
            this.ShellLabel.Location = new System.Drawing.Point(124, 593);
            this.ShellLabel.Name = "ShellLabel";
            this.ShellLabel.Size = new System.Drawing.Size(33, 13);
            this.ShellLabel.TabIndex = 29;
            this.ShellLabel.Text = "Time:";
            // 
            // TreeLabel
            // 
            this.TreeLabel.AutoSize = true;
            this.TreeLabel.Location = new System.Drawing.Point(124, 627);
            this.TreeLabel.Name = "TreeLabel";
            this.TreeLabel.Size = new System.Drawing.Size(33, 13);
            this.TreeLabel.TabIndex = 30;
            this.TreeLabel.Text = "Time:";
            // 
            // SortView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 692);
            this.Controls.Add(this.TreeLabel);
            this.Controls.Add(this.ShellLabel);
            this.Controls.Add(this.QuickLabel);
            this.Controls.Add(this.MergeLabel);
            this.Controls.Add(this.MSDLabel);
            this.Controls.Add(this.LSDLabel);
            this.Controls.Add(this.InsertionLabel);
            this.Controls.Add(this.HeapLabel);
            this.Controls.Add(this.GnomeLabel);
            this.Controls.Add(this.CocktailLabel);
            this.Controls.Add(this.AllSortButton);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.BubbleLabel);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.ShellSortButton);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.MergeSortButton);
            this.Controls.Add(this.MSDRadixSortButton);
            this.Controls.Add(this.LSDRadixSortButton);
            this.Controls.Add(this.InsertionSortButton);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.CocktailSortButton);
            this.Controls.Add(this.SelectionSortButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SortDatarichTextBox);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "SortView";
            this.Text = "SortView";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddValues;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.RichTextBox SortDatarichTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Button CocktailSortButton;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button InsertionSortButton;
        private System.Windows.Forms.Button LSDRadixSortButton;
        private System.Windows.Forms.Button MSDRadixSortButton;
        private System.Windows.Forms.Button MergeSortButton;
        private System.Windows.Forms.Button QuickSortButton;
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Label BubbleLabel;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Button AllSortButton;
        private System.Windows.Forms.Label CocktailLabel;
        private System.Windows.Forms.Label GnomeLabel;
        private System.Windows.Forms.Label HeapLabel;
        private System.Windows.Forms.Label InsertionLabel;
        private System.Windows.Forms.Label LSDLabel;
        private System.Windows.Forms.Label MSDLabel;
        private System.Windows.Forms.Label MergeLabel;
        private System.Windows.Forms.Label QuickLabel;
        private System.Windows.Forms.Label ShellLabel;
        private System.Windows.Forms.Label TreeLabel;
    }
}

