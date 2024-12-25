namespace Kurssss;

partial class FormKnapsackInput
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        labelInputCapacity = new Label();
        maskedTextBoxInputCapacity = new MaskedTextBox();
        buttonInputCapacity = new Button();
        labelAddItem = new Label();
        labelItemName = new Label();
        labelItemWeight = new Label();
        labelItemValue = new Label();
        maskedTextBoxInputValue = new MaskedTextBox();
        maskedTextBoxInputWeight = new MaskedTextBox();
        textBoxInputName = new TextBox();
        buttonAddItem = new Button();
        SuspendLayout();
        // 
        // labelInputCapacity
        // 
        labelInputCapacity.AutoSize = true;
        labelInputCapacity.Location = new Point(10, 7);
        labelInputCapacity.Name = "labelInputCapacity";
        labelInputCapacity.Size = new Size(174, 15);
        labelInputCapacity.TabIndex = 0;
        labelInputCapacity.Text = "Введите вместимость рюкзака";
        // 
        // maskedTextBoxInputCapacity
        // 
        maskedTextBoxInputCapacity.Enabled = false;
        maskedTextBoxInputCapacity.Location = new Point(10, 34);
        maskedTextBoxInputCapacity.Margin = new Padding(3, 2, 3, 2);
        maskedTextBoxInputCapacity.Mask = "00";
        maskedTextBoxInputCapacity.Name = "maskedTextBoxInputCapacity";
        maskedTextBoxInputCapacity.Size = new Size(194, 23);
        maskedTextBoxInputCapacity.TabIndex = 1;
        maskedTextBoxInputCapacity.ValidatingType = typeof(int);
        // 
        // buttonInputCapacity
        // 
        buttonInputCapacity.Enabled = false;
        buttonInputCapacity.Location = new Point(230, 26);
        buttonInputCapacity.Margin = new Padding(3, 2, 3, 2);
        buttonInputCapacity.Name = "buttonInputCapacity";
        buttonInputCapacity.Size = new Size(153, 35);
        buttonInputCapacity.TabIndex = 2;
        buttonInputCapacity.Text = "Задать вместимость";
        buttonInputCapacity.UseVisualStyleBackColor = true;
        buttonInputCapacity.Click += buttonInputCapacity_Click;
        // 
        // labelAddItem
        // 
        labelAddItem.AutoSize = true;
        labelAddItem.Location = new Point(130, 136);
        labelAddItem.Name = "labelAddItem";
        labelAddItem.Size = new Size(129, 15);
        labelAddItem.TabIndex = 3;
        labelAddItem.Text = "Добавление предмета";
        // 
        // labelItemName
        // 
        labelItemName.AutoSize = true;
        labelItemName.Location = new Point(29, 173);
        labelItemName.Name = "labelItemName";
        labelItemName.Size = new Size(59, 15);
        labelItemName.TabIndex = 4;
        labelItemName.Text = "Название";
        // 
        // labelItemWeight
        // 
        labelItemWeight.AutoSize = true;
        labelItemWeight.Location = new Point(187, 173);
        labelItemWeight.Name = "labelItemWeight";
        labelItemWeight.Size = new Size(26, 15);
        labelItemWeight.TabIndex = 5;
        labelItemWeight.Text = "Вес";
        // 
        // labelItemValue
        // 
        labelItemValue.AutoSize = true;
        labelItemValue.Location = new Point(318, 173);
        labelItemValue.Name = "labelItemValue";
        labelItemValue.Size = new Size(35, 15);
        labelItemValue.TabIndex = 6;
        labelItemValue.Text = "Цена";
        // 
        // maskedTextBoxInputValue
        // 
        maskedTextBoxInputValue.Enabled = false;
        maskedTextBoxInputValue.Location = new Point(285, 201);
        maskedTextBoxInputValue.Margin = new Padding(3, 2, 3, 2);
        maskedTextBoxInputValue.Mask = "000";
        maskedTextBoxInputValue.Name = "maskedTextBoxInputValue";
        maskedTextBoxInputValue.Size = new Size(110, 23);
        maskedTextBoxInputValue.TabIndex = 7;
        maskedTextBoxInputValue.ValidatingType = typeof(int);
        // 
        // maskedTextBoxInputWeight
        // 
        maskedTextBoxInputWeight.Enabled = false;
        maskedTextBoxInputWeight.Location = new Point(148, 201);
        maskedTextBoxInputWeight.Margin = new Padding(3, 2, 3, 2);
        maskedTextBoxInputWeight.Mask = "00";
        maskedTextBoxInputWeight.Name = "maskedTextBoxInputWeight";
        maskedTextBoxInputWeight.Size = new Size(110, 23);
        maskedTextBoxInputWeight.TabIndex = 8;
        maskedTextBoxInputWeight.ValidatingType = typeof(int);
        // 
        // textBoxInputName
        // 
        textBoxInputName.Enabled = false;
        textBoxInputName.Location = new Point(10, 201);
        textBoxInputName.Margin = new Padding(3, 2, 3, 2);
        textBoxInputName.Name = "textBoxInputName";
        textBoxInputName.Size = new Size(110, 23);
        textBoxInputName.TabIndex = 9;
        // 
        // buttonAddItem
        // 
        buttonAddItem.Enabled = false;
        buttonAddItem.Location = new Point(130, 244);
        buttonAddItem.Margin = new Padding(3, 2, 3, 2);
        buttonAddItem.Name = "buttonAddItem";
        buttonAddItem.Size = new Size(145, 34);
        buttonAddItem.TabIndex = 10;
        buttonAddItem.Text = "Добавить предмет";
        buttonAddItem.UseVisualStyleBackColor = true;
        buttonAddItem.Click += buttonAddItem_Click;
        // 
        // FormKnapsackInput
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(405, 297);
        Controls.Add(buttonAddItem);
        Controls.Add(textBoxInputName);
        Controls.Add(maskedTextBoxInputWeight);
        Controls.Add(maskedTextBoxInputValue);
        Controls.Add(labelItemValue);
        Controls.Add(labelItemWeight);
        Controls.Add(labelItemName);
        Controls.Add(labelAddItem);
        Controls.Add(buttonInputCapacity);
        Controls.Add(maskedTextBoxInputCapacity);
        Controls.Add(labelInputCapacity);
        Margin = new Padding(3, 2, 3, 2);
        Name = "FormKnapsackInput";
        Text = "Параметры";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelInputCapacity;
    private MaskedTextBox maskedTextBoxInputCapacity;
    private Button buttonInputCapacity;
    private Label labelAddItem;
    private Label labelItemName;
    private Label labelItemWeight;
    private Label labelItemValue;
    private MaskedTextBox maskedTextBoxInputValue;
    private MaskedTextBox maskedTextBoxInputWeight;
    private TextBox textBoxInputName;
    private Button buttonAddItem;
}