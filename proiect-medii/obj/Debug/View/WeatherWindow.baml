   M S B A M L   `   `   `  ????H  Dproiect-medii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:proiect_medii.Viewproiect_medii.View  5   	   A%clr-namespace:proiect_medii.ViewModelproiect_medii.ViewModel  5   	   &     proiect_medii.View.WeatherWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:proiect_medii.View     5   	   4vm%clr-namespace:proiect_medii.ViewModel     5   	     ? Title$  WeatherWindow??5	   	   $	??450??6   $	??800??6,    ? 	Resources 5
      .   (proiect_medii.ViewModel.WeatherViewModel   vm??%   &	          5   
   6   5      .??5      ?  ? DataContext# [  6    ? ColumnDefinitions 5   
   ?? 5      $
??137* ?6   ?? 5      $
??127* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??110,30q?6   $??2??6%   .+?5      ?? $	??0,5q?6   $??Cauta un oras:??6%   ?? 5      ??6   ?? *Query+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=??? 5      $
??0,10q?6   
????ح???6:   ?? *SearchCommand+??6\   ?? *Query+.??6   Cauta6?   ?? 5      $??Center=?6]   ??6   ?? *Cities+ ?? SelectedValue 66   ?? *SelectedCity+??5      ?? 5      .R?5      ? .+?5      ?? ??6(   ?? *LocalizedName+5       5!      5#      5$      ? 5%   
   $??1??6   
????? ?$??2??65    6I   ?? *	Weather+ 5&      ?? 5'      $??* ?6#   6/   ?? 5(      $
??Auto ?6#   62   .+?5*      ?? $
??0,10q?6   .+?5+      ?? $??15(?6   $??110,0q?6*   $
??30px??69   # [  6G   ??6i   ?? *SelectedCity.LocalizedName+?? 5,      $??110,0q?6   $
??30px??6+   ??69   ?? *WeatherText+5-      ?? 5.      $??1??6   $??110,10q?6(   ??68   ?? *Temperature.Metric.Value+ ?? StringFormat$
 {0}C??5/      50      51      