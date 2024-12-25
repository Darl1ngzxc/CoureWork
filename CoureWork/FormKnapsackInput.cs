namespace Kurssss;

public partial class FormKnapsackInput : System.Windows.Forms.Form
{
    private event Action<int>? _setSizeDelegate;
    private event Func<string, int, int, KnapsackStateStorage>? _addItemDelegate;
    private Action<EnumOperations>? _afterActionCallback;
    

    public FormKnapsackInput(EnumOperations actiontype)
    {
        InitializeComponent();
        switch (actiontype)
        {
            case EnumOperations.AddItem:
                buttonAddItem.Enabled = true;
                maskedTextBoxInputValue.Enabled = true;
                maskedTextBoxInputWeight.Enabled = true;
                textBoxInputName.Enabled = true;
                break;
            case EnumOperations.SetCapacity:
                buttonInputCapacity.Enabled = true;
                maskedTextBoxInputCapacity.Enabled = true;
                break;
            default:
                throw new ArgumentException();
        }
    }

    public void AddEvent(Action<int> setSizeDelegate)
    {
        _setSizeDelegate += setSizeDelegate;
    }

    public void AddEvent(Func<string, int, int, KnapsackStateStorage> addItemDelegate, Action<EnumOperations> afterActionCallback)
    {
        _addItemDelegate += addItemDelegate;
        _afterActionCallback = afterActionCallback;
    }



    private void buttonInputCapacity_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(maskedTextBoxInputCapacity.Text))
            {
                throw new Exception("¬ходные данные отстутствуют");
            }
            int capacity = Convert.ToInt32(maskedTextBoxInputCapacity.Text);
            _setSizeDelegate?.Invoke(capacity);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("¬ведите целочисленное число.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAddItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(textBoxInputName.Text) || string.IsNullOrEmpty(maskedTextBoxInputWeight.Text) || string.IsNullOrEmpty(maskedTextBoxInputValue.Text))
            {
                throw new Exception("¬ходные данные отсутствуют");
            }
            string name = textBoxInputName.Text;
            int weight = Convert.ToInt32(maskedTextBoxInputWeight.Text);
            int value = Convert.ToInt32(maskedTextBoxInputValue.Text);
            _addItemDelegate?.Invoke(name, weight, value);
            _afterActionCallback?.Invoke(EnumOperations.AddItem);
            Close();            
        }
        catch (Exception)
        {
            MessageBox.Show("¬ведите все параметры", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}