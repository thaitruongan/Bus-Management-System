   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.User   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   -   5          � Title$
  User��5   	   $	��450��6   $	��450��6#    � WindowStartupLocation$ CenterScreen=�6/   .��5	      � .+�5
   
   �� $��Nhân viên:��6   $
��Left=�6%   $��	61,43,0,0q�6@   $	��Top=�6S    J� RenderTransformOrigin$ -0.167,0.083&�6k   $��26��6�   $	��123��6�   �� 5   
   -   5         ��Name$ cboNhanVien��5      $
��Left=�6(   $��
162,41,0,0q�6C   $	��Top=�6W   $	��120��6o    �� DisplayMemberPath$ hoten��6{    �� SelectedValuePath$
 manv��6�   �� 5   
   $��Tên đăng nhập:��6   $
��Left=�6)   $��	36,74,0,0q�6D   $	��Top=�6W   $ -0.167,0.083&�6o   $��26��6�   $	��123��6�   �� 5   
   -   5         ��Name$ txtTenDangNhap��5      $
��Left=�6*   $��22��6E   $��
162,74,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5   
   $��Mật khẩu:��6   $
��Left=�6$   $��
64,105,0,0q�6?   $	��Top=�6S   $ -0.167,0.083&�6k   $��26��6�   $	��123��6�   �� 5   
   -   5        $ 
txtMatKhau��5      $
��Left=�6&   $��22��6A   $��164,101,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   $��Quyền:��6   $
��Left=�6!   $��
80,130,0,0q�6<   $	��Top=�6P   $ -0.167,0.083&�6h   $��26��6�   $	��123��6�   �� 5   
   -   5        $ cboQuyen��5      $
��Left=�6%   $��164,128,0,0q�6@   $	��Top=�6U   $	��120��6m   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvUser��5      $
��Left=�6$   $	��201��6?   $	��Top=�6L   $	��422��6d   $��
10,167,0,0q�6p   
����������#e0e0de$��1q�6�   $��12(�6�   	   
IsReadOnly	 . 
   HorizontalGridLinesBrush
 �	#FFE0E0DE   VerticalGridLinesBrush �	#FFE0E0DE   GridLinesVisibility$ 
Horizontal=�6)     AlternatingRowBackground
 �����   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5      $ Họ và tên��6%    68   �� *NhanVien.hoten+  5      $ Tên đăng nhập��6%    6<   �� *tendangnhap+  5      $ Mât khẩu��6%    67   �� *	matkhau+  5      $ Quyền��6%    64   �� *quyen+5      �� 5   
   -   5         ��Name$ btnSua��5      $��Sửa��6!   $
��Left=�6/   $��168,377,0,10q�6J   $��Center=�6`   $��74��6{   ���#d83d42���#d83d42
�������$ 0.689,0.688&�6�   6�   �� 5   
   -   5        $ btnXoa��5      $
��Xóa��6!   $
��Left=�6/   $��89,377,0,10q�6J   $��Center=�6_   $��74��6z   ���#007df8���#007df8
�������6�   �� 5   
   -	   5        $ btnThem��5      $��Thêm��6"   $
��Left=�61   $��10,377,0,10q�6L   $��Center=�6a   $��74��6|   ���#1b9f43���#1b9f43
�������6�   �� 5   
   -
   5        $ btnLuu��5      $
��Lưu��6!   $
��Left=�6/   $��358,377,0,10q�6J   $��Center=�6`   $��74��6{   
�������6�   �� 5   
   -   5        $ btnHuy��5      $��Hủy��6!   $
��Left=�6/   $��247,377,0,10q�6J   $��Center=�6`   $��74��6{   
�������
�������
�������6�   �� 5    
   $	��Id:��6   $
��Left=�6   $��
105,16,0,0q�69   $	��Top=�6M   $ -0.167,0.083&�6e   $��26��6�   $��87��6�   �� 5!   
   -   5        $ txtId��5!      $
��Left=�6!   $��22��6<   $��
164,16,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   5#      5$      