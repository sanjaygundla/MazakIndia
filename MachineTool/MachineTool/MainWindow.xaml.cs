using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MachineTool
{
     /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private WcfServiceReference.Service1Client service_client = new WcfServiceReference.Service1Client();

        public int record_Count;

        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = service_client.GetToolDetails().ToList();
            record_Count = dataGrid.Items.Count;
        }

        public void refresh_grid()
        {
            dataGrid.ItemsSource = service_client.GetToolDetails().ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Add_New_Tool win = new Add_New_Tool();
            win.record_count = record_Count;
            win.ShowDialog();    
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            MachineTool.WcfServiceReference.Tool_Details item = dataGrid.SelectedItem as MachineTool.WcfServiceReference.Tool_Details;

            try
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Are you sure to Update Record?", "confirm", MessageBoxButton.YesNo))
                {
                    item.tool_name = (dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                    item.tool_size= (dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                    item.tool_type = (dataGrid.SelectedCells[3].Column.GetCellContent(item) as ComboBox).SelectedValue.ToString();
                    item.tool_desc= (dataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                    service_client.UpdateToolDetails(item);
                    refresh_grid();
                }
                else
                {
                    refresh_grid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MachineTool.WcfServiceReference.Tool_Details item = dataGrid.SelectedItem as MachineTool.WcfServiceReference.Tool_Details;
            try
            {
               if(MessageBoxResult.Yes == MessageBox.Show("Are you sure to Delete it?","confirm",MessageBoxButton.YesNo))
                {
                    service_client.DeleteToolDetails(item);
                    refresh_grid();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}
