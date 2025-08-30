using System.Windows;
using System.Windows.Controls;

namespace FirstWPF.View.UserControls
{
    public partial class ClearableTextBoxes : UserControl
    {
        public ClearableTextBoxes()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return  placeholder; }
            set
            {
                placeholder = value;

                // not the best
                tbPlaceholder.Text = placeholder;
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            } else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
