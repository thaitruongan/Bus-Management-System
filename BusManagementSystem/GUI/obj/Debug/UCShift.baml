   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5          GUI.UCShift   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:GUI     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .��5
      � .+�5   
   � 
�������$	��678��6"   $
��1096��6/   .+�5      �� .+�5      �� $��Danh sách ca trực��6   $��20(�65   $��	10 20 0 0q�6C   
�������6j   5      �� 5      .+�5      �� $��Tìm kiếm:��6   $��16(�6-   $��Right=�6;   $��0 222 210 0q�6W   
�������6l   5      �� 5      $	��180��6   $��40��6%   $��
0 217 25 0q�61   $��Right=�6E   $	��Top=�6a   .+�5      �� -   5          ��Name$  
txtTimKiem��5      ���#e0e0de$��1q�6D   $��30��6X   $��	0,0,-15,0q�6d   $��14(�6w   6�   5      �� 5      ���#e0e0de$��1��6.   $��10,54,10,622q�69   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgvShift��5      $
��Left=�6)   $	��382��6D   $	��Top=�6Q   $
��1076��6i   $��
10,254,0,0q�6v   
����������#e0e0de$��1q�6�   $��12(�6�      
IsReadOnly .    HorizontalGridLinesBrush �	#FFE0E0DE   VerticalGridLinesBrush �	#FFE0E0DE   GridLinesVisibility$ 
Horizontal=�6/     AlternatingRowBackground
 �����   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã ca trực��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   �� *matuyenduong+  5      $	 Ngày trực��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6Y   
 6<   �� *
ngaytruc+6Y     5      $	 Ca��6)   
 65   �� *ca+  5      $	 Biển kiểm soát��6)   
 6A   �� *Xe.bienkiemsoat+  5      $	 Tuyến đường��6)   
 6>   �� *TuyenXe.tentuyenxe+  5      $	 	Tài xế��6)   
 69   �� *TaiXe.hotentx+  5      $	 Phụ xe��6)   
 69   �� *PhuXe.hoten+5       �� 5!      $��Mã ca trực:��6   $
��Left=�6*   $��	74,74,0,0q�6E   $	��Top=�6X    J� RenderTransformOrigin$ -0.167,0.083&�6p   $��26��6�   $	��123��6�   �� 5"      -   5        $  txtMaCaTruc��5"      $
��Left=�6+   $��23��6F   $��
172,75,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5#      $��Ngày trực:��6   $
��Left=�6)   $��
76,108,0,0q�6D   $	��Top=�6X   $ -0.167,0.083&�6p   $��26��6�   $	��120��6�   �� 5$      $	��Xe:��6   $
��Left=�6#   $��113,178,0,0q�6>   $	��Top=�6S   $ -0.167,0.083&�6k   $��26��6�   $��98��6�   �� 5%      $	��Ca:��6   $
��Left=�6"   $��114,139,0,0q�6=   $	��Top=�6R   $ -0.167,0.083&�6j   $��26��6�   $��76��6�   �� 5&      -   5        $  txtCa��5&      $
��Left=�6%   $��23��6@   $��172,138,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5'      -   5         ��Name$ btnThem��5'      $��Thêm��6&   $
��Left=�65   $��595,641,0,5q�6P   $��Center=�6e   $��75��6�   ���#1b9f43���#1b9f43
�������6�   �� 5(      -   5        $ btnXoa��5(      $
��Xóa��6%   $
��Left=�63   $��676,641,0,0q�6N   $	��Top=�6c   $��75��6{   ���#007df8���#007df8
�������6�   �� 5)      -   5        $ btnSua��5)      $��Sửa��6%   $
��Left=�63   $��758,641,0,0q�6N   $	��Top=�6c   $��75��6{   ���#d83d42���#d83d42
�������6�   �� 5*      -	   5        $ btnLuu��5*      $
��Lưu��6%   $
��Left=�63   $��1011,641,0,0q�6N   $	��Top=�6d   $��75��6|   
�������6�   �� 5+      -
   5        $ btnHuy��5+      $��Hủy��6%   $
��Left=�63   $��840,641,0,0q�6N   $	��Top=�6c   $��75��6{   
�������
�������
�������6�   �� 5,      -   5        $ btnIn��5,      $
��Left=�6%   $��
76,641,0,0q�6@   $	��Top=�6T   $��75��6l   
�������
�������
�������6�   �� 5-      $
��Left=�6   $��
75,636,0,0q�6/   $	��Top=�6C   $��42��6[   .��5.      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�6*   $��25��69   $��25��6D   $��Center=�6P   $��5q�6k   $��20(�6v   6�   5/      �� 50      $��In��6   $
��Left=�6!   $��115,642,0,0q�6<   $	��Top=�6Q   $��16(�6i   $
��Bold"�6w   (  "System.Windows.Controls.DatePicker  52      -   5          Name$ dtpNgayTruc��52      $
��Left=�6.   $��172,105,0,0q�6I   $	��Top=�6^   $	��120��6v   �� 53      -   5         ��Name$ cboXe��53      $
��Left=�6&   $��172,172,0,0q�6A   $	��Top=�6V   $	��120��6n    �� DisplayMemberPath$ bienkiemsoat��6z    �� SelectedValuePath$
 maxe��6�   �� 54      $��Tuyến đường:��6   $
��Left=�6,   $��
55,216,0,0q�6G   $	��Top=�6[   $ -0.167,0.083&�6s   $��26��6�   $��98��6�   �� 55      -   5        $ cboTuyenDuong��55      $
��Left=�6.   $��172,210,0,0q�6I   $	��Top=�6^   $	��120��6v   $ 
tentuyenxe��6�   $ 	matuyenxe��6�   �� 56      $��
Tài xế:��6   $
��Left=�6'   $��
385,74,0,0q�6B   $	��Top=�6V   $ -0.167,0.083&�6n   $��26��6�   $��98��6�   �� 57      -   5        $ cboTaiXe��57      $
��Left=�6)   $��
460,75,0,0q�6D   $	��Top=�6X   $	��120��6p   $ hotentx��6|   $
 matx��6�   �� 58      $��	Phụ xe:��6   $
��Left=�6'   $��379,108,0,0q�6B   $	��Top=�6W   $ -0.167,0.083&�6o   $��26��6�   $��98��6�   �� 59      -   5        $ cboPhuXe��59      $
��Left=�6)   $��460,105,0,0q�6D   $	��Top=�6Y   $	��120��6q   $ hoten��6}   $
 mapx��6�   5:      5;      5<      