   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Diplom.VM	Diplom.VM  5          Diplom.View.ClientsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Diplom.VM     5        N� Title$  Клиенты��5	         Page#��[  6    � DataContext 5
        Diplom.VM.ClientsVM  5   
   6   .��5      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $
��grid��5         AutoGenerateColumns .     SelectionMode$ Single=�6;      
IsReadOnly . ��6d   �� *
listItem+ �� SelectedItem 5      �� *selectedItem+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 60   �� *Id+6I     5      $ Фамилия��6%   	 66   �� *
LastName+6U     5      $ Имя��6%   	 62   �� *Name+6M     5      $ Отчетство��6%   	 68   �� *
MiddleName+6Y     5      $ Телефон��6%   	 66   �� *Phone+6R   5      � 5   
   $��1��6   .+�5      �� $��5q�6   $��Center=�6    $%��Добавить клиента��5       $%��Добавить клиента��69   ��5      �� *CommandGoTo+5    V   �� 5!      $��5q�6   $��Right=�6    ��5"      �� *
DelCommand+.��64   Удалить клиента6E   �� 5#      $��5q�6   $
��Left=�6    ��5$      �� *ChangeCommand+.��67   +)Редактировать клиента6N   5%      5&      5'      