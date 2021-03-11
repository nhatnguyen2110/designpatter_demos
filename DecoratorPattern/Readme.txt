Decorator pattern là một trong những Pattern thuộc nhóm cấu trúc (Structural Pattern). 
Nó cho phép người dùng thêm chức năng mới vào đối tượng hiện tại mà không muốn ảnh hưởng đến các đối tượng khác. 

Các thành phần trong mẫu thiết kế Decorator:

Component: là một interface quy định các method chung cần phải có cho tất cả các thành phần tham gia vào mẫu này.
ConcreteComponent : là lớp hiện thực (implements) các phương thức của Component.
Decorator : là một abstract class dùng để duy trì một tham chiếu của đối tượng Component và đồng thời cài đặt các phương thức của Component  interface.
ConcreteDecorator : là lớp hiện thực (implements) các phương thức của Decorator, nó cài đặt thêm các tính năng mới cho Component.
Client : đối tượng sử dụng Component.