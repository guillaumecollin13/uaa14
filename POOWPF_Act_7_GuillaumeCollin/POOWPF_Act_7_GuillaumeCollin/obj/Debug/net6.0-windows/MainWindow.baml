   M S B A M L   `   `   `  ����W  SPOOWPF_Act_7_GuillaumeCollin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:POOWPF_Act_7_GuillaumeCollinPOOWPF_Act_7_GuillaumeCollin  5   	   -    'POOWPF_Act_7_GuillaumeCollin.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:POOWPF_Act_7_GuillaumeCollin     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��800��6)   .��5	      � -   5         �Name$ grille��5	       � RowDefinitions 5
   
   �� 5      $
��280* �6   6,   �� 5      $
��405* �6   6,   .+�5   
   �� -   5         ��Name$ 	racetrack��5      $��0��6$   $��Center=�61   $��Center=�6N   .+�5      �� -   5         ��Name$ raceTrackIm��5       �� Left$
 -400��6)   
 �� Top$
 -130��6=   $
��None=�6O   $��assets\racetrack.png��6^   6~   5      �� 5   
   $	��800��6   $	��400��6   $��1��6,   ��5      �� 5      $��25(�6   $��arial)�6*   .��6=   Salle des paris6N   .��5      � -   5        $ grille2��5      $��1��6$    � ColumnDefinitions 5      �� 5      $��1* �6'   64   �� 5      $��1* �6'   64   �� 5      $��1* �6'   64   �� 5      $��2* �6'   64   �� 5      $��1* �6'   64   �� 5      $��2* �6'   64    5      �� 5      $��2* �6$   62   �� 5       $
��0.5* �6$   64   �� 5!      $
��0.5* �6$   64   .+�5%      �� $��0��6   $��3��6)   $��20(�6=   $��arial)�6K   $
��Left=�6^   $	��Top=�6y   $
��Bold"�6�   Pari minimum : 5 écus6�   �� 5'      $��0��6   $��3��6)   $��20(�69   $��arial)�6G   $
��Left=�6Z   $	��Top=�6u   $
��Bold"�6�   Paris6�   	� 5)      -   5         	�Name$ radiobutton1��5)   P   	 d� 	IsChecked$
	 TrueY�6   $��22(�6/   $��arial)�6=   $�� 0��6f   $��3��6t   $��50,60,0,110q�6�   	� 5*      -   5        $ radiobutton2��5*   @   $��22(�6   $��arial)�6,   $�� 0��6V   $��3��6d   $��50,120,0,70q�6x   	� 5+      -   5        $ radiobutton3��5+   ?   $��22(�6   $��arial)�6,   $�� 0��6U   $��3��6c   $��50, 180,0,30q�6w   �� 5-      -   5        
 ��Name$
 Text1��5-   ]   $��22(�6   $��arial)�6*   $��X n'a pas encore parier��6=   $�� 0��6l   $��3��6z   $��3��6�   $��10,60,0,110q�6�   �� 5.      -	   5        $
 Text2��5.   ]   $��22(�6   $��arial)�6*   $��X n'a pas encore parier��6=   $�� 0��6l   $��3��6z   $��3��6�   $��10,120,0,70q�6�   �� 5/      -
   5        $
 Text3��5/   ]   $��22(�6   $��arial)�6*   $��X n'a pas encore parier��6=   $�� 0��6l   $��3��6z   $��3��6�   $��10, 180,0,30q�6�   �� 51      -   5        $
 
nomParieur��51   =   $��22(�6   $��arial)�6*   $�� 1��6Q   $��0��6_   $��Center=�6o   $
��Left=�6�   $��20q�6�   $	�� X ��6�   �� 52      -   5         ��Name$ 
boutonPari��52   :   $��22(�6   $��arial)�6'   $��Parie��6N   $�� 1��6^   $��1��6l   $��Center=�6|   $
��Left=�6�   6�   �� 53      -   5         ��Name$ textBoxPari��53   <   $��22(�6   $��arial)�6)   $�� 1��6Q   $��1��6_   $��Center=�6o   $��Right=�6�   $��1q�6�   
���   �$��5q�6�   $��25��6�   6�   �� 54      -   5        $
 	TextePari��54   _   $��22(�6   $��arial)�6*   $ ��Ecus sur le chien numéros��6=   $�� 1��6r   $��2��6�   $��2��6�   $��Center=�6�   $
��Left=�6�   �� 55      -   5        $ textBoxNumChien��55   <   $��22(�6   $��arial)�6)   $��1��6U   $��3��6b   $��Center=�6r   $��Right=�6�   $��1q�6�   
���   �$��5q�6�   $��25��6�   6�   �� 56      -   5        $ boutonStart��56   :   $��25(�6   $��arial)�6'   $��Lancer la course��6O   $�� 1��6k   $��4��6y   $��3��6�   $��Center=�6�   6�   �� 58      -   5        $ boutonrESET��58   :   $��25(�6   $��arial)�6'   $��RESET��6O   $�� 2��6`   $��0��6n   $��6��6~   $��Center=�6�   6�   5:      5;      5<      5=      