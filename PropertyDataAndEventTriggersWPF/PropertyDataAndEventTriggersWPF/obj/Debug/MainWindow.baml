   M S B A M L   `   `   `  ����Z  VPropertyDataAndEventTriggersWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:PropertyDataAndEventTriggersWPFPropertyDataAndEventTriggersWPF  5   	   0    *PropertyDataAndEventTriggersWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:PropertyDataAndEventTriggersWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5
      �� .+�5   
   � .+�5      �� $��Hello, beloved World!��6   $��36(�66   $
��Bold"�6D   $��Center=�6V   $��20q�6s   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 � � �6G    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5   "   ��  � ��
 �  ��6M   �� 5   "    � ��$ 	Underline{�6D   6X   5      5      5      5      � 5   
   .+�5      �� $��Hello, Buddy��6   $��36(�6,   $
��Bold"�6:   $��Center=�6L   $��20q�6i   ��5      �� 5      " ��6    5      :� 5       :� RoutedEvent$ 
MouseEnter��6+   [�5    "   �� 5!   &   .��5"   *   �� .��5#   .   W�  g� Duration$ 	0:0:0.500D�6>   	 �� TargetProperty$	 FontSize�6S   	
 W� To$	
 108X�6x   6�   5$   +   5%   '   5'      :� 5(      $ 
MouseLeave��6+   [�5)   "   �� 5*   &   .��5+   *   �� .��5,   /   W� $ 	0:0:0.300D�6?   $	 FontSize�6T   $
 36X�6y   6�   5-   ,   5.   '   50      52      54      55      �� 56   
   $��20q�6   .+�57      �� -   5        $��
cbShanghai��57      $%�� Are people in Shanghai stupid?��6*   $��20(�6T   $��Center=�6b   6�   �� 58      ��59      �� 5:      " ��6   .�5;      ��  � ��$ No��61   6>   �� 5<       � ��
 �  ��6E   �� 5=       � ��$ 32(�65   6B   �� 5>       � ��$
 Bold"�67   6F   �� 5?       � ��$ Center=�6@   6Q    5@      �� 5A       �� Binding 6*   ��  �� ElementName$ 
cbShanghai�� �� Path$ 	IsChecked� �� Value True6e   .a�5B   "   ��  � ��$ 	Of Course��69   6M   �� 5C   "    � ��
 � � �6O   5D      5F      5H      5I      5J      5K      