   M S B A M L   `   `   `  ????J  FWpfAutorization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfAutorizationWpfAutorization  5   	   E'clr-namespace:WpfAutorization.ViewModelWpfAutorization.ViewModel  5   	        WpfAutorization.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfAutorization     5   	   =	ViewModel'clr-namespace:WpfAutorization.ViewModel     5   	   $??Center=?5
   	   $??Center=?5   	     ? 
ResizeMode$  NoResize=?5   	    ? Title$ Autorization??5   	   $	??450??6   $	??800??6+    ? DataContext 5      4   .WpfAutorization.ViewModel.MainWindowsViewModel  5   
   .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      ?? 5      $	??100 ?6   .+?5   
   ? ???#089147 ? ColumnDefinitions 5      ?? 5      $
??653* ?6#   ?? 5      $
??141* ?6#   .+?5      ?? $??Авторизация??6   $??Center=?5       $??Center=?5!      $??50(?5"      $??1??5#      $??1??6,   $??248,17,105.913,16q?6=   5$      ? 5%   
   $??1??6   ???#089147 5&      ?? 5'      $	??300 ?6#   ?? 5(       5*      ?? 5+      ?? 5,      .+?5/      ?? $??Login:??6   $??40(?6&   $??
0,20,20,20q?64   $
??Left=?6H   ?? 50      $??	Password:??6   $??40(?6)   $??
0,20,20,20q?67   $??2??6K   ?? 51      -   5         ??Name$ lgBox??51   b   $??0??6   $??1??6#   $??10(?63   $??40q?6A   ???#b0b6b6??6q   ?? *Usered.Login+G? 52      -   5         G?Name$ passBox??52   f   $??1??6   $??1??6'   $??10(?67   $??40q?6E   ???#b0b6b66w   53      ? 54   
   $??2??6   ???#089147.+?55      ?? -   5        $??200,10,200,10q?55      $??Вход??6,   $??40(?6;   
???/?????6b   ?? *AuthCommand+6?   56      57      58      