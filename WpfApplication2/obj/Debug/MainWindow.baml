   M S B A M L   `   `   `  ����J  FWorking Concept, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	     � Title$  Авторизация��5   	   $��335.043��6   $��698.504��6.    � WindowStartupLocation$ CenterScreen=�6>   
�������.��5	      � 
����+�� � ColumnDefinitions 5
   
   �� 5      $
��242* �6   �� 5      $
��449* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Логин:��6   $
��Left=�60   $��	10,27,0,0q�6K   $	��Top=�6^   $��Times New Roman)�6v   {�.  $��18(�6�   
���   �6�   �� 5   
   -   5         ��Name$	 log��5      $
��Left=�6   $��23��6:   $��	10,63,0,0q�6F    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��654��6�   $��Times New Roman)�6�   $��18(�6�   $��2��6�   �� 5   
   -   5        $ 
label_Copy��5      $��Пароль:��6$   $
��Left=�66   $��	10,97,0,0q�6Q   $	��Top=�6d   $��Times New Roman)�6|   {�.  $��18(�6�   
���   �6�   G� 5   
   -   5         G�Name$	 pas��5      $
��Left=�6#   $��23��6>   $��
10,133,0,0q�6J   $	��Top=�6_   $	��654��6w   $��Times New Roman)�6�   $��18(�6�   $��2��6�   �� 5   
   -   5         ��Name$ button��5      $��
Войти��6!   $
��Left=�61   $	��Top=�6L   $	��127��6d   $��
10,181,0,0q�6p   $��47��6�   $��Times New Roman)�6�   $��18(�6�   6�   �� 5   
   -   5        $ button_Copy��5      $��Регистрация��6&   $
��Left=�6<   $	��Top=�6W   $	��146��6o   $��276.064,181,0,0q�6{   $��47��6�   $��Times New Roman)�6�   $��18(�6�   $��1��6�   5      5      