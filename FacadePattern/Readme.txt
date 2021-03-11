Facade Pattern là một trong những Pattern thuộc nhóm cấu trúc (Structural Pattern). 
Pattern này cung cấp một giao diện chung đơn giản thay cho một nhóm các giao diện có trong một hệ thống con (subsystem). 
Facade Pattern định nghĩa một giao diện ở một cấp độ cao hơn để giúp cho người dùng có thể dễ dàng sử dụng hệ thống con này.

Các thành phần cơ bản của một Facade Pattern:

Facade: biết rõ lớp của hệ thống con nào đảm nhận việc đáp ứng yêu cầu của client, sẽ chuyển yêu cầu của client đến các đối tượng của hệ thống con tương ứng.
Subsystems: cài đặt các chức năng của hệ thống con, xử lý công việc được gọi bởi Facade. Các lớp này không cần biết Facade và không tham chiếu đến nó.
Client: đối tượng sử dụng Facade để tương tác với các subsystem.

Các đối tượng Facade thường là Singleton bởi vì chỉ cần duy nhất một đối tượng Facade.