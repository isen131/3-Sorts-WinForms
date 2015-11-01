namespace WinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArrayLength = new System.Windows.Forms.TextBox();
            this.MinValue = new System.Windows.Forms.TextBox();
            this.MaxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateArray = new System.Windows.Forms.Button();
            this.Bubble = new System.Windows.Forms.RadioButton();
            this.Insertions = new System.Windows.Forms.RadioButton();
            this.Selection = new System.Windows.Forms.RadioButton();
            this.SortIt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeSpend = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во элементов в массиве";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Границы значений массива";
            // 
            // ArrayLength
            // 
            this.ArrayLength.Location = new System.Drawing.Point(31, 55);
            this.ArrayLength.Name = "ArrayLength";
            this.ArrayLength.Size = new System.Drawing.Size(100, 20);
            this.ArrayLength.TabIndex = 2;
            // 
            // MinValue
            // 
            this.MinValue.Location = new System.Drawing.Point(317, 55);
            this.MinValue.Name = "MinValue";
            this.MinValue.Size = new System.Drawing.Size(100, 20);
            this.MinValue.TabIndex = 3;
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(317, 81);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(100, 20);
            this.MaxValue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "До";
            // 
            // GenerateArray
            // 
            this.GenerateArray.Location = new System.Drawing.Point(31, 82);
            this.GenerateArray.Name = "GenerateArray";
            this.GenerateArray.Size = new System.Drawing.Size(139, 23);
            this.GenerateArray.TabIndex = 7;
            this.GenerateArray.Text = "Сгенерировать массив";
            this.GenerateArray.UseVisualStyleBackColor = true;
            this.GenerateArray.Click += new System.EventHandler(this.GenerateArray_Click);
            // 
            // Bubble
            // 
            this.Bubble.AutoSize = true;
            this.Bubble.Location = new System.Drawing.Point(272, 121);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(70, 17);
            this.Bubble.TabIndex = 8;
            this.Bubble.TabStop = true;
            this.Bubble.Text = "Пузырек";
            this.Bubble.UseVisualStyleBackColor = true;
            // 
            // Insertions
            // 
            this.Insertions.AutoSize = true;
            this.Insertions.Location = new System.Drawing.Point(272, 145);
            this.Insertions.Name = "Insertions";
            this.Insertions.Size = new System.Drawing.Size(67, 17);
            this.Insertions.TabIndex = 9;
            this.Insertions.TabStop = true;
            this.Insertions.Text = "Вставки";
            this.Insertions.UseVisualStyleBackColor = true;
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Location = new System.Drawing.Point(272, 169);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(58, 17);
            this.Selection.TabIndex = 10;
            this.Selection.TabStop = true;
            this.Selection.Text = "Выбор";
            this.Selection.UseVisualStyleBackColor = true;
            // 
            // SortIt
            // 
            this.SortIt.Location = new System.Drawing.Point(31, 111);
            this.SortIt.Name = "SortIt";
            this.SortIt.Size = new System.Drawing.Size(139, 23);
            this.SortIt.TabIndex = 11;
            this.SortIt.Text = "Сортировать";
            this.SortIt.UseVisualStyleBackColor = true;
            this.SortIt.Click += new System.EventHandler(this.SortIt_Click);
            this.SortIt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SortIt_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Затрачено времени:";
            // 
            // TimeSpend
            // 
            this.TimeSpend.AutoSize = true;
            this.TimeSpend.Location = new System.Drawing.Point(145, 168);
            this.TimeSpend.Name = "TimeSpend";
            this.TimeSpend.Size = new System.Drawing.Size(13, 13);
            this.TimeSpend.TabIndex = 13;
            this.TimeSpend.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Состояние:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(102, 204);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(183, 13);
            this.Status.TabIndex = 15;
            this.Status.Text = "Ожидание действий пользователя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 236);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimeSpend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SortIt);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.Insertions);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.GenerateArray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.MinValue);
            this.Controls.Add(this.ArrayLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Сортировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArrayLength;
        private System.Windows.Forms.TextBox MinValue;
        private System.Windows.Forms.TextBox MaxValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateArray;
        private System.Windows.Forms.RadioButton Bubble;
        private System.Windows.Forms.RadioButton Insertions;
        private System.Windows.Forms.RadioButton Selection;
        private System.Windows.Forms.Button SortIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TimeSpend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Status;
    }
}

