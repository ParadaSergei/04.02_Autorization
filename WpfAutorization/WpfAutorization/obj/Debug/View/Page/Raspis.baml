   M S B A M L   `   `   `  ????J  FWpfAutorization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfAutorizationWpfAutorization  5      E'clr-namespace:WpfAutorization.ViewModelWpfAutorization.ViewModel  5          WpfAutorization.Raspis   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfAutorization     5      =	ViewModel'clr-namespace:WpfAutorization.ViewModel     5        N? Title$  Raspis??5      .??5      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      .+?5   
   ?  ? ColumnDefinitions 5      ?? 5      ?? 5      .+?5      ?? $&?? Выберите учителя:??6   $??30(?60   $
??Left=?6>   $??Center=?6Y   ?? 5      -   5         ??Name$ 
comboBoxs2??5   3   $??1??6   $??30q?6'    ?? DisplayMemberPath$ Teacher??6G   5      ? 5   
   $??1??6    5      ?? 5      ?? 5      .+?5       ?? $&?? Выберите предмет:??6   $??30(?61   $
??Left=?6?   $??Center=?6Z   ?? 5!      -   5        $ 
comboBoxs1??5!   F   $??1??6   
????? ?$??30q?6:   $
 Less??6Z   ?? 5"      -   5        $??Добавить??5"      $??15(?6)   $??1??67   $??Right=?6G   $??Bottom=?6c   ??6~   ?? * + ? DataContext 5#      4   .WpfAutorization.ViewModel.MainWindowsViewModel  5$      5&      5'      ? 5(   
   $??2??6   .+?5)      ?? -   5         ??Name$ listTextView??5)   4   
???????$??8q?6)   64   5*      5+      5,      