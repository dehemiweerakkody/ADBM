   M S B A M L   `   `   `  ����   ADBM    ADBM.MakeSale   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     G CHandyControl, Version=2.5.0.1, Culture=neutral, PublicKeyToken=null0hc'https://handyorg.github.io/handycontrol    � Title$  Make a Sale�� � WindowStartupLocation$ CenterScreen=�   WindowWin10#��[  "  HandyControl.Controls.Window   	ShowTitle . $	��256��$	��930�� � 
ResizeMode$ NoResize=�.��� .+��� -    ��Name$ 	itemsList��$
��Left=�$��
120,20,0,0q�$	��Top=�$	��160��$��10������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&� �� RelativeTransform V� .~���  �� CenterY$	 0.5Q�	 �� CenterX$		 0.5Q��� 
 �� CenterY$	
 0.5Q� �� CenterX$	 0.5Q���  �� Angle$	 -90Q� �� CenterY$	 0.5Q� �� CenterX$	 0.5Q�T� .���  � Color$ 	#FF5479F5�� � Offset$ 1Q�� $ 	#FF73A5FF���� -    ��Name$ label��$��	Item Code��$
��Left=�$��	20,20,0,0q�$	��Top=�$��80���� -   $ 
label_Copy��$��Customer��$
��Left=�$��
320,20,0,0q�$	��Top=�$��80���� -   $ label_Copy1��$	��Rep��$
��Left=�$��
640,20,0,0q�$	��Top=�$��80���� -   $ CustomersList��$
��Left=�$��
420,20,0,0q�$	��Top=�$	��160��$��10������ $ 0.5,1&�$ 0.5,0&� V� .~��� $	 0.5Q�$		 0.5Q��� $	
 0.5Q�$	 0.5Q��� $	 -90Q�$	 0.5Q�$	 0.5Q�T� .��� $ 	#FF5479F5��$ 1Q�� $ 	#FF73A5FF���� -   $ RepsList��$
��Left=�$��
740,20,0,0q�$	��Top=�$	��160��$��10������ $ 0.5,1&�$ 0.5,0&� V� .~��� $	 0.5Q�$		 0.5Q��� $	
 0.5Q�$	 0.5Q��� $	 -90Q�$	 0.5Q�$	 0.5Q�T� .��� $ 	#FF5479F5��$ 1Q�� $ 	#FF73A5FF���� -   $ label_Copy2��$��	Sale Date��$
��Left=�$��	20,60,0,0q�$	��Top=�$	��220���� -   $ label_Copy3��$��Expected Payment Date��$
��Left=�$��
480,60,0,0q�$	��Top=�$	��220���� -	   $ label_Copy4��$��Payment Amount��$
��Left=�$��	20,95,0,0q�$	��Top=�$	��220���� -
   $ label_Copy5��$��Quantity��$
��Left=�$��
480,95,0,0q�$	��Top=�$	��220��(  "System.Windows.Controls.DatePicker  -     Name$ SaleDate��$
��Left=�$��
245,60,0,0q�$	��Top=�   FirstDayOfWeek$ Monday=�$	��195��  -   $ expectedDate��$
��Left=�$��
705,60,0,0q�$	��Top=�$ Tuesday=�$	��195���� -    ��Name$ PaymentAmount��$
��Left=�$��23��$��
245,95,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��195���� -   $ quantity��$
��Left=�$��23��$��
705,95,0,0q�$
 Wrap=�$	��Top=�$	��195���� -   $ label_Copy6��$��Payment��$
��Left=�$��
20,130,0,0q�$	��Top=�$	��220���� -   $ label_Copy7��$��Tracking No.��$
��Left=�$��
20,165,0,0q�$	��Top=�$	��220���� -   $ tracking��$
��Left=�$��23��$��245,165,0,0q�$
 Wrap=�$	��Top=�$	��195���� -   $ label_Copy8��$��Currier Service��$
��Left=�$��480,130,0,0q�$	��Top=�$	��220���� -    ��Name$ MakeSaleBTN��$
��Save��$
��Left=�$��705,166,0,0q�$	��Top=�$��50��
�������$	��195������ $ 0.5,1&�$ 0.5,0&� V� .~��� $	 0.5Q�$		 0.5Q��� $	
 0.5Q�$	 0.5Q��� $	 -90Q�$	 0.5Q�$	 0.5Q�T� .��� $ 	#FF5479F5��$ 1Q��   MainThem# �  �� -   $ MakeSale_Copy1��$��Close��$
��Left=�$��480,166,0,0q�$	��Top=�$��50��
�������$	��220������ $ 0.5,1&�$ 0.5,0&� V� .~��� $	 0.5Q�$		 0.5Q��� $	
 0.5Q�$	 0.5Q��� $	 -90Q�$	 0.5Q�$	 0.5Q�T� .��� $ 	#FFF55454��$ 1Q�� $ 	#FFFF7373���� -   $ Currier��$
��Left=�$��705,131,0,0q�$	��Top=�$	��195��$��10������ $ 0.5,1&�$ 0.5,0&� V� .~��� $	 0.5Q�$		 0.5Q��� $	
 0.5Q�$	 0.5Q��� $	 -90Q�$	 0.5Q�$	 0.5Q�T� .��� $ 	#FF5479F5��$ 1Q�� $ 	#FF73A5FF��.@��� $��Fardar���� $��Prompt���� -   $ paymentType��$
��Left=�$��245,130,0,0q�$	��Top=�$	��195��$��10������ $ 0.5,1&�$ 0.5,0&� V� .~��� $	 0.5Q�$		 0.5Q��� $	
 0.5Q�$	 0.5Q��� $	 -90Q�$	 0.5Q�$	 0.5Q�T� .��� $ 	#FF5479F5��$ 1Q�� $ 	#FF73A5FF��.@��� $
��Cash���� $��Cheque��