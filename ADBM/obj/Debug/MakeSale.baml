   M S B A M L   `   `   `  ����  ADBM    ADBM.MakeSale   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   G CHandyControl, Version=2.5.0.1, Culture=neutral, PublicKeyToken=null0hc'https://handyorg.github.io/handycontrol  5   	     � Title$  Make a Sale��5   	    � WindowStartupLocation$ CenterScreen=�5	   	      WindowWin10#��[  5
   	   "  HandyControl.Controls.Window   	ShowTitle . $	��256��5   	   $	��930��5   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �� -   5         ��Name$ 	itemsList��5      $
��Left=�6&   $��
120,20,0,0q�6A   $	��Top=�6U   $	��160��6m   $��10��6y   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6-   	 �� CenterX$		 0.5Q�6;   �� 5      
 �� CenterY$	
 0.5Q�6,    �� CenterX$	 0.5Q�6:   �� 5       �� Angle$	 -90Q�6.    �� CenterY$	 0.5Q�6:    �� CenterX$	 0.5Q�6H   T� 5      5      .��5      �  � Color$ 	#FF5479F5��6#    � Offset$ 1Q�65   � 5      $ 	#FF73A5FF��6#   5      5      �� 5   
   -   5         ��Name$ label��5      $��	Item Code��6   $
��Left=�63   $��	20,20,0,0q�6N   $	��Top=�6a   $��80��6y   �� 5    
   -   5        $ 
label_Copy��5       $��Customer��6$   $
��Left=�67   $��
320,20,0,0q�6R   $	��Top=�6f   $��80��6~   �� 5!   
   -   5        $ label_Copy1��5!      $	��Rep��6%   $
��Left=�63   $��
640,20,0,0q�6N   $	��Top=�6b   $��80��6z   �� 5"   
   -   5        $ CustomersList��5"      $
��Left=�6*   $��
420,20,0,0q�6E   $	��Top=�6Y   $	��160��6q   $��10��6}   ��5#      �� 5$      $ 0.5,1&�6&   $ 0.5,0&�67    5%      V� 5&      .~�5'      �� $	 0.5Q�6-   $		 0.5Q�6;   �� 5(      $	
 0.5Q�6,   $	 0.5Q�6:   �� 5)      $	 -90Q�6.   $	 0.5Q�6:   $	 0.5Q�6H   T� 5*      5+      .��5-      � $ 	#FF5479F5��6#   $ 1Q�65   � 5.      $ 	#FF73A5FF��6#   5/      51      �� 52   
   -   5        $ RepsList��52      $
��Left=�6%   $��
740,20,0,0q�6@   $	��Top=�6T   $	��160��6l   $��10��6x   ��53      �� 54      $ 0.5,1&�6&   $ 0.5,0&�67    55      V� 56      .~�57      �� $	 0.5Q�6-   $		 0.5Q�6;   �� 58      $	
 0.5Q�6,   $	 0.5Q�6:   �� 59      $	 -90Q�6.   $	 0.5Q�6:   $	 0.5Q�6H   T� 5:      5;      .��5=      � $ 	#FF5479F5��6#   $ 1Q�65   � 5>      $ 	#FF73A5FF��6#   5?      5A      �� 5B   
   -   5        $ label_Copy2��5B      $��	Sale Date��6%   $
��Left=�69   $��	20,60,0,0q�6T   $	��Top=�6g   $	��220��6   �� 5C   
   -   5        $ label_Copy3��5C      $��Expected Payment Date��6%   $
��Left=�6E   $��
480,60,0,0q�6`   $	��Top=�6t   $	��220��6�   �� 5D   
   -	   5        $ label_Copy4��5D      $��Payment Amount��6%   $
��Left=�6>   $��	20,95,0,0q�6Y   $	��Top=�6l   $	��220��6�   �� 5E   
   -
   5        $ label_Copy5��5E      $��Quantity��6%   $
��Left=�68   $��
480,95,0,0q�6S   $	��Top=�6g   $	��220��6   (  "System.Windows.Controls.DatePicker  5F   
   -   5          Name$ SaleDate��5F      $
��Left=�6'   $��
245,60,0,0q�6B   $	��Top=�6V      FirstDayOfWeek$ Monday=�6n   $	��195��6�     5G   
   -   5        $ expectedDate��5G      $
��Left=�6+   $��
705,60,0,0q�6F   $	��Top=�6Z   $ Tuesday=�6r   $	��195��6�   �� 5H   
   -   5         ��Name$ PaymentAmount��5H      $
��Left=�6)   $��23��6D   $��
245,95,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��195��6�   �� 5I   
   -   5        $ quantity��5I      $
��Left=�6$   $��23��6?   $��
705,95,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��195��6�   �� 5J   
   -   5        $ label_Copy6��5J      $��Payment��6%   $
��Left=�67   $��
20,130,0,0q�6R   $	��Top=�6f   $	��220��6~   �� 5K   
   -   5        $ label_Copy7��5K      $��Tracking No.��6%   $
��Left=�6<   $��
20,165,0,0q�6W   $	��Top=�6k   $	��220��6�   �� 5L   
   -   5        $ tracking��5L      $
��Left=�6$   $��23��6?   $��245,165,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��195��6�   �� 5M   
   -   5        $ label_Copy8��5M      $��Currier Service��6%   $
��Left=�6?   $��480,130,0,0q�6Z   $	��Top=�6o   $	��220��6�   �� 5N   
   -   5         ��Name$ MakeSaleBTN��5N      $
��Save��6&   $
��Left=�65   $��705,166,0,0q�6P   $	��Top=�6e   $��50��6}   
�������$	��195��6�   ��5O      �� 5P      $ 0.5,1&�6&   $ 0.5,0&�67    5Q      V� 5R      .~�5S      �� $	 0.5Q�6-   $		 0.5Q�6;   �� 5T      $	
 0.5Q�6,   $	 0.5Q�6:   �� 5U      $	 -90Q�6.   $	 0.5Q�6:   $	 0.5Q�6H   T� 5V      5W      .��5Y      � $ 	#FF5479F5��6#   $ 1Q�65   � 5Z        MainThem# �  6#   5[      5]      �� 5^   
   -   5        $ MakeSale_Copy1��5^      $��Close��6)   $
��Left=�69   $��480,166,0,0q�6T   $	��Top=�6i   $��50��6�   
�������$	��220��6�   ��5_      �� 5`      $ 0.5,1&�6&   $ 0.5,0&�67    5a      V� 5b      .~�5c      �� $	 0.5Q�6-   $		 0.5Q�6;   �� 5d      $	
 0.5Q�6,   $	 0.5Q�6:   �� 5e      $	 -90Q�6.   $	 0.5Q�6:   $	 0.5Q�6H   T� 5f      5g      .��5i      � $ 	#FFF55454��6#   $ 1Q�65   � 5j      $ 	#FFFF7373��6#   5k      5m      �� 5n   
   -   5        $ Currier��5n      $
��Left=�6$   $��705,131,0,0q�6?   $	��Top=�6T   $	��195��6l   $��10��6x   ��5o      �� 5p      $ 0.5,1&�6&   $ 0.5,0&�67    5q      V� 5r      .~�5s      �� $	 0.5Q�6-   $		 0.5Q�6;   �� 5t      $	
 0.5Q�6,   $	 0.5Q�6:   �� 5u      $	 -90Q�6.   $	 0.5Q�6:   $	 0.5Q�6H   T� 5v      5w      .��5y      � $ 	#FF5479F5��6#   $ 1Q�65   � 5z      $ 	#FF73A5FF��6#   5{      .@�5}      �� $��Fardar��6   �� 5~      $��Prompt��6   5      �� 5�   
   -   5        $ paymentType��5�      $
��Left=�6(   $��245,130,0,0q�6C   $	��Top=�6X   $	��195��6p   $��10��6|   ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67    5�      V� 5�      .~�5�      �� $	 0.5Q�6-   $		 0.5Q�6;   �� 5�      $	
 0.5Q�6,   $	 0.5Q�6:   �� 5�      $	 -90Q�6.   $	 0.5Q�6:   $	 0.5Q�6H   T� 5�      5�      .��5�      � $ 	#FF5479F5��6#   $ 1Q�65   � 5�      $ 	#FF73A5FF��6#   5�      .@�5�      �� $
��Cash��6   �� 5�      $��Cheque��6   5�      5�      5�      