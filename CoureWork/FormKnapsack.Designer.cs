namespace Kurssss
{
    partial class FormKnapsack
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
            pictureBox = new PictureBox();
            groupBoxTools = new GroupBox();
            labelStep = new Label();
            labelSelectedValue = new Label();
            labelSelectedWeight = new Label();
            labelCapacity = new Label();
            textBoxStep = new TextBox();
            textBoxSelectedValue = new TextBox();
            textBoxSelectedWeight = new TextBox();
            textBoxCapacity = new TextBox();
            buttonSolve = new Button();
            buttonStepBack = new Button();
            buttonStepNext = new Button();
            buttonInformation = new Button();
            buttonAddItem = new Button();
            buttonSetCapacity = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxTools.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            saveFileDialog = new OpenFileDialog();
            openFileDialog = new OpenFileDialog();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 24);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1077, 595);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // groupBoxTools
            // 
            groupBoxTools.BackColor = SystemColors.Control;
            groupBoxTools.Controls.Add(labelStep);
            groupBoxTools.Controls.Add(labelSelectedValue);
            groupBoxTools.Controls.Add(labelSelectedWeight);
            groupBoxTools.Controls.Add(labelCapacity);
            groupBoxTools.Controls.Add(textBoxStep);
            groupBoxTools.Controls.Add(textBoxSelectedValue);
            groupBoxTools.Controls.Add(textBoxSelectedWeight);
            groupBoxTools.Controls.Add(textBoxCapacity);
            groupBoxTools.Controls.Add(buttonSolve);
            groupBoxTools.Controls.Add(buttonStepBack);
            groupBoxTools.Controls.Add(buttonStepNext);
            groupBoxTools.Controls.Add(buttonInformation);
            groupBoxTools.Controls.Add(buttonAddItem);
            groupBoxTools.Controls.Add(buttonSetCapacity);
            groupBoxTools.Dock = DockStyle.Right;
            groupBoxTools.Location = new Point(912, 24);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(165, 595);
            groupBoxTools.TabIndex = 1;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // labelStep
            // 
            labelStep.AutoSize = true;
            labelStep.Location = new Point(7, 383);
            labelStep.Name = "labelStep";
            labelStep.Size = new Size(84, 15);
            labelStep.TabIndex = 13;
            labelStep.Text = "Текущий шаг:";
            // 
            // labelSelectedValue
            // 
            labelSelectedValue.AutoSize = true;
            labelSelectedValue.Location = new Point(6, 330);
            labelSelectedValue.Name = "labelSelectedValue";
            labelSelectedValue.Size = new Size(158, 15);
            labelSelectedValue.TabIndex = 12;
            labelSelectedValue.Text = "Цена предметов в рюкзаке:";
            // 
            // labelSelectedWeight
            // 
            labelSelectedWeight.AutoSize = true;
            labelSelectedWeight.Location = new Point(6, 275);
            labelSelectedWeight.Name = "labelSelectedWeight";
            labelSelectedWeight.Size = new Size(149, 15);
            labelSelectedWeight.TabIndex = 11;
            labelSelectedWeight.Text = "Вес предметов в рюкзаке:";
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(6, 222);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(83, 15);
            labelCapacity.TabIndex = 10;
            labelCapacity.Text = "Вместимость:";
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(7, 410);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(125, 23);
            textBoxStep.TabIndex = 9;
            // 
            // textBoxSelectedValue
            // 
            textBoxSelectedValue.Location = new Point(6, 357);
            textBoxSelectedValue.Name = "textBoxSelectedValue";
            textBoxSelectedValue.Size = new Size(125, 23);
            textBoxSelectedValue.TabIndex = 8;
            // 
            // textBoxSelectedWeight
            // 
            textBoxSelectedWeight.Location = new Point(7, 304);
            textBoxSelectedWeight.Name = "textBoxSelectedWeight";
            textBoxSelectedWeight.Size = new Size(125, 23);
            textBoxSelectedWeight.TabIndex = 7;
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.Location = new Point(6, 249);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Size = new Size(125, 23);
            textBoxCapacity.TabIndex = 6;
            // 
            // buttonSolve
            // 
            buttonSolve.Enabled = false;
            buttonSolve.Location = new Point(7, 439);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(148, 50);
            buttonSolve.TabIndex = 5;
            buttonSolve.Text = "Решить задачу";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // buttonStepBack
            // 
            buttonStepBack.Enabled = false;
            buttonStepBack.Location = new Point(7, 553);
            buttonStepBack.Name = "buttonStepBack";
            buttonStepBack.Size = new Size(146, 51);
            buttonStepBack.TabIndex = 4;
            buttonStepBack.Text = "Шаг назад";
            buttonStepBack.UseVisualStyleBackColor = true;
            buttonStepBack.Click += buttonStepBack_Click;
            // 
            // buttonStepNext
            // 
            buttonStepNext.Enabled = false;
            buttonStepNext.Location = new Point(6, 495);
            buttonStepNext.Name = "buttonStepNext";
            buttonStepNext.Size = new Size(147, 52);
            buttonStepNext.TabIndex = 3;
            buttonStepNext.Text = "Шаг вперед";
            buttonStepNext.UseVisualStyleBackColor = true;
            buttonStepNext.Click += buttonStepNext_Click;
            // 
            // buttonInformation
            // 
            buttonInformation.Location = new Point(7, 151);
            buttonInformation.Name = "buttonInformation";
            buttonInformation.Size = new Size(146, 66);
            buttonInformation.TabIndex = 2;
            buttonInformation.Text = "Информация";
            buttonInformation.UseVisualStyleBackColor = true;
            buttonInformation.Click += buttonInformation_Click;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Enabled = false;
            buttonAddItem.Location = new Point(6, 79);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(147, 66);
            buttonAddItem.TabIndex = 1;
            buttonAddItem.Text = "Добавить предмет";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // buttonSetCapacity
            // 
            buttonSetCapacity.Location = new Point(6, 22);
            buttonSetCapacity.Name = "buttonSetCapacity";
            buttonSetCapacity.Size = new Size(147, 51);
            buttonSetCapacity.TabIndex = 0;
            buttonSetCapacity.Text = "Задать вместимость рюкзака";
            buttonSetCapacity.UseVisualStyleBackColor = true;
            buttonSetCapacity.Click += buttonSetCapacity_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1077, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, LoadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(180, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            LoadToolStripMenuItem.Size = new Size(180, 22);
            LoadToolStripMenuItem.Text = "Загрузить";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // FormKnapsack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 619);
            Controls.Add(groupBoxTools);
            Controls.Add(pictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormKnapsack";
            Text = "FormKnapsack";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxTools.ResumeLayout(false);
            groupBoxTools.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private GroupBox groupBoxTools;
        private Button buttonSetCapacity;
        private Button buttonInformation;
        private Button buttonAddItem;
        private Button buttonStepBack;
        private Button buttonStepNext;
        private Button buttonSolve;
        private TextBox textBoxStep;
        private TextBox textBoxSelectedValue;
        private TextBox textBoxSelectedWeight;
        private TextBox textBoxCapacity;
        private Label labelStep;
        private Label labelSelectedValue;
        private Label labelSelectedWeight;
        private Label labelCapacity;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private OpenFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}