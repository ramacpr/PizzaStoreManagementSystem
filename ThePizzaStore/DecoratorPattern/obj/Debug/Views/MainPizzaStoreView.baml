   M S B A M L   `   `   `  ����K  GDecoratorPattern, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:DecoratorPattern.Views.ViewsDecoratorPattern.Views.Views  5   	   3clr-namespace:DecoratorPatternDecoratorPattern  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   S.clr-namespace:DecoratorPattern.Views.Converter DecoratorPattern.Views.Converter  5	   	   )    #DecoratorPattern.MainPizzaStoreView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <views*clr-namespace:DecoratorPattern.Views.Views     5   	   0localclr-namespace:DecoratorPattern     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   D	converter.clr-namespace:DecoratorPattern.Views.Converter     5	   	   -   5        $��mainWnd��5
   -     � WindowStyle$
  None=�6    � Title$ Pizza Stop: Store Manager��5   	    � SizeToContent$ WidthAndHeight=�6+    � 	Resources 5      :   4DecoratorPattern.Views.Converter.VisibilityConverter   visConverter��%   &	          5   
   6?   5      ��5      �� 5   
    �� 
TargetType" �6   .�5      ��  �� Property � ��  WindowBackgroud_Gradient �� Value# [ 6+   6_   5      .��5      �� 
������ .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Center=�6   $��50��61   $��10q�6=   $	��700��6I   $
��Bold"�5      $��30(�6"   $��Italic$�60   
����  �$��Vegan's Love Pizza Store��5      �� 5      
������  �� 
IsReadOnly . $��0q�6A   $��10q�5      ��5      �� 	 �� ElementName$	 mainWnd��
 �� Path$
 CurrentTime�5      5      9� 5   
   -   5         9�Name$ OpenCloseStoreBtn��5      $��10q�6.   $
��Auto��6:   $
��Left=�5       $��Open/Close Store��6.    9� ExpandDirection$
 Down=�5!       9� 
IsExpanded .  .��5"      �� .+�5#      6   0DecoratorPattern.Views.Views.OrderUpdateViewArea  6.   5$      5%      5&      5'      