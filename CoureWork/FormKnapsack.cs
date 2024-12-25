using CourseWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Kurssss;

public partial class FormKnapsack : Form
{
    private KnapsackState savedState;
    public Manager knapsackManager;
    private KnapsackVisualization knapsackVisualization;
    private int currentStateStep = 0;
    private bool isSolved = false;
    private KnapsackStateStorage savedStates = new();

    private void CreateKnapsackManager(int capacity)
    {

        KnapsackParameters parameters = new KnapsackParameters(capacity);
        knapsackManager = new Manager(parameters);
        Show(currentStateStep);

        buttonInformation.Enabled = true;
        buttonAddItem.Enabled = true;
        buttonSetCapacity.Enabled = true;
        textBoxCapacity.Text = knapsackManager.GetStorage().GetState(currentStateStep).Capacity.ToString();
    }

    public FormKnapsack()
    {
        InitializeComponent();
        knapsackVisualization = new KnapsackVisualization();
    }

    public void Show(int currentConditionIndex)
    {
       // LoadBeforeOperation();
        if (knapsackManager == null || pictureBox.Height == 0 || pictureBox.Width == 0)
        {
            return;
        }
        Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.FromArgb(150, 190, 255));
        Pen pen = new Pen(Color.Black);
        Brush brush = new SolidBrush(Color.Black);
        graphics.DrawLine(pen, 500, 0, 500, 1000);
        graphics.DrawString("Предметы на выбор", SystemFonts.DefaultFont, Brushes.Black, 15, 0);
        graphics.DrawString("Рюкзак", SystemFonts.DefaultFont, Brushes.Black, 515, 0);

        var condition = knapsackManager.GetStorage().GetState(currentConditionIndex);

        knapsackVisualization.DrawKnapsack(graphics, condition);


        pictureBox.Image = bitmap;
    }


    private void buttonSetCapacity_Click(object sender, EventArgs e)
    {
        FormKnapsackInput form = new FormKnapsackInput(EnumOperations.SetCapacity);
        form.Show();
        form.AddEvent(CreateKnapsackManager);
    }
    private void buttonAddItem_Click(object sender, EventArgs e)
    {
        FormKnapsackInput form = new FormKnapsackInput(EnumOperations.AddItem);
        form.Show();
        form.AddEvent(knapsackManager.AddItem, RepaintState);
        buttonSetCapacity.Enabled = false;
        buttonSolve.Enabled = true;
        buttonStepBack.Enabled = true;
    }

    private void buttonInformation_Click(object sender, EventArgs e)
    {
        FormInformation form = new FormInformation();
        form.Show();
    }

    private void RepaintState(EnumOperations enumOperations)
    {
        currentStateStep++;
        Show(currentStateStep);
        textBoxStep.Text = currentStateStep.ToString();
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
    }

    private void buttonSolve_Click(object sender, EventArgs e)
    {
        LoadBeforeOperation();
        SaveBeforeOperation();
        int currentstep = currentStateStep;
        savedState = knapsackManager.GetStorage().GetState(currentstep);
        knapsackManager.ResultSolve(currentStateStep);
        currentStateStep = knapsackManager.GetStorage().GetStorageLenght() - 1;
        Show(currentStateStep);
        buttonStepBack.Enabled = true;
        buttonAddItem.Enabled = false;
        isSolved = true;
        buttonSolve.Enabled = false;
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
        
        while (currentStateStep > 0)
        {
            currentStateStep--;
            Show(currentStateStep);
            buttonSolve.Enabled = false;
            buttonAddItem.Enabled = false;
            buttonStepNext.Enabled = true;
            if (currentStateStep == 0)
            {
                buttonStepBack.Enabled = false;
            }
            textBoxStep.Text = currentStateStep.ToString();
            textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
            textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
        }
        while (buttonStepNext.Enabled = true)
        {
            try
            {


                currentStateStep++;
                Show(currentStateStep);
                if (currentStateStep == knapsackManager.GetStorage().GetStorageLenght() - 1)
                {
                    buttonStepNext.Enabled = false;
                    if (isSolved == false)
                    {
                        buttonSolve.Enabled = true;
                    }
                }

                buttonStepBack.Enabled = true;
                textBoxStep.Text = currentStateStep.ToString();
                textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
                textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
            }
            catch
            {
                buttonStepNext.Enabled = false;
                return; 
            }
        }
        LoadBeforeOperation();
    }

    private void buttonStepNext_Click(object sender, EventArgs e)
    {
        currentStateStep++;
        Show(currentStateStep);
        if (currentStateStep == knapsackManager.GetStorage().GetStorageLenght() - 1)
        {
            buttonStepNext.Enabled = false;
            if (isSolved == false)
            {
                buttonSolve.Enabled = true;
                buttonAddItem.Enabled = true;
            }
        }


        buttonStepBack.Enabled = true;
        textBoxStep.Text = currentStateStep.ToString();
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
    }

    private void buttonStepBack_Click(object sender, EventArgs e)
    {
        currentStateStep--;
        Show(currentStateStep);
        buttonSolve.Enabled = false;
        buttonAddItem.Enabled = false;
        buttonStepNext.Enabled = true;
        if (currentStateStep == 0)
        {
            buttonStepBack.Enabled = false;
        }
        textBoxStep.Text = currentStateStep.ToString();
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();
    }

    private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                DefaultExt = "txt",
                AddExtension = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                knapsackManager.GetStorage().SaveToFile(saveFileDialog.FileName);
                MessageBox.Show("Состояние успешно сохранено!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        isSolved = false;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                knapsackManager = new Manager(new KnapsackParameters(100));
                knapsackManager.GetStorage().LoadFromFile(openFileDialog.FileName);

                if (knapsackManager.GetStorage().Count > 0)
                {
                    var lastStateIndex = knapsackManager.GetStorage().GetStorageLenght() - 1;
                    var lastState = knapsackManager.GetStorage().GetState(lastStateIndex);

                    // Обновите knapsackManager с данными из последнего состояния
                    knapsackManager.InitializeKnapsack(lastState.Capacity);
                    knapsackManager.SetKnapsackState(lastState);

                    currentStateStep = lastStateIndex;
                    textBoxCapacity.Text = lastState.Capacity.ToString();
                    Show(currentStateStep);

                    textBoxStep.Text = currentStateStep.ToString();
                    textBoxSelectedValue.Text = lastState.GetSelectedValue().ToString();
                    textBoxSelectedWeight.Text = lastState.SelectedWeight.ToString();
                }

                MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        buttonSetCapacity.Enabled = false;
        buttonStepNext.Enabled = true;
        buttonStepBack.Enabled = true;

        currentStateStep--;
        Show(currentStateStep);
        buttonSolve.Enabled = false;
        buttonAddItem.Enabled = false;
        buttonStepNext.Enabled = true;
        if (currentStateStep == 0)
        {
            buttonStepBack.Enabled = false;
        }
        textBoxStep.Text = currentStateStep.ToString();
        textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
        textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();

        while (currentStateStep < knapsackManager.GetStorage().GetStorageLenght() - 1)
        {
            currentStateStep++;
            Show(currentStateStep);
            if (currentStateStep == knapsackManager.GetStorage().GetStorageLenght() - 1)
            {
                buttonStepNext.Enabled = false;
                if (isSolved == false)
                {
                    buttonSolve.Enabled = true;
                }
            }

            buttonStepBack.Enabled = true;
            textBoxStep.Text = currentStateStep.ToString();
            textBoxSelectedWeight.Text = knapsackManager.GetStorage().GetState(currentStateStep).SelectedWeight.ToString();
            textBoxSelectedValue.Text = knapsackManager.GetStorage().GetState(currentStateStep).GetSelectedValue().ToString();

            int countUnSelectedItems = 0;
            int countUnSelectedItemsOutOfRange = 0;
            foreach (var x in knapsackManager.GetStorage().GetState(currentStateStep).UnSelectedItems)
            {
                countUnSelectedItems++;
                if (x.Weight > knapsackManager.GetStorage().GetState(currentStateStep).Capacity)
                {
                    countUnSelectedItemsOutOfRange++;
                }
            }
            if (countUnSelectedItems == countUnSelectedItemsOutOfRange)
            {
                buttonSolve.Enabled = false;
                isSolved = true;
            }
        }
        buttonAddItem.Enabled = true;
        SaveBeforeOperation();
    }

    private void SaveBeforeOperation()
    {
        foreach (var x in knapsackManager.storage._storage)
        {
            var clonnedState = x.Clone();
            savedStates.AddState(clonnedState);
        }
    }

    private void LoadBeforeOperation()
    {
        for (int i = 0; i < savedStates.GetStorageLenght(); i++)
        {
            knapsackManager.storage._storage[i] = savedStates._storage[i];
        }
    }
    
}