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
using System.Windows.Shapes;
using MachineTool;
using System.Globalization;

namespace MachineTool
{
    /// <summary>
    /// Interaction logic for Add_New_Tool.xaml
    /// </summary>
    /// 

   
    public partial class Add_New_Tool : Window
    {
        private WcfServiceReference.Service1Client service_client = new WcfServiceReference.Service1Client();

        public int record_count;

        public Add_New_Tool()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MachineTool.WcfServiceReference.Tool_Details item = new MachineTool.WcfServiceReference.Tool_Details();
                item.tool_id = "Tool" + (record_count + 1).ToString();
                item.tool_name = txtname.Text;
                item.tool_size = txtSize.Text;
                ComboBoxItem typeItem = (ComboBoxItem)cmbxType.SelectedItem;
                item.tool_type = Convert.ToString(typeItem.Content.ToString());
                item.tool_desc = txtDesc.Text;

                service_client.AddToolDetails(item);
                MainWindow win = new MainWindow();
                win.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDesc.Text = "";
            txtname.Text = "";
            txtSize.Text = "";
            cmbxType.SelectedValue = null;
        }


       private void txtSize_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(e.Text !="." && isnumeric(e.Text)==false )
            {
                e.Handled = true;
            }
            else if(e.Text==".")
            {
                if( ((TextBox ) sender ).Text.IndexOf(e.Text)>-1 )
                {
                    e.Handled = true;
                }
               
            }
        }

        private bool isnumeric(string text)
        {
            int output;
            return int.TryParse(text, out output);
        }

        private void txtname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (isnumeric(e.Text) == true)
            {
                e.Handled = true;
            }

        }


    }


}
