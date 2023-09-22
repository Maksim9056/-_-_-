namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertLeft = new System.Windows.Forms.Button();
            this.btnInsertRight = new System.Windows.Forms.Button();
            this.btnPrintTree = new System.Windows.Forms.Button();
            this.txtParentValue = new System.Windows.Forms.TextBox();
            this.txtChildValue = new System.Windows.Forms.TextBox();
            this.txtNodeValue = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeafValue = new System.Windows.Forms.TextBox();
            this.Buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertLeft
            // 
            this.btnInsertLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsertLeft.Location = new System.Drawing.Point(12, 233);
            this.btnInsertLeft.Name = "btnInsertLeft";
            this.btnInsertLeft.Size = new System.Drawing.Size(290, 84);
            this.btnInsertLeft.TabIndex = 0;
            this.btnInsertLeft.Text = "Добавь  левый узел";
            this.btnInsertLeft.UseVisualStyleBackColor = true;
            this.btnInsertLeft.Click += new System.EventHandler(this.btnInsertLeft_Click);
            // 
            // btnInsertRight
            // 
            this.btnInsertRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsertRight.Location = new System.Drawing.Point(308, 233);
            this.btnInsertRight.Name = "btnInsertRight";
            this.btnInsertRight.Size = new System.Drawing.Size(334, 84);
            this.btnInsertRight.TabIndex = 1;
            this.btnInsertRight.Text = "Добавить в правый узел";
            this.btnInsertRight.UseVisualStyleBackColor = true;
            this.btnInsertRight.Click += new System.EventHandler(this.btnInsertRight_Click);
            // 
            // btnPrintTree
            // 
            this.btnPrintTree.Location = new System.Drawing.Point(822, 672);
            this.btnPrintTree.Name = "btnPrintTree";
            this.btnPrintTree.Size = new System.Drawing.Size(152, 85);
            this.btnPrintTree.TabIndex = 2;
            this.btnPrintTree.Text = "Вывод";
            this.btnPrintTree.UseVisualStyleBackColor = true;
            this.btnPrintTree.Visible = false;
            // 
            // txtParentValue
            // 
            this.txtParentValue.Location = new System.Drawing.Point(27, 51);
            this.txtParentValue.Multiline = true;
            this.txtParentValue.Name = "txtParentValue";
            this.txtParentValue.Size = new System.Drawing.Size(123, 59);
            this.txtParentValue.TabIndex = 3;
            // 
            // txtChildValue
            // 
            this.txtChildValue.Location = new System.Drawing.Point(254, 55);
            this.txtChildValue.Multiline = true;
            this.txtChildValue.Name = "txtChildValue";
            this.txtChildValue.Size = new System.Drawing.Size(274, 55);
            this.txtChildValue.TabIndex = 4;
            // 
            // txtNodeValue
            // 
            this.txtNodeValue.Location = new System.Drawing.Point(12, 708);
            this.txtNodeValue.Multiline = true;
            this.txtNodeValue.Name = "txtNodeValue";
            this.txtNodeValue.Size = new System.Drawing.Size(159, 55);
            this.txtNodeValue.TabIndex = 5;
            this.txtNodeValue.Text = "1";
            this.txtNodeValue.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 323);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(918, 434);
            this.treeView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Корень";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Элемент ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(641, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Удалить элемент";
            // 
            // txtLeafValue
            // 
            this.txtLeafValue.Location = new System.Drawing.Point(635, 51);
            this.txtLeafValue.Multiline = true;
            this.txtLeafValue.Name = "txtLeafValue";
            this.txtLeafValue.Size = new System.Drawing.Size(287, 61);
            this.txtLeafValue.TabIndex = 10;
            // 
            // Buton
            // 
            this.Buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Buton.Location = new System.Drawing.Point(655, 233);
            this.Buton.Name = "Buton";
            this.Buton.Size = new System.Drawing.Size(319, 84);
            this.Buton.TabIndex = 11;
            this.Buton.Text = "Удаляет элемент листа";
            this.Buton.UseVisualStyleBackColor = true;
            this.Buton.Click += new System.EventHandler(this.btnDeleteLeaf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 769);
            this.Controls.Add(this.Buton);
            this.Controls.Add(this.txtLeafValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtNodeValue);
            this.Controls.Add(this.txtChildValue);
            this.Controls.Add(this.txtParentValue);
            this.Controls.Add(this.btnPrintTree);
            this.Controls.Add(this.btnInsertRight);
            this.Controls.Add(this.btnInsertLeft);
            this.Name = "Form1";
            this.Text = "Бинарное дерево ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertLeft;
        private System.Windows.Forms.Button btnInsertRight;
        private System.Windows.Forms.Button btnPrintTree;
        private System.Windows.Forms.TextBox txtParentValue;
        private System.Windows.Forms.TextBox txtChildValue;
        private System.Windows.Forms.TextBox txtNodeValue;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLeafValue;
        private System.Windows.Forms.Button Buton;
    }
}

