using static WinFormsApp1.Classes.EnumHelper;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {

            TypeComboBox.DisplayMember = "Key";
            TypeComboBox.ValueMember = "Value";
            TypeComboBox.DataSource = GetItemsAsDictionary<CustomerType>(); ;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Enum.TryParse(TypeComboBox.SelectedValue.ToString(), out CustomerType customerType);

            MessageBox.Show(customerType == CustomerType.Select 
                ? "Please make a selection" : $"Selected {customerType}");
        }
    }
}