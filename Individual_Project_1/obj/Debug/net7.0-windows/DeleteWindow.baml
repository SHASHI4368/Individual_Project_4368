   M S B A M L   `   `   `  ����O  KIndividual_Project_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Individual_Project_1Individual_Project_1  5   	   '    !Individual_Project_1.DeleteWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   <d2http://schemas.microsoft.com/expression/blend/2008   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   0local"clr-namespace:Individual_Project_1   5   	     � Title$  DeleteWindow��5	   	   $	��210��6   $	��400��6+    � WindowStartupLocation$ CenterScreen=�67    � WindowStyle$
 None=�6\    � AllowsTransparency$
 True��6o   
������  � DataContext 5
      )   #Individual_Project_1.DeleteWindowVM  5   
   .��5      �� -   5        ���#212529 �� CornerRadius$ 20��5   "   
���   �$��2q�6H   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $
��auto �6    .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0��62   $��1��6?   $��Right=�6O   $��	0 15 15 0q�6k   .+�5      �� -   5           	TopButton#��[  5   0   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ close=�6,   $��15��69   $��15��6E   5      5      �� 5      $C��=Are you sure want to delete this student with Index Number : ��6   $
��Wrap=�6]   $��1��6q   $��16(�6~   $��SemiBold"�6�   $��
20 0 20 10q�6�   $��Center=�6�   ���#dbdbdb6�   �� 5      $
��Wrap=�6.   $��2��6B   $��16(�6O   $��SemiBold"�6]   $��
20 0 20 10q�6s   $��Center=�6�   ���#dbdbdb��6   �� *Indx+6�   �� 5!      -   5          	addButton#��[ 5!      $��3��68   $��10q�6E   $��Center=�6Q   $��Delete Student��6�   ��6n   �� *deleteStudentCommand+5"      5#      5$      5%      