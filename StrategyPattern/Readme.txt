Strategy Pattern giúp tách rời phần xử lý một chức năng cụ thể ra khỏi đối tượng. 
Sau đó tạo ra một tập hợp các thuật toán để xử lý chức năng đó và lựa chọn thuật toán nào mà chúng ta thấy đúng đắn nhất khi thực thi chương trình. 
Mẫu thiết kế này thường được sử dụng để thay thế cho sự kế thừa, khi muốn chấm dứt việc theo dõi và chỉnh sửa một chức năng qua nhiều lớp con.

Các thành phần tham gia Strategy Pattern:

Strategy : định nghĩa các hành vi có thể có của một Strategy.
ConcreteStrategy : cài đặt các hành vi cụ thể của Strategy.
Context : chứa một tham chiếu đến đối tượng Strategy và nhận các yêu cầu từ Client, các yêu cầu này sau đó được ủy quyền cho Strategy thực hiện.