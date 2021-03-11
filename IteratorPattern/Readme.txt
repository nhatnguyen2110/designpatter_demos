Iterator Pattern là một trong những Pattern thuộc nhóm hành vi (Behavior Pattern). 
Nó được sử dụng để “Cung cấp một cách thức truy cập tuần tự tới các phần tử của một đối tượng tổng hợp, 
mà không cần phải tạo dựng riêng các phương pháp truy cập cho đối tượng tổng hợp này”.

Các thành phần tham gia mẫu Iterator:

Aggregate : là một interface định nghĩa định nghĩa các phương thức để tạo Iterator object.
ConcreteAggregate : cài đặt các phương thức của Aggregate, nó cài đặt interface tạo Iterator để trả về một thể hiện của ConcreteIterator thích hợp.
Iterator : là một interface hay abstract class, định nghĩa các phương thức để truy cập và duyệt qua các phần tử.
ConcreteIterator : cài đặt các phương thức của Iterator, giữ index khi duyệt qua các phần tử.
Client : đối tượng sử dụng Iterator Pattern, nó yêu cầu một iterator từ một đối tượng collection để duyệt qua các phần tử mà nó giữ. 
Các phương thức của iterator được sử dụng để truy xuất các phần tử từ collection theo một trình tự thích hợp.