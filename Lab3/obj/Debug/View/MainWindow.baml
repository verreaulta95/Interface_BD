   M S B A M L   `   `   `  ����?  ;Lab3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Lab3.View	Lab3.View  5   	   /clr-namespace:Lab3.ViewModelLab3.ViewModel  5   	       Lab3.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Lab3.View     5   	   /local1clr-namespace:Lab3.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5       �� DataType"   Lab3.ViewModel.MainViewModel��%2   (��       5      *, +)�� 6
   "  6   6B   5      .��5      � $	��Top=�6   $��Center=�6#   $	��790��6@   $	��420��6L   
������� � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6!   $��Largeur de l'image :  100��61   $��Right=�6S   $��Center=�6o   $��Century)�6�   6�   �� 5   
   -   5         ��Name$ Slider��5       � Minimum$	 100Q�6!    � Maximum$	 300Q�6/   $��0��6=   $��1��6J   $��Center=�6Z   $��Center=�6w   $��20��6�   $	��200��6�    �� IsSnapToTickEnabled . 	 � Value	 6�   �� *Produit.Largeur+6�   �� 5    
   $��0��6   $��2��6!   $��Center=�61   $��Century)�6�   ��6L   �� 
 �� Path$
 Value� �� ElementName$ Slider�� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5!   
   $��0��6   $��2��6!   $��Center=�61   $��20,0,0,0q�6L   $��px��6^   $��Century)�6h   6   �� 5$   
   $��1��6   $��0��6!   $��Hauteur de l'image :  100��61   $��Right=�6R   $��Center=�6n   $��Century)�6�   6�   �� 5%   
   -   5        $ Slider1��5%      $��1��6"   $��1��6/   $��Center=�6?   $��Center=�6\   $��20��6w   $	��200��6�   $	 300Q�6�   $	 100Q�6�    . 	 6�   �� *Produit.Hauteur+6�   �� 5&   
   $��1��6   $��2��6!   $��Center=�61   $��Century)�6�   ��6L   �� $
 Value�$ Slider1��$ TwoWay=�$ PropertyChanged=�6�   �� 5'   
   $��1��6   $��2��6!   $��Center=�61   $��20,0,0,0q�6L   $��px��6^   $��Century)�6h   6   �� 5*   
   $��2��6   $��0��6!   $��Nom du produit : ��61   $��Right=�6J   $��Center=�6f   $��Century)�6�   6�   �� 5+   
   $��2��6   $��1��6   $��Center=�6/   $��Center=�6L   $	��200��6�   ��6g   �� *Produit.Nom+$ PropertyChanged=�6�   �� 5.   
   $��3��6   $��0��6!   $��Prix du produit :  0��61   $��Right=�6M   $��Center=�6j   $��Century)�6�   6�   �� 5/   
   -   5        $ Slider2��5/      $��3��6"   $��1��6/   $��Center=�6?   $��Center=�6\   $��20��6w   $	��200��6�   $	 100Q�6�   $ 0Q�6�    . 	 6�   �� *Produit.Prix+ 50         SliderThumbBackground �� Color��%-   &	        �� 51      $ 	LawnGreen��6@   52      53      �� 54   
   $��3��6   $��2��6!   $��Center=�61   $��Century)�6�   ��6L   �� $
 Value�$ Slider2��$ TwoWay=� �� StringFormat$ {0:C}��$ PropertyChanged=�6�   �� 57   
   $��4��6   $��0��6!   $��Couleur de fond : ��61   $��Right=�6K   $��Center=�6g   $��Century)�6�   6�   �� 58   
   $��4��6   $��1��6   $��Center=�6/   $��Center=�6L   $	��200��6g   ��6s   �� *Produit.Background+$ PropertyChanged=�6�   �� 5;   
   $��5��6   $��3��6   $��Center=�63   $��Center=�6P   
�������$	��800��6�   $��70��6�   $��1q�6�   $��Century)�6�   ��6�   �� *CommandeConnexion+.��6�   Afficher la fenetre5=      5>      5?      