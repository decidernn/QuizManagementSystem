   M S B A M L   `   `   `  ����I  EQuizManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:QuizManagementQuizManagement  5          QuizManagement.LoginPage   5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:QuizManagement     5        N� Title$  	LoginPage��5
      $	��768��6   $
��1366��6&    N� 
Background
 �����.��5      � .+�5   
   �� $#��Quiz / Exam Management System��6   $��Center=�68   $��0,80,0,0q�6U   $	��Top=�6g   $��42��6   $	��386��6�   $��Century Gothic)�6�   $��22(�6�   $
��Bold"�6�   �� 5   
   $/��)Выберите пользователя��6   $��Center=�60   $��	0,159,0,0q�6M   $	��Top=�6`   $��26��6x   $	��175��6�   $��Century Gothic)�6�   $��14(�6�   $��Italic$�6�   �� 5   
   -   5         ��Name$ comboBoxSelectUser��5      $��Center=�6/   $��	0,201,0,0q�6L   $	��Top=�6_   $	��391��6w   
���   �$��12(�6�   $��36��6�   6�   �� 5   
   $
��Left=�6   $	��520��6+   $��	0,248,0,0q�68   $	��Top=�6K   $	��788��6c   $��/3.jpg��6o   � 5   
   -   5         �Name$ GridTeacher��5   (   $��442,264,442,148q�6   .+�5      �� $5��/Авторизация организатора��6   $
��Bold"�67   $��Center=�6I   $��	0,0,0,295q�6f   $	��180��6y   �� 5      $��
Логин��6   $
��Bold"�6$   $��Center=�66   $��
0,75,0,221q�6S   $��46��6g   �� 5      $��Пароль��6   $
��Bold"�6%   $��Center=�67   $��0,160,0,169q�6T   $��60��6i   �� 5      -   5         ��Name$ txtUsername��5      $��Center=�6+   $��	0,105,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��341��6�   $��36��6�    �� TextAlignment$ Center=�6�   �� 5      -   5         ��Name$ btnLogin��5      $��
Войти��6'      styleButtonGreen#��[  67   $��Center=�6a   $��	0,285,0,0q�6~   $	��Top=�6�   $	��341��6�   $��36��6�   $��18(�6�   $
��Bold"�6�   6�   �� 5      -   5         ��Name$ checkBoxShowPassword��5      $#��Показать пароль��65   $��Center=�6O   $��	0,248,0,0q�6l   $	��Top=�6   6�   G� 5      -   5        	 G�Name$	 txtPassword��5      $��Center=�6/   $��	0,191,0,0q�6L   $	��Top=�6_   $	��341��6w   $��36��6�   
 G� PasswordChar$
 *��6�   $��Center=�6�   �� 5      -   5        $��passwordTxtBox��5   5   $��Center=�6   $��	0,191,0,0q�6K   $y�	Collapsed=�6^   $
��Wrap=�6u   $��	TextBlock��6�   $	��Top=�6�   $	��341��6�   $��35��6�    �� TextAlignment$ Center=�6�   5      � 5   
   -   5        $ GridStudent��5   (   $��442,265,442,148q�6   .+�5      �� $5��/Авторизация обучающегося��6   $
��Bold"�67   $��Center=�6I   $��	0,0,0,295q�6f   $	��182��6y   �� 5      -	   5        $ btnRegStudent��5      #��[  6,   $��Регистрация��6V   $��Center=�6l   $��	0,301,0,0q�6�   $	��Top=�6�   $	��342��6�   $��36��6�   $��18(�6�   $
��Bold"�6�   6�   �� 5      -
   5        $ btnLoginStudent��5      #��[  6.   $��
Войти��6X   $��Center=�6h   $��	0,248,0,0q�6�   $	��Top=�6�   $	��341��6�   $��36��6�   $��18(�6�   $
��Bold"�6�   6�   �� 5      $��
Логин��6   $
��Bold"�6$   $��Center=�66   $��
0,74,0,222q�6S   $��43��6g   �� 5       $��Пароль��6   $
��Bold"�6%   $��Center=�67   $��0,160,0,169q�6T   $��54��6i   �� 5!      -   5        $ txtUsernameStudent��5!      $��Center=�62   $��	0,105,0,0q�6O   $
 Wrap=�6b   $	��Top=�6v   $	��342��6�   $��36��6�   $ Center=�6�   G� 5"      -   5        $	 txtPasswordStudent��5"      $��Center=�66   $��	0,188,0,0q�6S   $	��Top=�6f   $	��342��6~   $��36��6�   $
 *��6�   $��Center=�6�   5#      5$      5%      