   M S B A M L   `   `   `  ����L  HMovieBookingSytem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MovieBookingSytem.UIMovieBookingSytem.UI  5   	        MovieBookingSytem.UI.Movie   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MovieBookingSytem.UI     5   	     � Title$  Movie��5	   	   $	��600��6   $
��1000��6$   .��5
      � $��	0,0,2,105q�6    � RowDefinitions 5   
   �� 5      $	��55* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��45* �6   �� 5      $	��46* �6   �� 5      $��45 �6   �� 5      $	��44* �6   �� 5      $	��46* �6   �� 5      $	��45* �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $��8* �6   �� 5      $	��14* �6   �� 5      $	��32* �6   .+�5   
   �� $��Movie��6   $��1��6    $
��Left=�60   $��20(�6K   $��Normal$�6Y   $��40��6n   $��	10,10,0,0q�6z   $	��Top=�6�   $	��952��6�   $��3��6�   �� 5    
   $��Title��6   $��1��6    $
��Left=�60   $��28��6K   $��8,10,0,0q�6W   $��1��6i   $	��Top=�6v   $	��114��6�   �� 5!   
   $��Release Date��6   $��1��6'   $
��Left=�67   $��28��6R   $��8,10,0,0q�6^   $��2��6p   $	��Top=�6}   $	��114��6�   �� 5"   
   $��Genre��6   $��1��6    $
��Left=�60   $��28��6K   $��8,10,0,0q�6W   $��3��6i   $	��Top=�6v   $	��114��6�   �� 5$   
   $��IMDB Rating��6   $��1��6&   $
��Left=�66   $��28��6Q   $��8,10,0,0q�6]   $��4��6o   $	��Top=�6|   $	��114��6�   �� 5&   
   $��Rotten Tomatoe Rating��6   $��1��60   $
��Left=�6@   $��28��6[   $��8,10,0,0q�6g   $��5��6y   $	��Top=�6�   $	��140��6�   $��2��6�   �� 5(   
   $��	PG Rating��6   $��1��6$   $
��Left=�64   $��28��6O   $��8,10,0,0q�6[   $��6��6m   $	��Top=�6z   $	��114��6�   �� 5*   
   $��Trailer��6   $��1��6"   $
��Left=�62   $��28��6M   $��8,10,0,0q�6Y   $��7��6k   $	��Top=�6x   $	��114��6�   �� 5-   
   $��Director��6   $��1��6#   $
��Left=�63   $��28��6N   $��8,10,0,0q�6Z   $��8��6l   $	��Top=�6y   $	��114��6�   �� 5/   
   $
��Cast��6   $��1��6   $
��Left=�6/   $��28��6J   $��8,10,0,0q�6V   $��9��6h   $	��Top=�6u   $	��114��6�   �� 51   
   $��Poster��6   $��3��6!   $
��Left=�61   $��28��6L   $��8,10,0,0q�6X   $��1��6j   $	��Top=�6w   $	��114��6�   �� 53   
   $��2��6   $��1��6"   $��3,10,3,7q�6/   �� 54   
   $��3��6   $��1��6"   $��
67,10,91,5q�6/   �� 55   
   $��2��6   $��2��6"   $��3,10,3,7q�6/   �� 56   
   $��2��6   $��3��6"   $��3,10,3,8q�6/   �� 57   
   $��2��6   $��4��6"   $��3,10,3,7q�6/   �� 58   
   $��2��6   $��5��6"   $��3,10,3,7q�6/   �� 59   
   $��2��6   $��6��6"   $��3,10,3,3q�6/   �� 5:   
   $��2��6   $��7��6"   $��3,10,3,2q�6/   �� 5;   
   $��2��6   $��8��6"   $��3,10,3,5q�6/   �� 5<   
   $��2��6   $��9��6"   $��3,0,0,3q�6/   �� 5>   
   $��3��6   $
��Left=�6    $	��301��6;   $��2��6H   $��7��6U   $	��Top=�6f   $	��418��6~   $��67,0,0,0q�6�   �� 5?   
   $��. . .��6   $��3��6!   $
��Left=�61   $��28��6L   $��
490,10,0,0q�6X   $��1��6l   $	��Top=�6y   $��36��6�   �� 5C   
   $��3��6   $��10��6!   $��80��5D      $��312,2,134,6q�6   $
��Save��64   �� 5E   
   $��3��6   $��10��6!   $��Right=�6/   $��80��5F      $��0,2,50,6q�6   $��Cancel��61    J� RenderTransformOrigin$ 
-0.962,0.5&�6B   5G      5H      