   M S B A M L   `   `   `  ����F  BHarjoitus20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Harjoitus20Harjoitus20  5   	       Harjoitus20.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Harjoitus20     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   � $
��Left=�6   $	��421��6*   $��407,0,0,-0.333q�67   $	��Top=�6O   $	��386��6g   ���	#FFC2BEBE$��2��6�   .+�5      �� $
��Left=�6   $��	38,54,0,0q�63   $
��Wrap=�6F   $��Etunimi��6Z   $	��Top=�6i   $��29��6�   $��77��6�   �� 5      -   5         ��Name$ Input_Etunimi��5      $
��Left=�6-   $��24��6H   $��	38,88,0,0q�6T    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5      $
��Left=�6   $��
206,49,0,0q�63   $
��Wrap=�6G   $��Sukunimi��6[   $	��Top=�6k   $��29��6�   $��77��6�   �� 5      -   5        $ Input_Sukunimi��5      $
��Left=�6.   $��24��6I   $��
195,83,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5      $
��Left=�6   $��
38,112,0,0q�63   $
��Wrap=�6G   $��Puhelinnumero��6[   $	��Top=�6p   $��29��6�   $��93��6�   �� 5      -   5        $ Input_Puhelinnumero��5      $
��Left=�63   $��24��6N   $��
38,141,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 5      $
��Left=�6   $��206,112,0,0q�63   $
��Wrap=�6H   $��Sähköposti��6\   $	��Top=�6n   $��29��6�   $��77��6�   �� 5      -   5        $ Input_Sähköposti��5      $
��Left=�60   $��24��6K   $��195,141,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   �� 5      $
��Left=�6   $��
38,195,0,0q�63   $
��Wrap=�6G   $��OpiskelijaID��6[   $	��Top=�6o   $��29��6�   $��77��6�   �� 5      -   5        $ Input_OpiskelijaID��5      $
��Left=�62   $��24��6M   $��
38,229,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   �� 5      -   5         ��Name$ btn_LisääOpiskelija��5      $��Lisää opiskelija��62   $
��Left=�6M   $��
47,280,0,0q�6h   $	��Top=�6|   $	��127��6�   $��42��6�   6�   �� 5      -   5        $ btn_PoistaOpiskelijat��5      $��Poista Opiskelija��64   $
��Left=�6P   $��220,280,0,0q�6k   $	��Top=�6�   $	��106��6�   $��42��6�   6�   �� 5      -   5        $ btn_TallennaOpiskelijat��5      $��Tallenna opiskelija��66   $
��Left=�6T   $��
47,349,0,0q�6o   $	��Top=�6�   $	��127��6�   $��44��6�   �� 5      -	   5        $ btn_HaeOpiskelijat��5      $��Hae opiskelija��61   $
��Left=�6J   $��220,349,0,0q�6e   $	��Top=�6z   $	��106��6�   $��38��6�   5      � 5   
   $
��Left=�6   $	��421��6*   $��0,0,0,-0.333q�67   $	��Top=�6M   $	��402��6e   
�������6q   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dg_Opiskelijat��5      $	��545��6+   $
��Left=�6O   $	��Top=�6j      AutoGenerateColumns .     CanUserReorderColumns .     CanUserDeleteRows .  $��56��6�   ��67   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Etunimi��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 66      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *	Etunimi+6^     5       $	 Sukunimi��6%   $	
 100 67    .  6C   �� *
Sukunimi+6`     5!      $	 Puhelinnumero��6%   $	
 100 6<    .  6H   �� *Puhelinnumero+6j     5"      $	 Sähköposti��6%   $	
 100 69    .  6E   �� *Sähköposti+6d     5#      $	 Opiskelija ID��6%   $	
 100 6<    .  6H   �� *OpiskelijaID+6i   4  .System.Windows.Controls.DataGridCheckBoxColumn  5$      $	 Poista��6)   $	
 50* 6X    69   �� *
IsSelected+6X   5&      5)      5*      