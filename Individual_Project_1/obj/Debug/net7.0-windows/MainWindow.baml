   M S B A M L   `   `   `  ����O  KIndividual_Project_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Individual_Project_1Individual_Project_1  5   	   %    Individual_Project_1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   0local"clr-namespace:Individual_Project_1   5   	     � Title$  
MainWindow��5	   	   $	��720��6   $
��1080��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � AllowsTransparency$
 True��6q   
������  � 	Resources 5
         	BoolToVis��%   &	        �� 5   
   6'   5       � DataContext 5      '   !Individual_Project_1.MainWindowVM  5   
   .��5      �� -   5        ���#212529 �� CornerRadius$ 30��5   "   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��62   $��Right=�6?   $��	0 15 15 0q�6[   .+�5      �� -   5          	TopButton#��[ 5   .   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial  	   Kind$	 WindowMinimize=�6,   $��15��6B   $��15��6N   5       �� 5!      -   5        #��[ 5!   0   .��5"        $	 WindowMaximize=�6,   $��15��6B   $��15��6N   5#      �� 5$      -   5        #��[ 5$   0   .��5%        $	 close=�6,   $��15��69   $��15��6E   5&      5'      �� 5+      $ ��Student Information System��6   $��1��6:   $��32(�6G   $��SemiBold"�6U   $��	0 -25 0 0q�6k   $��Center=�6~   ���#dbdbdb6�   �� 5.        	addButton#��[ 6   $��2��68   $��20q�6E   $	��180��6Q   ��6]   �� *AddStudentCommand+.��5/      �� $ 
Horizontal=�6   .+�50        $
	 Plus=�6,   $��Center=�68   $��11��6S   $��11��6^   $��0 1 8 0q�6j   �� 51      $��Add New Student��6    $��15(�67   $��SemiBold"�6E   52      53      �� 56      $��4��6   ���#3E434A$��2��64   $��5q�6?   �� 59      $��5��6   $��Right=�6&   $ 
Horizontal=�6B   .+�5:      �� $��Student Name : ��6   $��18(�63   $
��10 0q�6A   ���#dbdbdb$��Center=�6d   �� 5;      -   5        
 ��Name$
 indexNo��5;   A     textBoxSearch#��[ 6   $��	10 5 20 5q�6R   $��18(�6e   $	��200��6�   5<      &   System.Windows.Controls.DataGrid  5?      -   5          Name$ studentDataGrid��5?   $   $��6��6   $��20q�6=   
���   �   AutoGenerateColumns$ False��6]     DataGridStyle1#���  6�     DataGridCellStyle1   	CellStyle# �  6�     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�     DataGridRowStyle1   RowStyle# �  65  ��6y   �� *
Students+   Columns 5@      4  .System.Windows.Controls.DataGridTemplateColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Index No.��6-      CanUserResize$ False��6@      
IsReadOnly$
 True��6V      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6h      CellTemplate 5D      �� 5E      .R�5F   "   �� $��Center=�6,   ��6I   �� *IndexNumber+5G      5I        5L      $ Student��6-   $
 True��6>   $ * 6P    5M      �� 5N      .R�5O   "   �� $ 
Horizontal=�6-   $
��Left=�6F   $��10 0 0 0q�6a   .+�5P   &   �� $��28��6-   $��28��68   ���#dbdbdb$��1q�6Z   $ 25��6n   $��0 0 10 0q�6�   ��6�   �� *	BGColor+._�5Q   *   �� $��Center=�64   $��Center=�6O   
�������$��0 0 0 1q�6   $
��Wrap=�6�   ��6�   �� *	Charactor+6�   5R   '   �� 5S   &   $��Center=�60   $
��Wrap=�6e   ��6K   �� *
FullName+6e   5T   #   5U      5W        5Y      $ Date of Birth��6-   $ False��6D   $
 True��6Z   $	 150 6l    5Z      �� 5[      .R�5\   "   �� $��Center=�6,   ��6I   �� *	DOBString+5]      5_        5a      $ Address��6-   $ False��6>   $
 True��6T   $ * 6f    5b      �� 5c      .R�5d   "   �� $
��Left=�6,   $��10 0 0 0q�6G   $
��Wrap=�6r   ��6Y   �� *	Address+6r   5e      5g        5i      $ Phone Number��6-   $ False��6C   $
 True��6Y   $	 150 6k    5j      �� 5k      .R�5l   "   �� $��Center=�6,   $
��Wrap=�6d   ��6I   �� *	Telephone+6d   5m      5o        5q      $	 GPA��6-   $ False��6:   $
 True��6P   $	 100 6b    5r      �� 5s      .R�5t   "   �� $��Center=�6,   $
��Wrap=�6^   ��6I   �� *GPA+6^   5u      5w        5{      $ 
Operations��6-   $
 True��6A   $	 120 6S    5|      �� 5}      .R�5~   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5   &   �� -   5          gridEditButton#��[ 5   -   ��6l   �� .��5�   *     $	 PencilOutline=�6@    	 gridButtonIcon#��[	 6U   5�   '   �� 5�   &   -   5         
 gridRemoveButton#��[
 5�   -   $��5 0 0 0q�6W   ��6   �� .��5�   *     $	 DeleteOutline=�6@   #��[	 6U   5�   '   5�   #   5�      5�      5�      5�      5�      5�      