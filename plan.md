# ���� ������������.
## �������� ������� � ������� ��� ������������:

�������� �������� ������� � �� �������
-Validator:
    -typeError - ������ ���� �������� ������
    -valueError - ������ �������� �������� ������
- Shape:
    - GetPerimeter - �������� ������
    - ShowInfo - ������� �������������� ������
    - GetArea - ������� ������
- Square(double length) - �������, ������� ���������: ����� �������: ��� �����
    - GetArea - ������� 
    - GetPerimeter - ��������
    - GetDiagonal - ���������
    - ShowInfo - ������� �������������� ������
- Rectangle(double width, double height) - �������������. ������� ���������: ����� � ������: ��� �����
    - GetPerimeter - �������� ������
    - ShowInfo - ������� �������������� ������
    - GetArea - ������� ������
    - GetDiagonal - ���������
- Circle(radius: float) - ����. ������� ���������: ������: ��� �����
    - GetPerimeter - �������� ������
    - ShowInfo - ������� �������������� ������
    - GetArea - ������� ������
    - GetDiameter - �������
- Triangle(side1: float, side2: float, side3: float) - �����������. ������� ���������: �������1, �������2, �������3: ��� �����
    - PrivateTriangleValidation - ����������� �������� ����������� ������ �������������� 
    - GetPerimeter - �������� ������
    - ShowInfo - ������� �������������� ������
    - GetArea - ������� ������
    - GetHigh - ������


## ������������ ������� � �� �������:
### Square
����: ��������� �������� ������ Square, � ���������� �������� ��� �������������
- ����� ������������:
    - length = ����� ������, �� ����� - exception typeError
    - length = ������ ������ - exception typeError
    - length = ������������� ����� - Square. 
    - length = ������������� ����� - exception valueError
- ����� ������� �������:
    - 2 => 4
    - 0 => 0
    - 5 => 25
- ����� ������� ��������
    - 0 => 0
    - 1 => 4
    - 2.5 => 10
- ����� ������� ���������
    - 2 => 2.82
    - 0 => 0
    - 2.5 => 3.5

### Rectangle
����: ��������� �������� ������ Rectangle, � ���������� �������� ��� �������������
- ����� ������������:
    - ����� ������, �� ����� - exception typeError
    - ������ ������ - exception typeError
    - ������������� ����� - Rectangle. 
    - ������������� ����� - exception valueError
- ����� ������� �������:
    - 2, 1 => 2
    - 0, 0 => 0
    - 2.5, 3.5 => 8.75
- ����� ������� ��������
    - 2, 1 => 6
    - 0, 0 => 0
    - 2.5, 3.5 => 12
- ����� ������� ���������
    - 2, 1 => 2.23
    - 0, 0 => 0
    - 2.5, 3.5 => 4.301

### Circle
����: ��������� �������� ������ Circle, � ���������� �������� ��� �������������
- ����� ������������:
    - ����� ������, �� ����� - exception typeError
    - ������ ������ - exception typeError
    - ������������� ����� - Circle. 
    - ������������� ����� - exception valueError
- ����� ������� �������:
    - 2 => 12.5
    - 0 => 0
    - 2.5 => 19.6
- ����� ������� ��������
    - 0 => 0
    - 1 => 6.28
    - 2.5 => 15.7
- ����� ������� ��������
    - 2 => 4
    - 0 => 0

### Triangle
����: ��������� �������� ������ Triangle, � ���������� �������� ��� �������������
- ����� ������������:
    - ����� ������, �� ����� - exception typeError
    - ������ ������ - exception typeError
    - ������������� ����� - Triangle. 
    - ������������� ����� - exception valueError
- ����� ������� �������:
    - 2, 2, 3 => 1.98
    - 1, 1, 1 => 0.4330
    - 2.5, 3.5, 4 => 4.330
- ����� ������� ��������
    - 2, 2, 3 => 7
    - 1, 1, 1 => 3
    - 2.5, 3.5, 4 => 10
- ����� ������� ������
    - 2, 2, 3 => 1.98
    - 1, 1, 1 => 0.87
    - 2.5, 3.5, 4 => 3.46