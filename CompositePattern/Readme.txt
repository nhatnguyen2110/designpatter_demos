Composite Pattern được sử dụng khi chúng ta cần xử lý một nhóm đối tượng tương tự theo cách xử lý 1 object.

Một Composite Pattern bao gồm các thành phần cơ bản sau:

Base Component : là một interface hoặc abstract class quy định các method chung cần phải có cho tất cả các thành phần tham gia vào mẫu này.
Leaf : là lớp hiện thực (implements) các phương thức của Component. Nó là các object không có con.
Composite : lưu trữ tập hợp các Leaf và cài đặt các phương thức của Base Component. 
Composite cài đặt các phương thức được định nghĩa trong interface Component bằng cách ủy nhiệm cho các thành phần con xử lý.
Client: sử dụng Base Component để làm việc với các đối tượng trong Composite.