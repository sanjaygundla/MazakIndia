   M S B A M L   `   `   `  ����F  BMachineTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MachineToolMachineTool  5   	       MachineTool.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MachineTool     5   	     � Title$  
MainWindow��5   	   $��480.92��6   $��948.685��6,   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5
      $
��Left=�6%   $��
10,109,0,0q�6@   $	��Top=�6T   $	��294��6l   $	��907��6y      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Tool ID��6A      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	tool_id+6R     5      $ 	Tool Name��6C    6%   �� *	tool_name+6C     5      $ 	Tool Size��6C    6%   �� *	tool_size+6C   4  .System.Windows.Controls.DataGridComboBoxColumn  5         SelectedValuePath$ 	tool_type��6)      DisplayMemberPath$ 	tool_type��6r   $ 	Tool Type��6�   	   SelectedValueBinding	 6G   �� *	tool_type+6�     5      $ Tool Description��6C    6%   �� *	tool_desc+6C   4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ btnEdit��6%   -   5        $��Edit Record��5   L   6d   5      5        5      
 5      �� 5      .R�5      �� $ 	btnDelete��6%   -   5        $��Delete Record��5   P   6j   5      5      5!      �� 5"   
   -   5         ��Name$ label��5"      $��Mazak India��6   $
��Left=�65   $	��Top=�6P   $��
226,10,0,0q�6h   $��37��6|   $	��292��6�   $��20(�6�   $
��Bold"�6�   �� 5#   
   -   5        $ button��5#      $��Add Tool��6!   $
��Left=�64   $��	10,47,0,0q�6O   $	��Top=�6b   $	��124��6z   $��39��6�   6�   5%      5&      