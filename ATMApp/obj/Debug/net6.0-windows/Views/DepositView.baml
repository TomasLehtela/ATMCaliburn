   M S B A M L   `   `   `  ????A  =ATMApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ATMApp.ViewsATMApp.Views  5      5clr-namespace:ATMApp.ViewModelsATMApp.ViewModels  67       ATMApp.Views.DepositView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ATMApp.Views     5      6
viewmodelsclr-namespace:ATMApp.ViewModels     67   
???????$??Segoe UI Light)?5   2   $??24(?6N   .??5	      ?   ? ColumnDefinitions  5
   
   ?? 5      $??* ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??Sätt in önskat belopp??6   $??2??61   $??1??6E   $??40(?5      $
??Bold"?6"   $??Center=?64   $
??0 30q?5      ?? 5   
   $
??SEK:??6   $??1??6    $??1??6-   $??20(?5       $??Right=?6"   $??10 10 10 10q?5!      ?? 5#   
   $??
Mottagare:??6   $??2??6&   $??1??63   $??20(?5$      $??Right=?6"   $??10 10 10 10q?5%      ?? 5'   
   $??Saldo:??6   $??3??6"   $??1??6/   $??20(?5(      $??Right=?6"   $??10 10 10 10q?5)      ?? 5+   
   -   5         ??Name$ DepositAmountInput??5+      $??2??6.   $??1??6>   $??10 10 10 10q?6K    ?? TextAlignment$
 Left=?5,      $??30(?6(   $	??150??66   ?? 5.   
   -   5        $ AccountRecieverInput??5.      $??2??60   $??2??6@   $??10 10 10 10q?6M   $
 Left=?5/      $??30(?6(   ?? 51   
   $??2??6D   $??3??6T   $??10 10 10 10q?6a   $
 Left=?52      $??30(?6'   ??51      ??  ?? Path$ AccountBalance? ?? Mode$ TwoWay=?52   '   ?? 55   
   -   5         ??Name$ ConfirmDepositButton??56   ,   $??4??55      $??2??6   $??2??6.   $??10 10 10 10q?6B   $
??Left=?56      $	??200??6J   .??6Y   	Bekräfta58      5:      5;      