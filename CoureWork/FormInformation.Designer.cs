namespace CourseWork
{
    partial class FormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            richTextBoxDescription = new RichTextBox();
            label1 = new Label();
            richTextBoxUsing = new RichTextBox();
            labelUsing = new Label();
            labelHeading = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxDescription.Location = new Point(23, 70);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(210, 195);
            richTextBoxDescription.TabIndex = 0;
            richTextBoxDescription.Text = resources.GetString("richTextBoxDescription.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Задача";
            // 
            // richTextBoxUsing
            // 
            richTextBoxUsing.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxUsing.Location = new Point(251, 70);
            richTextBoxUsing.Name = "richTextBoxUsing";
            richTextBoxUsing.Size = new Size(335, 307);
            richTextBoxUsing.TabIndex = 2;
            richTextBoxUsing.Text = resources.GetString("richTextBoxUsing.Text");
            // 
            // labelUsing
            // 
            labelUsing.AutoSize = true;
            labelUsing.Location = new Point(251, 52);
            labelUsing.Name = "labelUsing";
            labelUsing.Size = new Size(62, 15);
            labelUsing.TabIndex = 3;
            labelUsing.Text = "Алгоритм";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.BackColor = Color.LightBlue;
            labelHeading.BorderStyle = BorderStyle.FixedSingle;
            labelHeading.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHeading.Location = new Point(146, 9);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(320, 23);
            labelHeading.TabIndex = 4;
            labelHeading.Text = "Задача о рюкзаке \"Жадный алгоритм\"";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 396);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(574, 229);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FormInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(615, 627);
            Controls.Add(richTextBox1);
            Controls.Add(labelHeading);
            Controls.Add(labelUsing);
            Controls.Add(richTextBoxUsing);
            Controls.Add(label1);
            Controls.Add(richTextBoxDescription);
            Name = "FormInformation";
            Text = "Информация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxDescription;
        private Label label1;
        private RichTextBox richTextBoxUsing;
        private Label labelUsing;
        private Label labelHeading;
        private RichTextBox richTextBox1;
    }
}