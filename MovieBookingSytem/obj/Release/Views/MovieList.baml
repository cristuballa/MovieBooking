   M S B A M L   `   `   `  ���� L  HMovieBookingSytem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MovieBookingSytem.ViewsMovieBookingSytem.Views  M+clr-namespace:MovieBookingSytem.Core.DomainMovieBookingSytem.Core.Domain  %    MovieBookingSytem.Views.Window1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:MovieBookingSytem.Views     >Domain+clr-namespace:MovieBookingSytem.Core.Domain     -     � Title$  Window1��$��440.278��$��979.167�� � 	Resources    movieViewSource��%   &	        �� .���  � DataContext# [  .+�&   System.Windows.Controls.DataGrid  -     Name$ movieDataGrid��   RowDetailsVisibilityMode$ VisibleWhenSelected=�$��0,29,0,0q�   EnableRowVirtualization .    AutoGenerateColumns .  ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   castsColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 	   Header$	 Casts��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Casts+  -   directorColumn��$ SizeToHeader $	 Director��
 �� *
Director+  -   genreColumn��$ SizeToHeader $	 Genre��
 �� *Genre+  -   idColumn��$ SizeToHeader $	 Id��
 �� *Id+  -   imdbRatingColumn��$ SizeToHeader $	 Imdb Rating��
 �� *
ImdbRating+  -   pgRatingColumn��$ SizeToHeader $	 	Pg Rating��
 �� *
PgRating+4  .System.Windows.Controls.DataGridTemplateColumn  -	   releaseDateColumn��$ SizeToHeader $	 Release Date��   CellTemplate �� .R�(  "System.Windows.Controls.DatePicker     SelectedDate �� *ReleaseDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions .   -
   rottenTomatoesRatingColumn��$ SizeToHeader $	 Rotten Tomatoes Rating��
 �� *RottenTomatoesRating+  -   titleColumn��$ SizeToHeader $	 Title��
 �� *Title+  -   trailerColumn��$ SizeToHeader $	 Trailer��
 �� *	Trailer+