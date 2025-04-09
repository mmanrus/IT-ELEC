using System.Windows;
using System.Windows.Controls;

namespace ItemManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            string newItem = NewItemTextBox.Text.Trim();

            if (string.IsNullOrEmpty(newItem))
            {
                MessageBox.Show("Please enter a non-empty item.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            ItemListBox.Items.Add(newItem);
            NewItemTextBox.Clear();
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (ItemListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to remove.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            ItemListBox.Items.Remove(ItemListBox.SelectedItem);
        }
    }
}
