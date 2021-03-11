Mediator Patern (mô hình trung gian) được sử dụng để giảm sự phức tạp trong “giao tiếp” giữa các lớp và các đối tượng. 
Mô hình này cung cấp một lớp trung gian có nhiệm vụ xử lý thông tin liên lạc giữa các tầng lớp, hỗ trợ bảo trì mã code dễ dàng bằng cách khớp nối lỏng lẻo.

Khớp nối lỏng lẻo ở đây được hiểu là các đối tượng tương đồng không “giao tiếp” trực tiếp với nhau mà giao tiếp thông qua người trung gian, 
và nó cho phép thay đổi cách tương tác giữa chúng một cách độc lập.

Các thành phần tham gia Mediator Pattern:

Colleague : là một abstract class, giữ tham chiếu đến Mediator object.
ConcreteColleague : cài đặt các phương thức của Colleague. Giao tiếp thông qua Mediator khi cần giao tiếp với Colleague khác.
Mediator : là một interface, định nghĩa các phương thức để giao tiếp với các Colleague object.
ConcreteMediator : cài đặt các phương thức của Mediator, biết và quản lý các Colleague object.