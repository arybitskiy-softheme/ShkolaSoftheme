using System.Windows;
using System.Windows.Controls;

namespace PrimitiveDataTypes
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (type.SelectedItem as ListBoxItem);
            switch (selectedItem.Content.ToString())
            {
                case "int":
                    ShowIntValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
              }
        }

        private void ShowIntValue()
        {
            int intVarDafault = 0;
            int intVarMax = 2147483647;
            int intVarMin = -2147483648;
            valueDafault.Text = intVarDafault.ToString();
            valueMax.Text = intVarMax.ToString();
            valueMin.Text = intVarMin.ToString();
        }

        private void ShowLongValue()
        {
            long longVarDafault = 0L;
            long longVarMax = 9223372036854775807;
            long longVarMin = -9223372036854775808;
            valueDafault.Text = longVarDafault.ToString();
            valueMax.Text = longVarMax.ToString();
            valueMin.Text = longVarMin.ToString();
        }

        private void ShowFloatValue()
        {
            float floatVarDafault = 0.0F;
            float floatVarMax = 3.40282347E+38F;
            float floatVarMin = -3.40282347E+38F;
            valueDafault.Text = floatVarDafault.ToString();
            valueMax.Text = floatVarMax.ToString();
            valueMin.Text = floatVarMin.ToString();
        }

        private void ShowDoubleValue()
        {
            double doubleVarDafault = 0.0D;
            double doubleVarMax = 1.7976931348623157E+308;
            double doubleVarMin= -1.7976931348623157E+308;
            valueDafault.Text = doubleVarDafault.ToString();
            valueMax.Text = doubleVarMax.ToString();
            valueMin.Text = doubleVarMin.ToString();
        }

        private void ShowDecimalValue()
        {
            decimal decimalVarDafault = 0.0M;
            decimal decimalVarMax = 79228162514264337593543950335M;
            decimal decimalVarMin = -79228162514264337593543950335M;
            valueDafault.Text = decimalVarDafault.ToString();
            valueMax.Text = decimalVarMax.ToString();
            valueMin.Text = decimalVarMin.ToString();
        }

        private void QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
